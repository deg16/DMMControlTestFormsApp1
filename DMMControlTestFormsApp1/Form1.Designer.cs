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
            this.Temperature = new System.Windows.Forms.Label();
            this.SourceEPower = new System.Windows.Forms.Label();
            this.ElectroMotiveForce = new System.Windows.Forms.Label();
            this.PresetTemperature = new System.Windows.Forms.Label();
            this.Kelvin = new System.Windows.Forms.Label();
            this.PresetVoltage = new System.Windows.Forms.Label();
            this.PresetEPower = new System.Windows.Forms.Label();
            this.UpperEPower = new System.Windows.Forms.Label();
            this.HeatVBox = new System.Windows.Forms.TextBox();
            this.TemperatureBox = new System.Windows.Forms.TextBox();
            this.PresetTBox = new System.Windows.Forms.TextBox();
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
            this.SettingConditionBox = new System.Windows.Forms.TextBox();
            this.SecondVABox = new System.Windows.Forms.TextBox();
            this.SecondVA = new System.Windows.Forms.Label();
            this.PrimRBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FrequencySet = new System.Windows.Forms.Button();
            this.SaveSpanBox = new System.Windows.Forms.TextBox();
            this.SaveSpanUp = new System.Windows.Forms.Button();
            this.SaveSpanDown = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(1128, 50);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(566, 184);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "電源電圧(V)";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Location = new System.Drawing.Point(1128, 238);
            this.chart2.Margin = new System.Windows.Forms.Padding(4);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(566, 184);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "電源電流(A)";
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            this.chart3.Location = new System.Drawing.Point(1128, 426);
            this.chart3.Margin = new System.Windows.Forms.Padding(4);
            this.chart3.Name = "chart3";
            this.chart3.Size = new System.Drawing.Size(566, 184);
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
            this.OnButton.Location = new System.Drawing.Point(463, 875);
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
            this.chart4.Location = new System.Drawing.Point(1128, 614);
            this.chart4.Margin = new System.Windows.Forms.Padding(4);
            this.chart4.Name = "chart4";
            this.chart4.Size = new System.Drawing.Size(566, 184);
            this.chart4.TabIndex = 4;
            this.chart4.Text = "電力(VA)";
            // 
            // chart5
            // 
            chartArea5.Name = "ChartArea1";
            this.chart5.ChartAreas.Add(chartArea5);
            this.chart5.Location = new System.Drawing.Point(1128, 802);
            this.chart5.Margin = new System.Windows.Forms.Padding(4);
            this.chart5.Name = "chart5";
            this.chart5.Size = new System.Drawing.Size(566, 184);
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
            this.menuStrip1.Size = new System.Drawing.Size(1735, 29);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ModeSelectMenu
            // 
            this.ModeSelectMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThermoCoupleToolStripMenuItem,
            this.ElectricPowerToolStripMenuItem});
            this.ModeSelectMenu.Name = "ModeSelectMenu";
            this.ModeSelectMenu.Size = new System.Drawing.Size(62, 25);
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
            this.ThermoCoupleToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
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
            this.ElectricPowerToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.ElectricPowerToolStripMenuItem.Text = "パワー制御";
            this.ElectricPowerToolStripMenuItem.Click += new System.EventHandler(this.ElectricPowerToolStripMenuItem_Click);
            // 
            // FittingCSV
            // 
            this.FittingCSV.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FittingEPCSVToolStrip});
            this.FittingCSV.Name = "FittingCSV";
            this.FittingCSV.Size = new System.Drawing.Size(46, 25);
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
            this.PresetVBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PresetVBox.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PresetVBox.Location = new System.Drawing.Point(245, 456);
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
            this.TargetVoltage.Location = new System.Drawing.Point(583, 400);
            this.TargetVoltage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TargetVoltage.Name = "TargetVoltage";
            this.TargetVoltage.Size = new System.Drawing.Size(186, 31);
            this.TargetVoltage.TabIndex = 16;
            this.TargetVoltage.Text = "目標電圧(V)";
            // 
            // SourceCurrent
            // 
            this.SourceCurrent.Font = new System.Drawing.Font("游ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SourceCurrent.Location = new System.Drawing.Point(38, 524);
            this.SourceCurrent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SourceCurrent.Name = "SourceCurrent";
            this.SourceCurrent.Size = new System.Drawing.Size(186, 31);
            this.SourceCurrent.TabIndex = 17;
            this.SourceCurrent.Text = "電源電流(A)";
            // 
            // SourceVoltage
            // 
            this.SourceVoltage.Font = new System.Drawing.Font("游ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SourceVoltage.Location = new System.Drawing.Point(38, 410);
            this.SourceVoltage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SourceVoltage.Name = "SourceVoltage";
            this.SourceVoltage.Size = new System.Drawing.Size(186, 31);
            this.SourceVoltage.TabIndex = 18;
            this.SourceVoltage.Text = "電源電圧(V)";
            // 
            // ApparentRegistance
            // 
            this.ApparentRegistance.Font = new System.Drawing.Font("游ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ApparentRegistance.Location = new System.Drawing.Point(583, 670);
            this.ApparentRegistance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ApparentRegistance.Name = "ApparentRegistance";
            this.ApparentRegistance.Size = new System.Drawing.Size(199, 31);
            this.ApparentRegistance.TabIndex = 19;
            this.ApparentRegistance.Text = "２次抵抗(Ω)";
            // 
            // Temperature
            // 
            this.Temperature.Font = new System.Drawing.Font("游ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Temperature.Location = new System.Drawing.Point(38, 238);
            this.Temperature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Temperature.Name = "Temperature";
            this.Temperature.Size = new System.Drawing.Size(186, 31);
            this.Temperature.TabIndex = 20;
            this.Temperature.Text = "温度(℃)";
            // 
            // SourceEPower
            // 
            this.SourceEPower.Font = new System.Drawing.Font("游ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SourceEPower.Location = new System.Drawing.Point(38, 638);
            this.SourceEPower.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SourceEPower.Name = "SourceEPower";
            this.SourceEPower.Size = new System.Drawing.Size(186, 31);
            this.SourceEPower.TabIndex = 21;
            this.SourceEPower.Text = "電源電力(VA)";
            // 
            // ElectroMotiveForce
            // 
            this.ElectroMotiveForce.Font = new System.Drawing.Font("游ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ElectroMotiveForce.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ElectroMotiveForce.Location = new System.Drawing.Point(38, 174);
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
            this.PresetTemperature.Location = new System.Drawing.Point(38, 295);
            this.PresetTemperature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PresetTemperature.Name = "PresetTemperature";
            this.PresetTemperature.Size = new System.Drawing.Size(186, 31);
            this.PresetTemperature.TabIndex = 24;
            this.PresetTemperature.Text = "設定温度(℃)";
            // 
            // Kelvin
            // 
            this.Kelvin.Font = new System.Drawing.Font("游ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Kelvin.Location = new System.Drawing.Point(38, 352);
            this.Kelvin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Kelvin.Name = "Kelvin";
            this.Kelvin.Size = new System.Drawing.Size(186, 31);
            this.Kelvin.TabIndex = 25;
            this.Kelvin.Text = "絶対温度(K)";
            // 
            // PresetVoltage
            // 
            this.PresetVoltage.Font = new System.Drawing.Font("游ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PresetVoltage.Location = new System.Drawing.Point(38, 467);
            this.PresetVoltage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PresetVoltage.Name = "PresetVoltage";
            this.PresetVoltage.Size = new System.Drawing.Size(186, 31);
            this.PresetVoltage.TabIndex = 26;
            this.PresetVoltage.Text = "設定電圧(V)";
            // 
            // PresetEPower
            // 
            this.PresetEPower.Font = new System.Drawing.Font("游ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PresetEPower.Location = new System.Drawing.Point(38, 695);
            this.PresetEPower.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PresetEPower.Name = "PresetEPower";
            this.PresetEPower.Size = new System.Drawing.Size(186, 31);
            this.PresetEPower.TabIndex = 27;
            this.PresetEPower.Text = "設定電力(VA)";
            // 
            // UpperEPower
            // 
            this.UpperEPower.Font = new System.Drawing.Font("游ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.UpperEPower.Location = new System.Drawing.Point(38, 752);
            this.UpperEPower.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpperEPower.Name = "UpperEPower";
            this.UpperEPower.Size = new System.Drawing.Size(186, 31);
            this.UpperEPower.TabIndex = 28;
            this.UpperEPower.Text = "電力上限(VA)";
            // 
            // HeatVBox
            // 
            this.HeatVBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HeatVBox.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HeatVBox.Location = new System.Drawing.Point(245, 163);
            this.HeatVBox.Margin = new System.Windows.Forms.Padding(4);
            this.HeatVBox.Multiline = true;
            this.HeatVBox.Name = "HeatVBox";
            this.HeatVBox.ShortcutsEnabled = false;
            this.HeatVBox.Size = new System.Drawing.Size(159, 41);
            this.HeatVBox.TabIndex = 29;
            // 
            // TemperatureBox
            // 
            this.TemperatureBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TemperatureBox.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TemperatureBox.Location = new System.Drawing.Point(245, 227);
            this.TemperatureBox.Margin = new System.Windows.Forms.Padding(4);
            this.TemperatureBox.Multiline = true;
            this.TemperatureBox.Name = "TemperatureBox";
            this.TemperatureBox.ShortcutsEnabled = false;
            this.TemperatureBox.Size = new System.Drawing.Size(159, 41);
            this.TemperatureBox.TabIndex = 30;
            // 
            // PresetTBox
            // 
            this.PresetTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PresetTBox.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PresetTBox.Location = new System.Drawing.Point(245, 285);
            this.PresetTBox.Margin = new System.Windows.Forms.Padding(4);
            this.PresetTBox.Multiline = true;
            this.PresetTBox.Name = "PresetTBox";
            this.PresetTBox.ShortcutsEnabled = false;
            this.PresetTBox.Size = new System.Drawing.Size(159, 41);
            this.PresetTBox.TabIndex = 31;
            // 
            // KelvinBox
            // 
            this.KelvinBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.KelvinBox.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.KelvinBox.Location = new System.Drawing.Point(245, 342);
            this.KelvinBox.Margin = new System.Windows.Forms.Padding(4);
            this.KelvinBox.Multiline = true;
            this.KelvinBox.Name = "KelvinBox";
            this.KelvinBox.ShortcutsEnabled = false;
            this.KelvinBox.Size = new System.Drawing.Size(159, 41);
            this.KelvinBox.TabIndex = 32;
            // 
            // SourceVBox
            // 
            this.SourceVBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SourceVBox.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SourceVBox.Location = new System.Drawing.Point(245, 399);
            this.SourceVBox.Margin = new System.Windows.Forms.Padding(4);
            this.SourceVBox.Multiline = true;
            this.SourceVBox.Name = "SourceVBox";
            this.SourceVBox.ShortcutsEnabled = false;
            this.SourceVBox.Size = new System.Drawing.Size(159, 41);
            this.SourceVBox.TabIndex = 33;
            // 
            // SourceABox
            // 
            this.SourceABox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SourceABox.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SourceABox.Location = new System.Drawing.Point(245, 513);
            this.SourceABox.Margin = new System.Windows.Forms.Padding(4);
            this.SourceABox.Multiline = true;
            this.SourceABox.Name = "SourceABox";
            this.SourceABox.ShortcutsEnabled = false;
            this.SourceABox.Size = new System.Drawing.Size(159, 41);
            this.SourceABox.TabIndex = 34;
            // 
            // SecondRBox
            // 
            this.SecondRBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SecondRBox.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SecondRBox.Location = new System.Drawing.Point(790, 670);
            this.SecondRBox.Margin = new System.Windows.Forms.Padding(4);
            this.SecondRBox.Multiline = true;
            this.SecondRBox.Name = "SecondRBox";
            this.SecondRBox.ShortcutsEnabled = false;
            this.SecondRBox.Size = new System.Drawing.Size(159, 41);
            this.SecondRBox.TabIndex = 35;
            // 
            // TargetVBox
            // 
            this.TargetVBox.Location = new System.Drawing.Point(790, 400);
            this.TargetVBox.Margin = new System.Windows.Forms.Padding(4);
            this.TargetVBox.Multiline = true;
            this.TargetVBox.Name = "TargetVBox";
            this.TargetVBox.Size = new System.Drawing.Size(159, 41);
            this.TargetVBox.TabIndex = 36;
            // 
            // SourceEPBox
            // 
            this.SourceEPBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SourceEPBox.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SourceEPBox.Location = new System.Drawing.Point(245, 628);
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
            this.PresetEPBox.Location = new System.Drawing.Point(245, 685);
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
            this.UpperEPBox.Location = new System.Drawing.Point(245, 742);
            this.UpperEPBox.Margin = new System.Windows.Forms.Padding(4);
            this.UpperEPBox.Multiline = true;
            this.UpperEPBox.Name = "UpperEPBox";
            this.UpperEPBox.ShortcutsEnabled = false;
            this.UpperEPBox.Size = new System.Drawing.Size(159, 41);
            this.UpperEPBox.TabIndex = 39;
            // 
            // ModeBox
            // 
            this.ModeBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeBox.Location = new System.Drawing.Point(443, 50);
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
            this.OffButton.Location = new System.Drawing.Point(645, 875);
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
            this.StopWatchlabel.Location = new System.Drawing.Point(174, 901);
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
            this.RecordButton.Location = new System.Drawing.Point(949, 876);
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
            this.FunctionTextBox.Location = new System.Drawing.Point(412, 110);
            this.FunctionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FunctionTextBox.Multiline = true;
            this.FunctionTextBox.Name = "FunctionTextBox";
            this.FunctionTextBox.Size = new System.Drawing.Size(334, 42);
            this.FunctionTextBox.TabIndex = 44;
            // 
            // SecondVBox
            // 
            this.SecondVBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SecondVBox.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SecondVBox.Location = new System.Drawing.Point(790, 464);
            this.SecondVBox.Margin = new System.Windows.Forms.Padding(4);
            this.SecondVBox.Multiline = true;
            this.SecondVBox.Name = "SecondVBox";
            this.SecondVBox.ShortcutsEnabled = false;
            this.SecondVBox.Size = new System.Drawing.Size(159, 41);
            this.SecondVBox.TabIndex = 46;
            // 
            // SecondVoltLabel
            // 
            this.SecondVoltLabel.Font = new System.Drawing.Font("游ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SecondVoltLabel.Location = new System.Drawing.Point(583, 475);
            this.SecondVoltLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SecondVoltLabel.Name = "SecondVoltLabel";
            this.SecondVoltLabel.Size = new System.Drawing.Size(186, 31);
            this.SecondVoltLabel.TabIndex = 45;
            this.SecondVoltLabel.Text = "2次電圧(V)";
            // 
            // SecondABox
            // 
            this.SecondABox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SecondABox.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SecondABox.Location = new System.Drawing.Point(790, 538);
            this.SecondABox.Margin = new System.Windows.Forms.Padding(4);
            this.SecondABox.Multiline = true;
            this.SecondABox.Name = "SecondABox";
            this.SecondABox.ShortcutsEnabled = false;
            this.SecondABox.Size = new System.Drawing.Size(159, 41);
            this.SecondABox.TabIndex = 48;
            // 
            // SecondCurrLabel
            // 
            this.SecondCurrLabel.Font = new System.Drawing.Font("游ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SecondCurrLabel.Location = new System.Drawing.Point(583, 548);
            this.SecondCurrLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SecondCurrLabel.Name = "SecondCurrLabel";
            this.SecondCurrLabel.Size = new System.Drawing.Size(186, 31);
            this.SecondCurrLabel.TabIndex = 47;
            this.SecondCurrLabel.Text = "2次電流(A)";
            // 
            // PresetVdUp
            // 
            this.PresetVdUp.Location = new System.Drawing.Point(412, 435);
            this.PresetVdUp.Margin = new System.Windows.Forms.Padding(4);
            this.PresetVdUp.Name = "PresetVdUp";
            this.PresetVdUp.Size = new System.Drawing.Size(48, 42);
            this.PresetVdUp.TabIndex = 49;
            this.PresetVdUp.Text = "+0.1";
            this.PresetVdUp.UseVisualStyleBackColor = true;
            this.PresetVdUp.Click += new System.EventHandler(this.PresetVdUp_Click);
            // 
            // PresetVdDown
            // 
            this.PresetVdDown.Location = new System.Drawing.Point(412, 485);
            this.PresetVdDown.Margin = new System.Windows.Forms.Padding(4);
            this.PresetVdDown.Name = "PresetVdDown";
            this.PresetVdDown.Size = new System.Drawing.Size(48, 42);
            this.PresetVdDown.TabIndex = 50;
            this.PresetVdDown.Text = "-0.1";
            this.PresetVdDown.UseVisualStyleBackColor = true;
            this.PresetVdDown.Click += new System.EventHandler(this.PresetVdDown_Click);
            // 
            // Igain
            // 
            this.Igain.Font = new System.Drawing.Font("游ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Igain.Location = new System.Drawing.Point(583, 342);
            this.Igain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Igain.Name = "Igain";
            this.Igain.Size = new System.Drawing.Size(186, 31);
            this.Igain.TabIndex = 51;
            this.Igain.Text = "Igain";
            // 
            // Dgain
            // 
            this.Dgain.Font = new System.Drawing.Font("游ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Dgain.Location = new System.Drawing.Point(583, 284);
            this.Dgain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dgain.Name = "Dgain";
            this.Dgain.Size = new System.Drawing.Size(186, 31);
            this.Dgain.TabIndex = 52;
            this.Dgain.Text = "Dgain";
            // 
            // frequency
            // 
            this.frequency.Font = new System.Drawing.Font("游ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.frequency.Location = new System.Drawing.Point(583, 172);
            this.frequency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.frequency.Name = "frequency";
            this.frequency.Size = new System.Drawing.Size(186, 31);
            this.frequency.TabIndex = 53;
            this.frequency.Text = "周波数（㎐）";
            // 
            // IgainBox
            // 
            this.IgainBox.Location = new System.Drawing.Point(790, 342);
            this.IgainBox.Margin = new System.Windows.Forms.Padding(4);
            this.IgainBox.Multiline = true;
            this.IgainBox.Name = "IgainBox";
            this.IgainBox.Size = new System.Drawing.Size(159, 41);
            this.IgainBox.TabIndex = 54;
            // 
            // DgainBox
            // 
            this.DgainBox.Location = new System.Drawing.Point(790, 284);
            this.DgainBox.Margin = new System.Windows.Forms.Padding(4);
            this.DgainBox.Multiline = true;
            this.DgainBox.Name = "DgainBox";
            this.DgainBox.Size = new System.Drawing.Size(159, 41);
            this.DgainBox.TabIndex = 55;
            // 
            // FrequencyBox
            // 
            this.FrequencyBox.Location = new System.Drawing.Point(790, 172);
            this.FrequencyBox.Margin = new System.Windows.Forms.Padding(4);
            this.FrequencyBox.Multiline = true;
            this.FrequencyBox.Name = "FrequencyBox";
            this.FrequencyBox.Size = new System.Drawing.Size(159, 41);
            this.FrequencyBox.TabIndex = 56;
            // 
            // PgainBox
            // 
            this.PgainBox.Location = new System.Drawing.Point(790, 227);
            this.PgainBox.Margin = new System.Windows.Forms.Padding(4);
            this.PgainBox.Multiline = true;
            this.PgainBox.Name = "PgainBox";
            this.PgainBox.Size = new System.Drawing.Size(159, 41);
            this.PgainBox.TabIndex = 58;
            // 
            // Pgain
            // 
            this.Pgain.Font = new System.Drawing.Font("游ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Pgain.Location = new System.Drawing.Point(583, 227);
            this.Pgain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pgain.Name = "Pgain";
            this.Pgain.Size = new System.Drawing.Size(186, 31);
            this.Pgain.TabIndex = 57;
            this.Pgain.Text = "Pgain";
            // 
            // PresetViDown
            // 
            this.PresetViDown.Location = new System.Drawing.Point(468, 485);
            this.PresetViDown.Margin = new System.Windows.Forms.Padding(4);
            this.PresetViDown.Name = "PresetViDown";
            this.PresetViDown.Size = new System.Drawing.Size(48, 42);
            this.PresetViDown.TabIndex = 60;
            this.PresetViDown.Text = "-1.0";
            this.PresetViDown.UseVisualStyleBackColor = true;
            this.PresetViDown.Click += new System.EventHandler(this.PresetViDown_Click);
            // 
            // PresetViup
            // 
            this.PresetViup.Location = new System.Drawing.Point(468, 435);
            this.PresetViup.Margin = new System.Windows.Forms.Padding(4);
            this.PresetViup.Name = "PresetViup";
            this.PresetViup.Size = new System.Drawing.Size(48, 42);
            this.PresetViup.TabIndex = 59;
            this.PresetViup.Text = "+1.0";
            this.PresetViup.UseVisualStyleBackColor = true;
            this.PresetViup.Click += new System.EventHandler(this.PresetViup_Click);
            // 
            // PresetVSet
            // 
            this.PresetVSet.Location = new System.Drawing.Point(524, 456);
            this.PresetVSet.Margin = new System.Windows.Forms.Padding(4);
            this.PresetVSet.Name = "PresetVSet";
            this.PresetVSet.Size = new System.Drawing.Size(48, 42);
            this.PresetVSet.TabIndex = 61;
            this.PresetVSet.Text = "Set";
            this.PresetVSet.UseVisualStyleBackColor = true;
            this.PresetVSet.Click += new System.EventHandler(this.PresetVSet_Click);
            // 
            // SettingConditionBox
            // 
            this.SettingConditionBox.Location = new System.Drawing.Point(13, 58);
            this.SettingConditionBox.Margin = new System.Windows.Forms.Padding(4);
            this.SettingConditionBox.Multiline = true;
            this.SettingConditionBox.Name = "SettingConditionBox";
            this.SettingConditionBox.Size = new System.Drawing.Size(391, 94);
            this.SettingConditionBox.TabIndex = 62;
            // 
            // SecondVABox
            // 
            this.SecondVABox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SecondVABox.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SecondVABox.Location = new System.Drawing.Point(790, 604);
            this.SecondVABox.Margin = new System.Windows.Forms.Padding(4);
            this.SecondVABox.Multiline = true;
            this.SecondVABox.Name = "SecondVABox";
            this.SecondVABox.ShortcutsEnabled = false;
            this.SecondVABox.Size = new System.Drawing.Size(159, 41);
            this.SecondVABox.TabIndex = 64;
            // 
            // SecondVA
            // 
            this.SecondVA.Font = new System.Drawing.Font("游ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SecondVA.Location = new System.Drawing.Point(583, 614);
            this.SecondVA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SecondVA.Name = "SecondVA";
            this.SecondVA.Size = new System.Drawing.Size(186, 31);
            this.SecondVA.TabIndex = 63;
            this.SecondVA.Text = "２次電力(VA)";
            // 
            // PrimRBox
            // 
            this.PrimRBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PrimRBox.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PrimRBox.Location = new System.Drawing.Point(245, 569);
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
            this.label1.Location = new System.Drawing.Point(38, 579);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 31);
            this.label1.TabIndex = 65;
            this.label1.Text = "1次抵抗(Ω)";
            // 
            // FrequencySet
            // 
            this.FrequencySet.Location = new System.Drawing.Point(970, 172);
            this.FrequencySet.Margin = new System.Windows.Forms.Padding(4);
            this.FrequencySet.Name = "FrequencySet";
            this.FrequencySet.Size = new System.Drawing.Size(48, 42);
            this.FrequencySet.TabIndex = 67;
            this.FrequencySet.Text = "Set";
            this.FrequencySet.UseVisualStyleBackColor = true;
            this.FrequencySet.Click += new System.EventHandler(this.FrequencySet_Click);
            // 
            // SaveSpanBox
            // 
            this.SaveSpanBox.BackColor = System.Drawing.SystemColors.Info;
            this.SaveSpanBox.Font = new System.Drawing.Font("MS UI Gothic", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SaveSpanBox.Location = new System.Drawing.Point(806, 908);
            this.SaveSpanBox.Multiline = true;
            this.SaveSpanBox.Name = "SaveSpanBox";
            this.SaveSpanBox.ReadOnly = true;
            this.SaveSpanBox.Size = new System.Drawing.Size(115, 47);
            this.SaveSpanBox.TabIndex = 68;
            // 
            // SaveSpanUp
            // 
            this.SaveSpanUp.AutoSize = true;
            this.SaveSpanUp.Location = new System.Drawing.Point(921, 909);
            this.SaveSpanUp.Name = "SaveSpanUp";
            this.SaveSpanUp.Size = new System.Drawing.Size(32, 25);
            this.SaveSpanUp.TabIndex = 69;
            this.SaveSpanUp.Text = "▲";
            this.SaveSpanUp.UseVisualStyleBackColor = true;
            // 
            // SaveSpanDown
            // 
            this.SaveSpanDown.AutoSize = true;
            this.SaveSpanDown.Location = new System.Drawing.Point(921, 933);
            this.SaveSpanDown.Name = "SaveSpanDown";
            this.SaveSpanDown.Size = new System.Drawing.Size(32, 25);
            this.SaveSpanDown.TabIndex = 70;
            this.SaveSpanDown.Text = "▼";
            this.SaveSpanDown.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1735, 993);
            this.Controls.Add(this.SaveSpanDown);
            this.Controls.Add(this.SaveSpanUp);
            this.Controls.Add(this.SaveSpanBox);
            this.Controls.Add(this.FrequencySet);
            this.Controls.Add(this.PrimRBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecondVABox);
            this.Controls.Add(this.SecondVA);
            this.Controls.Add(this.SettingConditionBox);
            this.Controls.Add(this.PresetVSet);
            this.Controls.Add(this.PresetViDown);
            this.Controls.Add(this.PresetViup);
            this.Controls.Add(this.PgainBox);
            this.Controls.Add(this.Pgain);
            this.Controls.Add(this.FrequencyBox);
            this.Controls.Add(this.DgainBox);
            this.Controls.Add(this.IgainBox);
            this.Controls.Add(this.frequency);
            this.Controls.Add(this.Dgain);
            this.Controls.Add(this.Igain);
            this.Controls.Add(this.PresetVdDown);
            this.Controls.Add(this.PresetVdUp);
            this.Controls.Add(this.SecondABox);
            this.Controls.Add(this.SecondCurrLabel);
            this.Controls.Add(this.SecondVBox);
            this.Controls.Add(this.SecondVoltLabel);
            this.Controls.Add(this.FunctionTextBox);
            this.Controls.Add(this.RecordButton);
            this.Controls.Add(this.StopWatchlabel);
            this.Controls.Add(this.OffButton);
            this.Controls.Add(this.ModeBox);
            this.Controls.Add(this.UpperEPBox);
            this.Controls.Add(this.PresetEPBox);
            this.Controls.Add(this.SourceEPBox);
            this.Controls.Add(this.TargetVBox);
            this.Controls.Add(this.SecondRBox);
            this.Controls.Add(this.SourceABox);
            this.Controls.Add(this.SourceVBox);
            this.Controls.Add(this.KelvinBox);
            this.Controls.Add(this.PresetTBox);
            this.Controls.Add(this.TemperatureBox);
            this.Controls.Add(this.HeatVBox);
            this.Controls.Add(this.UpperEPower);
            this.Controls.Add(this.PresetEPower);
            this.Controls.Add(this.PresetVoltage);
            this.Controls.Add(this.Kelvin);
            this.Controls.Add(this.PresetTemperature);
            this.Controls.Add(this.ElectroMotiveForce);
            this.Controls.Add(this.SourceEPower);
            this.Controls.Add(this.Temperature);
            this.Controls.Add(this.ApparentRegistance);
            this.Controls.Add(this.SourceVoltage);
            this.Controls.Add(this.SourceCurrent);
            this.Controls.Add(this.TargetVoltage);
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
        private System.Windows.Forms.Label Temperature;
        private System.Windows.Forms.Label SourceEPower;
        private System.Windows.Forms.Label ElectroMotiveForce;
        private System.Windows.Forms.Label PresetTemperature;
        private System.Windows.Forms.Label Kelvin;
        private System.Windows.Forms.Label PresetVoltage;
        private System.Windows.Forms.Label PresetEPower;
        private System.Windows.Forms.Label UpperEPower;
        private System.Windows.Forms.TextBox HeatVBox;
        private System.Windows.Forms.TextBox TemperatureBox;
        private System.Windows.Forms.TextBox PresetTBox;
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
        private System.Windows.Forms.TextBox SettingConditionBox;
        private System.Windows.Forms.TextBox SecondVABox;
        private System.Windows.Forms.Label SecondVA;
        private System.Windows.Forms.TextBox PrimRBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FrequencySet;
        private System.Windows.Forms.Button SaveSpanDown;
        private System.Windows.Forms.Button SaveSpanUp;
        private System.Windows.Forms.TextBox SaveSpanBox;
    }
}

