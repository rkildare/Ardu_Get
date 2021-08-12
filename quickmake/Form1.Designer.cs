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
            this.btnClearChart = new System.Windows.Forms.Button();
            this.btnClearTxt = new System.Windows.Forms.Button();
            this.btnScatter = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnSpline = new System.Windows.Forms.Button();
            this.trackZoom = new System.Windows.Forms.TrackBar();
            this.chkChScroll = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackZoom)).BeginInit();
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
            this.rtxtOut.Location = new System.Drawing.Point(140, 13);
            this.rtxtOut.Name = "rtxtOut";
            this.rtxtOut.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtxtOut.Size = new System.Drawing.Size(451, 183);
            this.rtxtOut.TabIndex = 6;
            this.rtxtOut.Text = "";
            // 
            // chartOut
            // 
            this.chartOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            chartArea1.CursorX.AutoScroll = false;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.chartOut.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartOut.Legends.Add(legend1);
            this.chartOut.Location = new System.Drawing.Point(13, 203);
            this.chartOut.Name = "chartOut";
            this.chartOut.Size = new System.Drawing.Size(578, 251);
            this.chartOut.TabIndex = 7;
            this.chartOut.Text = "chart1";
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(75, 152);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(57, 44);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // btnClearChart
            // 
            this.btnClearChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearChart.Location = new System.Drawing.Point(521, 460);
            this.btnClearChart.Name = "btnClearChart";
            this.btnClearChart.Size = new System.Drawing.Size(70, 23);
            this.btnClearChart.TabIndex = 9;
            this.btnClearChart.Text = "Clear Chart";
            this.btnClearChart.UseVisualStyleBackColor = true;
            this.btnClearChart.Click += new System.EventHandler(this.BtnClearChart_Click);
            // 
            // btnClearTxt
            // 
            this.btnClearTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearTxt.Location = new System.Drawing.Point(445, 460);
            this.btnClearTxt.Name = "btnClearTxt";
            this.btnClearTxt.Size = new System.Drawing.Size(70, 23);
            this.btnClearTxt.TabIndex = 10;
            this.btnClearTxt.Text = "Clear Text";
            this.btnClearTxt.UseVisualStyleBackColor = true;
            this.btnClearTxt.Click += new System.EventHandler(this.BtnClearTxt_Click);
            // 
            // btnScatter
            // 
            this.btnScatter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnScatter.Location = new System.Drawing.Point(12, 460);
            this.btnScatter.Name = "btnScatter";
            this.btnScatter.Size = new System.Drawing.Size(75, 23);
            this.btnScatter.TabIndex = 11;
            this.btnScatter.Text = "Scatter";
            this.btnScatter.UseVisualStyleBackColor = true;
            this.btnScatter.Click += new System.EventHandler(this.BtnScatter_Click);
            // 
            // btnLine
            // 
            this.btnLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLine.Location = new System.Drawing.Point(93, 460);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(75, 23);
            this.btnLine.TabIndex = 11;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.BtnLine_Click);
            // 
            // btnSpline
            // 
            this.btnSpline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSpline.Enabled = false;
            this.btnSpline.Location = new System.Drawing.Point(174, 460);
            this.btnSpline.Name = "btnSpline";
            this.btnSpline.Size = new System.Drawing.Size(75, 23);
            this.btnSpline.TabIndex = 11;
            this.btnSpline.Text = "Spline";
            this.btnSpline.UseVisualStyleBackColor = true;
            this.btnSpline.Click += new System.EventHandler(this.BtnSpline_Click);
            // 
            // trackZoom
            // 
            this.trackZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackZoom.Location = new System.Drawing.Point(255, 460);
            this.trackZoom.Name = "trackZoom";
            this.trackZoom.Size = new System.Drawing.Size(163, 45);
            this.trackZoom.TabIndex = 12;
            this.trackZoom.Scroll += new System.EventHandler(this.TrackZoom_Scroll);
            // 
            // chkChScroll
            // 
            this.chkChScroll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkChScroll.AutoSize = true;
            this.chkChScroll.Enabled = false;
            this.chkChScroll.Location = new System.Drawing.Point(424, 465);
            this.chkChScroll.Name = "chkChScroll";
            this.chkChScroll.Size = new System.Drawing.Size(15, 14);
            this.chkChScroll.TabIndex = 13;
            this.chkChScroll.UseVisualStyleBackColor = true;
            this.chkChScroll.CheckedChanged += new System.EventHandler(this.ChkChScroll_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 495);
            this.Controls.Add(this.chkChScroll);
            this.Controls.Add(this.trackZoom);
            this.Controls.Add(this.btnSpline);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.btnScatter);
            this.Controls.Add(this.btnClearTxt);
            this.Controls.Add(this.btnClearChart);
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
            this.Text = "Arduino Data Getter V1.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackZoom)).EndInit();
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
        private System.Windows.Forms.Button btnClearChart;
        private System.Windows.Forms.Button btnClearTxt;
        private System.Windows.Forms.Button btnScatter;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnSpline;
        private System.Windows.Forms.TrackBar trackZoom;
        private System.Windows.Forms.CheckBox chkChScroll;
    }
}

