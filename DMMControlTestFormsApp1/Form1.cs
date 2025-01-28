using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NationalInstruments.Visa;
using Ivi.Visa;
using System.Threading;

using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;
using System.Xml.Schema;
using MathNet.Numerics;  //chart用
using System.Text.RegularExpressions;
using System.Globalization;



namespace DMMControlTestFormsApp1
{
    public partial class Form1 : Form
    {
        //VISAセッションをするためのもの
        private MessageBasedSession mbSession1; //電圧用
        private MessageBasedSession mbSession2; //電流用　クランプメータ
        private MessageBasedSession mbSession3; //熱電対用
        private MessageBasedSession mbSession4; //SS-C2400 VISAセッションをするためのもの
        //private System.Windows.Forms.Timer timer;　//TimerかつThreading（UIに出さないよう）とかぶらないため

        //Chart
        private System.Windows.Forms.DataVisualization.Charting.Series Vseries1;
        private System.Windows.Forms.DataVisualization.Charting.Series Aseries2;
        private System.Windows.Forms.DataVisualization.Charting.Series Rseries3;
        private System.Windows.Forms.DataVisualization.Charting.Series Pseries4;
        private System.Windows.Forms.DataVisualization.Charting.Series Tseries5;

        private int displayRange = 20;  // 表示範囲のデータ数

        private bool isOutput = false;        //出力のONOFFフラグ
        private bool isRecording = false;       //測定フラグ
        private bool isFileSaving = false;        //file保存フラグ
        private bool isPIDControl = false;      //PID制御のフラグ

        private int useModeSelect = 0;     //メニューによるモードの切替フラグ

        private Stopwatch stopwatch;        //測定時間計測

        private float PresetV = 0;//PresetV(設定電圧)の現在の値
        private double PressT = 22;//プレス内温度の初期設定
        private double roomT;//室温の初期設定
        private double deltaT = 0;//熱起電力の初期設定

        //計測周期の初期設定
        private float SaveSpan = 1.0f;
        private int SaveSpanCmd = 2; //値決定しておかないと、ボタンおさん限りSaveSpanCmdが変な数値（限りなく0に近い数字）になってバカでかいデータになる？

        //PID制御の初期設定
        private double PIDSpan = 1; //PID測定周期
        private double mPIDSpan = 1000;
        private double PGain = 20;
        private double DGain = 5;
        private double IGain = 1;
        private double TargetT = 0;

        private double currErr = 0;//目標温度との差
        private double currErr_pre = 0;//目標温度都の差の初期値
        private double errRate = 0;//微分用の近似値
        private double errSum = 0;//積分用の近似値

        private double PIDOutput = 0;//PIDの操作量
        private float PIDFloatOutput = 0f;//PIDの操作量(float)

        //csv,chart用データリスト
        List<String> elapsedTimes = new List<String>();
        List<double> voltageValues = new List<double>();
        List<double> PrimVoltageValues = new List<double>();
        List<double> currentValues = new List<double>();
        List<double> PrimCurrentValues = new List<double>();
        List<double> resistanceValues = new List<double>();
        List<double> electricPowerValues = new List<double>();
        List<double> PrimelEctricPowerValues = new List<double>();
        List<double> temperatureValues = new List<double>();

        //Fitting用(Form2)で出力する係数
        private double[] p;         // 係数配列を保持するフィールド

        public Form1()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();        //stopwatch
            SettingChart();     //Chart処理

