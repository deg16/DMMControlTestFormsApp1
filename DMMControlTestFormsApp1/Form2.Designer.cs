namespace DMMControlTestFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Fittingchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FfunctionTextBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Fittingchart)).BeginInit();
            this.SuspendLayout();
            // 
            // Fittingchart
            // 
            this.Fittingchart.Location = new System.Drawing.Point(25, 26);
            this.Fittingchart.Name = "Fittingchart";
            series1.Name = "Series1";
            this.Fittingchart.Series.Add(series1);
            this.Fittingchart.Size = new System.Drawing.Size(689, 397);
            this.Fittingchart.TabIndex = 0;
            this.Fittingchart.Text = "FittingChart";
            // 
            // FfunctionTextBox
            // 
            this.FfunctionTextBox.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FfunctionTextBox.Location = new System.Drawing.Point(43, 444);
            this.FfunctionTextBox.Multiline = true;
            this.FfunctionTextBox.Name = "FfunctionTextBox";
            this.FfunctionTextBox.Size = new System.Drawing.Size(584, 58);
            this.FfunctionTextBox.TabIndex = 1;
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SendButton.Location = new System.Drawing.Point(714, 460);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(143, 42);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 514);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.FfunctionTextBox);
            this.Controls.Add(this.Fittingchart);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.Fittingchart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Fittingchart;
        private System.Windows.Forms.TextBox FfunctionTextBox;
        private System.Windows.Forms.Button SendButton;
    }
}