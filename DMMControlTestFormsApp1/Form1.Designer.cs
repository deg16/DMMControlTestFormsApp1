namespace DMMControlTestFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.OnButton = new System.Windows.Forms.Button();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart5 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ModeSelectMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ThermoCoupleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TypeKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TypeBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TypeDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TypeRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ElectricPowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FittingCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.FittingEPCSVToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.PresetVBox = new System.Windows.Forms.TextBox();
            this.TargetVoltage = new System.Windows.Forms.Label();
            this.SourceCurrent = new System.Windows.Forms.Label();
            this.SourceVoltage = new System.Windows.Forms.Label();
            this.ApparentRegistance = new System.Windows.Forms.Label();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.SourceEPower = new System.Windows.Forms.Label();
            this.ElectroMotiveForce = new System.Windows.Forms.Label();
            this.PresetTemperature = new System.Windows.Forms.Label();
            this.Kelvin = new System.Windows.Forms.Label();
            this.PresetVoltage = new System.Windows.Forms.Label();
            this.PresetEPower = new System.Windows.Forms.Label();
            this.UpperEPower = new System.Windows.Forms.Label();
            this.HeatVBox = new System.Windows.Forms.TextBox();
            this.TemperatureBox = new System.Windows.Forms.TextBox();
            this.TargetTBox = new System.Windows.Forms.TextBox();
            this.KelvinBox = new System.Windows.Forms.TextBox();
            this.SourceVBox = new System.Windows.Forms.TextBox();
            this.SourceABox = new System.Windows.Forms.TextBox();
            this.SecondRBox = new System.Windows.Forms.TextBox();
            this.TargetVBox = new System.Windows.Forms.TextBox();
            this.SourceEPBox = new System.Windows.Forms.TextBox();
            this.PresetEPBox = new System.Windows.Forms.TextBox();
            this.UpperEPBox = new System.Windows.Forms.TextBox();
            this.ModeBox = new System.Windows.Forms.TextBox();
            this.OffButton = new System.Windows.Forms.Button();
            this.StopWatchlabel = new System.Windows.Forms.Label();
            this.RecordButton = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.FunctionTextBox = new System.Windows.Forms.TextBox();
            this.SecondVBox = new System.Windows.Forms.TextBox();
            this.SecondVoltLabel = new System.Windows.Forms.Label();
            this.SecondABox = new System.Windows.Forms.TextBox();
            this.SecondCurrLabel = new System.Windows.Forms.Label();
            this.PresetVdUp = new System.Windows.Forms.Button();
            this.PresetVdDown = new System.Windows.Forms.Button();
            this.Igain = new System.Windows.Forms.Label();
            this.Dgain = new System.Windows.Forms.Label();
            this.frequency = new System.Windows.Forms.Label();
            this.IgainBox = new System.Windows.Forms.TextBox();
            this.DgainBox = new System.Windows.Forms.TextBox();
            this.FrequencyBox = new System.Windows.Forms.TextBox();
            this.PgainBox = new System.Windows.Forms.TextBox();
            this.Pgain = new System.Windows.Forms.Label();
            this.PresetViDown = new System.Windows.Forms.Button();
            this.PresetViup = new System.Windows.Forms.Button();
            this.PresetVSet = new System.Windows.Forms.Button();
            this.T0Box = new System.Windows.Forms.TextBox();
            this.SecondVABox = new System.Windows.Forms.TextBox();
            this.SecondVA = new System.Windows.Forms.Label();
            this.PrimRBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FrequencySet = new System.Windows.Forms.Button();
            this.SaveSpanBox = new System.Windows.Forms.TextBox();
            this.SaveSpanUp = new System.Windows.Forms.Button();
            this.SaveSpanDown = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PgainDownButton = new System.Windows.Forms.Button();
            this.PgainUpButton = new System.Windows.Forms.Button();
            this.DgainDownButon = new System.Windows.Forms.Button();
            this.DgainUpButton = new System.Windows.Forms.Button();
            this.IgainDownButton = new System.Windows.Forms.Button();
            this.IgainUpButton = new System.Windows.Forms.Button();
            this.PgainSetButton = new System.Windows.Forms.Button();
            this.DgainSetButton = new System.Windows.Forms.Button();
            this.IgainSetButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PIDtimer = new System.Windows.Forms.Timer(this.components);
            this.PIDButton = new System.Windows.Forms.Button();
            this.TargetTSetButton = new System.Windows.Forms.Button();
            this.PIDConditionText = new System.Windows.Forms.TextBox();
            this.PIDSpanBox = new System.Windows.Forms.TextBox();
            this.PIDSpanSetButton = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.GroupBox();
            this.PID = new System.Windows.Forms.GroupBox();
            this.Setting = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.Status.SuspendLayout();
            this.PID.SuspendLayout();
            this.Setting.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(1029, 35);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(566, 177);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "電源電圧(V)";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Location = new System.Drawing.Point(1029, 218);
            this.chart2.Margin = new System.Windows.Forms.Padding(4);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(566, 177);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "電源電流(A)";
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            this.chart3.Location = new System.Drawing.Point(1029, 398);
            this.chart3.Margin = new System.Windows.Forms.Padding(4);
            this.chart3.Name = "chart3";
            this.chart3.Size = new System.Drawing.Size(566, 177);
            this.chart3.TabIndex = 2;
            this.chart3.Text = "抵抗(Ω)";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OnButton
            // 
            this.OnButton.BackColor = System.Drawing.Color.Lime;
            this.OnButton.Font = new System.Drawing.Font("游ゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OnButton.Location = new System.Drawing.Point(380, 854);
            this.OnButton.Margin = new System.Windows.Forms.Padding(4);
            this.OnButton.Name = "OnButton";
            this.OnButton.Size = new System.Drawing.Size(154, 80);
            this.OnButton.TabIndex = 3;
            this.OnButton.Text = "出力";
            this.OnButton.UseVisualStyleBackColor = false;
            this.OnButton.Click += new System.EventHandler(this.OnButton_Click);
            // 
            // chart4
            // 
            chartArea4.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea4);
            this.chart4.Location = new System.Drawing.Point(1029, 581);
            this.chart4.Margin = new System.Windows.Forms.Padding(4);
            this.chart4.Name = "chart4";
            this.chart4.Size = new System.Drawing.Size(566, 177);
            this.chart4.TabIndex = 4;
            this.chart4.Text = "電力(VA)";
            // 
            // chart5
            // 
            chartArea5.Name = "ChartArea1";
            this.chart5.ChartAreas.Add(chartArea5);
            this.chart5.Location = new System.Drawing.Point(1029, 765);
            this.chart5.Margin = new System.Windows.Forms.Padding(4);
            this.chart5.Name = "chart5";
            this.chart5.Size = new System.Drawing.Size(566, 177);
            this.chart5.TabIndex = 5;
            this.chart5.Text = "温度(℃)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModeSelectMenu,
            this.FittingCSV});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1735, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ModeSelectMenu
            // 
            this.ModeSelectMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThermoCoupleToolStripMenuItem,
            this.ElectricPowerToolStripMenuItem});
            this.ModeSelectMenu.Name = "ModeSelectMenu";
            this.ModeSelectMenu.Size = new System.Drawing.Size(62, 24);
            this.ModeSelectMenu.Text = "Mode";
            // 
            // ThermoCoupleToolStripMenuItem
            // 
            this.ThermoCoupleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TypeKToolStripMenuItem,
            this.TypeBToolStripMenuItem,
            this.TypeDToolStripMenuItem,
            this.TypeRToolStripMenuItem});
            this.ThermoCoupleToolStripMenuItem.Name = "ThermoCoupleToolStripMenuItem";
            this.ThermoCoupleToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.ThermoCoupleToolStripMenuItem.Text = "熱電対モード";
            // 
            // TypeKToolStripMenuItem
            // 
            this.TypeKToolStripMenuItem.Name = "TypeKToolStripMenuItem";
            this.TypeKToolStripMenuItem.Size = new System.Drawing.Size(332, 26);
            this.TypeKToolStripMenuItem.Text = "K（クロメルーアルメル）";
            this.TypeKToolStripMenuItem.Click += new System.EventHandler(this.TypeKToolStripMenuItem_Click);
            // 
            // TypeBToolStripMenuItem
            // 
            this.TypeBToolStripMenuItem.Name = "TypeBToolStripMenuItem";
            this.TypeBToolStripMenuItem.Size = new System.Drawing.Size(332, 26);
            this.TypeBToolStripMenuItem.Text = "B  (白金30％ロジウムー白金6％ロジウム)";
            this.TypeBToolStripMenuItem.Click += new System.EventHandler(this.TypeBToolStripMenuItem_Click);
            // 
            // TypeDToolStripMenuItem
            // 
            this.TypeDToolStripMenuItem.Name = "TypeDToolStripMenuItem";
            this.TypeDToolStripMenuItem.Size = new System.Drawing.Size(332, 26);
            this.TypeDToolStripMenuItem.Text = "D (W3%Re-W25%Re)";
            this.TypeDToolStripMenuItem.Click += new System.EventHandler(this.TypeDToolStripMenuItem_Click);
            // 
            // TypeRToolStripMenuItem
            // 
            this.TypeRToolStripMenuItem.Name = "TypeRToolStripMenuItem";
            this.TypeRToolStripMenuItem.Size = new System.Drawing.Size(332, 26);
            this.TypeRToolStripMenuItem.Text = "R (白金－白金ロジウム)";
            this.TypeRToolStripMenuItem.Click += new System.EventHandler(this.TypeRToolStripMenuItem_Click);
            // 
            // ElectricPowerToolStripMenuItem
            // 
            this.ElectricPowerToolStripMenuItem.Name = "ElectricPowerToolStripMenuItem";
            this.ElectricPowerToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.ElectricPowerToolStripMenuItem.Text = "パワーモード";
            this.ElectricPowerToolStripMenuItem.Click += new System.EventHandler(this.ElectricPowerToolStripMenuItem_Click);
            // 
            // FittingCSV
            // 
            this.FittingCSV.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FittingEPCSVToolStrip});
            this.FittingCSV.Name = "FittingCSV";
            this.FittingCSV.Size = new System.Drawing.Size(46, 24);
            this.FittingCSV.Text = "File";
            // 
            // FittingEPCSVToolStrip
            // 
            this.FittingEPCSVToolStrip.Name = "FittingEPCSVToolStrip";
            this.FittingEPCSVToolStrip.Size = new System.Drawing.Size(229, 26);
            this.FittingEPCSVToolStrip.Text = "電力制御Fitting(CSV)";
            this.FittingEPCSVToolStrip.Click += new System.EventHandler(this.FittingEPCSVToolStrip_Click);
            // 
            // PresetVBox
            // 
            this.PresetVBox.BackColor = System.Drawing.SystemColors.Info;
            this.PresetVBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PresetVBox.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PresetVBox.Location = new System.Drawing.Point(40, 887);
            this.PresetVBox.Margin = new System.Windows.Forms.Padding(4);
            this.PresetVBox.Multiline = true;
            this.PresetVBox.Name = "PresetVBox";
            this.PresetVBox.ShortcutsEnabled = false;
            this.PresetVBox.Size = new System.Drawing.Size(159, 41);
            this.PresetVBox.TabIndex = 15;
            this.PresetVBox.Text = "0";
            // 
            // TargetVoltage
            // 
            this.TargetVoltage.Font = new System.Drawing.Font("游ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TargetVoltage.Location = new System.Drawing.Point(30, 253);
            this.TargetVoltage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TargetVoltage.Name = "TargetVoltage";
            this.TargetVoltage.Size = new System.Drawing.Size(171, 31);
            this.TargetVoltage.TabIndex = 16;
            this.TargetVoltage.Text = "目標電圧(V)";
            // 
            // SourceCurrent
            // 
            this.SourceCurrent.Font = new System.Drawing.Font("游ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SourceCurrent.Location = new System.Drawing.Point(17, 85);
            this.SourceCurrent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SourceCurrent.Name = "SourceCurrent";
            this.SourceCurrent.Size = new System.Drawing.Size(186, 31);
            this.SourceCurrent.TabIndex = 17;
            this.SourceCurrent.Text = "1次電流(A)";
            // 
            // SourceVoltage
            // 
            this.SourceVoltage.Font = new System.Drawing.Font("游ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SourceVoltage.Location = new System.Drawing.Point(17, 37);
            this.SourceVoltage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SourceVoltage.Name = "SourceVoltage";
            this.SourceVoltage.Size = new System.Drawing.Size(186, 31);
            this.SourceVoltage.TabIndex = 18;
            this.SourceVoltage.Text = "1次電圧(V)";
            // 
            // ApparentRegistance
            // 
            this.ApparentRegistance.Font = new System.Drawing.Font("游ゴシック", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ApparentRegistance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ApparentRegistance.Location = new System.Drawing.Point(17, 340);
            this.ApparentRegistance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ApparentRegistance.Name = "ApparentRegistance";
            this.ApparentRegistance.Size = new System.Drawing.Size(199, 31);
            this.ApparentRegistance.TabIndex = 19;
            this.ApparentRegistance.Text = "2次抵抗(Ω)";
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.Font = new System.Drawing.Font("游ゴシック", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TemperatureLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.TemperatureLabel.Location = new System.Drawing.Point(17, 503);
            this.TemperatureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(186, 31);
            this.TemperatureLabel.TabIndex = 20;
            this.TemperatureLabel.Text = "温度(℃)";
            // 
            // SourceEPower
            // 
            this.SourceEPower.Font = new System.Drawing.Font("游ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SourceEPower.Location = new System.Drawing.Point(17, 182);
            this.SourceEPower.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SourceEPower.Name = "SourceEPower";
            this.SourceEPower.Size = new System.Drawing.Size(186, 31);
            this.SourceEPower.TabIndex = 21;
            this.SourceEPower.Text = "1次電力(VA)";
            // 
            // ElectroMotiveForce
            // 
            this.ElectroMotiveForce.Font = new System.Drawing.Font("游ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ElectroMotiveForce.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ElectroMotiveForce.Location = new System.Drawing.Point(17, 457);
            this.ElectroMotiveForce.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ElectroMotiveForce.Name = "ElectroMotiveForce";
            this.ElectroMotiveForce.Size = new System.Drawing.Size(186, 31);
            this.ElectroMotiveForce.TabIndex = 23;
            this.ElectroMotiveForce.Text = "起電力(mV)";
            this.ElectroMotiveForce.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PresetTemperature
            // 
            this.PresetTemperature.Font = new System.Drawing.Font("游ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PresetTemperature.Location = new System.Drawing.Point(30, 46);
            this.PresetTemperature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PresetTemperature.Name = "PresetTemperature";
            this.PresetTemperature.Size = new System.Drawing.Size(171, 31);
            this.PresetTemperature.TabIndex = 24;
            this.PresetTemperature.Text = "設定温度(℃)";
            // 
            // Kelvin
            // 
            this.Kelvin.Font = new System.Drawing.Font("游ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Kelvin.Location = new System.Drawing.Point(17, 552);
            this.Kelvin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Kelvin.Name = "Kelvin";
            this.Kelvin.Size = new System.Drawing.Size(186, 31);
            this.Kelvin.TabIndex = 25;
            this.Kelvin.Text = "絶対温度(K)";
            // 
            // PresetVoltage
            // 
            this.PresetVoltage.Font = new System.Drawing.Font("游ゴシック", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PresetVoltage.Location = new System.Drawing.Point(41, 858);
            this.PresetVoltage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PresetVoltage.Name = "PresetVoltage";
            this.PresetVoltage.Size = new System.Drawing.Size(133, 25);
            this.PresetVoltage.TabIndex = 26;
            this.PresetVoltage.Text = "設定電圧(V)";
            // 
            // PresetEPower
            // 
            this.PresetEPower.Font = new System.Drawing.Font("游ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PresetEPower.Location = new System.Drawing.Point(30, 302);
            this.PresetEPower.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PresetEPower.Name = "PresetEPower";
            this.PresetEPower.Size = new System.Drawing.Size(185, 31);
            this.PresetEPower.TabIndex = 27;
            this.PresetEPower.Text = "設定電力(VA)";
            // 
            // UpperEPower
            // 
            this.UpperEPower.Font = new System.Drawing.Font("游ゴシック", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.UpperEPower.Location = new System.Drawing.Point(89, 58);
            this.UpperEPower.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpperEPower.Name = "UpperEPower";
            this.UpperEPower.Size = new System.Drawing.Size(126, 25);
            this.UpperEPower.TabIndex = 28;
            this.UpperEPower.Text = "電力上限(VA)";
            // 
            // HeatVBox
            // 
            this.HeatVBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.HeatVBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HeatVBox.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HeatVBox.Location = new System.Drawing.Point(224, 454);
            this.HeatVBox.Margin = new System.Windows.Forms.Padding(4);
            this.HeatVBox.Multiline = true;
            this.HeatVBox.Name = "HeatVBox";
            this.HeatVBox.ShortcutsEnabled = false;
            this.HeatVBox.Size = new System.Drawing.Size(159, 41);
            this.HeatVBox.TabIndex = 29;
            // 
            // TemperatureBox
            // 
            this.TemperatureBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TemperatureBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TemperatureBox.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TemperatureBox.ForeColor = System.Drawing.Color.IndianRed;
            this.TemperatureBox.Location = new System.Drawing.Point(224, 503);
            this.TemperatureBox.Margin = new System.Windows.Forms.Padding(4);
            this.TemperatureBox.Multiline = true;
            this.TemperatureBox.Name = "TemperatureBox";
            this.TemperatureBox.ShortcutsEnabled = false;
            this.TemperatureBox.Size = new System.Drawing.Size(159, 41);
            this.TemperatureBox.TabIndex = 30;
            // 
            // TargetTBox
            // 
            this.TargetTBox.BackColor = System.Drawing.SystemColors.Info;
            this.TargetTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TargetTBox.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TargetTBox.Location = new System.Drawing.Point(237, 36);
            this.TargetTBox.Margin = new System.Windows.Forms.Padding(4);
            this.TargetTBox.Multiline = true;
            this.TargetTBox.Name = "TargetTBox";
            this.TargetTBox.ShortcutsEnabled = false;
            this.TargetTBox.Size = new System.Drawing.Size(159, 41);
            this.TargetTBox.TabIndex = 31;
            // 
            // KelvinBox
            // 
            this.KelvinBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.KelvinBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.KelvinBox.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.KelvinBox.Location = new System.Drawing.Point(224, 552);
            this.KelvinBox.Margin = new System.Windows.Forms.Padding(4);
            this.KelvinBox.Multiline = true;
            this.KelvinBox.Name = "KelvinBox";
            this.KelvinBox.ShortcutsEnabled = false;
            this.KelvinBox.Size = new System.Drawing.Size(159, 41);
            this.KelvinBox.TabIndex = 32;
            // 
            // SourceVBox
            // 
            this.SourceVBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.SourceVBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SourceVBox.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SourceVBox.Location = new System.Drawing.Point(224, 36);
            this.SourceVBox.Margin = new System.Windows.Forms.Padding(4);
            this.SourceVBox.Multiline = true;
            this.SourceVBox.Name = "SourceVBox";
            this.SourceVBox.ShortcutsEnabled = false;
            this.SourceVBox.Size = new System.Drawing.Size(159, 41);
            this.SourceVBox.TabIndex = 33;
            // 
            // SourceABox
            // 
            this.SourceABox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.SourceABox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SourceABox.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SourceABox.Location = new System.Drawing.Point(224, 85);
            this.SourceABox.Margin = new System.Windows.Forms.Padding(4);
            this.SourceABox.Multiline = true;
            this.SourceABox.Name = "SourceABox";
            this.SourceABox.ShortcutsEnabled = false;
            this.SourceABox.Size = new System.Drawing.Size(159, 41);
            this.SourceABox.TabIndex = 34;
            // 
            // SecondRBox
            // 
            this.SecondRBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.SecondRBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SecondRBox.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SecondRBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.SecondRBox.Location = new System.Drawing.Point(224, 340);
            this.SecondRBox.Margin = new System.Windows.Forms.Padding(4);
            this.SecondRBox.Multiline = true;
            this.SecondRBox.Name = "SecondRBox";
            this.SecondRBox.ShortcutsEnabled = false;
            this.SecondRBox.Size = new System.Drawing.Size(159, 41);
            this.SecondRBox.TabIndex = 35;
            // 
            // TargetVBox
            // 
            this.TargetVBox.Location = new System.Drawing.Point(237, 246);
            this.TargetVBox.Margin = new System.Windows.Forms.Padding(4);
            this.TargetVBox.Multiline = true;
            this.TargetVBox.Name = "TargetVBox";
            this.TargetVBox.Size = new System.Drawing.Size(159, 41);
            this.TargetVBox.TabIndex = 36;
            // 
            // SourceEPBox
            // 
            this.SourceEPBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.SourceEPBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SourceEPBox.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SourceEPBox.Location = new System.Drawing.Point(224, 183);
            this.SourceEPBox.Margin = new System.Windows.Forms.Padding(4);
            this.SourceEPBox.Multiline = true;
            this.SourceEPBox.Name = "SourceEPBox";
            this.SourceEPBox.ShortcutsEnabled = false;
            this.SourceEPBox.Size = new System.Drawing.Size(159, 41);
            this.SourceEPBox.TabIndex = 37;
            // 
            // PresetEPBox
            // 
            this.PresetEPBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PresetEPBox.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PresetEPBox.Location = new System.Drawing.Point(237, 295);
            this.PresetEPBox.Margin = new System.Windows.Forms.Padding(4);
            this.PresetEPBox.Multiline = true;
            this.PresetEPBox.Name = "PresetEPBox";
            this.PresetEPBox.ShortcutsEnabled = false;
            this.PresetEPBox.Size = new System.Drawing.Size(159, 41);
            this.PresetEPBox.TabIndex = 38;
            // 
            // UpperEPBox
            // 
            this.UpperEPBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UpperEPBox.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.UpperEPBox.Location = new System.Drawing.Point(245, 58);
            this.UpperEPBox.Margin = new System.Windows.Forms.Padding(4);
            this.UpperEPBox.Multiline = true;
            this.UpperEPBox.Name = "UpperEPBox";
            this.UpperEPBox.ShortcutsEnabled = false;
            this.UpperEPBox.Size = new System.Drawing.Size(71, 25);
            this.UpperEPBox.TabIndex = 39;
            // 
            // ModeBox
            // 
            this.ModeBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeBox.Location = new System.Drawing.Point(145, 44);
            this.ModeBox.Margin = new System.Windows.Forms.Padding(4);
            this.ModeBox.Multiline = true;
            this.ModeBox.Name = "ModeBox";
            this.ModeBox.ReadOnly = true;
            this.ModeBox.Size = new System.Drawing.Size(271, 50);
            this.ModeBox.TabIndex = 40;
            this.ModeBox.Text = "Mode";
            this.ModeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OffButton
            // 
            this.OffButton.BackColor = System.Drawing.Color.White;
            this.OffButton.Font = new System.Drawing.Font("游ゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OffButton.Location = new System.Drawing.Point(542, 854);
            this.OffButton.Margin = new System.Windows.Forms.Padding(4);
            this.OffButton.Name = "OffButton";
            this.OffButton.Size = new System.Drawing.Size(154, 80);
            this.OffButton.TabIndex = 41;
            this.OffButton.Text = "停止中";
            this.OffButton.UseVisualStyleBackColor = false;
            this.OffButton.Click += new System.EventHandler(this.OffButton_Click);
            // 
            // StopWatchlabel
            // 
            this.StopWatchlabel.AutoSize = true;
            this.StopWatchlabel.Font = new System.Drawing.Font("游ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StopWatchlabel.Location = new System.Drawing.Point(17, 616);
            this.StopWatchlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StopWatchlabel.Name = "StopWatchlabel";
            this.StopWatchlabel.Size = new System.Drawing.Size(243, 34);
            this.StopWatchlabel.TabIndex = 42;
            this.StopWatchlabel.Text = "測定時間　00:00:00";
            // 
            // RecordButton
            // 
            this.RecordButton.BackColor = System.Drawing.Color.White;
            this.RecordButton.Font = new System.Drawing.Font("游ゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RecordButton.Location = new System.Drawing.Point(851, 854);
            this.RecordButton.Margin = new System.Windows.Forms.Padding(4);
            this.RecordButton.Name = "RecordButton";
            this.RecordButton.Size = new System.Drawing.Size(154, 80);
            this.RecordButton.TabIndex = 43;
            this.RecordButton.Text = "測定";
            this.RecordButton.UseVisualStyleBackColor = false;
            this.RecordButton.Click += new System.EventHandler(this.RecordButton_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // FunctionTextBox
            // 
            this.FunctionTextBox.Location = new System.Drawing.Point(451, 44);
            this.FunctionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FunctionTextBox.Multiline = true;
            this.FunctionTextBox.Name = "FunctionTextBox";
            this.FunctionTextBox.Size = new System.Drawing.Size(369, 50);
            this.FunctionTextBox.TabIndex = 44;
            // 
            // SecondVBox
            // 
            this.SecondVBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.SecondVBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SecondVBox.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SecondVBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.SecondVBox.Location = new System.Drawing.Point(224, 242);
            this.SecondVBox.Margin = new System.Windows.Forms.Padding(4);
            this.SecondVBox.Multiline = true;
            this.SecondVBox.Name = "SecondVBox";
            this.SecondVBox.ShortcutsEnabled = false;
            this.SecondVBox.Size = new System.Drawing.Size(159, 41);
            this.SecondVBox.TabIndex = 46;
            // 
            // SecondVoltLabel
            // 
            this.SecondVoltLabel.Font = new System.Drawing.Font("游ゴシック", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SecondVoltLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.SecondVoltLabel.Location = new System.Drawing.Point(17, 242);
            this.SecondVoltLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SecondVoltLabel.Name = "SecondVoltLabel";
            this.SecondVoltLabel.Size = new System.Drawing.Size(186, 31);
            this.SecondVoltLabel.TabIndex = 45;
            this.SecondVoltLabel.Text = "2次電圧(V)";
            // 
            // SecondABox
            // 
            this.SecondABox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.SecondABox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SecondABox.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SecondABox.ForeColor = System.Drawing.Color.SeaGreen;
            this.SecondABox.Location = new System.Drawing.Point(224, 291);
            this.SecondABox.Margin = new System.Windows.Forms.Padding(4);
            this.SecondABox.Multiline = true;
            this.SecondABox.Name = "SecondABox";
            this.SecondABox.ShortcutsEnabled = false;
            this.SecondABox.Size = new System.Drawing.Size(159, 41);
            this.SecondABox.TabIndex = 48;
            // 
            // SecondCurrLabel
            // 
            this.SecondCurrLabel.Font = new System.Drawing.Font("游ゴシック", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SecondCurrLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.SecondCurrLabel.Location = new System.Drawing.Point(17, 291);
            this.SecondCurrLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SecondCurrLabel.Name = "SecondCurrLabel";
            this.SecondCurrLabel.Size = new System.Drawing.Size(186, 31);
            this.SecondCurrLabel.TabIndex = 47;
            this.SecondCurrLabel.Text = "2次電流(A)";
            // 
            // PresetVdUp
            // 
            this.PresetVdUp.Location = new System.Drawing.Point(207, 868);
            this.PresetVdUp.Margin = new System.Windows.Forms.Padding(4);
            this.PresetVdUp.Name = "PresetVdUp";
            this.PresetVdUp.Size = new System.Drawing.Size(48, 30);
            this.PresetVdUp.TabIndex = 49;
            this.PresetVdUp.Text = "+0.1";
            this.PresetVdUp.UseVisualStyleBackColor = true;
            this.PresetVdUp.Click += new System.EventHandler(this.PresetVdUp_Click);
            // 
            // PresetVdDown
            // 
            this.PresetVdDown.Location = new System.Drawing.Point(207, 897);
            this.PresetVdDown.Margin = new System.Windows.Forms.Padding(4);
            this.PresetVdDown.Name = "PresetVdDown";
            this.PresetVdDown.Size = new System.Drawing.Size(48, 30);
            this.PresetVdDown.TabIndex = 50;
            this.PresetVdDown.Text = "-0.1";
            this.PresetVdDown.UseVisualStyleBackColor = true;
            this.PresetVdDown.Click += new System.EventHandler(this.PresetVdDown_Click);
            // 
            // Igain
            // 
            this.Igain.Font = new System.Drawing.Font("游ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Igain.Location = new System.Drawing.Point(30, 192);
            this.Igain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Igain.Name = "Igain";
            this.Igain.Size = new System.Drawing.Size(87, 31);
            this.Igain.TabIndex = 51;
            this.Igain.Text = "Igain";
            // 
            // Dgain
            // 
            this.Dgain.Font = new System.Drawing.Font("游ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Dgain.Location = new System.Drawing.Point(30, 138);
            this.Dgain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dgain.Name = "Dgain";
            this.Dgain.Size = new System.Drawing.Size(87, 31);
            this.Dgain.TabIndex = 52;
            this.Dgain.Text = "Dgain";
            // 
            // frequency
            // 
            this.frequency.Font = new System.Drawing.Font("游ゴシック", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.frequency.Location = new System.Drawing.Point(89, 93);
            this.frequency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.frequency.Name = "frequency";
            this.frequency.Size = new System.Drawing.Size(126, 25);
            this.frequency.TabIndex = 53;
            this.frequency.Text = "周波数（㎐）";
            // 
            // IgainBox
            // 
            this.IgainBox.BackColor = System.Drawing.SystemColors.Info;
            this.IgainBox.Font = new System.Drawing.Font("MS UI Gothic", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.IgainBox.Location = new System.Drawing.Point(237, 192);
            this.IgainBox.Margin = new System.Windows.Forms.Padding(4);
            this.IgainBox.Multiline = true;
            this.IgainBox.Name = "IgainBox";
            this.IgainBox.Size = new System.Drawing.Size(159, 41);
            this.IgainBox.TabIndex = 54;
            this.IgainBox.Text = "0.03";
            // 
            // DgainBox
            // 
            this.DgainBox.BackColor = System.Drawing.SystemColors.Info;
            this.DgainBox.Font = new System.Drawing.Font("MS UI Gothic", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DgainBox.Location = new System.Drawing.Point(237, 143);
            this.DgainBox.Margin = new System.Windows.Forms.Padding(4);
            this.DgainBox.Multiline = true;
            this.DgainBox.Name = "DgainBox";
            this.DgainBox.Size = new System.Drawing.Size(159, 41);
            this.DgainBox.TabIndex = 55;
            this.DgainBox.Text = "0.04";
            // 
            // FrequencyBox
            // 
            this.FrequencyBox.Location = new System.Drawing.Point(245, 93);
            this.FrequencyBox.Margin = new System.Windows.Forms.Padding(4);
            this.FrequencyBox.Multiline = true;
            this.FrequencyBox.Name = "FrequencyBox";
            this.FrequencyBox.Size = new System.Drawing.Size(71, 25);
            this.FrequencyBox.TabIndex = 56;
            // 
            // PgainBox
            // 
            this.PgainBox.BackColor = System.Drawing.SystemColors.Info;
            this.PgainBox.Font = new System.Drawing.Font("MS UI Gothic", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PgainBox.Location = new System.Drawing.Point(237, 89);
            this.PgainBox.Margin = new System.Windows.Forms.Padding(4);
            this.PgainBox.Multiline = true;
            this.PgainBox.Name = "PgainBox";
            this.PgainBox.Size = new System.Drawing.Size(159, 41);
            this.PgainBox.TabIndex = 58;
            this.PgainBox.Text = "0.8";
            // 
            // Pgain
            // 
            this.Pgain.Font = new System.Drawing.Font("游ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Pgain.Location = new System.Drawing.Point(30, 89);
            this.Pgain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pgain.Name = "Pgain";
            this.Pgain.Size = new System.Drawing.Size(87, 31);
            this.Pgain.TabIndex = 57;
            this.Pgain.Text = "Pgain";
            // 
            // PresetViDown
            // 
            this.PresetViDown.Location = new System.Drawing.Point(263, 897);
            this.PresetViDown.Margin = new System.Windows.Forms.Padding(4);
            this.PresetViDown.Name = "PresetViDown";
            this.PresetViDown.Size = new System.Drawing.Size(48, 30);
            this.PresetViDown.TabIndex = 60;
            this.PresetViDown.Text = "-1.0";
            this.PresetViDown.UseVisualStyleBackColor = true;
            this.PresetViDown.Click += new System.EventHandler(this.PresetViDown_Click);
            // 
            // PresetViup
            // 
            this.PresetViup.Location = new System.Drawing.Point(263, 868);
            this.PresetViup.Margin = new System.Windows.Forms.Padding(4);
            this.PresetViup.Name = "PresetViup";
            this.PresetViup.Size = new System.Drawing.Size(48, 30);
            this.PresetViup.TabIndex = 59;
            this.PresetViup.Text = "+1.0";
            this.PresetViup.UseVisualStyleBackColor = true;
            this.PresetViup.Click += new System.EventHandler(this.PresetViup_Click);
            // 
            // PresetVSet
            // 
            this.PresetVSet.Location = new System.Drawing.Point(319, 868);
            this.PresetVSet.Margin = new System.Windows.Forms.Padding(4);
            this.PresetVSet.Name = "PresetVSet";
            this.PresetVSet.Size = new System.Drawing.Size(48, 59);
            this.PresetVSet.TabIndex = 61;
            this.PresetVSet.Text = "Set";
            this.PresetVSet.UseVisualStyleBackColor = true;
            this.PresetVSet.Click += new System.EventHandler(this.PresetVSet_Click);
            // 
            // T0Box
            // 
            this.T0Box.Font = new System.Drawing.Font("MS UI Gothic", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.T0Box.Location = new System.Drawing.Point(245, 16);
            this.T0Box.Margin = new System.Windows.Forms.Padding(4);
            this.T0Box.Multiline = true;
            this.T0Box.Name = "T0Box";
            this.T0Box.Size = new System.Drawing.Size(71, 25);
            this.T0Box.TabIndex = 62;
            this.T0Box.Text = "27";
            // 
            // SecondVABox
            // 
            this.SecondVABox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.SecondVABox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SecondVABox.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SecondVABox.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.SecondVABox.Location = new System.Drawing.Point(224, 389);
            this.SecondVABox.Margin = new System.Windows.Forms.Padding(4);
            this.SecondVABox.Multiline = true;
            this.SecondVABox.Name = "SecondVABox";
            this.SecondVABox.ShortcutsEnabled = false;
            this.SecondVABox.Size = new System.Drawing.Size(159, 41);
            this.SecondVABox.TabIndex = 64;
            // 
            // SecondVA
            // 
            this.SecondVA.Font = new System.Drawing.Font("游ゴシック", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SecondVA.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.SecondVA.Location = new System.Drawing.Point(17, 388);
            this.SecondVA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SecondVA.Name = "SecondVA";
            this.SecondVA.Size = new System.Drawing.Size(186, 31);
            this.SecondVA.TabIndex = 63;
            this.SecondVA.Text = "2次電力(VA)";
            // 
            // PrimRBox
            // 
            this.PrimRBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PrimRBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PrimRBox.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PrimRBox.Location = new System.Drawing.Point(224, 134);
            this.PrimRBox.Margin = new System.Windows.Forms.Padding(4);
            this.PrimRBox.Multiline = true;
            this.PrimRBox.Name = "PrimRBox";
            this.PrimRBox.ShortcutsEnabled = false;
            this.PrimRBox.Size = new System.Drawing.Size(159, 41);
            this.PrimRBox.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("游ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(17, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 31);
            this.label1.TabIndex = 65;
            this.label1.Text = "1次抵抗(Ω)";
            // 
            // FrequencySet
            // 
            this.FrequencySet.Font = new System.Drawing.Font("MS UI Gothic", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FrequencySet.Location = new System.Drawing.Point(341, 93);
            this.FrequencySet.Margin = new System.Windows.Forms.Padding(4);
            this.FrequencySet.Name = "FrequencySet";
            this.FrequencySet.Size = new System.Drawing.Size(71, 25);
            this.FrequencySet.TabIndex = 67;
            this.FrequencySet.Text = "Set";
            this.FrequencySet.UseVisualStyleBackColor = true;
            this.FrequencySet.Click += new System.EventHandler(this.FrequencySet_Click);
            // 
            // SaveSpanBox
            // 
            this.SaveSpanBox.BackColor = System.Drawing.SystemColors.Info;
            this.SaveSpanBox.Font = new System.Drawing.Font("MS UI Gothic", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SaveSpanBox.Location = new System.Drawing.Point(708, 886);
            this.SaveSpanBox.Multiline = true;
            this.SaveSpanBox.Name = "SaveSpanBox";
            this.SaveSpanBox.ReadOnly = true;
            this.SaveSpanBox.Size = new System.Drawing.Size(115, 47);
            this.SaveSpanBox.TabIndex = 68;
            // 
            // SaveSpanUp
            // 
            this.SaveSpanUp.AutoSize = true;
            this.SaveSpanUp.Location = new System.Drawing.Point(819, 884);
            this.SaveSpanUp.Name = "SaveSpanUp";
            this.SaveSpanUp.Size = new System.Drawing.Size(32, 25);
            this.SaveSpanUp.TabIndex = 69;
            this.SaveSpanUp.Text = "▲";
            this.SaveSpanUp.UseVisualStyleBackColor = true;
            this.SaveSpanUp.Click += new System.EventHandler(this.SaveSpanUp_Click);
            // 
            // SaveSpanDown
            // 
            this.SaveSpanDown.AutoSize = true;
            this.SaveSpanDown.Location = new System.Drawing.Point(819, 908);
            this.SaveSpanDown.Name = "SaveSpanDown";
            this.SaveSpanDown.Size = new System.Drawing.Size(32, 25);
            this.SaveSpanDown.TabIndex = 70;
            this.SaveSpanDown.Text = "▼";
            this.SaveSpanDown.UseVisualStyleBackColor = true;
            this.SaveSpanDown.Click += new System.EventHandler(this.SaveSpanDown_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("游ゴシック", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(457, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 71;
            this.label2.Text = "W-T eq.";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("游ゴシック", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(89, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 72;
            this.label3.Text = "室温(℃)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PgainDownButton
            // 
            this.PgainDownButton.AutoSize = true;
            this.PgainDownButton.Font = new System.Drawing.Font("MS UI Gothic", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PgainDownButton.Location = new System.Drawing.Point(396, 110);
            this.PgainDownButton.Name = "PgainDownButton";
            this.PgainDownButton.Size = new System.Drawing.Size(48, 23);
            this.PgainDownButton.TabIndex = 74;
            this.PgainDownButton.Text = "▼";
            this.PgainDownButton.UseVisualStyleBackColor = true;
            // 
            // PgainUpButton
            // 
            this.PgainUpButton.AutoSize = true;
            this.PgainUpButton.Font = new System.Drawing.Font("MS UI Gothic", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PgainUpButton.Location = new System.Drawing.Point(396, 86);
            this.PgainUpButton.Name = "PgainUpButton";
            this.PgainUpButton.Size = new System.Drawing.Size(48, 23);
            this.PgainUpButton.TabIndex = 73;
            this.PgainUpButton.Text = "▲";
            this.PgainUpButton.UseVisualStyleBackColor = true;
            // 
            // DgainDownButon
            // 
            this.DgainDownButon.AutoSize = true;
            this.DgainDownButon.Font = new System.Drawing.Font("MS UI Gothic", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DgainDownButon.Location = new System.Drawing.Point(396, 161);
            this.DgainDownButon.Name = "DgainDownButon";
            this.DgainDownButon.Size = new System.Drawing.Size(48, 23);
            this.DgainDownButon.TabIndex = 76;
            this.DgainDownButon.Text = "▼";
            this.DgainDownButon.UseVisualStyleBackColor = true;
            // 
            // DgainUpButton
            // 
            this.DgainUpButton.AutoSize = true;
            this.DgainUpButton.Font = new System.Drawing.Font("MS UI Gothic", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DgainUpButton.Location = new System.Drawing.Point(396, 137);
            this.DgainUpButton.Name = "DgainUpButton";
            this.DgainUpButton.Size = new System.Drawing.Size(48, 23);
            this.DgainUpButton.TabIndex = 75;
            this.DgainUpButton.Text = "▲";
            this.DgainUpButton.UseVisualStyleBackColor = true;
            // 
            // IgainDownButton
            // 
            this.IgainDownButton.AutoSize = true;
            this.IgainDownButton.Font = new System.Drawing.Font("MS UI Gothic", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.IgainDownButton.Location = new System.Drawing.Point(396, 210);
            this.IgainDownButton.Name = "IgainDownButton";
            this.IgainDownButton.Size = new System.Drawing.Size(48, 23);
            this.IgainDownButton.TabIndex = 78;
            this.IgainDownButton.Text = "▼";
            this.IgainDownButton.UseVisualStyleBackColor = true;
            // 
            // IgainUpButton
            // 
            this.IgainUpButton.AutoSize = true;
            this.IgainUpButton.Font = new System.Drawing.Font("MS UI Gothic", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.IgainUpButton.Location = new System.Drawing.Point(396, 186);
            this.IgainUpButton.Name = "IgainUpButton";
            this.IgainUpButton.Size = new System.Drawing.Size(48, 23);
            this.IgainUpButton.TabIndex = 77;
            this.IgainUpButton.Text = "▲";
            this.IgainUpButton.UseVisualStyleBackColor = true;
            // 
            // PgainSetButton
            // 
            this.PgainSetButton.Font = new System.Drawing.Font("MS UI Gothic", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PgainSetButton.Location = new System.Drawing.Point(451, 89);
            this.PgainSetButton.Margin = new System.Windows.Forms.Padding(4);
            this.PgainSetButton.Name = "PgainSetButton";
            this.PgainSetButton.Size = new System.Drawing.Size(48, 42);
            this.PgainSetButton.TabIndex = 79;
            this.PgainSetButton.Text = "Set";
            this.PgainSetButton.UseVisualStyleBackColor = true;
            this.PgainSetButton.Click += new System.EventHandler(this.PgainSetButton_Click);
            // 
            // DgainSetButton
            // 
            this.DgainSetButton.Font = new System.Drawing.Font("MS UI Gothic", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DgainSetButton.Location = new System.Drawing.Point(451, 143);
            this.DgainSetButton.Margin = new System.Windows.Forms.Padding(4);
            this.DgainSetButton.Name = "DgainSetButton";
            this.DgainSetButton.Size = new System.Drawing.Size(48, 42);
            this.DgainSetButton.TabIndex = 80;
            this.DgainSetButton.Text = "Set";
            this.DgainSetButton.UseVisualStyleBackColor = true;
            this.DgainSetButton.Click += new System.EventHandler(this.DgainSetButton_Click);
            // 
            // IgainSetButton
            // 
            this.IgainSetButton.Font = new System.Drawing.Font("MS UI Gothic", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.IgainSetButton.Location = new System.Drawing.Point(451, 192);
            this.IgainSetButton.Margin = new System.Windows.Forms.Padding(4);
            this.IgainSetButton.Name = "IgainSetButton";
            this.IgainSetButton.Size = new System.Drawing.Size(48, 42);
            this.IgainSetButton.TabIndex = 81;
            this.IgainSetButton.Text = "Set";
            this.IgainSetButton.UseVisualStyleBackColor = true;
            this.IgainSetButton.Click += new System.EventHandler(this.IgainSetButton_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("游ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(30, 351);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 31);
            this.label4.TabIndex = 82;
            this.label4.Text = "制御周期(s)";
            // 
            // PIDtimer
            // 
            this.PIDtimer.Interval = 1000;
            this.PIDtimer.Tick += new System.EventHandler(this.PIDtimer_Tick);
            // 
            // PIDButton
            // 
            this.PIDButton.BackColor = System.Drawing.Color.White;
            this.PIDButton.Font = new System.Drawing.Font("游ゴシック", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PIDButton.Location = new System.Drawing.Point(341, 502);
            this.PIDButton.Margin = new System.Windows.Forms.Padding(4);
            this.PIDButton.Name = "PIDButton";
            this.PIDButton.Size = new System.Drawing.Size(169, 80);
            this.PIDButton.TabIndex = 85;
            this.PIDButton.Text = "Auto(PID):OFF";
            this.PIDButton.UseVisualStyleBackColor = false;
            this.PIDButton.Click += new System.EventHandler(this.PIDButton_Click);
            // 
            // TargetTSetButton
            // 
            this.TargetTSetButton.Font = new System.Drawing.Font("MS UI Gothic", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TargetTSetButton.Location = new System.Drawing.Point(414, 35);
            this.TargetTSetButton.Margin = new System.Windows.Forms.Padding(4);
            this.TargetTSetButton.Name = "TargetTSetButton";
            this.TargetTSetButton.Size = new System.Drawing.Size(48, 42);
            this.TargetTSetButton.TabIndex = 86;
            this.TargetTSetButton.Text = "Set";
            this.TargetTSetButton.UseVisualStyleBackColor = true;
            this.TargetTSetButton.Click += new System.EventHandler(this.TargetTSetButton_Click);
            // 
            // PIDConditionText
            // 
            this.PIDConditionText.Font = new System.Drawing.Font("MS UI Gothic", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PIDConditionText.Location = new System.Drawing.Point(36, 405);
            this.PIDConditionText.Multiline = true;
            this.PIDConditionText.Name = "PIDConditionText";
            this.PIDConditionText.Size = new System.Drawing.Size(280, 188);
            this.PIDConditionText.TabIndex = 87;
            // 
            // PIDSpanBox
            // 
            this.PIDSpanBox.BackColor = System.Drawing.SystemColors.Info;
            this.PIDSpanBox.Font = new System.Drawing.Font("MS UI Gothic", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PIDSpanBox.Location = new System.Drawing.Point(235, 351);
            this.PIDSpanBox.Multiline = true;
            this.PIDSpanBox.Name = "PIDSpanBox";
            this.PIDSpanBox.Size = new System.Drawing.Size(159, 41);
            this.PIDSpanBox.TabIndex = 88;
            this.PIDSpanBox.Text = "1";
            // 
            // PIDSpanSetButton
            // 
            this.PIDSpanSetButton.Font = new System.Drawing.Font("MS UI Gothic", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PIDSpanSetButton.Location = new System.Drawing.Point(414, 351);
            this.PIDSpanSetButton.Margin = new System.Windows.Forms.Padding(4);
            this.PIDSpanSetButton.Name = "PIDSpanSetButton";
            this.PIDSpanSetButton.Size = new System.Drawing.Size(48, 42);
            this.PIDSpanSetButton.TabIndex = 89;
            this.PIDSpanSetButton.Text = "Set";
            this.PIDSpanSetButton.UseVisualStyleBackColor = true;
            this.PIDSpanSetButton.Click += new System.EventHandler(this.PIDSpanSetButton_Click);
            // 
            // Status
            // 
            this.Status.Controls.Add(this.PrimRBox);
            this.Status.Controls.Add(this.label1);
            this.Status.Controls.Add(this.SourceABox);
            this.Status.Controls.Add(this.SourceVBox);
            this.Status.Controls.Add(this.KelvinBox);
            this.Status.Controls.Add(this.TemperatureBox);
            this.Status.Controls.Add(this.HeatVBox);
            this.Status.Controls.Add(this.Kelvin);
            this.Status.Controls.Add(this.ElectroMotiveForce);
            this.Status.Controls.Add(this.TemperatureLabel);
            this.Status.Controls.Add(this.SourceVoltage);
            this.Status.Controls.Add(this.SourceCurrent);
            this.Status.Controls.Add(this.SourceEPBox);
            this.Status.Controls.Add(this.SourceEPower);
            this.Status.Controls.Add(this.SecondVA);
            this.Status.Controls.Add(this.StopWatchlabel);
            this.Status.Controls.Add(this.SecondRBox);
            this.Status.Controls.Add(this.SecondVABox);
            this.Status.Controls.Add(this.ApparentRegistance);
            this.Status.Controls.Add(this.SecondABox);
            this.Status.Controls.Add(this.SecondCurrLabel);
            this.Status.Controls.Add(this.SecondVBox);
            this.Status.Controls.Add(this.SecondVoltLabel);
            this.Status.Font = new System.Drawing.Font("MS UI Gothic", 18.15652F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Status.Location = new System.Drawing.Point(33, 101);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(405, 667);
            this.Status.TabIndex = 90;
            this.Status.TabStop = false;
            this.Status.Text = "Status";
            // 
            // PID
            // 
            this.PID.Controls.Add(this.IgainDownButton);
            this.PID.Controls.Add(this.IgainUpButton);
            this.PID.Controls.Add(this.PIDSpanSetButton);
            this.PID.Controls.Add(this.PIDButton);
            this.PID.Controls.Add(this.DgainDownButon);
            this.PID.Controls.Add(this.PIDSpanBox);
            this.PID.Controls.Add(this.DgainUpButton);
            this.PID.Controls.Add(this.PIDConditionText);
            this.PID.Controls.Add(this.label4);
            this.PID.Controls.Add(this.PgainDownButton);
            this.PID.Controls.Add(this.TargetTSetButton);
            this.PID.Controls.Add(this.PgainUpButton);
            this.PID.Controls.Add(this.IgainSetButton);
            this.PID.Controls.Add(this.PgainBox);
            this.PID.Controls.Add(this.DgainSetButton);
            this.PID.Controls.Add(this.Pgain);
            this.PID.Controls.Add(this.PgainSetButton);
            this.PID.Controls.Add(this.DgainBox);
            this.PID.Controls.Add(this.IgainBox);
            this.PID.Controls.Add(this.Dgain);
            this.PID.Controls.Add(this.Igain);
            this.PID.Controls.Add(this.PresetEPBox);
            this.PID.Controls.Add(this.TargetVBox);
            this.PID.Controls.Add(this.TargetTBox);
            this.PID.Controls.Add(this.PresetEPower);
            this.PID.Controls.Add(this.PresetTemperature);
            this.PID.Controls.Add(this.TargetVoltage);
            this.PID.Font = new System.Drawing.Font("MS UI Gothic", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PID.Location = new System.Drawing.Point(479, 234);
            this.PID.Name = "PID";
            this.PID.Size = new System.Drawing.Size(526, 600);
            this.PID.TabIndex = 91;
            this.PID.TabStop = false;
            this.PID.Text = "PID制御";
            // 
            // Setting
            // 
            this.Setting.Controls.Add(this.UpperEPower);
            this.Setting.Controls.Add(this.UpperEPBox);
            this.Setting.Controls.Add(this.T0Box);
            this.Setting.Controls.Add(this.label3);
            this.Setting.Controls.Add(this.frequency);
            this.Setting.Controls.Add(this.FrequencyBox);
            this.Setting.Controls.Add(this.FrequencySet);
            this.Setting.Font = new System.Drawing.Font("MS UI Gothic", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Setting.Location = new System.Drawing.Point(479, 101);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(418, 121);
            this.Setting.TabIndex = 92;
            this.Setting.TabStop = false;
            this.Setting.Text = "Setting";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("游ゴシック", 11.26957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(712, 858);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 73;
            this.label5.Text = "測定スパン(s)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1735, 947);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Setting);
            this.Controls.Add(this.PID);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaveSpanDown);
            this.Controls.Add(this.SaveSpanUp);
            this.Controls.Add(this.SaveSpanBox);
            this.Controls.Add(this.PresetVSet);
            this.Controls.Add(this.PresetViDown);
            this.Controls.Add(this.PresetViup);
            this.Controls.Add(this.PresetVdDown);
            this.Controls.Add(this.PresetVdUp);
            this.Controls.Add(this.FunctionTextBox);
            this.Controls.Add(this.RecordButton);
            this.Controls.Add(this.OffButton);
            this.Controls.Add(this.ModeBox);
            this.Controls.Add(this.PresetVoltage);
            this.Controls.Add(this.PresetVBox);
            this.Controls.Add(this.chart5);
            this.Controls.Add(this.chart4);
            this.Controls.Add(this.OnButton);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.PID.ResumeLayout(false);
            this.PID.PerformLayout();
            this.Setting.ResumeLayout(false);
            this.Setting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button OnButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ModeSelectMenu;
        private System.Windows.Forms.ToolStripMenuItem ThermoCoupleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ElectricPowerToolStripMenuItem;
        private System.Windows.Forms.TextBox PresetVBox;
        private System.Windows.Forms.ToolStripMenuItem TypeKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TypeBToolStripMenuItem;
        private System.Windows.Forms.Label TargetVoltage;
        private System.Windows.Forms.Label SourceCurrent;
        private System.Windows.Forms.Label SourceVoltage;
        private System.Windows.Forms.Label ApparentRegistance;
        private System.Windows.Forms.Label TemperatureLabel;
        private System.Windows.Forms.Label SourceEPower;
        private System.Windows.Forms.Label ElectroMotiveForce;
        private System.Windows.Forms.Label PresetTemperature;
        private System.Windows.Forms.Label Kelvin;
        private System.Windows.Forms.Label PresetVoltage;
        private System.Windows.Forms.Label PresetEPower;
        private System.Windows.Forms.Label UpperEPower;
        private System.Windows.Forms.TextBox HeatVBox;
        private System.Windows.Forms.TextBox TemperatureBox;
        private System.Windows.Forms.TextBox TargetTBox;
        private System.Windows.Forms.TextBox KelvinBox;
        private System.Windows.Forms.TextBox SourceVBox;
        private System.Windows.Forms.TextBox SourceABox;
        private System.Windows.Forms.TextBox SecondRBox;
        private System.Windows.Forms.TextBox TargetVBox;
        private System.Windows.Forms.TextBox SourceEPBox;
        private System.Windows.Forms.TextBox PresetEPBox;
        private System.Windows.Forms.TextBox UpperEPBox;
        private System.Windows.Forms.ToolStripMenuItem TypeDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TypeRToolStripMenuItem;
        private System.Windows.Forms.TextBox ModeBox;
        private System.Windows.Forms.Button OffButton;
        private System.Windows.Forms.Label StopWatchlabel;
        private System.Windows.Forms.Button RecordButton;
        private System.Windows.Forms.ToolStripMenuItem FittingCSV;
        private System.Windows.Forms.ToolStripMenuItem FittingEPCSVToolStrip;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox FunctionTextBox;
        private System.Windows.Forms.TextBox SecondABox;
        private System.Windows.Forms.Label SecondCurrLabel;
        private System.Windows.Forms.TextBox SecondVBox;
        private System.Windows.Forms.Label SecondVoltLabel;
        private System.Windows.Forms.Button PresetVdUp;
        private System.Windows.Forms.Button PresetVdDown;
        private System.Windows.Forms.TextBox FrequencyBox;
        private System.Windows.Forms.TextBox DgainBox;
        private System.Windows.Forms.TextBox IgainBox;
        private System.Windows.Forms.Label frequency;
        private System.Windows.Forms.Label Dgain;
        private System.Windows.Forms.Label Igain;
        private System.Windows.Forms.TextBox PgainBox;
        private System.Windows.Forms.Label Pgain;
        private System.Windows.Forms.Button PresetVSet;
        private System.Windows.Forms.Button PresetViDown;
        private System.Windows.Forms.Button PresetViup;
        private System.Windows.Forms.TextBox T0Box;
        private System.Windows.Forms.TextBox SecondVABox;
        private System.Windows.Forms.Label SecondVA;
        private System.Windows.Forms.TextBox PrimRBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FrequencySet;
        private System.Windows.Forms.Button SaveSpanDown;
        private System.Windows.Forms.Button SaveSpanUp;
        private System.Windows.Forms.TextBox SaveSpanBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button IgainSetButton;
        private System.Windows.Forms.Button DgainSetButton;
        private System.Windows.Forms.Button PgainSetButton;
        private System.Windows.Forms.Button IgainDownButton;
        private System.Windows.Forms.Button IgainUpButton;
        private System.Windows.Forms.Button DgainDownButon;
        private System.Windows.Forms.Button DgainUpButton;
        private System.Windows.Forms.Button PgainDownButton;
        private System.Windows.Forms.Button PgainUpButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer PIDtimer;
        private System.Windows.Forms.Button PIDButton;
        private System.Windows.Forms.Button TargetTSetButton;
        private System.Windows.Forms.TextBox PIDConditionText;
        private System.Windows.Forms.Button PIDSpanSetButton;
        private System.Windows.Forms.TextBox PIDSpanBox;
        private System.Windows.Forms.GroupBox Status;
        private System.Windows.Forms.GroupBox PID;
        private System.Windows.Forms.GroupBox Setting;
        private System.Windows.Forms.Label label5;
    }
}

