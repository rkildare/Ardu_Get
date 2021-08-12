namespace quickmake
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.cmbBaud = new System.Windows.Forms.ComboBox();
            this.chkSave = new System.Windows.Forms.CheckBox();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.rtxtOut = new System.Windows.Forms.RichTextBox();
            this.chartOut = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.saveDia = new System.Windows.Forms.SaveFileDialog();
            this.btnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartOut)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPort
            // 
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(13, 13);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(121, 21);
            this.cmbPort.TabIndex = 0;
            this.cmbPort.Text = "Port";
            // 
            // cmbBaud
            // 
            this.cmbBaud.FormattingEnabled = true;
            this.cmbBaud.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400"});
            this.cmbBaud.Location = new System.Drawing.Point(12, 40);
            this.cmbBaud.Name = "cmbBaud";
            this.cmbBaud.Size = new System.Drawing.Size(121, 21);
            this.cmbBaud.TabIndex = 1;
            this.cmbBaud.Text = "Baud rate";
            // 
            // chkSave
            // 
            this.chkSave.AutoSize = true;
            this.chkSave.Location = new System.Drawing.Point(13, 68);
            this.chkSave.Name = "chkSave";
            this.chkSave.Size = new System.Drawing.Size(83, 17);
            this.chkSave.TabIndex = 2;
            this.chkSave.Text = "Save Data?";
            this.chkSave.UseVisualStyleBackColor = true;
            // 
            // txtLoc
            // 
            this.txtLoc.Location = new System.Drawing.Point(13, 92);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(121, 20);
            this.txtLoc.TabIndex = 3;
            this.txtLoc.Text = "Location";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(13, 119);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(120, 25);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 151);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(57, 45);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // rtxtOut
            // 
            this.rtxtOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtOut.Location = new System.Drawing.Point(141, 13);
            this.rtxtOut.Name = "rtxtOut";
            this.rtxtOut.Size = new System.Drawing.Size(450, 183);
            this.rtxtOut.TabIndex = 6;
            this.rtxtOut.Text = "";
            // 
            // chartOut
            // 
            this.chartOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartOut.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartOut.Legends.Add(legend1);
            this.chartOut.Location = new System.Drawing.Point(13, 203);
            this.chartOut.Name = "chartOut";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series3";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Series4";
            this.chartOut.Series.Add(series1);
            this.chartOut.Series.Add(series2);
            this.chartOut.Series.Add(series3);
            this.chartOut.Series.Add(series4);
            this.chartOut.Size = new System.Drawing.Size(578, 280);
            this.chartOut.TabIndex = 7;
            this.chartOut.Text = "chart1";
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(75, 152);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(57, 45);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 495);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.chartOut);
            this.Controls.Add(this.rtxtOut);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtLoc);
            this.Controls.Add(this.chkSave);
            this.Controls.Add(this.cmbBaud);
            this.Controls.Add(this.cmbPort);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Arduino Data Getter V2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.ComboBox cmbBaud;
        private System.Windows.Forms.CheckBox chkSave;
        private System.Windows.Forms.TextBox txtLoc;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox rtxtOut;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOut;
        private System.Windows.Forms.SaveFileDialog saveDia;
        private System.Windows.Forms.Button btnStop;
    }
}

