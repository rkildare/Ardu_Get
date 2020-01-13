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

namespace quickmake
{
    public partial class Form1 : Form
    {
        public delegate void AddDataDelegate(String myString);
        public AddDataDelegate myDelegate;

        SerialPort port = new SerialPort();
        public Form1()
        {
            InitializeComponent();
            cmbPort.Items.AddRange(SerialPort.GetPortNames());
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
            port.Close();
            port.Dispose();
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
                        if (graphvals.Length >= 1) { chartOut.Series["Series1"].Points.AddY(graphvals[0]); }
                        if (graphvals.Length >= 2) { chartOut.Series["Series2"].Points.AddY(graphvals[1]); }
                        if (graphvals.Length >= 3) { chartOut.Series["Series3"].Points.AddY(graphvals[2]); }
                        if (graphvals.Length >= 4) { chartOut.Series["Series4"].Points.AddY(graphvals[3]); }
                    }
                }
                catch
                {

                }
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
                Console.WriteLine("recieved data:" + data);
                Invoke(this.myDelegate, new Object[] { data });
                
            }
            catch
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.myDelegate = new AddDataDelegate(PrintSave);
        }
    }
}
