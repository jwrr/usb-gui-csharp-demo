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


namespace usb_gui
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            buttonLeft.Text = "\u2B9c";
            buttonCenter.Text = "\u2B9d";
            buttonRight.Text = "\u2B9e";
            groupBoxCommandLine.Visible = false;
            getAvailablePorts();
        }

        void enableConnectedWidgets()
        {
            buttonBackground.Enabled = true;
            buttonClear.Enabled = true;
            buttonLeft.Enabled = true;
            buttonLoad.Enabled = true;
            buttonCenter.Enabled = true;
            buttonReceive.Enabled = true;
            buttonRight.Enabled = true;
            buttonSend.Enabled = true;
            buttonStatus.Enabled = true;
            buttonTrig.Enabled = true;
            buttonLog.Enabled = true;
            commandLine.Enabled = true;
            consoleScreen.Enabled = true;
            comboBoxAvailablePorts.Enabled = false;
            buttonConnect.Enabled = false;
        }

        void getAvailablePorts()
        {
            string[] ports = SerialPort.GetPortNames();
            comboBoxAvailablePorts.Items.AddRange(ports);
            if (ports.Count() == 1)
            {
                comboBoxAvailablePorts.SelectedIndex = 0;
                buttonConnect.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            string portName = comboBoxAvailablePorts.Text;

            try
            {
                if (comboBoxAvailablePorts.Text == "")
                {
                    consoleScreen.AppendText("Port not selected" + Environment.NewLine);
                }
                else
                {
                    serialPort1.PortName = portName;
                    serialPort1.BaudRate = 9600;
                    serialPort1.Open();
                    enableConnectedWidgets();

                    consoleScreen.AppendText("Connected to " + portName + Environment.NewLine + "> ");
                    groupBoxConnect.Visible = false;
                    groupBoxCommandLine.Visible = true;
                    groupBoxLogo.Visible = true;
                    groupBoxButttons.Visible = true;
                    this.Text += " - " + portName;
                }
            }
            catch (UnauthorizedAccessException)
            {
                consoleScreen.AppendText("Error connecting to port '" + portName + "'" + Environment.NewLine);
            }
        }

        private string rcvFromDevice()
        {
            string rcvText = "";
            string tmpText = serialPort1.ReadExisting();
            while (tmpText != "")
            {
                rcvText += tmpText;
                tmpText = serialPort1.ReadExisting();
            }
            return rcvText;
        }

        private void sendCommandLine()
        {
            bool waitForAck = true;
            serialPort1.WriteLine(commandLine.Text + "\n\r");
            consoleScreen.AppendText(commandLine.Text + Environment.NewLine);
            string rcvText = rcvFromDevice();
            while (waitForAck && (rcvText == ""))
            {
                rcvText = rcvFromDevice();
            }
            if (rcvText != "")
            {
                rcvText = rcvText.Replace("\r", "");
                rcvText = rcvText.Replace("\n", Environment.NewLine);
                consoleScreen.AppendText(rcvText);
            }
            commandLine.Text = "";
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            sendCommandLine();
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
            sendCommandLine();
        }

        private void buttonCenter_Click(object sender, EventArgs e)
        {
            commandLine.Text = "s";
            sendCommandLine();
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            commandLine.Text = "d";
            sendCommandLine();
        }

        private void buttonTrig_Click(object sender, EventArgs e)
        {
            commandLine.Text = "f";
            sendCommandLine();
        }

        private void buttonBackground_Click(object sender, EventArgs e)
        {
            commandLine.Text = "b";
            sendCommandLine();
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


        private void buttonLoad_Click(object sender, EventArgs e)
        {
            commandLine.Text = "l";
            sendCommandLine();
            string[] samples = slurpFile();
            foreach (string sample in samples)
            {
                commandLine.Text = sample;
                sendCommandLine();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            commandLine.Text = "h";
            sendCommandLine();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            commandLine.Text = "c";
            sendCommandLine();
        }

        private void buttonStatus_Click(object sender, EventArgs e)
        {
            commandLine.Text = "status";
            sendCommandLine();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consoleScreen.Visible = !consoleScreen.Visible;
        }
    }
}