            FormClosing += Form1_FormClosing;       //終了処理
        }
        private void SettingChart() //Chartの設定
        {
            // Chart1コントロールの初期化
            Vseries1 = new System.Windows.Forms.DataVisualization.Charting.Series("VData");
            Aseries2 = new System.Windows.Forms.DataVisualization.Charting.Series("CurrentData");
            Rseries3 = new System.Windows.Forms.DataVisualization.Charting.Series("ResistanceData");
            Pseries4 = new System.Windows.Forms.DataVisualization.Charting.Series("ElectricPower");
            Tseries5 = new System.Windows.Forms.DataVisualization.Charting.Series("PressT");
            Vseries1.ChartType = SeriesChartType.Line;
            Aseries2.ChartType = SeriesChartType.Line;
            Rseries3.ChartType = SeriesChartType.Line;// 折れ線として表示
            Pseries4.ChartType = SeriesChartType.Line;// 折れ線として表示
            Tseries5.ChartType = SeriesChartType.Line;// 折れ線として表示
            chart1.Series.Add(Vseries1);
            chart2.Series.Add(Aseries2);
            chart3.Series.Add(Rseries3);
            chart4.Series.Add(Pseries4);
            chart5.Series.Add(Tseries5);

            // チャートの軸の設定
            //チャート目盛り消す
            chart1.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            chart2.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            chart3.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            chart4.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            chart5.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            //チャートのタイトル
            chart1.ChartAreas[0].AxisY.Title = "Voltage(V)";
            chart2.ChartAreas[0].AxisY.Title = "Current(A)";
            chart3.ChartAreas[0].AxisY.Title = "Resistance(Ω)";
            chart4.ChartAreas[0].AxisY.Title = "ElectricPower(VA)";
            chart5.ChartAreas[0].AxisY.Title = "PressT(℃)";

            // X軸の設定
            chart1.ChartAreas[0].AxisX.Minimum = 0;  // X軸の初期値
            chart2.ChartAreas[0].AxisX.Minimum = 0;  // X軸の初期値
            chart3.ChartAreas[0].AxisX.Minimum = 0;  // X軸の初期値
            chart4.ChartAreas[0].AxisX.Minimum = 0;  // X軸の初期値
            chart5.ChartAreas[0].AxisX.Minimum = 0;  // X軸の初期値
            chart1.ChartAreas[0].AxisX.Maximum = displayRange - 1;  // 初期表示範囲を設定 
            chart2.ChartAreas[0].AxisX.Maximum = displayRange - 1;  // 初期表示範囲を設定 
            chart3.ChartAreas[0].AxisX.Maximum = displayRange - 1;  // 初期表示範囲を設定 
            chart4.ChartAreas[0].AxisX.Maximum = displayRange - 1;  // 初期表示範囲を設定 
            chart5.ChartAreas[0].AxisX.Maximum = displayRange - 1;  // 初期表示範囲を設定 


            chart1.ChartAreas[0].AxisX.Interval = 5;  // X軸の目盛りの間隔            
            chart1.ChartAreas[0].AxisX.IsMarginVisible = false;     //X軸の余白をなくす
            chart2.ChartAreas[0].AxisX.Interval = 5;  // X軸の目盛りの間隔            
            chart2.ChartAreas[0].AxisX.IsMarginVisible = false;     //X軸の余白をなくす
            chart3.ChartAreas[0].AxisX.Interval = 5;  // X軸の目盛りの間隔            
            chart3.ChartAreas[0].AxisX.IsMarginVisible = false;     //X軸の余白をなくす
            chart4.ChartAreas[0].AxisX.Interval = 5;  // X軸の目盛りの間隔            
            chart4.ChartAreas[0].AxisX.IsMarginVisible = false;     //X軸の余白をなくす
            chart5.ChartAreas[0].AxisX.Interval = 5;  // X軸の目盛りの間隔            
            chart5.ChartAreas[0].AxisX.IsMarginVisible = false;     //X軸の余白をなくす

            //chartの色設定
            chart1.ChartAreas[0].BackColor = Color.White;
            chart2.ChartAreas[0].BackColor = Color.White;
            chart3.ChartAreas[0].BackColor = Color.White;
            chart4.ChartAreas[0].BackColor = Color.White;
            chart5.ChartAreas[0].BackColor = Color.White;
        }
        private void PresetVdUp_Click(object sender, EventArgs e)   //0.1ずつ上げる
        {
            //MessageBox.Show("Button clicked");
            if (float.TryParse(PresetVBox.Text, out PresetV))
            {
                PresetV += 0.1f; // テキストボックスの値を+0.1する
                PresetVBox.Text = PresetV.ToString(); // 新しい値をテキストボックスに設定する

                using (var rmSession4 = new ResourceManager())
                {
                    mbSession4 = (MessageBasedSession)rmSession4.Open("GPIB0::4::INSTR");  //特定の機器への挨拶
                    string VTCommand = "VA" + PresetV.ToString(); // VTCommandを生成
                    mbSession4.RawIO.Write(VTCommand);     //出力のWrite ON
                    mbSession4.Dispose();
                }
            }
            else
            {
                // テキストボックスの値が数値に変換できなかった場合のエラーハンドリング
                MessageBox.Show("有効な数値を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PresetViup_Click(object sender, EventArgs e)   //1ずつ上げる
        {
            if (float.TryParse(PresetVBox.Text, out PresetV))
            {
                PresetV += 1.0f; // テキストボックスの値を+1.0する
                PresetVBox.Text = PresetV.ToString(); // 新しい値をテキストボックスに設定する

                using (var rmSession4 = new ResourceManager())
                {
                    mbSession4 = (MessageBasedSession)rmSession4.Open("GPIB0::4::INSTR");  //特定の機器への挨拶
                    string VTCommand = "VA" + PresetV.ToString(); // VTCommandを生成
                    mbSession4.RawIO.Write(VTCommand);     //出力のWrite ON
                    mbSession4.Dispose();
                }
            }
            else
            {
                // テキストボックスの値が数値に変換できなかった場合のエラーハンドリング
                MessageBox.Show("有効な数値を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void PresetVdDown_Click(object sender, EventArgs e) //0.1ずつ下げる
        {
            //MessageBox.Show("Button clicked");
            if (float.TryParse(PresetVBox.Text, out PresetV))
            {
                PresetV -= 0.1f; // テキストボックスの値を-0.1する
                PresetVBox.Text = PresetV.ToString(); // 新しい値をテキストボックスに設定する

                using (var rmSession4 = new ResourceManager())
                {
                    mbSession4 = (MessageBasedSession)rmSession4.Open("GPIB0::4::INSTR");  //特定の機器への挨拶
                    string VTCommand = "VA" + PresetV.ToString(); // VTCommandを生成
                    mbSession4.RawIO.Write(VTCommand);     //出力のWrite ON
                    mbSession4.Dispose();
                }
            }
            else
            {
                // テキストボックスの値が数値に変換できなかった場合のエラーハンドリング
                MessageBox.Show("有効な数値を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void PresetViDown_Click(object sender, EventArgs e) //１ずつ下げる
        {
            if (float.TryParse(PresetVBox.Text, out PresetV))
            {
                PresetV -= 1.0f; // テキストボックスの値を-1.0する
                PresetVBox.Text = PresetV.ToString(); // 新しい値をテキストボックスに設定する

                using (var rmSession4 = new ResourceManager())
                {
                    mbSession4 = (MessageBasedSession)rmSession4.Open("GPIB0::4::INSTR");  //特定の機器への挨拶
                    string VTCommand = "VA" + PresetV.ToString(); // VTCommandを生成
                    mbSession4.RawIO.Write(VTCommand);     //出力のWrite ON
                    mbSession4.Dispose();
                }
            }
            else
            {
                // テキストボックスの値が数値に変換できなかった場合のエラーハンドリング
                MessageBox.Show("有効な数値を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void PresetVSet_Click(object sender, EventArgs e)   //電圧セットボタン
        {
            //if(!float.TryParse(PresetVBox.Text,out PresetV))
            //{
                //PresetVBox.Text = PresetV.ToString(); // 新しい値をテキストボックスに設定する
                using (var rmSession4 = new ResourceManager())
                {
                    mbSession4 = (MessageBasedSession)rmSession4.Open("GPIB0::4::INSTR");  //特定の機器への挨拶
                    string VTCommand = "VA" + PresetVBox.Text; // VTCommandを生成
                    mbSession4.RawIO.Write(VTCommand);     //出力のWrite ON
                    mbSession4.Dispose();
                }
            //}
            //else
            //{
            //    // テキストボックスの値が数値に変換できなかった場合のエラーハンドリング
            //    MessageBox.Show("有効な数値を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }


        private void ElectricPowerToolStripMenuItem_Click(object sender, EventArgs e) //パワー制御を使用
        {
            useModeSelect = 1;  
            ModeBox.Text = "パワーモード";
            timer1.Stop();
            stopwatch.Stop();

            //form2へ移行してFitting関数を出力し、適応
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void TypeKToolStripMenuItem_Click(object sender, EventArgs e)  //typeK
        {
            useModeSelect = 2;  
            ModeBox.Text = "Type K";
        }

        private void TypeBToolStripMenuItem_Click(object sender, EventArgs e)  //typeB
        {
            useModeSelect = 3;
            ModeBox.Text = "Type B";
        }

        private void TypeDToolStripMenuItem_Click(object sender, EventArgs e)  //typeD
        {
            useModeSelect = 4;
            ModeBox.Text = "Type D";
        }

        private void TypeRToolStripMenuItem_Click(object sender, EventArgs e)  //typeR
        {
            useModeSelect = 5;
            ModeBox.Text = "Type R";
        }
        private void FittingEPCSVToolStrip_Click(object sender, EventArgs e)    //Form2からFitting関数を持ってくる
        {
            timer1.Stop();
            stopwatch.Stop();
            Form2 form2 = new Form2();
            form2.Show();
        }

        public void ReceivePolynomial(double[] p)   // Form2から受け取った係数配列をフィールドに代入
        {
            this.p = p;
            FunctionTextBox.Text = ToTeXPolynomial(p);      //textに出力
            timer1.Start();
            stopwatch.Start();

        }
        private string ToTeXPolynomial(double[] coefficients) //テキストボックスにW-T関数を表示させるもの　ｐの係数がcoefficients
        {
            string polynomialTeX = "T(℃) = ";

            for (int i = coefficients.Length - 1; i >= 0; i--)
            {
                if (i == coefficients.Length - 1)
                {
                    // 最高次の項
                    polynomialTeX += $"{coefficients[i]}W^{i}";
                }
                else
                {
                    if (coefficients[i] >= 0)
                    {
                        polynomialTeX += $" + {coefficients[i]}W^{i}";
                    }
                    else
                    {
                        polynomialTeX += $" - {Math.Abs(coefficients[i])}W^{i}";
                    }
                }
            }

            return polynomialTeX;
        }

        private void Form1_Load(object sender, EventArgs e)     //起動設定
        {
            //立ち上げ設定
            useModeSelect = 0;
            //HeaterControl();
            //SettingCondition(); //電圧レンジの変更部分
            timer1.Start();     //timer作動
            stopwatch.Stop();

            double roomT = 27;
            T0Box.Text = roomT.ToString();

            int SaveSpanCmd = (int)(SaveSpan * 2);  //ms換算のため (Timer1の周期:0.5より)
            SaveSpanBox.Text = SaveSpan.ToString(); // 新しい値をテキストボックスに設定する
            GetDataT(deltaT);//温度の初期状態を設定
        }
        private void HeaterControl()
        {
            using (var rmSession4 = new ResourceManager())
            {
                mbSession4 = (MessageBasedSession)rmSession4.Open("GPIB0::4::INSTR");  //特定の機器への挨拶
                mbSession4.RawIO.Write("FQ50,ZA0");     //周波数50，インピーダンス0%に初期設定
                mbSession4.Dispose();
            }
        }
        private void SettingCondition()
        {
            using (var rmSession4 = new ResourceManager())
            {
                mbSession4 = (MessageBasedSession)rmSession4.Open("GPIB0::4::INSTR");  //特定の機器への挨拶
                mbSession4.RawIO.Write("RG0");     //状態のWrite 電圧レンジLoレンジモード
                mbSession4.Dispose();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)    //Timer設定
        {
                try
                {
                    var (SecondVoltValue, SecondCurrValue,SecondElectricPower, HeatVoltValue, PrimV, PrimA, PrimR, PrimVA) = GetDataFromInstruments();  //機器との通信
                    var (ElectricPowerValue, SecondResistanceValue, PressT, deltaT, mVHeatVoltValue) = PerformCalculations(SecondVoltValue, SecondCurrValue, HeatVoltValue);    //電力抵抗温度の出力
                    UpdateUI(SecondVoltValue, SecondCurrValue, HeatVoltValue, SecondElectricPower, SecondResistanceValue, deltaT, PrimV, PrimA, PrimR, PrimVA);       //Chartへの出力シーケンス
                }
                catch (Exception ex)
                {
                    HandleError(ex);
                }

            //測定時間をモニター
            UpdateElapsedTime();
        }
        private (double SecondVoltValue, double SecondCurrValue, double HeatVoltValue, double PrimV, double PrimA, double PrimR, double PrimVA,double SecondElectricPower) GetDataFromInstruments()    //電圧、電流、熱電対用起電力
        {
            using (var rmSession1 = new ResourceManager())
            using (var rmSession2 = new ResourceManager())
            using (var rmSession3 = new ResourceManager())
            using (var rmSession4 = new ResourceManager())
            {
                mbSession1 = (MessageBasedSession)rmSession1.Open("GPIB0::1::INSTR");
                mbSession2 = (MessageBasedSession)rmSession2.Open("GPIB0::2::INSTR");
                mbSession3 = (MessageBasedSession)rmSession3.Open("GPIB0::3::INSTR");
                mbSession4 = (MessageBasedSession)rmSession4.Open("GPIB0::4::INSTR");

                //DMM HP社など共通コード　MEAS: で始まるもの
                //mbSession1.RawIO.Write("MEAS:VOLTage:AC?");         //二次の電圧
                //mbSession2.RawIO.Write("MEAS:VOLTage:AC?");        //二次の電流用電圧
                //mbSession3.RawIO.Write("MEAS:VOLTage:AC?");        //熱電対起電力

                //DMM Advantest社　コード　R6450　R64410A×２
                mbSession1.RawIO.Write("F2");         //二次の電圧 
                mbSession2.RawIO.Write("F2");        //二次の電流用電圧　V＝0.2/50A
                mbSession3.RawIO.Write("F1");        //熱電対起電力 起電力なので直流
                mbSession4.RawIO.Write("TM0");        //1次の電源電圧のステータスを直接電源シミュレータに聞く
                //Thread.Sleep(TimeSpan.FromSeconds(0.1));  //WriteとReadでのスパンを決めないとRead出来ない→今の機器（ADVANTESTやったらスパンなくてもよさそう）

                string voltageData = mbSession1.RawIO.ReadString();
                string CrampVoltData = mbSession2.RawIO.ReadString();
                string HeatVoltData = mbSession3.RawIO.ReadString();
                string SourceData = mbSession4.RawIO.ReadString();  //１次電圧電流を直接シミュレータに応答

                mbSession1.Dispose();   //タイマーごとに通信切らないと応答のログが残ってDMM側にエラー
                mbSession2.Dispose();
                mbSession3.Dispose();
                mbSession4.Dispose();

                double SecondVoltValue = double.Parse(voltageData);    //2次電圧
                double CrampVoltValue = double.Parse(CrampVoltData);  //クランプ電圧
                double SecondCurrValue = 50 / 0.2 * CrampVoltValue;  //2次電流換算
                double SecondElectricPower = SecondVoltValue * SecondCurrValue;
                double HeatVoltValue = double.Parse(HeatVoltData);    //熱電対起電圧

                double PrimV = ExtractValue(SourceData, 'V');
                double PrimA = ExtractValue(SourceData, 'A');
                double PrimR = PrimV / PrimA;
                double PrimVA = PrimV * PrimA;

                return (SecondVoltValue, SecondCurrValue, SecondElectricPower, HeatVoltValue, PrimV, PrimA, PrimR, PrimVA);
            }
        }
        private (double ElectricPowerValue, double SecondResistanceValue, double PressT, double deltaT, double mVHeatVoltValue) PerformCalculations(double SecondVoltValue, double SecondCurrValue, double HeatVoltValue)   //2次のデータ処理
        {
            double ElectricPowerValue = SecondVoltValue * SecondCurrValue;
            double SecondResistanceValue = SecondVoltValue / SecondCurrValue;
            double mVHeatVoltValue = 0;  //HeatVoltValue[V] を計算式の単位に揃える

            switch (useModeSelect)   //Power制御　or 熱電対（タブで分岐）
            {
                case 1:
                    PressT = Polynomial.Evaluate(ElectricPowerValue, p);
                    break;

                case 2:  //熱電対typeK
                    mVHeatVoltValue = HeatVoltValue * 1000000;
                    if (mVHeatVoltValue < 0)
                    {
                        deltaT = 0;
                    }
                    else if (mVHeatVoltValue >= 0 && mVHeatVoltValue <= 20664 * Math.Pow(10, -6))  //0~20644μV　０℃の下限は設定してないから設定する必要があるかも
                    {
                        deltaT = (2.508355 * Math.Pow(10, -2) * mVHeatVoltValue) +
                                      (7.860106 * Math.Pow(10, -8) * Math.Pow(mVHeatVoltValue, 2)) +
                                      (-2.503131 * Math.Pow(10, -10) * Math.Pow(mVHeatVoltValue, 3)) +
                                      (8.315270 * Math.Pow(10, -14) * Math.Pow(mVHeatVoltValue, 4)) +
                                      (-1.228034 * Math.Pow(10, -17) * Math.Pow(mVHeatVoltValue, 5)) +
                                      (9.804036 * Math.Pow(10, -22) * Math.Pow(mVHeatVoltValue, 6)) +
                                      (-4.413030 * Math.Pow(10, -26) * Math.Pow(mVHeatVoltValue, 7)) +
                                      (1.057734 * Math.Pow(10, -30) * Math.Pow(mVHeatVoltValue, 8)) +
                                      (-1.052755 * Math.Pow(10, -35) * Math.Pow(mVHeatVoltValue, 9));          //(基準関数による）
                    }
                    else　　//上限設定なし
                    {
                        deltaT = -1.318058 * Math.Pow(10, 2) +
                                      (4.830222 * Math.Pow(10, -2) * mVHeatVoltValue) +
                                      (-1.646031 * Math.Pow(10, -6) * Math.Pow(mVHeatVoltValue, 2)) +
                                      (5.464731 * Math.Pow(10, -11) * Math.Pow(mVHeatVoltValue, 3)) +
                                      (-9.650715 * Math.Pow(10, -16) * Math.Pow(mVHeatVoltValue, 4)) +
                                      (8.802193 * Math.Pow(10, -21) * Math.Pow(mVHeatVoltValue, 5)) +
                                      (-3.110810 * Math.Pow(10, -26) * Math.Pow(mVHeatVoltValue, 6));
                    }
                    PressT = roomT + deltaT;
                    break;

                case 3:     //熱電対typeB　 
                    mVHeatVoltValue = HeatVoltValue * 1000000;
                    if (mVHeatVoltValue <= 291 * Math.Pow(10, -6))    //291μV～2431μV
                    {
                        deltaT = 0;
                    }
                    else if (mVHeatVoltValue >= 291 * Math.Pow(10, -6) && mVHeatVoltValue <= 2431 * Math.Pow(10, -6))    //2431μV～13820μV
                    {
                        deltaT = 98.42332 +
                                    (0.6997150 * mVHeatVoltValue) +
                                    (-8.4765304 * Math.Pow(10, -4) * Math.Pow(mVHeatVoltValue, 2)) +
                                    (1.0052644 * Math.Pow(10, -6) * Math.Pow(mVHeatVoltValue, 3)) +
                                    (-8.3345952 * Math.Pow(10, -10) * Math.Pow(mVHeatVoltValue, 4)) +
                                    (4.5508542 * Math.Pow(10, -13) * Math.Pow(mVHeatVoltValue, 5)) +
                                    (-1.5523037 * Math.Pow(10, -16) * Math.Pow(mVHeatVoltValue, 6)) +
                                    (2.9886750 * Math.Pow(10, -20) * Math.Pow(mVHeatVoltValue, 7)) +
                                    (-2.4742860 * Math.Pow(10, -24) * Math.Pow(mVHeatVoltValue, 8));
                    }
                    else
                    {
                        deltaT = 213.1507 +
                                    (0.2851504 * mVHeatVoltValue) +
                                    (-5.2742887 * Math.Pow(10, -5) * Math.Pow(mVHeatVoltValue, 2)) +
                                    (9.9160804 * Math.Pow(10, -9) * Math.Pow(mVHeatVoltValue, 3)) +
                                    (-1.2965303 * Math.Pow(10, -12) * Math.Pow(mVHeatVoltValue, 4)) +
                                    (1.1195870 * Math.Pow(10, -16) * Math.Pow(mVHeatVoltValue, 5)) +
                                    (-6.0625199 * Math.Pow(10, -21) * Math.Pow(mVHeatVoltValue, 6)) +
                                    (1.8661696 * Math.Pow(10, -25) * Math.Pow(mVHeatVoltValue, 7)) +
                                    (-2.4878585 * Math.Pow(10, -30) * Math.Pow(mVHeatVoltValue, 8));
                    }
                    PressT = roomT + deltaT;
                    break;

                case 4:     //typeD y = 0.0015x5 - 0.0615x4 + 1.0395x3 - 9.1571x2 + 94.021x + 2.1901    (x=[mV], y=[℃])
                    mVHeatVoltValue = HeatVoltValue * 1000;
                    if (mVHeatVoltValue < 0)
                    {
                        deltaT = 0;
                    }
                    else if (mVHeatVoltValue >= 0 && mVHeatVoltValue < 13.8019609) //0~13.8019609 [mV]
                    {
                        deltaT = (2.1901) +
                                    (94.021 * mVHeatVoltValue) +
                                    (-9.1571 * Math.Pow(mVHeatVoltValue, 2)) +
                                    (1.0395 * Math.Pow(mVHeatVoltValue, 3)) +
                                    (-0.0615 * Math.Pow(mVHeatVoltValue, 4)) +
                                    (0.0015 * Math.Pow(mVHeatVoltValue, 5));
                    }
                    else    //y = 0.0001x5 - 0.0152x4 + 0.7319x3 - 17.132x2 + 243.09x - 748.01
                    {
                        deltaT = (-748.01) +
                                    (243.09 * mVHeatVoltValue) +
                                    (-17.132 * Math.Pow(mVHeatVoltValue, 2)) +
                                    (0.7319 * Math.Pow(mVHeatVoltValue, 3)) +
                                    (-0.0152 * Math.Pow(mVHeatVoltValue, 4)) +
                                    (0.0001 * Math.Pow(mVHeatVoltValue, 5));
                    }
                    PressT = roomT + deltaT;
                    break;

                case 5:     //typeR  電圧範囲の単位(μⅤ) 分解能？
                    mVHeatVoltValue = HeatVoltValue * 1000000;
                    if (mVHeatVoltValue < 0)
                    {
                        deltaT = 0;
                    }
                    else if (mVHeatVoltValue >= 0 && mVHeatVoltValue <= 1874 * Math.Pow(10, -6))
                    {
                        deltaT = (1.849 * Math.Pow(10, -1) * mVHeatVoltValue) +
                                    (-8.005 * Math.Pow(10, -5) * Math.Pow(mVHeatVoltValue, 2)) +
                                    (1.022 * Math.Pow(10, -7) * Math.Pow(mVHeatVoltValue, 3)) +
                                    (-1.522 * Math.Pow(10, -10) * Math.Pow(mVHeatVoltValue, 4)) +
                                    (1.888 * Math.Pow(10, -13) * Math.Pow(mVHeatVoltValue, 5)) +
                                    (-1.591 * Math.Pow(10, -16) * Math.Pow(mVHeatVoltValue, 6)) +
                                    (8.230 * Math.Pow(10, -20) * Math.Pow(mVHeatVoltValue, 7)) +
                                    (-2.342 * Math.Pow(10, -23) * Math.Pow(mVHeatVoltValue, 8)) *
                                    (2.798 * Math.Pow(10, -27) * Math.Pow(mVHeatVoltValue, 9));
                    }
                    else if (mVHeatVoltValue > 1874 * Math.Pow(10, -6) && mVHeatVoltValue <= 10332 * Math.Pow(10, -6))
                    {
                        deltaT = 12.92 +
                                    (1.466 * Math.Pow(10, -1) * mVHeatVoltValue) +
                                    (-1.535 * Math.Pow(10, -5) * Math.Pow(mVHeatVoltValue, 2)) +
                                    (3.146 * Math.Pow(10, -9) * Math.Pow(mVHeatVoltValue, 3)) +
                                    (-4.163 * Math.Pow(10, -13) * Math.Pow(mVHeatVoltValue, 4)) +
                                    (3.188 * Math.Pow(10, -17) * Math.Pow(mVHeatVoltValue, 5)) +
                                    (-1.292 * Math.Pow(10, -21) * Math.Pow(mVHeatVoltValue, 6)) +
                                    (2.183 * Math.Pow(10, -26) * Math.Pow(mVHeatVoltValue, 7)) +
                                    (-1.447 * Math.Pow(10, -31) * Math.Pow(mVHeatVoltValue, 8)) +
                                    (8.211 * Math.Pow(10, -36) * Math.Pow(mVHeatVoltValue, 9));
                    }
                    else if (mVHeatVoltValue > 10332 * Math.Pow(10, -6) && mVHeatVoltValue <= 17536 * Math.Pow(10, -6))
                    {
                        deltaT = -80.88 +
                                    (1.622 * Math.Pow(10, -1) * mVHeatVoltValue) +
                                    (-8.537 * Math.Pow(10, -6) * Math.Pow(mVHeatVoltValue, 2)) +
                                    (4.720 * Math.Pow(10, -10) * Math.Pow(mVHeatVoltValue, 3)) +
                                    (-1.442 * Math.Pow(10, -14) * Math.Pow(mVHeatVoltValue, 4)) +
                                    (2.082 * Math.Pow(10, -19) * Math.Pow(mVHeatVoltValue, 5));
                    }
                    else
                    {
                        deltaT = (5.334 * Math.Pow(10, 4)) +
                                    (-1.236 * Math.Pow(10, 1) * mVHeatVoltValue) +
                                    (1.093 * Math.Pow(10, -3) * Math.Pow(mVHeatVoltValue, 2)) +
                                    (-4.266 * Math.Pow(10, -8) * Math.Pow(mVHeatVoltValue, 3)) +
                                    (6.247 * Math.Pow(10, -13) * Math.Pow(mVHeatVoltValue, 4));
                    }
                    PressT = roomT + deltaT;
                    break;
                default:
                    // デフォルトの処理（必要に応じて）
                    PressT = 20; // 例として、デフォルトでは温度を 0 に設定
                    break;
            }
            return (ElectricPowerValue, SecondResistanceValue, PressT, deltaT, mVHeatVoltValue);
        }
        private void UpdateUI(double SecondVoltValue, double SecondCurrValue, double HeatVoltValue, double SecondElectricPower, double SecondResistanceValue, double deltaT, double PrimV, double PrimA, double PrimR, double PrimVA)
        {
            double Kelvin = PressT + 273;
            double mVHeatVoltValue = HeatVoltValue * 1000;
            //TextBoxに出力
            HeatVBox.Text = mVHeatVoltValue.ToString("F3");//熱起電力（mV？)単位を実際に測って検証しないといけないかも
            TemperatureBox.Text = PressT.ToString("F3");//プレス内温度
            KelvinBox.Text = Kelvin.ToString("F3");//絶対温度
            SourceVBox.Text = PrimV.ToString("F3");  //１次電圧
            SourceABox.Text = PrimA.ToString("F3");//１次電流
            PrimRBox.Text = Math.Round(PrimR, 4, MidpointRounding.AwayFromZero).ToString();//１次抵抗[小数点以下４桁まで四捨五入]
            SourceEPBox.Text = PrimVA.ToString("F3");   //1次電力
            SecondVBox.Text = SecondVoltValue.ToString("F3");   //2次電圧
            SecondABox.Text = SecondCurrValue.ToString("F3");   //2次電流
            SecondRBox.Text = SecondResistanceValue.ToString("F3");     //2次抵抗
            SecondVABox.Text = Math.Round(SecondElectricPower, 4, MidpointRounding.AwayFromZero).ToString();  //2次電力、小数点以下４桁まで丸める

            Vseries1.BorderWidth = 3;
            Aseries2.BorderWidth = 3;
            Rseries3.BorderWidth = 3;
            Pseries4.BorderWidth = 3;
            Tseries5.BorderWidth = 3;
            //色指定
            Vseries1.Color = Color.DarkOrange;
            Aseries2.Color = Color.SeaGreen;
            Rseries3.Color = Color.DodgerBlue;
            Pseries4.Color = Color.MediumSlateBlue;
            Tseries5.Color = Color.IndianRed;
            //Chartに出力
            Vseries1.Points.AddY(SecondVoltValue);
            Aseries2.Points.AddY(SecondCurrValue);
            Rseries3.Points.AddY(SecondResistanceValue);
            Pseries4.Points.AddY(SecondElectricPower);
            Tseries5.Points.AddY(PressT);
            //Listに入れる（CSV用）
            voltageValues.Add(SecondVoltValue);
            currentValues.Add(SecondCurrValue);
            resistanceValues.Add(SecondResistanceValue);
            electricPowerValues.Add(SecondElectricPower);
            temperatureValues.Add(PressT);
            PrimVoltageValues.Add(PrimV);
            PrimCurrentValues.Add(PrimA);
            PrimelEctricPowerValues.Add(PrimVA);
            //Chartの更新
            UpdateChart(Vseries1, chart1, SecondVoltValue);
            UpdateChart(Aseries2, chart2, SecondCurrValue);
            UpdateChart(Rseries3, chart3, SecondResistanceValue);
            UpdateChart(Pseries4, chart4, SecondElectricPower);
            UpdateChart(Tseries5, chart5, PressT);
        }
        private double ExtractValue(string SourceData, char identifier)     //電源から直接電圧電流を測定した時の文字列から数値データとして取り出す
        {
            string pattern = @"([-+]?\d+(\.\d+)?)\s*" + identifier;     //電源シミュレータごとの出力文字列に合わせてコーディング
            Match match = Regex.Match(SourceData, pattern);

            if (match.Success && double.TryParse(match.Groups[1].Value, NumberStyles.Any, CultureInfo.InvariantCulture, out double value))
            {
                return value;
            }
            else
            {
                throw new ArgumentException($"入力文字列に有効な {identifier} 値が見つかりません。");
            }
        }
        private void GetDataT(double deltaT)//温度入力値読み込み
        {
            //roomT読み込み,Tに変換
            if (double.TryParse(T0Box.Text, out roomT))
            {
                PressT = roomT + deltaT;
                TemperatureBox.Text = PressT.ToString();
            }
            else
            {
                // テキストボックスの値が数値に変換できなかった場合のエラーハンドリング
                MessageBox.Show("有効な数値を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void HandleError(Exception ex)　//通信エラー処理
        {
            timer1.Stop();
            stopwatch.Stop();
            MessageBox.Show("通信エラー");

            // 測定におけるフラグによって分岐
            if (isRecording == true)    //測定フラグがある時
            {
                DialogResult result = MessageBox.Show(
                    "各機器の接続状態を確認してください。\n再試行しますか？",
                    "エラー",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
                if (result == DialogResult.Yes)
                {
                    DialogResult resultRetry = MessageBox.Show(
                        "データを保持したまま測定再開しますか？\nYes,No[データリセット]",
                        "エラー",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                        );
                    if (resultRetry == DialogResult.Yes)
                    {
                        timer1.Start();
                        stopwatch.Start();
                    }
                    else if (resultRetry == DialogResult.No)
                    {
                        ResetAndResumeMeasurement();    //データのリセット処理
                        timer1.Start();
                        stopwatch.Start();
                    }
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
            else if (isRecording == false)  //測定フラグないとき
            {
                DialogResult result = MessageBox.Show(
                    "各機器の接続状態を確認してください。\n再試行しますか？",
                    "エラー",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
                if (result == DialogResult.Yes)
                {
                    timer1.Start();
                    stopwatch.Start();
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)    //フォームが閉じられようとしている場合
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (isFileSaving == false)
                {
                    //確認メッセージを表示
                    DialogResult result1 = MessageBox.Show("ファイルを保存して終了しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result1 == DialogResult.Yes)
                    {
                        timer1.Stop();
                        // SaveFileDialog を使ってユーザーにファイル名と保存場所を選択させる
                        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                        saveFileDialog1.Filter = "CSV ファイル (*.csv)|*.csv|すべてのファイル (*.*)|*.*";
                        saveFileDialog1.Title = "CSV ファイルを保存する";
                        saveFileDialog1.ShowDialog();

                        if (saveFileDialog1.FileName == "")
                            return;

                        string filePath = saveFileDialog1.FileName;

                        SaveAllDataToCsv(filePath);        //ファイルパスとデータ
                        isFileSaving = true;      //file保存フラグ
                    }
                }
                DialogResult PimVA = MessageBox.Show("アプリケーションを終了しますか？" +
                    "安全のため出力をOFFにして終了します。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (PimVA == DialogResult.Yes)
                {
                    if (isOutput == true)
                    {
                        using (var rmSession4 = new ResourceManager())   //変数の宣言
                            mbSession4 = (MessageBasedSession)rmSession4.Open("GPIB0::4::INSTR");  //特定の機器への挨拶
                        mbSession4.RawIO.Write("OT0");     //出力のWrite OFF
                        mbSession4.Dispose(); mbSession4.Dispose();
                    }

                    //終了
                    Application.Exit();
                }
                else
                {
                    //終了をキャンセル
                    e.Cancel = true;
                }
            }
        }
        private void ResetAndResumeMeasurement()　 // データをリセットする処理
        {
            stopwatch.Reset();  //stopwatchのリセット

            // データを格納しているリストをクリア
            elapsedTimes.Clear();
            voltageValues.Clear();
            currentValues.Clear();
            resistanceValues.Clear();
            electricPowerValues.Clear();
            temperatureValues.Clear();
            PrimVoltageValues.Clear();
            PrimCurrentValues.Clear();
            PrimelEctricPowerValues.Clear();

            // グラフ上のデータもクリア
            Vseries1.Points.Clear();
            Aseries2.Points.Clear();
            Rseries3.Points.Clear();
            Pseries4.Points.Clear();
            Tseries5.Points.Clear();

            // 表示範囲の初期化
            chart1.ChartAreas[0].AxisX.Minimum = 0;  // X軸の初期値
            chart2.ChartAreas[0].AxisX.Minimum = 0;  // X軸の初期値
            chart3.ChartAreas[0].AxisX.Minimum = 0;  // X軸の初期値
            chart4.ChartAreas[0].AxisX.Minimum = 0;  // X軸の初期値
            chart5.ChartAreas[0].AxisX.Minimum = 0;  // X軸の初期値
            chart1.ChartAreas[0].AxisX.Maximum = displayRange - 1;  // 初期表示範囲を設定 
            chart2.ChartAreas[0].AxisX.Maximum = displayRange - 1;  // 初期表示範囲を設定 
            chart3.ChartAreas[0].AxisX.Maximum = displayRange - 1;  // 初期表示範囲を設定 
            chart4.ChartAreas[0].AxisX.Maximum = displayRange - 1;  // 初期表示範囲を設定 
            chart5.ChartAreas[0].AxisX.Maximum = displayRange - 1;  // 初期表示範囲を設定 

            // 測定を再開
            timer1.Start();
        }
        //Chartを右から左へ流れるように更新する（UpdateChartでグラフを書き換え
        private void UpdateChart(System.Windows.Forms.DataVisualization.Charting.Series series, Chart chart, double SecondVoltValue)      //
        {
            int lastPointIndex = Vseries1.Points.Count - 1;
            //int displayRange = 20;  // 表示範囲のデータ数

            // データポイント数が表示範囲を超えている場合、表示範囲を動的に更新
            if (lastPointIndex > displayRange)
            {
                chart.ChartAreas[0].AxisX.Minimum = lastPointIndex - displayRange;　　 //データが増える分過去データがグラフから見えなくなる
                chart.ChartAreas[0].AxisX.Maximum = lastPointIndex;　　//右端は常に最新
            }
        }

        private void OnButton_Click(object sender, EventArgs e)//出力ＯＮ
        {
            using (var rmSession4 = new ResourceManager())   //変数の宣言
                switch (useModeSelect)
                {
                    case 0:
                        MessageBox.Show("測定モードを選択してください");
                        break;
                    default:
                        mbSession4 = (MessageBasedSession)rmSession4.Open("GPIB0::4::INSTR");  //特定の機器への挨拶
                        string VTCommand = "VA" + PresetVBox.Text;
                        mbSession4.RawIO.Write(VTCommand);     //出力のWrite ON
                        mbSession4.RawIO.Write("OT1");     //信号源,周波数50,電圧レンジLOW,出力波形Sin,出力インピーダンス0%, 出力のWrite ON
                        mbSession4.Dispose();
                        //MessageBox.Show(VTCommand);

                        isOutput = true;        //出力のフラグ
                        OnButton.Text = "出力中";
                        OffButton.Text = "停止";
                        OnButton.Enabled = false;
                        OffButton.Enabled = true;
                        OnButton.BackColor = Color.White;
                        OffButton.BackColor = Color.Red;
                        break;
                }
            //stopwatch.Start();
            ResetAndResumeMeasurement();        //データのリセット処理
        }

        private void OffButton_Click(object sender, EventArgs e)//出力ＯＦＦ
        {
            using (var rmSession4 = new ResourceManager())   //変数の宣言
                mbSession4 = (MessageBasedSession)rmSession4.Open("GPIB0::4::INSTR");  //特定の機器への挨拶
            string VTCommand = "VA" + PresetVBox.Text;
            mbSession4.RawIO.Write("OT0");     //出力のWrite OFF
            mbSession4.Dispose();
            isOutput = false;       //出力のフラグ
            var (SecondVoltValue, SecondCurrValue, SecondElectricPower, HeatVoltValue, PrimV, PrimA, PrimR, PrimVA) = GetDataFromInstruments();  //機器との通信
            var (ElectricPowerValue, SecondResistanceValue, PressT, deltaT, mVHeatVoltValue) = PerformCalculations(SecondVoltValue, SecondCurrValue, HeatVoltValue);    //電力抵抗温度の出力
            UpdateUI(SecondVoltValue, SecondCurrValue, HeatVoltValue, ElectricPowerValue, SecondResistanceValue, deltaT, PrimV, PrimA, PrimR, PrimVA);       //Chartへの出力シーケンス
            OnButton.Text = "出力";
            OffButton.Text = "停止中";
            OnButton.Enabled = true;
            OffButton.Enabled = false;
            OffButton.BackColor = Color.White;
            OnButton.BackColor = Color.Lime;
        }
        private void SaveAllDataToCsv(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))      //UTF-8エンコーディングを使用、文字化け対策
            {
                //時間、測定モード
                string modetext = ModeBox.Text;
                string stopwatchtext = StopWatchlabel.Text;
                string PIDMode = PIDButton.Text;
                string PGaintext = PgainBox.Text;
                string IGaintext = IgainBox.Text;
                string DGaintext = DgainBox.Text;
                writer.WriteLine(modetext);
                writer.WriteLine(stopwatchtext);
                writer.WriteLine("PIDmode,PGain,IGain,DGain");
                writer.WriteLine($"{PIDMode},{PGaintext},{IGaintext},{DGaintext}");

                // 列の名前を出力
                writer.WriteLine("測定時間,2次電圧(V),2次電流(A),2次抵抗(Ω),2次電力(VA),温度(℃),1次電圧(V),1次電流(A),1次電力(VA)");
                //各列のデータ
                //for (int i = 0; i < voltageValues.Count;  i ++)
                for (int i = 0; i < elapsedTimes.Count;  i += SaveSpanCmd)
                {
                    writer.WriteLine($"{elapsedTimes[i]},{voltageValues[i]}, {currentValues[i]}, {resistanceValues[i]}, {electricPowerValues[i]}, {temperatureValues[i]}, {PrimVoltageValues[i]}, {PrimCurrentValues[i]}, {PrimelEctricPowerValues[i]}");
                }
            }
        }
        private void UpdateElapsedTime()        //測定時間
        {
            TimeSpan elapsed = stopwatch.Elapsed;
            string elapsedString = elapsed.ToString(@"hh\:mm\:ss");
            elapsedTimes.Add(elapsedString);
            StopWatchlabel.Text = $"測定時間:{elapsed.ToString(@"hh\:mm\:ss")}";
        }

        private void RecordButton_Click(object sender, EventArgs e) //記録ボタン
        {
            if (!isRecording)
            {
                ResetAndResumeMeasurement();        //データのリセット処理かつCSVにデータが入りだす
                stopwatch.Start();

                RecordButton.BackColor = Color.Green;
                RecordButton.Text = "記録中";
                isRecording = true;     //記録開始フラグ
            }
            else 
            {
                stopwatch.Stop();
                timer1.Stop();
                RecordButton.BackColor = Color.White;
                RecordButton.Text = "記録";
                isRecording = false;     //記録停止フラグ

                DialogResult PimVA = MessageBox.Show("測定を終了しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //「はい」を選択したとき
                if (PimVA == DialogResult.Yes)
                {
                    // SaveFileDialog を使ってユーザーにファイル名と保存場所を選択させる
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "CSV ファイル (*.csv)|*.csv|すべてのファイル (*.*)|*.*";
                    saveFileDialog1.Title = "CSV ファイルを保存する";
                    saveFileDialog1.ShowDialog();

                    if (saveFileDialog1.FileName == "")
                        return;

                    string filePath = saveFileDialog1.FileName;

                    SaveAllDataToCsv(filePath);        //ファイルパスとデータ
                    isFileSaving = true;      //file保存フラグ

                    timer1.Start();
                }
                else
                {
                    timer1.Start();
                    stopwatch.Start();
                    RecordButton.BackColor = Color.Green;
                    RecordButton.Text = "記録中";
                    isRecording = true;     //記録開始フラグ
                }
            }
        }

        private void FrequencySet_Click(object sender, EventArgs e)
        {
            using (var rmSession4 = new ResourceManager())  //変数の宣言
                mbSession4 = (MessageBasedSession)rmSession4.Open("GPIB0::4::INSTR");  //特定の機器への挨拶
            string Frequency = "FQ" + FrequencyBox.Text;
            mbSession4.RawIO.Write(Frequency);     //出力のWrite ON
            mbSession4.Dispose();
        }

        private void SaveSpanUp_Click(object sender, EventArgs e)
        {
            if (float.TryParse(SaveSpanBox.Text, out SaveSpan))
            {
                SaveSpan *= 2.0f; // テキストボックスの値を*2する
                SaveSpanBox.Text = SaveSpan.ToString(); // 新しい値をテキストボックスに設定する

                if (SaveSpan > 128f)
                {
                    SaveSpan = 128f;
                    SaveSpanBox.Text = SaveSpan.ToString();
                    return;
                }

                int SaveSpanCmd = (int)(SaveSpan * 2);  //ms換算のため (Timer1の周期:0.5より)
            }
            else
            {
                // テキストボックスの値が数値に変換できなかった場合のエラーハンドリング
                MessageBox.Show("有効な数値を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveSpanDown_Click(object sender, EventArgs e)
        {
            if (float.TryParse(SaveSpanBox.Text, out SaveSpan))
            {
                SaveSpan /= 2.0f; // テキストボックスの値を÷2する
                SaveSpanBox.Text = SaveSpan.ToString(); // 新しい値をテキストボックスに設定する

                if (SaveSpan < 0.5f)
                {
                    SaveSpan = 0.5f;
                    SaveSpanBox.Text = SaveSpan.ToString();
                    return;
                }

                int SaveSpanCmd = (int)(SaveSpan * 2);  //ms換算のため (Timer1の周期:0.5より)
            }
            else
            {
                // テキストボックスの値が数値に変換できなかった場合のエラーハンドリング
                MessageBox.Show("有効な数値を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void PIDtimer_Tick(object sender, EventArgs e)
        {
            // 制御周期分だけ待つ処理

            // 熱電対での測定の場合、温度での計算
            if (useModeSelect == 2 ||
                useModeSelect == 3 ||
                useModeSelect == 4 ||
                useModeSelect == 5)
            {
                PressT = roomT + deltaT; // 出力を取得。例:センサー情報を読み取る処理

                // PID制御の式より、制御入力uを計算
                currErr = TargetT - PressT;                // 偏差を計算
                errRate = (currErr - currErr_pre) / PIDSpan;        // 偏差の微分を近似計算 
                errSum = errSum + ((currErr + currErr_pre) * PIDSpan / 2); // 誤差の積分を近似計算 周期Tの時　errSum = errSum + (currErr + currErr_pre) * T / 2
                PIDOutput = (PGain * currErr) + (IGain * errSum) + (DGain * errRate); // %なので％に伴う操作量を以下で指定
                PIDConditionText.Text = $"PGain: {PGain}\nDGain: {DGain}\nIGain: {IGain}\n偏差: {currErr}\n微分: {errRate}\n積分: {errSum}\n出力(%): {PIDOutput}";
                //制御入力をシステムに与える処理 電力での出力量を制御したい。２次電力と１次の電圧関係から出力をいじる。（温度が上がれば、抵抗値が変わり、1：１対応ではないっぽい）

                // 出力条件
                if (PIDOutput > 100)//温度出力の最大設定
                {
                    if (float.TryParse(PresetVBox.Text, out PresetV))
                    {
                        PresetV += 1.0f; // テキストボックスの値を+1.0する
                        PresetVBox.Text = PresetV.ToString(); // 新しい値をテキストボックスに設定する

                        using (var rmSession4 = new ResourceManager())
                        {
                            mbSession4 = (MessageBasedSession)rmSession4.Open("GPIB0::4::INSTR");  //特定の機器への挨拶
                            string VTCommand = "VA" + PresetV.ToString(); // VTCommandを生成
                            mbSession4.RawIO.Write(VTCommand);     //出力のWrite ON
                            mbSession4.Dispose();
                        }
                    }
                    else
                    {
                        // テキストボックスの値が数値に変換できなかった場合のエラーハンドリング
                        MessageBox.Show("有効な数値を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (PIDOutput < -100)//最低条件
                {
                    if (float.TryParse(PresetVBox.Text, out PresetV))
                    {
                        PresetV -= 0.1f; // テキストボックスの値を-0.1する
                        PresetVBox.Text = PresetV.ToString(); // 新しい値をテキストボックスに設定する

                        using (var rmSession4 = new ResourceManager())
                        {
                            mbSession4 = (MessageBasedSession)rmSession4.Open("GPIB0::4::INSTR");  //特定の機器への挨拶
                            string VTCommand = "VA" + PresetV.ToString(); // VTCommandを生成
                            mbSession4.RawIO.Write(VTCommand);     //出力のWrite ON
                            mbSession4.Dispose();
                        }
                    }
                    else
                    {
                        // テキストボックスの値が数値に変換できなかった場合のエラーハンドリング
                        MessageBox.Show("有効な数値を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    PIDOutput = PIDOutput / 100;
                    float PIDFloatOutput = (float)Math.Round(PIDOutput, 2);
                    PresetV += PIDFloatOutput;
                    PresetVBox.Text = PresetV.ToString();

                    using (var rmSession4 = new ResourceManager())
                    {
                        mbSession4 = (MessageBasedSession)rmSession4.Open("GPIB0::4::INSTR");  //特定の機器への挨拶
                        string VTCommand = "VA" + PresetV.ToString(); // VTCommandを生成
                        mbSession4.RawIO.Write(VTCommand);     //出力のWrite ON
                        mbSession4.Dispose();
                    }

                }
                // 次のために現時刻の情報を記録
                currErr_pre = currErr;
            }
            else //電力制御での計算
            {

            }
        }

        private void PIDButton_Click(object sender, EventArgs e)
        {
            if (!isPIDControl)
            {
                isPIDControl = true;
                // 定数設定 PID条件のテキストボックス殻の取得 ===============
                if (!double.TryParse(PIDSpanBox.Text, out PIDSpan) ||
                   !double.TryParse(PgainBox.Text, out PGain) ||
                   !double.TryParse(DgainBox.Text, out DGain) ||
                   !double.TryParse(IgainBox.Text, out IGain) ||
                   !double.TryParse(TargetTBox.Text, out TargetT))
                {
                    MessageBox.Show("有効な数値を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                PIDtimer.Start();

                PIDButton.BackColor = Color.DodgerBlue;
                PIDButton.Text = "Auto(PID):ON";
            }
            else
            {
                isPIDControl = false;
                PIDtimer.Stop();

                PIDButton.BackColor = Color.White;
                PIDButton.Text = "Auto(PID):OFF";
            }
        }

        private void TargetTSetButton_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(TargetTBox.Text, out TargetT))
            {
                MessageBox.Show("有効な数値を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void PgainSetButton_Click(object sender, EventArgs e)
        {
            if (!double. TryParse(PgainBox.Text, out PGain))
            {
                MessageBox.Show("有効な数値を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void DgainSetButton_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(DgainBox.Text, out DGain))
            {
                MessageBox.Show("有効な数値を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void IgainSetButton_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(IgainBox.Text, out IGain))
            {
                MessageBox.Show("有効な数値を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void PIDSpanSetButton_Click(object sender, EventArgs e)
        {
            if(!double.TryParse(PIDSpanBox.Text,out PIDSpan))
            {
                MessageBox.Show("有効な数値を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                mPIDSpan = PIDSpan * 1000;
                PIDtimer.Interval = (int)mPIDSpan;
            }
        }

    }
}
//やること
//全体を通じての周波数の変化の影響調査
//開発したアプリケーションをほかのPCでも起動できるのか。PATHなどもしくは.exeとして実装出来ないのか
//Uiの改善
//PID制御の導入　(目標温度を入力すると自動で、制御ができるもの）
//経過時間のリセット処理を入れないと再度起動するときにデータ数が合わずエラー出てまう
//stopwatchのリセットをすることで経過時間の処理を正常化？
//エラー処理を変更（測定フラグによる分岐）

//timer1 測定周期　~0.5　


//参考文献（熱電対）
// 熱電対起電力の圧力効果：マルチアンビル装置と放射光を用いた実験的研究　西原 遊, 中田 輝, 松影 香子, 肥後 祐司, 丹下 慶範　 https://doi.org/10.4131/jshpreview.34.81
