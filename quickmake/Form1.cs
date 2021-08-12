using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ardu_get
{
    public partial class Form1 : Form
    {
        public delegate void AddDataDelegate(String myString);
        public AddDataDelegate myDelegate;

        SerialPort port = new SerialPort();
        public Form1()
        {
            InitializeComponent();
        }

        private SerialPort Make_Port()
        {
            SerialPort serPrt = new SerialPort(cmbPort.Text, Convert.ToInt32(cmbBaud.Text));
            return serPrt;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            port.PortName = cmbPort.Text; 
            port.BaudRate = Convert.ToInt32(cmbBaud.Text);
            port.DataReceived += new SerialDataReceivedEventHandler(DataRecievedHandler);
            port.Open();
            port.DiscardInBuffer();
            port.DiscardOutBuffer();
        }
        private void BtnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            port.DataReceived -= DataRecievedHandler;
            port.DiscardInBuffer();
            port.DiscardOutBuffer();
            port.Close();
            port.Dispose();
            chkChScroll.Checked = false;
            chkChScroll.Enabled = false;
            trackZoom.Value = 0;
        }
        public void PrintSave(String read)
        {
            if (read != "")
            {
                bool nope = false;
                int loop = 0;
                double testdbl = 0;
                try
                {
                    rtxtOut.AppendText(read + "\n");
                    string val = read;
                    string[] strarr = val.Split(',');
                    while (loop < strarr.Length)
                    {
                        if (double.TryParse(strarr[loop], out testdbl) == false)
                        {
                            nope = true;
                        }
                        loop = loop + 1;
                    }
                    if (nope == false)
                    {
                        double[] graphvals = Array.ConvertAll<string, double>(strarr, double.Parse);
                        int k = 0;
                        string name;
                        while (chartOut.Series.Count < graphvals.Length)
                        {

                            name = "Series" + (chartOut.Series.Count + 1).ToString();
                            chartOut.Series.Add(name);
                            if (btnSpline.Enabled == false)
                            {
                                chartOut.Series[name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                            }
                            else if (btnLine.Enabled == false)
                            {
                                chartOut.Series[name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                            }
                            else
                            {
                                chartOut.Series[name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                            }
                        }
                        while (k != graphvals.Length)
                        {
                            name = "Series" + (k + 1).ToString();
                            chartOut.Series[name].Points.AddY(graphvals[k]);
                            if (Convert.ToInt32(txtMaxPt.Text) > 0)
                            {
                                if (Convert.ToInt32(txtMaxPt.Text) < chartOut.Series[name].Points.Count)
                                {
                                    chartOut.Series[name].Points.RemoveAt(0);
                                }
                            }
                            k = k + 1;
                        }

                        if (chkChScroll.Checked)
                        {
                            chartOut.ChartAreas[0].AxisX.ScaleView.Scroll(System.Windows.Forms.DataVisualization.Charting.ScrollType.Last);
                        }

                    }
                }
                catch { }
            }
            if (chkSave.Checked)
            {
                try
                {
                    using (System.IO.StreamWriter sw = System.IO.File.AppendText(txtLoc.Text))
                    {
                        sw.Write(read + "\n");
                    }
                }
                catch (System.IO.DirectoryNotFoundException)
                {
                    rtxtOut.AppendText("Error... Invalid file location. Please check and try again!!!\n");
                }
            }
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            SaveFileDialog Save1 = new SaveFileDialog();
            Save1.Filter = "Text file (*.txt)|*.txt|CSV File (*.csv)|*.csv|All Files (*.*)|*.*";
            Save1.DefaultExt = ".txt";
            Save1.OverwritePrompt = false;
            Save1.AddExtension = true;
            Save1.ShowDialog();
            txtLoc.Text = Save1.FileName;
        }

        private void DataRecievedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            try
            {
                string data = sp.ReadLine();
                Invoke(this.myDelegate, new Object[] { data });
                
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.myDelegate = new AddDataDelegate(PrintSave);
        }

        private void BtnClearChart_Click(object sender, EventArgs e)
        {
            chartOut.Series.Clear();
        }

        private void BtnClearTxt_Click(object sender, EventArgs e)
        {
            rtxtOut.Text = "";
        }

        private void TrackZoom_Scroll(object sender, EventArgs e)
        {
            int zoom = trackZoom.Value;
            if (zoom == 0)
            {
                chartOut.ChartAreas[0].AxisX.ScaleView.ZoomReset();
                chkChScroll.Checked = false;
                chkChScroll.Enabled = false;
            }
            else
            {
                int num = Convert.ToInt32(chartOut.ChartAreas[0].AxisX.Maximum);
                zoom = (-num/10)*zoom+num;
                chartOut.ChartAreas[0].AxisX.ScaleView.Zoom(0,zoom);
                chkChScroll.Enabled = true;
            }
            
        }

        private void BtnSpline_Click(object sender, EventArgs e)
        {
            btnSpline.Enabled = false;
            btnLine.Enabled = true;
            btnScatter.Enabled = true;
            if (chartOut.Series.Count!=0)
            {
                for (int i = 0; i < chartOut.Series.Count; i++ )
                {
                    chartOut.Series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                }
            }
        }

        private void BtnLine_Click(object sender, EventArgs e)
        {
            btnSpline.Enabled = true;
            btnLine.Enabled = false;
            btnScatter.Enabled = true;
            if (chartOut.Series.Count != 0)
            {
                for (int i = 0; i < chartOut.Series.Count; i++)
                {
                    chartOut.Series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                }
            }
        }

        private void BtnScatter_Click(object sender, EventArgs e)
        {
            btnSpline.Enabled = true;
            btnLine.Enabled = true;
            btnScatter.Enabled = false;
            if (chartOut.Series.Count != 0)
            {
                for (int i = 0; i < chartOut.Series.Count; i++)
                {
                    chartOut.Series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                }
            }
        }

        private void CmbPort_DropDown(object sender, EventArgs e)
        {
            cmbPort.Items.Clear();
            cmbPort.Items.AddRange(SerialPort.GetPortNames());
        }
    }
}
