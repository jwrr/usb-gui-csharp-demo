using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;

namespace usb_gui
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 500;
            buttonLeft.Text = "\u2B9c";
            buttonCenter.Text = "\u2B9d";
            buttonRight.Text = "\u2B9e";
            getAvailablePorts();
            comboBoxMode0.SelectedIndex = 0;
            comboBoxMode1.SelectedIndex = 0;
        }

        bool getAvailablePorts()
        {
            timer1.Stop();
            bool fail = false;
            this.Text = this.Text.Split('-')[0];
            this.Text = this.Text.Trim();
            groupBoxFlash.Visible = false;
            groupBoxUSB.Visible = false;
            consoleScreen.Visible = false;
            groupBoxLogo.Visible = false;
            groupBoxMiddle.Visible = false;
            groupBoxConnect.Visible = true;
            buttonRefresh.Visible = true;
            buttonRefresh.Enabled = true;
            buttonConnect.Visible = false;
            comboBoxAvailablePorts.Items.Clear();
            string[] ports = SerialPort.GetPortNames();

            string portName = serialPort1.PortName;

            // the ports list contains the current port, but the
            // current port close (for some reason). Check to see
            // if the port can be opened. If its not the mark it
            // as not connected.
            bool openSuccess = true;
            if (ports.Contains(portName))
            {
                serialPort1.Close();
                openSuccess = OpenSerialPort(portName);
                if (openSuccess)
                {
                    serialPort1.Close();
                }
                else
                {
                    int i = Array.IndexOf(ports, portName);
                    ports[i] += " Not Connected";
                    fail = true;
                }
            }

            int portsCount = ports.Count();
            if (portsCount == 0)
            {
                Array.Resize(ref ports, 1);    
                ports[0] = "No Ports Found";
                fail = true;
            }
            comboBoxAvailablePorts.Items.AddRange(ports);
            comboBoxAvailablePorts.SelectedIndex = 0;
            buttonConnect.Visible = (portsCount > 1) || (portsCount == 1 && openSuccess);
            bool success = !fail;
            return success;
        }

        void handleDisconnect()
        {
            getAvailablePorts();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private bool OpenSerialPort(string portName)
        {
            bool success = false;
            try
            {
                serialPort1.PortName = portName;
                serialPort1.BaudRate = 9600;
                serialPort1.Open();
                success = true;
            }
            catch (UnauthorizedAccessException)
            {
                success = false;
            }
            catch (IOException)
            {
                success = false;
            }
            return success;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            string portName = comboBoxAvailablePorts.Text;
            bool success = OpenSerialPort(portName);
            if (success)
            {
                groupBoxConnect.Visible = false;
                groupBoxViewOptions.Visible = true;
                buttonUSBOption.BackColor = Color.Gray;
                groupBoxUSB.Visible = true;
                groupBoxLogo.Visible = true;
                groupBoxFlash.Visible = true;
                groupBoxMiddle.Visible = true;
                groupBoxConfig.Visible = true;
                consoleScreen.Enabled = true;
                consoleScreen.AppendText("Connected to " + portName + Environment.NewLine + "=> ");
                this.Text += " - " + portName;
                getStatus();
            }
        }

        private void rcvFromDevice(string rxTerminationStr = "", bool updateStatusBox = false)
        {
            if (updateStatusBox)
            {
                textBoxStatus.Clear();
            }
            bool rxTerminatorFound = false;
            while (!rxTerminatorFound)
            {
                string rxStr = "";
                try
                {
                    rxStr = serialPort1.ReadExisting();
                }
                catch
                {
                    handleDisconnect();
                }
                if (rxStr != "")
                {
                    rxTerminatorFound = rxStr.Contains(rxTerminationStr);
                    rxStr = rxStr.Replace("\r", "");
                    rxStr = rxStr.Replace("\n", Environment.NewLine);
                    if (consoleScreen.Enabled)
                    {
                        consoleScreen.AppendText(rxStr);
                    }
                    if (updateStatusBox)
                    {
                        rxStr = rxStr.Replace(Environment.NewLine + "                  " +Environment.NewLine+"=>", "");
                        textBoxStatus.AppendText(rxStr);
                    }
                }
            }
        }

        private void sendCommandLine(string rxTerminationStr = G_prompt, bool updateStatusBox = false)
        {
            try
            {
                serialPort1.WriteLine(commandLine.Text + "\n\r"); // FIXME try/catch needed to handle disconnect excepion System.InvalidOperationException: 'The port is closed.'
            }
            catch
            {
                handleDisconnect();
            }

            if (consoleScreen.Enabled)
            {
                consoleScreen.AppendText(commandLine.Text + Environment.NewLine);
            }
            rcvFromDevice(rxTerminationStr, updateStatusBox);
            commandLine.Text = "";
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            sendCommandLine(G_prompt);
            getStatus();
        }

        private void buttonReceive_Click(object sender, EventArgs e)
        {
            try
            {
                string rcvText = serialPort1.ReadExisting();
                consoleScreen.AppendText(rcvText + Environment.NewLine);
            }
            catch (TimeoutException)
            {
                consoleScreen.AppendText("Timeout" + Environment.NewLine);
            }
        }

        private void commandLine_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            commandLine.Text = "a";
            sendCommandLine(G_prompt);
            getStatus();
        }

        private void buttonCenter_Click(object sender, EventArgs e)
        {
            commandLine.Text = "s";
            sendCommandLine(G_prompt);
            getStatus();
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            commandLine.Text = "d";
            sendCommandLine(G_prompt);
            getStatus();
        }

        private void buttonTrig_Click(object sender, EventArgs e)
        {
            commandLine.Text = "f";
            sendCommandLine(G_prompt);
            getStatus();
        }

        private void buttonBackground_Click(object sender, EventArgs e)
        {
            commandLine.Text = "b";
            if (textBoxStatus.BackColor == Color.Black)
            {
                textBoxStatus.BackColor = Color.White;
                textBoxStatus.ForeColor = Color.Black;
            }
            else
            {
                textBoxStatus.BackColor = Color.Black;
                textBoxStatus.ForeColor = Color.White;
            }

            sendCommandLine(G_prompt);
        }

        private string[] slurpFile()
        {
            string[] lines = {};
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    lines = File.ReadAllLines(file);
                }
                catch (IOException)
                {
                }
            }
            return lines;
        }

        private RadioButton GetCheckedRadio(Control container)
        {
            foreach (var c in container.Controls)
            {
                RadioButton r = c as RadioButton;
                if (r != null && r.Checked)
                {
                    return r;
                }
            }
            return null;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            RadioButton r = GetCheckedRadio(groupBoxFlash);
            if (r == null) return;

            string mode = r.Text;
            commandLine.Text = mode;
            sendCommandLine(G_prompt);
            getStatus();

            commandLine.Text = "l";
            sendCommandLine(G_prompt);
            string[] samples = slurpFile();
            foreach (string sample in samples)
            {
                commandLine.Text = sample;
                sendCommandLine(G_prompt);
            }
            getStatus();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        { // erase wave
            commandLine.Text = "e";
            sendCommandLine(G_prompt);
        }

        private void getStatus(bool consoleScreenEnabled = false)
        {
            Boolean orig = consoleScreen.Enabled;
            consoleScreen.Enabled = consoleScreenEnabled;
            commandLine.Text = "status";
            sendCommandLine(G_prompt,true);
            consoleScreen.Enabled = orig;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            bool success = getAvailablePorts();
        }

        private void button1_Click_1(object sender, EventArgs e)
        { // close
            serialPort1.Close();
            handleDisconnect();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            getStatus();
        }

        private void PlotWaveform()
        {
            //DataSet ds = new DataSet();

            //chartWaveform.
        }

        private void button1_Click_2(object sender, EventArgs e)
        { // View Wave
            commandLine.Text = "v";
            sendCommandLine(G_prompt);
            buttonUSBOption.BackColor = Color.Gainsboro;
            buttonWavesOption.BackColor = Color.Gainsboro;
            buttonConfigOption.BackColor = Color.Gainsboro;
            buttonLog.BackColor = Color.Gray;
            consoleScreen.BringToFront();
            consoleScreen.Visible = false;
            PlotWaveform();

            string[] lines = consoleScreen.Text.Split('\n');
            int len = lines.Length;
            textBoxWave.Text = lines[len-2];

            string[] samplesString = textBoxWave.Text.Split(',');
            List<int> samplesInt = new List<int>();
            for (int i = 0; i < samplesString.Length; i++)
            {
                samplesInt.Add(Int32.Parse(samplesString[i]));
            }

            chartWaveform.Series.Clear();
            var series = new Series("Waveform");
            series.Points.DataBindY(samplesInt);
            chartWaveform.Series.Add(series);
        }

        private void groupBoxLogo_Enter(object sender, EventArgs e)
        {

        }

        private void buttonTimer_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        private void buttonStatus_Click(object sender, EventArgs e)
        {
            getStatus();
        }

        private void buttonTrig_KeyUp(object sender, KeyEventArgs e)
        {
            commandLine.Text = "f";
            sendCommandLine(G_prompt);
            getStatus();
        }

        private void buttonTrig_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Start();
            commandLine.Text = "f";
            sendCommandLine(G_prompt);
            getStatus();
        }

        private void buttonTrig_MouseDown(object sender, MouseEventArgs e)
        {
            commandLine.Text = "f";
            sendCommandLine(G_prompt);
            getStatus();
            timer1.Start();
        }

        private void commandLine_Enter(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonTrig_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonMode_Click(object sender, EventArgs e)
        {
            commandLine.Text = comboBoxMode0.Text;
            sendCommandLine(G_prompt);
            commandLine.Text = comboBoxMode1.Text;
            sendCommandLine(G_prompt);
            getStatus();
        }

        private void comboBoxMode0_SelectionChangeCommitted(object sender, EventArgs e)
        {
            commandLine.Text = comboBoxMode0.Text;
            sendCommandLine(G_prompt);
            getStatus();
        }

        private void comboBoxMode1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            commandLine.Text = comboBoxMode1.Text;
            sendCommandLine(G_prompt);
            getStatus();
        }

        private void buttonFlashOption_Click(object sender, EventArgs e)
        { // now WavesOption
            buttonUSBOption.BackColor = Color.Gainsboro;
            buttonWavesOption.BackColor = Color.Gray;
            buttonConfigOption.BackColor = Color.Gainsboro;
            buttonLog.BackColor = Color.Gainsboro;
            groupBoxFlash.BringToFront();
            consoleScreen.Visible = false;
        }

        private void buttonUSBOption_Click(object sender, EventArgs e)
        {
            buttonUSBOption.BackColor = Color.Gray;
            buttonWavesOption.BackColor = Color.Gainsboro;
            buttonConfigOption.BackColor = Color.Gainsboro;
            groupBoxUSB.BringToFront();
            consoleScreen.BringToFront();
            consoleScreen.Visible = true;
        }

        private void buttonConfigOption_Click(object sender, EventArgs e)
        {
            buttonUSBOption.BackColor = Color.Gainsboro;
            buttonWavesOption.BackColor = Color.Gainsboro;
            buttonConfigOption.BackColor = Color.Gray;
            buttonLog.BackColor = Color.Gainsboro;
            groupBoxConfig.BringToFront();
            consoleScreen.Visible = false;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            buttonUSBOption.BackColor = Color.Gainsboro;
            buttonWavesOption.BackColor = Color.Gainsboro;
            buttonConfigOption.BackColor = Color.Gainsboro;
            buttonLog.BackColor = Color.Gray;
            consoleScreen.BringToFront();
            consoleScreen.Visible = !consoleScreen.Visible;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
