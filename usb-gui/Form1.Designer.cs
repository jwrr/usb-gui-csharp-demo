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
            this.consoleScreen = new System.Windows.Forms.TextBox();
            this.commandLine = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonReceive = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonCenter = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonTrig = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonStatus = new System.Windows.Forms.Button();
            this.buttonBackground = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.buttonConnect = new System.Windows.Forms.Button();
            this.groupBoxConnect = new System.Windows.Forms.GroupBox();
            this.groupBoxCommandLine = new System.Windows.Forms.GroupBox();
            this.groupBoxButttons = new System.Windows.Forms.GroupBox();
            this.buttonLog = new System.Windows.Forms.Button();
            this.groupBoxLogo = new System.Windows.Forms.GroupBox();
            this.groupBoxConnect.SuspendLayout();
            this.groupBoxCommandLine.SuspendLayout();
            this.groupBoxButttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxAvailablePorts
            // 
            this.comboBoxAvailablePorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAvailablePorts.FormattingEnabled = true;
            this.comboBoxAvailablePorts.Location = new System.Drawing.Point(36, 21);
            this.comboBoxAvailablePorts.Name = "comboBoxAvailablePorts";
            this.comboBoxAvailablePorts.Size = new System.Drawing.Size(219, 28);
            this.comboBoxAvailablePorts.TabIndex = 0;
            this.comboBoxAvailablePorts.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // consoleScreen
            // 
            this.consoleScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleScreen.Enabled = false;
            this.consoleScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleScreen.Location = new System.Drawing.Point(535, 1);
            this.consoleScreen.Multiline = true;
            this.consoleScreen.Name = "consoleScreen";
            this.consoleScreen.ReadOnly = true;
            this.consoleScreen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleScreen.Size = new System.Drawing.Size(543, 504);
            this.consoleScreen.TabIndex = 1;
            this.consoleScreen.Visible = false;
            this.consoleScreen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // commandLine
            // 
            this.commandLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commandLine.Enabled = false;
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
            this.buttonSend.Enabled = false;
            this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSend.Location = new System.Drawing.Point(69, 73);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(102, 93);
            this.buttonSend.TabIndex = 3;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonReceive
            // 
            this.buttonReceive.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonReceive.Enabled = false;
            this.buttonReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReceive.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonReceive.Location = new System.Drawing.Point(215, 73);
            this.buttonReceive.Name = "buttonReceive";
            this.buttonReceive.Size = new System.Drawing.Size(102, 93);
            this.buttonReceive.TabIndex = 4;
            this.buttonReceive.Text = "Receive";
            this.buttonReceive.UseVisualStyleBackColor = false;
            this.buttonReceive.Click += new System.EventHandler(this.buttonReceive_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonLeft.Enabled = false;
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
            this.buttonCenter.Enabled = false;
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
            this.buttonRight.Enabled = false;
            this.buttonRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRight.Location = new System.Drawing.Point(273, 35);
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
            this.buttonTrig.Enabled = false;
            this.buttonTrig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrig.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTrig.Location = new System.Drawing.Point(389, 35);
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
            this.buttonLoad.Enabled = false;
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLoad.Location = new System.Drawing.Point(34, 105);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(101, 53);
            this.buttonLoad.TabIndex = 9;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonClear.Enabled = false;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClear.Location = new System.Drawing.Point(152, 105);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(101, 53);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonStatus
            // 
            this.buttonStatus.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonStatus.Enabled = false;
            this.buttonStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonStatus.Location = new System.Drawing.Point(273, 105);
            this.buttonStatus.Name = "buttonStatus";
            this.buttonStatus.Size = new System.Drawing.Size(102, 53);
            this.buttonStatus.TabIndex = 11;
            this.buttonStatus.Text = "Status";
            this.buttonStatus.UseVisualStyleBackColor = false;
            this.buttonStatus.Click += new System.EventHandler(this.buttonStatus_Click);
            // 
            // buttonBackground
            // 
            this.buttonBackground.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonBackground.Enabled = false;
            this.buttonBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackground.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBackground.Location = new System.Drawing.Point(392, 105);
            this.buttonBackground.Name = "buttonBackground";
            this.buttonBackground.Size = new System.Drawing.Size(99, 53);
            this.buttonBackground.TabIndex = 13;
            this.buttonBackground.Text = "B/W";
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
            this.buttonConnect.Location = new System.Drawing.Point(34, 73);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(219, 51);
            this.buttonConnect.TabIndex = 14;
            this.buttonConnect.Text = "CONNECT";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // groupBoxConnect
            // 
            this.groupBoxConnect.Controls.Add(this.comboBoxAvailablePorts);
            this.groupBoxConnect.Controls.Add(this.buttonConnect);
            this.groupBoxConnect.Location = new System.Drawing.Point(6, 1);
            this.groupBoxConnect.Name = "groupBoxConnect";
            this.groupBoxConnect.Size = new System.Drawing.Size(521, 162);
            this.groupBoxConnect.TabIndex = 15;
            this.groupBoxConnect.TabStop = false;
            this.groupBoxConnect.Text = "Connect";
            // 
            // groupBoxCommandLine
            // 
            this.groupBoxCommandLine.Controls.Add(this.buttonLog);
            this.groupBoxCommandLine.Controls.Add(this.commandLine);
            this.groupBoxCommandLine.Controls.Add(this.buttonSend);
            this.groupBoxCommandLine.Controls.Add(this.buttonReceive);
            this.groupBoxCommandLine.Location = new System.Drawing.Point(12, 182);
            this.groupBoxCommandLine.Name = "groupBoxCommandLine";
            this.groupBoxCommandLine.Size = new System.Drawing.Size(515, 187);
            this.groupBoxCommandLine.TabIndex = 16;
            this.groupBoxCommandLine.TabStop = false;
            this.groupBoxCommandLine.Text = "Commands";
            // 
            // groupBoxButttons
            // 
            this.groupBoxButttons.Controls.Add(this.buttonCenter);
            this.groupBoxButttons.Controls.Add(this.buttonLeft);
            this.groupBoxButttons.Controls.Add(this.buttonRight);
            this.groupBoxButttons.Controls.Add(this.buttonBackground);
            this.groupBoxButttons.Controls.Add(this.buttonLoad);
            this.groupBoxButttons.Controls.Add(this.buttonTrig);
            this.groupBoxButttons.Controls.Add(this.buttonClear);
            this.groupBoxButttons.Controls.Add(this.buttonStatus);
            this.groupBoxButttons.Location = new System.Drawing.Point(6, 1);
            this.groupBoxButttons.Name = "groupBoxButttons";
            this.groupBoxButttons.Size = new System.Drawing.Size(523, 175);
            this.groupBoxButttons.TabIndex = 17;
            this.groupBoxButttons.TabStop = false;
            this.groupBoxButttons.Text = "Controls";
            this.groupBoxButttons.Visible = false;
            // 
            // buttonLog
            // 
            this.buttonLog.BackColor = System.Drawing.Color.Gray;
            this.buttonLog.Enabled = false;
            this.buttonLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLog.Location = new System.Drawing.Point(356, 73);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(99, 93);
            this.buttonLog.TabIndex = 14;
            this.buttonLog.Text = "View Log";
            this.buttonLog.UseVisualStyleBackColor = false;
            this.buttonLog.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxLogo
            // 
            this.groupBoxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxLogo.BackgroundImage")));
            this.groupBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxLogo.Location = new System.Drawing.Point(12, 365);
            this.groupBoxLogo.Name = "groupBoxLogo";
            this.groupBoxLogo.Size = new System.Drawing.Size(517, 130);
            this.groupBoxLogo.TabIndex = 18;
            this.groupBoxLogo.TabStop = false;
            this.groupBoxLogo.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 507);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAvailablePorts;
        private System.Windows.Forms.TextBox consoleScreen;
        private System.Windows.Forms.TextBox commandLine;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonReceive;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonCenter;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonTrig;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonStatus;
        private System.Windows.Forms.Button buttonBackground;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.GroupBox groupBoxConnect;
        private System.Windows.Forms.GroupBox groupBoxCommandLine;
        private System.Windows.Forms.GroupBox groupBoxButttons;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.GroupBox groupBoxLogo;
    }
}

