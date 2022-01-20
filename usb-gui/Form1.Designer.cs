namespace usb_gui
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
            this.groupBoxCommandLine = new System.Windows.Forms.GroupBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.groupBoxButttons = new System.Windows.Forms.GroupBox();
            this.groupBoxLogo = new System.Windows.Forms.GroupBox();
            this.groupBoxMiddle = new System.Windows.Forms.GroupBox();
            this.consoleScreen = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonViewWave = new System.Windows.Forms.Button();
            this.buttonTimer = new System.Windows.Forms.Button();
            this.groupBoxConnect.SuspendLayout();
            this.groupBoxCommandLine.SuspendLayout();
            this.groupBoxButttons.SuspendLayout();
            this.groupBoxMiddle.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxAvailablePorts
            // 
            this.comboBoxAvailablePorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAvailablePorts.FormattingEnabled = true;
            this.comboBoxAvailablePorts.Location = new System.Drawing.Point(24, 21);
            this.comboBoxAvailablePorts.Name = "comboBoxAvailablePorts";
            this.comboBoxAvailablePorts.Size = new System.Drawing.Size(312, 28);
            this.comboBoxAvailablePorts.TabIndex = 0;
            this.comboBoxAvailablePorts.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // commandLine
            // 
            this.commandLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commandLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandLine.Location = new System.Drawing.Point(6, 21);
            this.commandLine.Name = "commandLine";
            this.commandLine.Size = new System.Drawing.Size(503, 30);
            this.commandLine.TabIndex = 2;
            this.commandLine.TextChanged += new System.EventHandler(this.commandLine_TextChanged);
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSend.Location = new System.Drawing.Point(28, 73);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(101, 93);
            this.buttonSend.TabIndex = 3;
            this.buttonSend.Text = "Send Cmd";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeft.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLeft.Location = new System.Drawing.Point(34, 35);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(101, 53);
            this.buttonLeft.TabIndex = 5;
            this.buttonLeft.Text = "<-";
            this.buttonLeft.UseVisualStyleBackColor = false;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonCenter
            // 
            this.buttonCenter.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCenter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCenter.Location = new System.Drawing.Point(151, 35);
            this.buttonCenter.Name = "buttonCenter";
            this.buttonCenter.Size = new System.Drawing.Size(102, 53);
            this.buttonCenter.TabIndex = 6;
            this.buttonCenter.Text = "^";
            this.buttonCenter.UseVisualStyleBackColor = false;
            this.buttonCenter.Click += new System.EventHandler(this.buttonCenter_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRight.Location = new System.Drawing.Point(271, 35);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(102, 53);
            this.buttonRight.TabIndex = 7;
            this.buttonRight.Text = "->";
            this.buttonRight.UseVisualStyleBackColor = false;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonTrig
            // 
            this.buttonTrig.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonTrig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrig.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTrig.Location = new System.Drawing.Point(392, 35);
            this.buttonTrig.Name = "buttonTrig";
            this.buttonTrig.Size = new System.Drawing.Size(102, 53);
            this.buttonTrig.TabIndex = 8;
            this.buttonTrig.Text = "TRIG";
            this.buttonTrig.UseVisualStyleBackColor = false;
            this.buttonTrig.Click += new System.EventHandler(this.buttonTrig_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLoad.Location = new System.Drawing.Point(34, 103);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(101, 92);
            this.buttonLoad.TabIndex = 9;
            this.buttonLoad.Text = "Load Wave";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClear.Location = new System.Drawing.Point(151, 103);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(101, 92);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Clear Wave";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonBackground
            // 
            this.buttonBackground.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackground.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBackground.Location = new System.Drawing.Point(392, 103);
            this.buttonBackground.Name = "buttonBackground";
            this.buttonBackground.Size = new System.Drawing.Size(99, 92);
            this.buttonBackground.TabIndex = 13;
            this.buttonBackground.Text = "Black White";
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
            this.buttonConnect.Location = new System.Drawing.Point(183, 64);
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
            this.groupBoxConnect.Size = new System.Drawing.Size(521, 144);
            this.groupBoxConnect.TabIndex = 15;
            this.groupBoxConnect.TabStop = false;
            this.groupBoxConnect.Text = "Connect";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRefresh.Location = new System.Drawing.Point(24, 64);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(153, 51);
            this.buttonRefresh.TabIndex = 15;
            this.buttonRefresh.Text = "REFRESH";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // groupBoxCommandLine
            // 
            this.groupBoxCommandLine.Controls.Add(this.buttonTimer);
            this.groupBoxCommandLine.Controls.Add(this.buttonClose);
            this.groupBoxCommandLine.Controls.Add(this.buttonLog);
            this.groupBoxCommandLine.Controls.Add(this.commandLine);
            this.groupBoxCommandLine.Controls.Add(this.buttonSend);
            this.groupBoxCommandLine.Location = new System.Drawing.Point(12, 219);
            this.groupBoxCommandLine.Name = "groupBoxCommandLine";
            this.groupBoxCommandLine.Size = new System.Drawing.Size(515, 193);
            this.groupBoxCommandLine.TabIndex = 16;
            this.groupBoxCommandLine.TabStop = false;
            this.groupBoxCommandLine.Text = "Commands";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClose.Location = new System.Drawing.Point(145, 73);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(102, 93);
            this.buttonClose.TabIndex = 15;
            this.buttonClose.Text = "Close Session";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonLog
            // 
            this.buttonLog.BackColor = System.Drawing.Color.Gray;
            this.buttonLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLog.Location = new System.Drawing.Point(389, 73);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(99, 93);
            this.buttonLog.TabIndex = 14;
            this.buttonLog.Text = "View Log";
            this.buttonLog.UseVisualStyleBackColor = false;
            this.buttonLog.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxButttons
            // 
            this.groupBoxButttons.Controls.Add(this.buttonViewWave);
            this.groupBoxButttons.Controls.Add(this.buttonCenter);
            this.groupBoxButttons.Controls.Add(this.buttonLeft);
            this.groupBoxButttons.Controls.Add(this.buttonRight);
            this.groupBoxButttons.Controls.Add(this.buttonBackground);
            this.groupBoxButttons.Controls.Add(this.buttonLoad);
            this.groupBoxButttons.Controls.Add(this.buttonTrig);
            this.groupBoxButttons.Controls.Add(this.buttonClear);
            this.groupBoxButttons.Location = new System.Drawing.Point(6, 12);
            this.groupBoxButttons.Name = "groupBoxButttons";
            this.groupBoxButttons.Size = new System.Drawing.Size(523, 201);
            this.groupBoxButttons.TabIndex = 17;
            this.groupBoxButttons.TabStop = false;
            this.groupBoxButttons.Text = "Controls";
            this.groupBoxButttons.Visible = false;
            // 
            // groupBoxLogo
            // 
            this.groupBoxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxLogo.BackgroundImage")));
            this.groupBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxLogo.Location = new System.Drawing.Point(12, 412);
            this.groupBoxLogo.Name = "groupBoxLogo";
            this.groupBoxLogo.Size = new System.Drawing.Size(788, 246);
            this.groupBoxLogo.TabIndex = 18;
            this.groupBoxLogo.TabStop = false;
            this.groupBoxLogo.Visible = false;
            this.groupBoxLogo.Enter += new System.EventHandler(this.groupBoxLogo_Enter);
            // 
            // groupBoxMiddle
            // 
            this.groupBoxMiddle.Controls.Add(this.textBoxStatus);
            this.groupBoxMiddle.Location = new System.Drawing.Point(536, 6);
            this.groupBoxMiddle.Name = "groupBoxMiddle";
            this.groupBoxMiddle.Size = new System.Drawing.Size(270, 406);
            this.groupBoxMiddle.TabIndex = 22;
            this.groupBoxMiddle.TabStop = false;
            this.groupBoxMiddle.Text = "Status";
            this.groupBoxMiddle.Visible = false;
            // 
            // consoleScreen
            // 
            this.consoleScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleScreen.Location = new System.Drawing.Point(806, 12);
            this.consoleScreen.MaxLength = 65535;
            this.consoleScreen.Multiline = true;
            this.consoleScreen.Name = "consoleScreen";
            this.consoleScreen.ReadOnly = true;
            this.consoleScreen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleScreen.Size = new System.Drawing.Size(371, 646);
            this.consoleScreen.TabIndex = 1;
            this.consoleScreen.Visible = false;
            this.consoleScreen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStatus.Location = new System.Drawing.Point(-1, 18);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(265, 393);
            this.textBoxStatus.TabIndex = 21;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // buttonViewWave
            // 
            this.buttonViewWave.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonViewWave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewWave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonViewWave.Location = new System.Drawing.Point(271, 103);
            this.buttonViewWave.Name = "buttonViewWave";
            this.buttonViewWave.Size = new System.Drawing.Size(101, 92);
            this.buttonViewWave.TabIndex = 14;
            this.buttonViewWave.Text = "View Wave";
            this.buttonViewWave.UseVisualStyleBackColor = false;
            this.buttonViewWave.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // buttonTimer
            // 
            this.buttonTimer.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTimer.Location = new System.Drawing.Point(264, 73);
            this.buttonTimer.Name = "buttonTimer";
            this.buttonTimer.Size = new System.Drawing.Size(102, 93);
            this.buttonTimer.TabIndex = 16;
            this.buttonTimer.Text = "Timer On/Off";
            this.buttonTimer.UseVisualStyleBackColor = false;
            this.buttonTimer.Click += new System.EventHandler(this.buttonTimer_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 663);
            this.Controls.Add(this.groupBoxMiddle);
            this.Controls.Add(this.groupBoxLogo);
            this.Controls.Add(this.groupBoxButttons);
            this.Controls.Add(this.groupBoxCommandLine);
            this.Controls.Add(this.groupBoxConnect);
            this.Controls.Add(this.consoleScreen);
            this.Name = "Form1";
            this.Text = "USB GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxConnect.ResumeLayout(false);
            this.groupBoxCommandLine.ResumeLayout(false);
            this.groupBoxCommandLine.PerformLayout();
            this.groupBoxButttons.ResumeLayout(false);
            this.groupBoxMiddle.ResumeLayout(false);
            this.groupBoxMiddle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox groupBoxCommandLine;
        private System.Windows.Forms.GroupBox groupBoxButttons;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.GroupBox groupBoxLogo;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonClose;

        private const string G_prompt = "=>";
        private System.Windows.Forms.GroupBox groupBoxMiddle;
        private System.Windows.Forms.TextBox consoleScreen;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonViewWave;
        private System.Windows.Forms.Button buttonTimer;
    }
}

