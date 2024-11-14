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

        private int useModeSelect = 0;     //メニューによるモードの切替フラグ

        private Stopwatch stopwatch;        //測定時間計測

        private float PresetV = 0;//PresetV(設定電圧)の現在の値

        //double ElectricPowerValue = new double();
        List<double> voltageValues = new List<double>();
        List<double> PrimVoltageValues = new List<double>();
        List<double> currentValues = new List<double>();
        List<double> PrimCurrentValues = new List<double>();
        List<double> resistanceValues = new List<double>();
        List<double> electricPowerValues = new List<double>();
        List<double> PrimelEctricPowerValues = new List<double>();
        List<double> temperatureValues = new List<double>();

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
            Tseries5 = new System.Windows.Forms.DataVisualization.Charting.Series("Temperature");
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
            chart1.ChartAreas[0].AxisX.Title = "Time (seconds)";
            chart2.ChartAreas[0].AxisX.Title = "Time (seconds)";
            chart3.ChartAreas[0].AxisX.Title = "Time (seconds)";
            chart4.ChartAreas[0].AxisX.Title = "Time (seconds)";
            chart5.ChartAreas[0].AxisX.Title = "Time (seconds)";
            chart1.ChartAreas[0].AxisY.Title = "Voltage(V)";
            chart2.ChartAreas[0].AxisY.Title = "Current(A)";
            chart3.ChartAreas[0].AxisY.Title = "Resistance(Ω)";
            chart4.ChartAreas[0].AxisY.Title = "ElectricPower(VA)";
            chart5.ChartAreas[0].AxisY.Title = "Temperature(℃)";

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
        }
        private void PresetVdUp_Click(object sender, EventArgs e)   //0.1ずつ上げる
        {
            //MessageBox.Show("Button clicked");
            if (float.TryParse(PresetVBox.Text, out PresetV))
            {
                PresetV += 0.1f; // テキストボックスの値を+0.5する
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
                PresetV -= 0.1f; // テキストボックスの値を-0.5する
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
            ModeBox.Text = "パワー制御";
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
            Form2 form2 = new Form2();
            form2.Show();
        }

        public void ReceivePolynomial(double[] p)   // 受け取った係数配列をフィールドに代入
        {
            this.p = p;
            FunctionTextBox.Text = ToTeXPolynomial(p);      //textに出力
        }
        private string ToTeXPolynomial(double[] coefficients) //テキストボックスに関数を表示させるもの　ｐの係数がcoefficients
        {
            string polynomialTeX = "y(x) = ";

            for (int i = coefficients.Length - 1; i >= 0; i--)
            {
                if (i == coefficients.Length - 1)
                {
                    // 最高次の項
                    polynomialTeX += $"{coefficients[i]}x^{i}";
                }
                else
                {
                    if (coefficients[i] >= 0)
                    {
                        polynomialTeX += $" + {coefficients[i]}x^{i}";
                    }
                    else
                    {
                        polynomialTeX += $" - {Math.Abs(coefficients[i])}x^{i}";
                    }
                }
            }

            return polynomialTeX;
        }

        private void Form1_Load(object sender, EventArgs e)     //起動設定
        {
            //立ち上げ設定
            useModeSelect = 0;
            HeaterControl();
            SettingCondition();
            timer1.Start();     //timer作動
            stopwatch.Stop();
        }
        private void HeaterControl()
        {
            using (var rmSession4 = new ResourceManager())
            {
                mbSession4 = (MessageBasedSession)rmSession4.Open("GPIB0::4::INSTR");  //特定の機器への挨拶
                mbSession4.RawIO.Write("FQ50,ZA0");     //抵抗値のWrite
                mbSession4.Dispose();
            }
        }
        private void SettingCondition()
        {
            using (var rmSession4 = new ResourceManager())
            {
                mbSession4 = (MessageBasedSession)rmSession4.Open("GPIB0::4::INSTR");  //特定の機器への挨拶
                mbSession4.RawIO.Write("TM1,TM2");     //状態のWrite
                Thread.Sleep(TimeSpan.FromSeconds(1));  //WriteとReadでのスパンを決めないとRead出来ない
                SettingConditionBox.Text = mbSession4.RawIO.ReadString();
                mbSession4.Dispose();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)    //Timer設定
        {
                try
                {
                    var (SecondVoltValue, SecondCurrValue,SecondElectricPower, HeatVoltValue, PrimV, PrimA, PrimR, PrimVA) = GetDataFromInstruments();  //機器との通信
                    var (ElectricPowerValue, SecondResistanceValue, Temperature) = PerformCalculations(SecondVoltValue, SecondCurrValue, HeatVoltValue);    //電力抵抗温度の出力
                    UpdateUI(SecondVoltValue, SecondCurrValue, HeatVoltValue, SecondElectricPower, SecondResistanceValue, Temperature, PrimV, PrimA, PrimR, PrimVA);       //Chartへの出力シーケンス
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
                mbSession3.RawIO.Write("F2");        //熱電対起電力
                mbSession4.RawIO.Write("TM0");        //1次の電源電圧のステータスを直接電源シミュレータに聞く
                Thread.Sleep(TimeSpan.FromSeconds(1));  //WriteとReadでのスパンを決めないとRead出来ない

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
        private double ExtractValue(string SourceData, char identifier)     //電源から直接電圧電流を測定した時の文字列から数値データとして取り出す
        {
            string pattern = @"([-+]?\d+(\.\d+)?)\s*" + identifier;
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


        private void UpdateUI(double SecondVoltValue, double SecondCurrValue, double HeatVoltValue, double SecondElectricPower, double SecondResistanceValue, double Temperature, double PrimV, double PrimA, double PrimR, double PrimVA)
        {
            double Kelvin = Temperature + 273;
            //TextBoxに出力
            HeatVBox.Text = HeatVoltValue.ToString("F3");
            TemperatureBox.Text = Temperature.ToString("F3");
            KelvinBox.Text = Kelvin.ToString("F3");
            SourceVBox.Text = PrimV.ToString("F3");  
            SourceABox.Text = PrimA.ToString("F3");
            PrimRBox.Text = Math.Round(PrimR,4,MidpointRounding.AwayFromZero).ToString();
            SourceEPBox.Text = PrimVA.ToString("F3");   //1次電力
            SecondVBox.Text = SecondVoltValue.ToString("F3");   //2次電圧
            SecondABox.Text = SecondCurrValue.ToString("F3");   //2次電流
            SecondRBox.Text = SecondResistanceValue.ToString("F3");     //2次抵抗
            SecondVABox.Text = Math.Round(SecondElectricPower,4,MidpointRounding.AwayFromZero).ToString();  //2次電力、小数点以下４桁まで丸める

            Vseries1.BorderWidth = 3;
            Aseries2.BorderWidth = 3;
            Rseries3.BorderWidth = 3;
            Pseries4.BorderWidth = 3;
            Tseries5.BorderWidth = 3;
            //Chartに出力
            Vseries1.Points.AddY(SecondVoltValue);
            Aseries2.Points.AddY(SecondCurrValue);
            Rseries3.Points.AddY(SecondResistanceValue);
            Pseries4.Points.AddY(SecondElectricPower);
            Tseries5.Points.AddY(Temperature);
            //Listに入れる（CSV用）
            voltageValues.Add(SecondVoltValue);
            currentValues.Add(SecondCurrValue);
            resistanceValues.Add(SecondResistanceValue);
            electricPowerValues.Add(SecondElectricPower);
            temperatureValues.Add(Temperature);
            PrimVoltageValues.Add(PrimV);
            PrimCurrentValues.Add(PrimA);
            PrimelEctricPowerValues.Add(PrimVA);
            //Chartの更新
            UpdateChart(Vseries1,chart1, SecondVoltValue);
            UpdateChart(Aseries2,chart2, SecondCurrValue);
            UpdateChart(Rseries3,chart3, SecondResistanceValue);
            UpdateChart(Pseries4,chart4, SecondElectricPower);
            UpdateChart(Tseries5,chart5, Temperature);
        }
        private (double ElectricPowerValue, double SecondResistanceValue, double Temperature) PerformCalculations(double SecondVoltValue, double SecondCurrValue, double HeatVoltValue)   //2次のデータ処理
        {
            double ElectricPowerValue = SecondVoltValue * SecondCurrValue;
            double SecondResistanceValue = SecondVoltValue / SecondCurrValue;
            double Temperature;

            switch (useModeSelect)   //Power制御　or 熱電対（タブで分岐）
            {
                case 1:
                    Temperature = Polynomial.Evaluate(ElectricPowerValue, p);
                    break;

                case 2:  //熱電対typeK
                    if (HeatVoltValue <= 20664 * Math.Pow(10, -6))  //0~500℃　０℃の下限は設定してないから設定する必要があるかも
                    {
                        Temperature = (2.508355 * Math.Pow(10, -2) * HeatVoltValue) +
                                      (7.860106 * Math.Pow(10, -8) * Math.Pow(HeatVoltValue, 2)) +
                                      (-2.503131 * Math.Pow(10, -10) * Math.Pow(HeatVoltValue, 3)) +
                                      (8.315270 * Math.Pow(10, -14) * Math.Pow(HeatVoltValue, 4)) +
                                      (-1.228034 * Math.Pow(10, -17) * Math.Pow(HeatVoltValue, 5)) +
                                      (9.804036 * Math.Pow(10, -22) * Math.Pow(HeatVoltValue, 6)) +
                                      (-4.413030 * Math.Pow(10, -26) * Math.Pow(HeatVoltValue, 7)) +
                                      (1.057734 * Math.Pow(10, -30) * Math.Pow(HeatVoltValue, 8)) +
                                      (-1.052755 * Math.Pow(10, -35) * Math.Pow(HeatVoltValue, 9));          //(基準関数による）
                    }
                    else　　//上限設定なし
                    {
                        Temperature = -1.318058 * Math.Pow(10, 2) +
                                      (4.830222 * Math.Pow(10, -2) * HeatVoltValue) +
                                      (-1.646031 * Math.Pow(10, -6) * Math.Pow(HeatVoltValue, 2)) +
                                      (5.464731 * Math.Pow(10, -11) * Math.Pow(HeatVoltValue, 3)) +
                                      (-9.650715 * Math.Pow(10, -16) * Math.Pow(HeatVoltValue, 4)) +
                                      (8.802193 * Math.Pow(10, -21) * Math.Pow(HeatVoltValue, 5)) +
                                      (-3.110810 * Math.Pow(10, -26) * Math.Pow(HeatVoltValue, 6));
                    }
                    break;

                case 3:     //熱電対typeB
                    if (HeatVoltValue <= 291 * Math.Pow(10, -6))
                    {
                        Temperature = 0;
                    }
                    if (HeatVoltValue >= 291 * Math.Pow(10, -6) && HeatVoltValue <= 2431 * Math.Pow(10, -6))
                    {
                        Temperature = 98.42332 +
                                    (0.6997150 * HeatVoltValue) +
                                    (-8.4765304 * Math.Pow(10, -4) * Math.Pow(HeatVoltValue, 2)) +
                                    (1.0052644 * Math.Pow(10, -6) * Math.Pow(HeatVoltValue, 3)) +
                                    (-8.3345952 * Math.Pow(10, -10) * Math.Pow(HeatVoltValue, 4)) +
                                    (4.5508542 * Math.Pow(10, -13) * Math.Pow(HeatVoltValue, 5)) +
                                    (-1.5523037 * Math.Pow(10, -16) * Math.Pow(HeatVoltValue, 6)) +
                                    (2.9886750 * Math.Pow(10, -20) * Math.Pow(HeatVoltValue, 7)) +
                                    (-2.4742860 * Math.Pow(10, -24) * Math.Pow(HeatVoltValue, 8));
                    }
                    else
                    {
                        Temperature = 213.1507 +
                                    (0.2851504 * HeatVoltValue) +
                                    (-5.2742887 * Math.Pow(10, -5) * Math.Pow(HeatVoltValue, 2)) +
                                    (9.9160804 * Math.Pow(10, -9) * Math.Pow(HeatVoltValue, 3)) +
                                    (-1.2965303 * Math.Pow(10, -12) * Math.Pow(HeatVoltValue, 4)) +
                                    (1.1195870 * Math.Pow(10, -16) * Math.Pow(HeatVoltValue, 5)) +
                                    (-6.0625199 * Math.Pow(10, -21) * Math.Pow(HeatVoltValue, 6)) +
                                    (1.8661696 * Math.Pow(10, -25) * Math.Pow(HeatVoltValue, 7)) +
                                    (-2.4878585 * Math.Pow(10, -30) * Math.Pow(HeatVoltValue, 8));
                    }
                    break;

                case 4:     //typeD
                    if (HeatVoltValue < 13.8019609)
                    {
                        Temperature = (2 * Math.Pow(10, -10)) +
                                    (0.0096 * HeatVoltValue) +
                                    (2 * Math.Pow(10, -5) * Math.Pow(HeatVoltValue, 2)) +
                                    (-2 * Math.Pow(10, -8) * Math.Pow(HeatVoltValue, 3)) +
                                    (8 * Math.Pow(10, -12) * Math.Pow(HeatVoltValue, 4)) +
                                    (-1 * Math.Pow(10, -15) * Math.Pow(HeatVoltValue, 5));
                    }
                    else
                    {
                        Temperature = (6 * Math.Pow(10, -9)) +
                                    (0.0099 * HeatVoltValue) +
                                    (2 * Math.Pow(10, -5) * Math.Pow(HeatVoltValue, 2)) +
                                    (-1 * Math.Pow(10, -8) * Math.Pow(HeatVoltValue, 3)) +
                                    (5 * Math.Pow(10, -12) * Math.Pow(HeatVoltValue, 4)) +
                                    (-8 * Math.Pow(10, -16) * Math.Pow(HeatVoltValue, 5));
                    }
                    break;

                case 5:     //typeR
                    if (HeatVoltValue <= 1874 * Math.Pow(10, -6))
                    {
                        Temperature = (1.849 * Math.Pow(10, -1) * HeatVoltValue) +
                                    (-8.005 * Math.Pow(10, -5) * Math.Pow(HeatVoltValue, 2)) +
                                    (1.022 * Math.Pow(10, -7) * Math.Pow(HeatVoltValue, 3)) +
                                    (-1.522 * Math.Pow(10, -10) * Math.Pow(HeatVoltValue, 4)) +
                                    (1.888 * Math.Pow(10, -13) * Math.Pow(HeatVoltValue, 5)) +
                                    (-1.591 * Math.Pow(10, -16) * Math.Pow(HeatVoltValue, 6)) +
                                    (8.230 * Math.Pow(10, -20) * Math.Pow(HeatVoltValue, 7)) +
                                    (-2.342 * Math.Pow(10, -23) * Math.Pow(HeatVoltValue, 8)) *
                                    (2.798 * Math.Pow(10, -27) * Math.Pow(HeatVoltValue, 9));
                    }
                    if (HeatVoltValue > 1874 * Math.Pow(10, -6) && HeatVoltValue <= 10332 * Math.Pow(10, -6))
                    {
                        Temperature = 12.92 +
                                    (1.466 * Math.Pow(10, -1) * HeatVoltValue) +
                                    (-1.535 * Math.Pow(10, -5) * Math.Pow(HeatVoltValue, 2)) +
                                    (3.146 * Math.Pow(10, -9) * Math.Pow(HeatVoltValue, 3)) +
                                    (-4.163 * Math.Pow(10, -13) * Math.Pow(HeatVoltValue, 4)) +
                                    (3.188 * Math.Pow(10, -17) * Math.Pow(HeatVoltValue, 5)) +
                                    (-1.292 * Math.Pow(10, -21) * Math.Pow(HeatVoltValue, 6)) +
                                    (2.183 * Math.Pow(10, -26) * Math.Pow(HeatVoltValue, 7)) +
                                    (-1.447 * Math.Pow(10, -31) * Math.Pow(HeatVoltValue, 8)) +
                                    (8.211 * Math.Pow(10, -36) * Math.Pow(HeatVoltValue, 9));
                    }
                    if (HeatVoltValue > 10332 * Math.Pow(10, -6) && HeatVoltValue <= 17536 * Math.Pow(10, -6))
                    {
                        Temperature = -80.88 +
                                    (1.622 * Math.Pow(10, -1) * HeatVoltValue) +
                                    (-8.537 * Math.Pow(10, -6) * Math.Pow(HeatVoltValue, 2)) +
                                    (4.720 * Math.Pow(10, -10) * Math.Pow(HeatVoltValue, 3)) +
                                    (-1.442 * Math.Pow(10, -14) * Math.Pow(HeatVoltValue, 4)) +
                                    (2.082 * Math.Pow(10, -19) * Math.Pow(HeatVoltValue, 5));
                    }
                    else
                    {
                        Temperature = (5.334 * Math.Pow(10, 4)) +
                                    (-1.236 * Math.Pow(10, 1) * HeatVoltValue) +
                                    (1.093 * Math.Pow(10, -3) * Math.Pow(HeatVoltValue, 2)) +
                                    (-4.266 * Math.Pow(10, -8) * Math.Pow(HeatVoltValue, 3)) +
                                    (6.247 * Math.Pow(10, -13) * Math.Pow(HeatVoltValue, 4));
                    }
                    break;
                default:
                    // デフォルトの処理（必要に応じて）
                    Temperature = 20; // 例として、デフォルトでは温度を 0 に設定
                    break;
            }
            return (ElectricPowerValue, SecondResistanceValue, Temperature);
        }
        private void HandleError(Exception ex)　//エラー処理
        {
            timer1.Stop();
            MessageBox.Show("各機器の接続状態を確認してください");
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
            // データを格納しているリストをクリア
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

        private void OnButton_Click(object sender, EventArgs e)
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

        private void OffButton_Click(object sender, EventArgs e)
        {
            using (var rmSession4 = new ResourceManager())   //変数の宣言
                mbSession4 = (MessageBasedSession)rmSession4.Open("GPIB0::4::INSTR");  //特定の機器への挨拶
            string VTCommand = "VA" + PresetVBox.Text;
            mbSession4.RawIO.Write("OT0");     //出力のWrite OFF
            mbSession4.Dispose();
            isOutput = false;       //出力のフラグ
            var (SecondVoltValue, SecondCurrValue, SecondElectricPower, HeatVoltValue, PrimV, PrimA, PrimR, PrimVA) = GetDataFromInstruments();  //機器との通信
            var (ElectricPowerValue, SecondResistanceValue, Temperature) = PerformCalculations(SecondVoltValue, SecondCurrValue, HeatVoltValue);    //電力抵抗温度の出力
            UpdateUI(SecondVoltValue, SecondCurrValue, HeatVoltValue, ElectricPowerValue, SecondResistanceValue, Temperature, PrimV, PrimA, PrimR, PrimVA);       //Chartへの出力シーケンス
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
                //TimeSpan elapsed = stopwatch.Elapsed;
                //string elapsedtime = elapsed.ToString(@"hh\:/mm:ss");
                //時間、測定モード
                string modetext = ModeBox.Text;
                string stopwatchtext = StopWatchlabel.Text;
                writer.WriteLine(modetext);
                writer.WriteLine(stopwatchtext);
                //writer.WriteLine(modetext, elapsedtime);
                // 列の名前を出力
                writer.WriteLine("2次電圧(V),2次電流(A),2次抵抗(Ω),2次電力(VA),温度(℃),1次電圧(V),1次電流(A),1次電力(VA)");
                //各列のデータ
                for (int i = 0; i < voltageValues.Count;  i++)
                {
                    writer.WriteLine($"{voltageValues[i]}, {currentValues[i]}, {resistanceValues[i]}, {electricPowerValues[i]}, {temperatureValues[i]}, {PrimVoltageValues[i]}, {PrimCurrentValues[i]}, {PrimelEctricPowerValues[i]}");
                }
            }
        }
        private void UpdateElapsedTime()        //測定時間としてForm上で表示させる用
        {
            TimeSpan elapsed = stopwatch.Elapsed;
            StopWatchlabel.Text = $"測定時間:{elapsed.ToString(@"hh\:mm\:ss")}";
        }

        private void RecordButton_Click(object sender, EventArgs e) //記録ボタン
        {
            if (!isRecording)
            {
                stopwatch.Start();
                ResetAndResumeMeasurement();        //データのリセット処理かつCSVにデータが入りだす

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

        //private void PIDControl(object sender, EventArgs e)
        //{
        //    // 定数設定 ===============
        //    KP = 20;  // Pゲイン
        //    KD = 5;   // Dゲイン
        //    KI = 1;   // Iゲイン
        //    T  = 0.01;// 制御周期[秒]

        //    // 変数初期化 ===============
        //    e_pre = 0; // 微分の近似計算のための初期値
        //    ie = 0;    // 積分の近似計算のための初期値

        //    // メインループ ===============
        //    while(1){
        //      // 制御周期分だけ待つ処理
        //      sleep(T);

        //    // 現時刻における情報を取得
        //    y = get_y(); // 出力を取得。例:センサー情報を読み取る処理
        //    r = get_r(); // 目標値を取得。目標値が一定ならその値を代入する

        //    // PID制御の式より、制御入力uを計算
        //    e  = r - y;                // 誤差を計算
        //    de = (e - e_pre)/T;        // 誤差の微分を近似計算
        //    ie = ie + (e + e_pre)*T/2; // 誤差の積分を近似計算
        //    u  = KP* e + KI* ie + KD* de; // PID制御の式にそれぞれを代入　u:操作量　 "VA" + u　これの変更
        //    // 制御入力をシステムに与える処理
        //    give_u(u); // 例:モーターに電流を流す処理
        //    mbSession4.RawIO.Write(VTCommand);     //出力の変更　give_u(u):の部分

        //    // 次のために現時刻の情報を記録
        //    e_pre = e;
        //    }
        //}
    }
}
//なぜかテキストボックス（周波数)をいじると、電圧出力がバグって反応しなくなる
//やること
//1次と2次の電圧電流比較
//全体を通じての周波数の変化の影響調査
//開発したアプリケーションをほかのPCでも起動できるのか。PATHなどもしくは.exeとして実装出来ないのか
//Uiの改善
//PID制御の導入　(目標温度を入力すると自動で、制御ができるもの）
