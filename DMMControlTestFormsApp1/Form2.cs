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
using System.Windows.Forms.DataVisualization.Charting;
using MathNet.Numerics;     //Math.Numericsをインストール下うえで、System.Numericsを参照に入れる
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DMMControlTestFormsApp1
{
    public partial class Form2 : Form
    {
        private System.Windows.Forms.DataVisualization.Charting.Series DirSeries1 = new System.Windows.Forms.DataVisualization.Charting.Series();
        private System.Windows.Forms.DataVisualization.Charting.Series FitSeries2 = new System.Windows.Forms.DataVisualization.Charting.Series();
        private double[] p; // p 係数をクラスレベルで定義
        private double[] yfit;
        private string polynomialTeX;
        private bool Fitting = false;

        public Form2()
        {
            InitializeComponent();
            InitializeChart();
            PerformFitting();
        }
        public void InitializeChart()
        {
            // 初期化
            Fittingchart.Series.Clear();
            Fittingchart.Titles.Clear();
            Fittingchart.Legends.Clear();
            // チャートエリアの追加を確認し、なければ追加
            if (Fittingchart.ChartAreas.Count == 0)
            {
                Fittingchart.ChartAreas.Add(new ChartArea());
            }

            DirSeries1.ChartType = SeriesChartType.Point;
            DirSeries1.BorderWidth = 1;
            DirSeries1.LegendText = "熱電対データ";
            Fittingchart.Series.Add(DirSeries1);

            FitSeries2.ChartType = SeriesChartType.Line;
            FitSeries2.BorderWidth = 2;
            FitSeries2.LegendText = "フィッティング";
            Fittingchart.Series.Add(FitSeries2);

            Axis axisX = new Axis();
            axisX.Title = "電力(VA)";
            axisX.Interval = 1;
            Fittingchart.ChartAreas[0].AxisX = axisX;

            Axis axisY = new Axis();
            axisY.Title = "温度(℃)";
            axisY.Interval = 1;
            Fittingchart.ChartAreas[0].AxisY = axisY;
        }
        public void PerformFitting()
        {
            string filePath = GetFilePath(); // ファイルパスを取得するメソッド
            List<double> d_EP_List = new List<double>();    //データの電圧のリスト
            List<double> d_Temp_List = new List<double>();     //データの温度のリスト

            // CSVファイルの読み込み
            try
            {
                string line;
                int lineNumber = 0;

                using (StreamReader sr = new StreamReader(filePath))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        lineNumber++;

                        // 1~5行目を無視
                        if (lineNumber <= 5)
                        {
                            continue;
                        }

                        var columns = line.Split(',');

                        // 5列目のデータをリストに追加
                        if (columns.Length >= 5 && double.TryParse(columns[4], out double col4Value))
                        {
                            d_EP_List.Add(col4Value);
                        }

                        // 6列目のデータをリストに追加
                        if (columns.Length >= 6 && double.TryParse(columns[5], out double col5Value))
                        {
                            d_Temp_List.Add(col5Value);
                        }
                    }
                    //// 最初の3行を読み飛ばす i<3
                    //for (int i = 0; i < 3; i++)
                    //{
                    //    sr.ReadLine();
                    //}
                    //// 末尾まで繰り返す
                    //while (!sr.EndOfStream)
                    //{
                    //    // CSVファイルの一行を読み込む
                    //    string line = sr.ReadLine();
                    //    // 読み込んだ一行をカンマ毎に分けて配列に格納する
                    //    string[] values = line.Split(',');

                    //    // 1つ目の要素を1レーンのリストに追加
                    //    d_EP_List.Add(double.Parse(values[0]));
                    //    // 2つ目の要素を2レーンのリストに追加
                    //    d_Temp_List.Add(double.Parse(values[1]));
                    //}
                }

                // フィッティング
                p = Fit.Polynomial(d_EP_List.ToArray(), d_Temp_List.ToArray(), 3); //(フィッティングするｘ、ｙ, 近似次数)

                // フィッティング結果の表示
                double[] xfit = Generate.LinearSpaced(10, 0, 20); //(分割数, ｘの最低, xの上限）
                yfit = Array.ConvertAll(xfit, xtemp => Polynomial.Evaluate(xtemp, p)); //電力から温度を決めるFitting関数

                for (int i = 0; i < d_EP_List.Count; i++)
                {
                    DirSeries1.Points.AddXY(d_EP_List[i], d_Temp_List[i]);
                }

                for (int i = 0; i < xfit.Length; i++)
                {
                    FitSeries2.Points.AddXY(xfit[i], yfit[i]);
                }

                string polynomialTeX = ToTeXPolynomial(p);
                // テキストボックスに多項式を表示
                FfunctionTextBox.Text = ToTeXPolynomial(p);
            }
            catch (Exception ex)
            {
                // 例外処理
                MessageBox.Show("エラーが発生しました: " + ex.Message);
            }
        }
        private string ToTeXPolynomial(double[] coefficients) //テキストボックスに関数を表示させるもの
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
        private string GetFilePath()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "\"C:\\Users\\deg12\\C#Experience\\ThermoCouple\\test1.csv\"";
            openFileDialog.Filter = "CSVファイル (*.csv)|*.csv|すべてのファイル (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            string filePath = "";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
            }

            return filePath;
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            // Form1 に yfit の式を送信
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            form1?.ReceivePolynomial(p);    //Form1に送る処理　ｐを送る
            //this.Close();
        }
    }


}
