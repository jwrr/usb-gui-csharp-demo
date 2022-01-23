﻿namespace usb_gui
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxAvailablePorts = new System.Windows.Forms.ComboBox();
            this.commandLine = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonCenter = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonTrig = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonBackground = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.buttonConnect = new System.Windows.Forms.Button();
            this.groupBoxConnect = new System.Windows.Forms.GroupBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.groupBoxFlash = new System.Windows.Forms.GroupBox();
            this.checkBoxConfig = new System.Windows.Forms.CheckBox();
            this.checkBoxViewConsole = new System.Windows.Forms.CheckBox();
            this.checkBoxViewWaves = new System.Windows.Forms.CheckBox();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.buttonEraseAll = new System.Windows.Forms.Button();
            this.chartWaveform = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxWave = new System.Windows.Forms.TextBox();
            this.groupBoxLogo = new System.Windows.Forms.GroupBox();
            this.groupBoxMiddle = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.consoleScreen = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonMode = new System.Windows.Forms.Button();
            this.comboBoxMode1 = new System.Windows.Forms.ComboBox();
            this.comboBoxMode0 = new System.Windows.Forms.ComboBox();
            this.toolTipTrigger = new System.Windows.Forms.ToolTip(this.components);
            this.buttonConfigOption = new System.Windows.Forms.Button();
            this.buttonWavesOption = new System.Windows.Forms.Button();
            this.buttonUSBOption = new System.Windows.Forms.Button();
            this.groupBoxConfig = new System.Windows.Forms.GroupBox();
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonTimer = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxConsole = new System.Windows.Forms.GroupBox();
            this.groupBoxWaves = new System.Windows.Forms.GroupBox();
            this.buttonViewNext = new System.Windows.Forms.Button();
            this.groupBoxConnect.SuspendLayout();
            this.groupBoxFlash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWaveform)).BeginInit();
            this.groupBoxMiddle.SuspendLayout();
            this.groupBoxConfig.SuspendLayout();
            this.groupBoxConsole.SuspendLayout();
            this.groupBoxWaves.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxAvailablePorts
            // 
            this.comboBoxAvailablePorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAvailablePorts.FormattingEnabled = true;
            this.comboBoxAvailablePorts.Location = new System.Drawing.Point(94, 21);
            this.comboBoxAvailablePorts.Name = "comboBoxAvailablePorts";
            this.comboBoxAvailablePorts.Size = new System.Drawing.Size(312, 28);
            this.comboBoxAvailablePorts.TabIndex = 0;
            this.comboBoxAvailablePorts.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // commandLine
            // 
            this.commandLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commandLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandLine.Location = new System.Drawing.Point(11, 697);
            this.commandLine.Name = "commandLine";
            this.commandLine.Size = new System.Drawing.Size(873, 30);
            this.commandLine.TabIndex = 2;
            this.commandLine.TextChanged += new System.EventHandler(this.commandLine_TextChanged);
            this.commandLine.Enter += new System.EventHandler(this.commandLine_Enter);
            // 
            // buttonSend
            // 
            this.buttonSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSend.BackColor = System.Drawing.Color.Gray;
            this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSend.Location = new System.Drawing.Point(906, 697);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(102, 30);
            this.buttonSend.TabIndex = 3;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackColor = System.Drawing.Color.Gray;
            this.buttonLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeft.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLeft.Location = new System.Drawing.Point(15, 312);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(101, 53);
            this.buttonLeft.TabIndex = 5;
            this.buttonLeft.Text = "<-";
            this.buttonLeft.UseVisualStyleBackColor = false;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonCenter
            // 
            this.buttonCenter.BackColor = System.Drawing.Color.Gray;
            this.buttonCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCenter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCenter.Location = new System.Drawing.Point(122, 312);
            this.buttonCenter.Name = "buttonCenter";
            this.buttonCenter.Size = new System.Drawing.Size(102, 53);
            this.buttonCenter.TabIndex = 6;
            this.buttonCenter.Text = "^";
            this.buttonCenter.UseVisualStyleBackColor = false;
            this.buttonCenter.Click += new System.EventHandler(this.buttonCenter_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.BackColor = System.Drawing.Color.Gray;
            this.buttonRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRight.Location = new System.Drawing.Point(230, 312);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(102, 53);
            this.buttonRight.TabIndex = 7;
            this.buttonRight.Text = "->";
            this.buttonRight.UseVisualStyleBackColor = false;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonTrig
            // 
            this.buttonTrig.BackColor = System.Drawing.Color.Gray;
            this.buttonTrig.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrig.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTrig.Location = new System.Drawing.Point(94, 374);
            this.buttonTrig.Name = "buttonTrig";
            this.buttonTrig.Size = new System.Drawing.Size(166, 83);
            this.buttonTrig.TabIndex = 8;
            this.buttonTrig.Text = "TRIGGER";
            this.buttonTrig.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTipTrigger.SetToolTip(this.buttonTrig, "Press, Hold and then Release");
            this.buttonTrig.UseVisualStyleBackColor = false;
            this.buttonTrig.Click += new System.EventHandler(this.buttonTrig_Click_1);
            this.buttonTrig.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonTrig_MouseDown);
            this.buttonTrig.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonTrig_MouseUp);
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.Gray;
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLoad.Location = new System.Drawing.Point(23, 21);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(99, 92);
            this.buttonLoad.TabIndex = 9;
            this.buttonLoad.Text = "Load Wave";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Gray;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClear.Location = new System.Drawing.Point(23, 132);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(99, 92);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Erase Wave";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonBackground
            // 
            this.buttonBackground.BackColor = System.Drawing.Color.Black;
            this.buttonBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackground.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBackground.Location = new System.Drawing.Point(47, 126);
            this.buttonBackground.Name = "buttonBackground";
            this.buttonBackground.Size = new System.Drawing.Size(119, 114);
            this.buttonBackground.TabIndex = 13;
            this.buttonBackground.Text = "BLACK / WHITE";
            this.buttonBackground.UseVisualStyleBackColor = false;
            this.buttonBackground.Click += new System.EventHandler(this.buttonBackground_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonConnect.Location = new System.Drawing.Point(253, 64);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(153, 51);
            this.buttonConnect.TabIndex = 14;
            this.buttonConnect.Text = "CONNECT";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // groupBoxConnect
            // 
            this.groupBoxConnect.Controls.Add(this.buttonRefresh);
            this.groupBoxConnect.Controls.Add(this.comboBoxAvailablePorts);
            this.groupBoxConnect.Controls.Add(this.buttonConnect);
            this.groupBoxConnect.Location = new System.Drawing.Point(6, 19);
            this.groupBoxConnect.Name = "groupBoxConnect";
            this.groupBoxConnect.Size = new System.Drawing.Size(484, 144);
            this.groupBoxConnect.TabIndex = 15;
            this.groupBoxConnect.TabStop = false;
            this.groupBoxConnect.Text = "Connect";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRefresh.Location = new System.Drawing.Point(94, 64);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(153, 51);
            this.buttonRefresh.TabIndex = 15;
            this.buttonRefresh.Text = "REFRESH";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // groupBoxFlash
            // 
            this.groupBoxFlash.Controls.Add(this.checkBoxConfig);
            this.groupBoxFlash.Controls.Add(this.checkBoxViewConsole);
            this.groupBoxFlash.Controls.Add(this.checkBoxViewWaves);
            this.groupBoxFlash.Controls.Add(this.radioButton9);
            this.groupBoxFlash.Controls.Add(this.radioButton8);
            this.groupBoxFlash.Controls.Add(this.radioButton7);
            this.groupBoxFlash.Controls.Add(this.radioButton6);
            this.groupBoxFlash.Controls.Add(this.radioButton5);
            this.groupBoxFlash.Controls.Add(this.radioButton4);
            this.groupBoxFlash.Controls.Add(this.radioButton3);
            this.groupBoxFlash.Controls.Add(this.radioButton2);
            this.groupBoxFlash.Controls.Add(this.radioButton1);
            this.groupBoxFlash.Controls.Add(this.buttonEraseAll);
            this.groupBoxFlash.Controls.Add(this.buttonLoad);
            this.groupBoxFlash.Controls.Add(this.buttonClear);
            this.groupBoxFlash.Location = new System.Drawing.Point(359, 19);
            this.groupBoxFlash.Name = "groupBoxFlash";
            this.groupBoxFlash.Size = new System.Drawing.Size(217, 450);
            this.groupBoxFlash.TabIndex = 17;
            this.groupBoxFlash.TabStop = false;
            this.groupBoxFlash.Visible = false;
            // 
            // checkBoxConfig
            // 
            this.checkBoxConfig.AutoSize = true;
            this.checkBoxConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxConfig.Location = new System.Drawing.Point(24, 415);
            this.checkBoxConfig.Name = "checkBoxConfig";
            this.checkBoxConfig.Size = new System.Drawing.Size(139, 29);
            this.checkBoxConfig.TabIndex = 37;
            this.checkBoxConfig.Text = "View Config";
            this.checkBoxConfig.UseVisualStyleBackColor = true;
            this.checkBoxConfig.CheckedChanged += new System.EventHandler(this.checkBoxConfig_CheckedChanged);
            // 
            // checkBoxViewConsole
            // 
            this.checkBoxViewConsole.AutoSize = true;
            this.checkBoxViewConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxViewConsole.Location = new System.Drawing.Point(24, 380);
            this.checkBoxViewConsole.Name = "checkBoxViewConsole";
            this.checkBoxViewConsole.Size = new System.Drawing.Size(155, 29);
            this.checkBoxViewConsole.TabIndex = 36;
            this.checkBoxViewConsole.Text = "View Console";
            this.checkBoxViewConsole.UseVisualStyleBackColor = true;
            this.checkBoxViewConsole.CheckedChanged += new System.EventHandler(this.checkBoxViewConsole_CheckedChanged);
            // 
            // checkBoxViewWaves
            // 
            this.checkBoxViewWaves.AutoSize = true;
            this.checkBoxViewWaves.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxViewWaves.Location = new System.Drawing.Point(24, 350);
            this.checkBoxViewWaves.Name = "checkBoxViewWaves";
            this.checkBoxViewWaves.Size = new System.Drawing.Size(144, 29);
            this.checkBoxViewWaves.TabIndex = 35;
            this.checkBoxViewWaves.Text = "View Waves";
            this.checkBoxViewWaves.UseVisualStyleBackColor = true;
            this.checkBoxViewWaves.CheckedChanged += new System.EventHandler(this.checkBoxViewWaves_CheckedChanged);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton9.Location = new System.Drawing.Point(147, 294);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(39, 24);
            this.radioButton9.TabIndex = 33;
            this.radioButton9.Text = "8";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton8.Location = new System.Drawing.Point(147, 268);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(39, 24);
            this.radioButton8.TabIndex = 32;
            this.radioButton8.Text = "7";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton7.Location = new System.Drawing.Point(147, 242);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(39, 24);
            this.radioButton7.TabIndex = 31;
            this.radioButton7.Text = "6";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton6.Location = new System.Drawing.Point(147, 182);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(39, 24);
            this.radioButton6.TabIndex = 30;
            this.radioButton6.Text = "5";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(147, 158);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(39, 24);
            this.radioButton5.TabIndex = 29;
            this.radioButton5.Text = "4";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(147, 132);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(39, 24);
            this.radioButton4.TabIndex = 28;
            this.radioButton4.Text = "3";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(147, 73);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(39, 24);
            this.radioButton3.TabIndex = 27;
            this.radioButton3.Text = "2";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(147, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(39, 24);
            this.radioButton2.TabIndex = 26;
            this.radioButton2.Text = "1";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(147, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(39, 24);
            this.radioButton1.TabIndex = 25;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "0";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // buttonEraseAll
            // 
            this.buttonEraseAll.BackColor = System.Drawing.Color.Gray;
            this.buttonEraseAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEraseAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEraseAll.Location = new System.Drawing.Point(23, 241);
            this.buttonEraseAll.Name = "buttonEraseAll";
            this.buttonEraseAll.Size = new System.Drawing.Size(99, 88);
            this.buttonEraseAll.TabIndex = 21;
            this.buttonEraseAll.Text = "Erase All";
            this.buttonEraseAll.UseVisualStyleBackColor = false;
            this.buttonEraseAll.Click += new System.EventHandler(this.buttonEraseAll_Click);
            // 
            // chartWaveform
            // 
            this.chartWaveform.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartWaveform.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartWaveform.Legends.Add(legend1);
            this.chartWaveform.Location = new System.Drawing.Point(17, 41);
            this.chartWaveform.Name = "chartWaveform";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartWaveform.Series.Add(series1);
            this.chartWaveform.Size = new System.Drawing.Size(997, 292);
            this.chartWaveform.TabIndex = 0;
            this.chartWaveform.Text = "chart1";
            // 
            // textBoxWave
            // 
            this.textBoxWave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWave.Location = new System.Drawing.Point(144, 339);
            this.textBoxWave.Multiline = true;
            this.textBoxWave.Name = "textBoxWave";
            this.textBoxWave.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxWave.Size = new System.Drawing.Size(876, 105);
            this.textBoxWave.TabIndex = 34;
            // 
            // groupBoxLogo
            // 
            this.groupBoxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxLogo.BackgroundImage")));
            this.groupBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxLogo.Location = new System.Drawing.Point(6, 475);
            this.groupBoxLogo.Name = "groupBoxLogo";
            this.groupBoxLogo.Size = new System.Drawing.Size(570, 234);
            this.groupBoxLogo.TabIndex = 18;
            this.groupBoxLogo.TabStop = false;
            this.groupBoxLogo.Visible = false;
            this.groupBoxLogo.Enter += new System.EventHandler(this.groupBoxLogo_Enter);
            // 
            // groupBoxMiddle
            // 
            this.groupBoxMiddle.Controls.Add(this.textBox1);
            this.groupBoxMiddle.Controls.Add(this.textBoxStatus);
            this.groupBoxMiddle.Controls.Add(this.buttonRight);
            this.groupBoxMiddle.Controls.Add(this.buttonCenter);
            this.groupBoxMiddle.Controls.Add(this.buttonTrig);
            this.groupBoxMiddle.Controls.Add(this.buttonLeft);
            this.groupBoxMiddle.Location = new System.Drawing.Point(6, 12);
            this.groupBoxMiddle.Name = "groupBoxMiddle";
            this.groupBoxMiddle.Size = new System.Drawing.Size(347, 457);
            this.groupBoxMiddle.TabIndex = 22;
            this.groupBoxMiddle.TabStop = false;
            this.groupBoxMiddle.Text = "Status";
            this.groupBoxMiddle.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(109, 414);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(138, 23);
            this.textBox1.TabIndex = 26;
            this.textBox1.Text = "(click and hold)";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStatus.Location = new System.Drawing.Point(41, 21);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(263, 272);
            this.textBoxStatus.TabIndex = 21;
            // 
            // consoleScreen
            // 
            this.consoleScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleScreen.Location = new System.Drawing.Point(11, 22);
            this.consoleScreen.MaxLength = 65535;
            this.consoleScreen.Multiline = true;
            this.consoleScreen.Name = "consoleScreen";
            this.consoleScreen.ReadOnly = true;
            this.consoleScreen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleScreen.Size = new System.Drawing.Size(997, 669);
            this.consoleScreen.TabIndex = 1;
            this.consoleScreen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // buttonMode
            // 
            this.buttonMode.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMode.Location = new System.Drawing.Point(95, 436);
            this.buttonMode.Name = "buttonMode";
            this.buttonMode.Size = new System.Drawing.Size(214, 51);
            this.buttonMode.TabIndex = 17;
            this.buttonMode.Text = "Send Config";
            this.buttonMode.UseVisualStyleBackColor = false;
            this.buttonMode.Click += new System.EventHandler(this.buttonMode_Click);
            // 
            // comboBoxMode1
            // 
            this.comboBoxMode1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMode1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMode1.FormattingEnabled = true;
            this.comboBoxMode1.Items.AddRange(new object[] {
            "DDDD",
            "EEEE",
            "FFFF"});
            this.comboBoxMode1.Location = new System.Drawing.Point(94, 397);
            this.comboBoxMode1.Name = "comboBoxMode1";
            this.comboBoxMode1.Size = new System.Drawing.Size(215, 33);
            this.comboBoxMode1.TabIndex = 1;
            this.comboBoxMode1.SelectionChangeCommitted += new System.EventHandler(this.comboBoxMode1_SelectionChangeCommitted);
            // 
            // comboBoxMode0
            // 
            this.comboBoxMode0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMode0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMode0.FormattingEnabled = true;
            this.comboBoxMode0.Items.AddRange(new object[] {
            "AAAA",
            "BBBB",
            "CCCC"});
            this.comboBoxMode0.Location = new System.Drawing.Point(95, 358);
            this.comboBoxMode0.Name = "comboBoxMode0";
            this.comboBoxMode0.Size = new System.Drawing.Size(214, 33);
            this.comboBoxMode0.TabIndex = 0;
            this.comboBoxMode0.SelectionChangeCommitted += new System.EventHandler(this.comboBoxMode0_SelectionChangeCommitted);
            // 
            // buttonConfigOption
            // 
            this.buttonConfigOption.BackColor = System.Drawing.Color.Gray;
            this.buttonConfigOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfigOption.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonConfigOption.Location = new System.Drawing.Point(47, 64);
            this.buttonConfigOption.Name = "buttonConfigOption";
            this.buttonConfigOption.Size = new System.Drawing.Size(119, 56);
            this.buttonConfigOption.TabIndex = 20;
            this.buttonConfigOption.Text = "CONFIG";
            this.buttonConfigOption.UseVisualStyleBackColor = false;
            this.buttonConfigOption.Click += new System.EventHandler(this.buttonConfigOption_Click);
            // 
            // buttonWavesOption
            // 
            this.buttonWavesOption.BackColor = System.Drawing.Color.Gray;
            this.buttonWavesOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWavesOption.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonWavesOption.Location = new System.Drawing.Point(47, 246);
            this.buttonWavesOption.Name = "buttonWavesOption";
            this.buttonWavesOption.Size = new System.Drawing.Size(119, 56);
            this.buttonWavesOption.TabIndex = 17;
            this.buttonWavesOption.Text = "WAVES";
            this.buttonWavesOption.UseVisualStyleBackColor = false;
            this.buttonWavesOption.Click += new System.EventHandler(this.buttonFlashOption_Click);
            // 
            // buttonUSBOption
            // 
            this.buttonUSBOption.BackColor = System.Drawing.Color.Gray;
            this.buttonUSBOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUSBOption.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUSBOption.Location = new System.Drawing.Point(47, 4);
            this.buttonUSBOption.Name = "buttonUSBOption";
            this.buttonUSBOption.Size = new System.Drawing.Size(119, 56);
            this.buttonUSBOption.TabIndex = 16;
            this.buttonUSBOption.Text = "USB";
            this.buttonUSBOption.UseVisualStyleBackColor = false;
            this.buttonUSBOption.Click += new System.EventHandler(this.buttonUSBOption_Click);
            // 
            // groupBoxConfig
            // 
            this.groupBoxConfig.Controls.Add(this.buttonLog);
            this.groupBoxConfig.Controls.Add(this.buttonTimer);
            this.groupBoxConfig.Controls.Add(this.buttonMode);
            this.groupBoxConfig.Controls.Add(this.buttonClose);
            this.groupBoxConfig.Controls.Add(this.buttonWavesOption);
            this.groupBoxConfig.Controls.Add(this.comboBoxMode0);
            this.groupBoxConfig.Controls.Add(this.buttonConfigOption);
            this.groupBoxConfig.Controls.Add(this.comboBoxMode1);
            this.groupBoxConfig.Controls.Add(this.buttonBackground);
            this.groupBoxConfig.Controls.Add(this.buttonUSBOption);
            this.groupBoxConfig.Location = new System.Drawing.Point(599, 19);
            this.groupBoxConfig.Name = "groupBoxConfig";
            this.groupBoxConfig.Size = new System.Drawing.Size(578, 558);
            this.groupBoxConfig.TabIndex = 26;
            this.groupBoxConfig.TabStop = false;
            this.groupBoxConfig.Text = "Config";
            this.groupBoxConfig.Visible = false;
            // 
            // buttonLog
            // 
            this.buttonLog.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLog.Location = new System.Drawing.Point(187, 228);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(102, 93);
            this.buttonLog.TabIndex = 21;
            this.buttonLog.Text = "LOG";
            this.buttonLog.UseVisualStyleBackColor = false;
            // 
            // buttonTimer
            // 
            this.buttonTimer.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTimer.Location = new System.Drawing.Point(187, 122);
            this.buttonTimer.Name = "buttonTimer";
            this.buttonTimer.Size = new System.Drawing.Size(102, 93);
            this.buttonTimer.TabIndex = 23;
            this.buttonTimer.Text = "Timer On/Off";
            this.buttonTimer.UseVisualStyleBackColor = false;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClose.Location = new System.Drawing.Point(172, 15);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(102, 93);
            this.buttonClose.TabIndex = 22;
            this.buttonClose.Text = "Close Session";
            this.buttonClose.UseVisualStyleBackColor = false;
            // 
            // groupBoxConsole
            // 
            this.groupBoxConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxConsole.Controls.Add(this.commandLine);
            this.groupBoxConsole.Controls.Add(this.consoleScreen);
            this.groupBoxConsole.Controls.Add(this.buttonSend);
            this.groupBoxConsole.Location = new System.Drawing.Point(605, 12);
            this.groupBoxConsole.Name = "groupBoxConsole";
            this.groupBoxConsole.Size = new System.Drawing.Size(1026, 745);
            this.groupBoxConsole.TabIndex = 27;
            this.groupBoxConsole.TabStop = false;
            this.groupBoxConsole.Text = "Console";
            this.groupBoxConsole.Visible = false;
            // 
            // groupBoxWaves
            // 
            this.groupBoxWaves.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxWaves.Controls.Add(this.buttonViewNext);
            this.groupBoxWaves.Controls.Add(this.chartWaveform);
            this.groupBoxWaves.Controls.Add(this.textBoxWave);
            this.groupBoxWaves.Location = new System.Drawing.Point(605, 19);
            this.groupBoxWaves.Name = "groupBoxWaves";
            this.groupBoxWaves.Size = new System.Drawing.Size(1026, 450);
            this.groupBoxWaves.TabIndex = 28;
            this.groupBoxWaves.TabStop = false;
            this.groupBoxWaves.Text = "Waves";
            this.groupBoxWaves.Visible = false;
            // 
            // buttonViewNext
            // 
            this.buttonViewNext.BackColor = System.Drawing.Color.Gray;
            this.buttonViewNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonViewNext.Location = new System.Drawing.Point(29, 348);
            this.buttonViewNext.Name = "buttonViewNext";
            this.buttonViewNext.Size = new System.Drawing.Size(99, 88);
            this.buttonViewNext.TabIndex = 38;
            this.buttonViewNext.Text = "View Next";
            this.buttonViewNext.UseVisualStyleBackColor = false;
            this.buttonViewNext.Click += new System.EventHandler(this.buttonViewNext_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1634, 751);
            this.Controls.Add(this.groupBoxWaves);
            this.Controls.Add(this.groupBoxConsole);
            this.Controls.Add(this.groupBoxConfig);
            this.Controls.Add(this.groupBoxFlash);
            this.Controls.Add(this.groupBoxMiddle);
            this.Controls.Add(this.groupBoxLogo);
            this.Controls.Add(this.groupBoxConnect);
            this.Name = "Form1";
            this.Text = "USB GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxConnect.ResumeLayout(false);
            this.groupBoxFlash.ResumeLayout(false);
            this.groupBoxFlash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWaveform)).EndInit();
            this.groupBoxMiddle.ResumeLayout(false);
            this.groupBoxMiddle.PerformLayout();
            this.groupBoxConfig.ResumeLayout(false);
            this.groupBoxConsole.ResumeLayout(false);
            this.groupBoxConsole.PerformLayout();
            this.groupBoxWaves.ResumeLayout(false);
            this.groupBoxWaves.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAvailablePorts;
        private System.Windows.Forms.TextBox commandLine;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonCenter;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonTrig;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonBackground;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.GroupBox groupBoxConnect;
        private System.Windows.Forms.GroupBox groupBoxFlash;
        private System.Windows.Forms.GroupBox groupBoxLogo;
        private System.Windows.Forms.Button buttonRefresh;

        private const string G_prompt = "=>";
        private string G_defaultFilename = "";
        private System.Windows.Forms.GroupBox groupBoxMiddle;
        private System.Windows.Forms.TextBox consoleScreen;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonMode;
        private System.Windows.Forms.ComboBox comboBoxMode1;
        private System.Windows.Forms.ComboBox comboBoxMode0;
        private System.Windows.Forms.ToolTip toolTipTrigger;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWaveform;
        private System.Windows.Forms.Button buttonConfigOption;
        private System.Windows.Forms.Button buttonWavesOption;
        private System.Windows.Forms.Button buttonUSBOption;
        private System.Windows.Forms.Button buttonEraseAll;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxConfig;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.TextBox textBoxWave;
        private System.Windows.Forms.CheckBox checkBoxViewWaves;
        private System.Windows.Forms.CheckBox checkBoxViewConsole;
        private System.Windows.Forms.GroupBox groupBoxConsole;
        private System.Windows.Forms.GroupBox groupBoxWaves;
        private System.Windows.Forms.CheckBox checkBoxConfig;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Button buttonTimer;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonViewNext;
    }
}

