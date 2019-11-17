namespace LAB3_GUI
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.autoReconnectBox = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnTransmitToComPort = new System.Windows.Forms.Button();
            this.txtByte5 = new System.Windows.Forms.TextBox();
            this.txtByte4 = new System.Windows.Forms.TextBox();
            this.txtByte3 = new System.Windows.Forms.TextBox();
            this.txtByte2 = new System.Windows.Forms.TextBox();
            this.txtByte1 = new System.Windows.Forms.TextBox();
            this.chkByte3 = new System.Windows.Forms.CheckBox();
            this.chkByte2 = new System.Windows.Forms.CheckBox();
            this.chkByte1 = new System.Windows.Forms.CheckBox();
            this.lblIncomingDataRate = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.chkShowResponse = new System.Windows.Forms.CheckBox();
            this.txtRawSerial = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.ToolStripButton();
            this.chkByte4 = new System.Windows.Forms.CheckBox();
            this.txtBaudRate = new System.Windows.Forms.ToolStripTextBox();
            this.chkByte5 = new System.Windows.Forms.CheckBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cmbComPort = new System.Windows.Forms.ToolStripComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cbStepperEnable = new System.Windows.Forms.CheckBox();
            this.btStepperDir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btStepperCommand = new System.Windows.Forms.Button();
            this.btStepperMode = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbStepperSpeed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbStepperRev = new System.Windows.Forms.CheckBox();
            this.cbStepperSteps = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDCPWM = new System.Windows.Forms.TextBox();
            this.btDCCommand = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btDCDir = new System.Windows.Forms.Button();
            this.cbDCEnable = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btDCMode = new System.Windows.Forms.Button();
            this.ctData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.tbVelocity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.txtByte6 = new System.Windows.Forms.TextBox();
            this.chkByte6 = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbDirection = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.CbSaveToFile = new System.Windows.Forms.CheckBox();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.btSaveFile = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctData)).BeginInit();
            this.SuspendLayout();
            // 
            // autoReconnectBox
            // 
            this.autoReconnectBox.AutoSize = true;
            this.autoReconnectBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.autoReconnectBox.Location = new System.Drawing.Point(295, 44);
            this.autoReconnectBox.Name = "autoReconnectBox";
            this.autoReconnectBox.Size = new System.Drawing.Size(104, 17);
            this.autoReconnectBox.TabIndex = 23;
            this.autoReconnectBox.Text = "Auto Reconnect";
            this.autoReconnectBox.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnTransmitToComPort
            // 
            this.btnTransmitToComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnTransmitToComPort.Location = new System.Drawing.Point(7, 130);
            this.btnTransmitToComPort.Name = "btnTransmitToComPort";
            this.btnTransmitToComPort.Size = new System.Drawing.Size(386, 35);
            this.btnTransmitToComPort.TabIndex = 22;
            this.btnTransmitToComPort.Text = "Transmit to Com Port";
            this.btnTransmitToComPort.UseVisualStyleBackColor = true;
            this.btnTransmitToComPort.Click += new System.EventHandler(this.btnTransmitToComPort_Click);
            // 
            // txtByte5
            // 
            this.txtByte5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtByte5.Location = new System.Drawing.Point(265, 97);
            this.txtByte5.Name = "txtByte5";
            this.txtByte5.Size = new System.Drawing.Size(59, 26);
            this.txtByte5.TabIndex = 20;
            this.txtByte5.TextChanged += new System.EventHandler(this.genericTextBoxEventHandler);
            // 
            // txtByte4
            // 
            this.txtByte4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtByte4.Location = new System.Drawing.Point(200, 97);
            this.txtByte4.Name = "txtByte4";
            this.txtByte4.Size = new System.Drawing.Size(60, 26);
            this.txtByte4.TabIndex = 19;
            this.txtByte4.TextChanged += new System.EventHandler(this.genericTextBoxEventHandler);
            // 
            // txtByte3
            // 
            this.txtByte3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtByte3.Location = new System.Drawing.Point(136, 97);
            this.txtByte3.Name = "txtByte3";
            this.txtByte3.Size = new System.Drawing.Size(60, 26);
            this.txtByte3.TabIndex = 18;
            this.txtByte3.TextChanged += new System.EventHandler(this.genericTextBoxEventHandler);
            // 
            // txtByte2
            // 
            this.txtByte2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtByte2.Location = new System.Drawing.Point(71, 97);
            this.txtByte2.Name = "txtByte2";
            this.txtByte2.Size = new System.Drawing.Size(60, 26);
            this.txtByte2.TabIndex = 17;
            this.txtByte2.TextChanged += new System.EventHandler(this.genericTextBoxEventHandler);
            // 
            // txtByte1
            // 
            this.txtByte1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtByte1.Location = new System.Drawing.Point(7, 97);
            this.txtByte1.Name = "txtByte1";
            this.txtByte1.Size = new System.Drawing.Size(60, 26);
            this.txtByte1.TabIndex = 16;
            this.txtByte1.TextChanged += new System.EventHandler(this.genericTextBoxEventHandler);
            // 
            // chkByte3
            // 
            this.chkByte3.AutoSize = true;
            this.chkByte3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chkByte3.Location = new System.Drawing.Point(136, 70);
            this.chkByte3.Name = "chkByte3";
            this.chkByte3.Size = new System.Drawing.Size(63, 17);
            this.chkByte3.TabIndex = 15;
            this.chkByte3.Text = "Byte #3";
            this.chkByte3.UseVisualStyleBackColor = true;
            this.chkByte3.CheckedChanged += new System.EventHandler(this.chkByte3_CheckedChanged);
            // 
            // chkByte2
            // 
            this.chkByte2.AutoSize = true;
            this.chkByte2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chkByte2.Location = new System.Drawing.Point(71, 70);
            this.chkByte2.Name = "chkByte2";
            this.chkByte2.Size = new System.Drawing.Size(63, 17);
            this.chkByte2.TabIndex = 14;
            this.chkByte2.Text = "Byte #2";
            this.chkByte2.UseVisualStyleBackColor = true;
            this.chkByte2.CheckedChanged += new System.EventHandler(this.chkByte2_CheckedChanged);
            // 
            // chkByte1
            // 
            this.chkByte1.AutoSize = true;
            this.chkByte1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chkByte1.Location = new System.Drawing.Point(7, 70);
            this.chkByte1.Name = "chkByte1";
            this.chkByte1.Size = new System.Drawing.Size(63, 17);
            this.chkByte1.TabIndex = 13;
            this.chkByte1.Text = "Byte #1";
            this.chkByte1.UseVisualStyleBackColor = true;
            this.chkByte1.CheckedChanged += new System.EventHandler(this.chkByte1_CheckedChanged);
            // 
            // lblIncomingDataRate
            // 
            this.lblIncomingDataRate.AutoSize = true;
            this.lblIncomingDataRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblIncomingDataRate.Location = new System.Drawing.Point(668, 0);
            this.lblIncomingDataRate.Name = "lblIncomingDataRate";
            this.lblIncomingDataRate.Size = new System.Drawing.Size(152, 13);
            this.lblIncomingDataRate.TabIndex = 8;
            this.lblIncomingDataRate.Text = "Incoming data rate = 0 [byte/s]";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // chkShowResponse
            // 
            this.chkShowResponse.AutoSize = true;
            this.chkShowResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chkShowResponse.Location = new System.Drawing.Point(133, 44);
            this.chkShowResponse.Name = "chkShowResponse";
            this.chkShowResponse.Size = new System.Drawing.Size(143, 17);
            this.chkShowResponse.TabIndex = 12;
            this.chkShowResponse.Text = "Response from Com Port";
            this.chkShowResponse.UseVisualStyleBackColor = true;
            // 
            // txtRawSerial
            // 
            this.txtRawSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRawSerial.Location = new System.Drawing.Point(9, 353);
            this.txtRawSerial.Multiline = true;
            this.txtRawSerial.Name = "txtRawSerial";
            this.txtRawSerial.Size = new System.Drawing.Size(812, 62);
            this.txtRawSerial.TabIndex = 21;
            // 
            // btnConnect
            // 
            this.btnConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnConnect.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect.Image")));
            this.btnConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(56, 22);
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // chkByte4
            // 
            this.chkByte4.AutoSize = true;
            this.chkByte4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chkByte4.Location = new System.Drawing.Point(200, 70);
            this.chkByte4.Name = "chkByte4";
            this.chkByte4.Size = new System.Drawing.Size(63, 17);
            this.chkByte4.TabIndex = 11;
            this.chkByte4.Text = "Byte #4";
            this.chkByte4.UseVisualStyleBackColor = true;
            this.chkByte4.CheckedChanged += new System.EventHandler(this.chkByte4_CheckedChanged);
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(70, 25);
            this.txtBaudRate.Text = "9600";
            // 
            // chkByte5
            // 
            this.chkByte5.AutoSize = true;
            this.chkByte5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chkByte5.Location = new System.Drawing.Point(265, 70);
            this.chkByte5.Name = "chkByte5";
            this.chkByte5.Size = new System.Drawing.Size(63, 17);
            this.chkByte5.TabIndex = 10;
            this.chkByte5.Text = "Byte #5";
            this.chkByte5.UseVisualStyleBackColor = true;
            this.chkByte5.CheckedChanged += new System.EventHandler(this.chkByte5_CheckedChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(63, 22);
            this.toolStripLabel1.Text = "Baud Rate:";
            // 
            // cmbComPort
            // 
            this.cmbComPort.Name = "cmbComPort";
            this.cmbComPort.Size = new System.Drawing.Size(120, 25);
            this.cmbComPort.DropDown += new System.EventHandler(this.cmbComPort_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Custom Data Packet:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmbComPort,
            this.toolStripLabel1,
            this.txtBaudRate,
            this.btnConnect});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(834, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cbStepperEnable
            // 
            this.cbStepperEnable.AutoSize = true;
            this.cbStepperEnable.Location = new System.Drawing.Point(207, 194);
            this.cbStepperEnable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbStepperEnable.Name = "cbStepperEnable";
            this.cbStepperEnable.Size = new System.Drawing.Size(135, 17);
            this.cbStepperEnable.TabIndex = 25;
            this.cbStepperEnable.Text = "Stepper Control Enable";
            this.cbStepperEnable.UseVisualStyleBackColor = true;
            this.cbStepperEnable.CheckedChanged += new System.EventHandler(this.CbStepperEnable_CheckedChanged);
            // 
            // btStepperDir
            // 
            this.btStepperDir.Location = new System.Drawing.Point(207, 216);
            this.btStepperDir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btStepperDir.Name = "btStepperDir";
            this.btStepperDir.Size = new System.Drawing.Size(68, 30);
            this.btStepperDir.TabIndex = 26;
            this.btStepperDir.Text = "CW";
            this.btStepperDir.UseVisualStyleBackColor = true;
            this.btStepperDir.Click += new System.EventHandler(this.BtStepperDir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Toggle Direction";
            // 
            // btStepperCommand
            // 
            this.btStepperCommand.Location = new System.Drawing.Point(207, 313);
            this.btStepperCommand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btStepperCommand.Name = "btStepperCommand";
            this.btStepperCommand.Size = new System.Drawing.Size(320, 29);
            this.btStepperCommand.TabIndex = 28;
            this.btStepperCommand.Text = "Send Command";
            this.btStepperCommand.UseVisualStyleBackColor = true;
            this.btStepperCommand.Click += new System.EventHandler(this.BtStepperCommand_Click);
            // 
            // btStepperMode
            // 
            this.btStepperMode.Location = new System.Drawing.Point(207, 251);
            this.btStepperMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btStepperMode.Name = "btStepperMode";
            this.btStepperMode.Size = new System.Drawing.Size(68, 32);
            this.btStepperMode.TabIndex = 29;
            this.btStepperMode.Text = "Step";
            this.btStepperMode.UseVisualStyleBackColor = true;
            this.btStepperMode.Click += new System.EventHandler(this.BtStepperMode_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Toggle Mode";
            // 
            // tbStepperSpeed
            // 
            this.tbStepperSpeed.Location = new System.Drawing.Point(207, 288);
            this.tbStepperSpeed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbStepperSpeed.Name = "tbStepperSpeed";
            this.tbStepperSpeed.Size = new System.Drawing.Size(69, 20);
            this.tbStepperSpeed.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 289);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Constant Mode Speed";
            // 
            // cbStepperRev
            // 
            this.cbStepperRev.AutoSize = true;
            this.cbStepperRev.Location = new System.Drawing.Point(470, 286);
            this.cbStepperRev.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbStepperRev.Name = "cbStepperRev";
            this.cbStepperRev.Size = new System.Drawing.Size(57, 17);
            this.cbStepperRev.TabIndex = 33;
            this.cbStepperRev.Text = "[rev/s]";
            this.cbStepperRev.UseVisualStyleBackColor = true;
            this.cbStepperRev.CheckedChanged += new System.EventHandler(this.CbStepperRev_CheckedChanged);
            // 
            // cbStepperSteps
            // 
            this.cbStepperSteps.AutoSize = true;
            this.cbStepperSteps.Location = new System.Drawing.Point(399, 286);
            this.cbStepperSteps.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbStepperSteps.Name = "cbStepperSteps";
            this.cbStepperSteps.Size = new System.Drawing.Size(67, 17);
            this.cbStepperSteps.TabIndex = 34;
            this.cbStepperSteps.Text = "[steps/s]";
            this.cbStepperSteps.UseVisualStyleBackColor = true;
            this.cbStepperSteps.CheckedChanged += new System.EventHandler(this.CbStepperSteps_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 290);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "PWM Duty [%]";
            // 
            // tbDCPWM
            // 
            this.tbDCPWM.Location = new System.Drawing.Point(9, 287);
            this.tbDCPWM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDCPWM.Name = "tbDCPWM";
            this.tbDCPWM.Size = new System.Drawing.Size(69, 20);
            this.tbDCPWM.TabIndex = 41;
            // 
            // btDCCommand
            // 
            this.btDCCommand.Location = new System.Drawing.Point(9, 313);
            this.btDCCommand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btDCCommand.Name = "btDCCommand";
            this.btDCCommand.Size = new System.Drawing.Size(176, 29);
            this.btDCCommand.TabIndex = 38;
            this.btDCCommand.Text = "Send Command";
            this.btDCCommand.UseVisualStyleBackColor = true;
            this.btDCCommand.Click += new System.EventHandler(this.BtDCCommand_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 224);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Toggle Direction";
            // 
            // btDCDir
            // 
            this.btDCDir.Location = new System.Drawing.Point(9, 216);
            this.btDCDir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btDCDir.Name = "btDCDir";
            this.btDCDir.Size = new System.Drawing.Size(68, 30);
            this.btDCDir.TabIndex = 36;
            this.btDCDir.Text = "CW";
            this.btDCDir.UseVisualStyleBackColor = true;
            this.btDCDir.Click += new System.EventHandler(this.BtDCDir_Click);
            // 
            // cbDCEnable
            // 
            this.cbDCEnable.AutoSize = true;
            this.cbDCEnable.Location = new System.Drawing.Point(9, 194);
            this.cbDCEnable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbDCEnable.Name = "cbDCEnable";
            this.cbDCEnable.Size = new System.Drawing.Size(143, 17);
            this.cbDCEnable.TabIndex = 35;
            this.cbDCEnable.Text = "DC Motor Control Enable";
            this.cbDCEnable.UseVisualStyleBackColor = true;
            this.cbDCEnable.CheckedChanged += new System.EventHandler(this.CbDCEnable_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 259);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "PWM Mode";
            // 
            // btDCMode
            // 
            this.btDCMode.Location = new System.Drawing.Point(9, 251);
            this.btDCMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btDCMode.Name = "btDCMode";
            this.btDCMode.Size = new System.Drawing.Size(68, 30);
            this.btDCMode.TabIndex = 43;
            this.btDCMode.Text = "Duty";
            this.btDCMode.UseVisualStyleBackColor = true;
            this.btDCMode.Click += new System.EventHandler(this.BtDCMode_Click);
            // 
            // ctData
            // 
            chartArea1.Name = "ChartArea1";
            this.ctData.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 12.70903F;
            legend1.Position.Width = 25.41806F;
            legend1.Position.X = 20F;
            legend1.Position.Y = 3F;
            this.ctData.Legends.Add(legend1);
            this.ctData.Location = new System.Drawing.Point(410, 28);
            this.ctData.Name = "ctData";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.LegendText = "RPM [rev/s]";
            series1.Name = "RPM";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.LegendText = "Position [counts]";
            series2.Name = "Position";
            this.ctData.Series.Add(series1);
            this.ctData.Series.Add(series2);
            this.ctData.Size = new System.Drawing.Size(410, 244);
            this.ctData.TabIndex = 45;
            this.ctData.Text = "chart1";
            // 
            // tbPosition
            // 
            this.tbPosition.Location = new System.Drawing.Point(718, 285);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(46, 20);
            this.tbPosition.TabIndex = 46;
            // 
            // tbVelocity
            // 
            this.tbVelocity.Location = new System.Drawing.Point(718, 311);
            this.tbVelocity.Name = "tbVelocity";
            this.tbVelocity.Size = new System.Drawing.Size(46, 20);
            this.tbVelocity.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(668, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Position";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(668, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Velocity";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(552, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Instantaneous Motor: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(770, 314);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "[rpm]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(770, 289);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "[count]";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // txtByte6
            // 
            this.txtByte6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtByte6.Location = new System.Drawing.Point(328, 97);
            this.txtByte6.Name = "txtByte6";
            this.txtByte6.Size = new System.Drawing.Size(60, 26);
            this.txtByte6.TabIndex = 55;
            this.txtByte6.TextChanged += new System.EventHandler(this.genericTextBoxEventHandler);
            // 
            // chkByte6
            // 
            this.chkByte6.AutoSize = true;
            this.chkByte6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chkByte6.Location = new System.Drawing.Point(328, 70);
            this.chkByte6.Name = "chkByte6";
            this.chkByte6.Size = new System.Drawing.Size(63, 17);
            this.chkByte6.TabIndex = 54;
            this.chkByte6.Text = "Byte #6";
            this.chkByte6.UseVisualStyleBackColor = true;
            this.chkByte6.CheckedChanged += new System.EventHandler(this.chkByte6_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(556, 312);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 59;
            this.label15.Text = "Direction";
            // 
            // tbDirection
            // 
            this.tbDirection.Location = new System.Drawing.Point(610, 311);
            this.tbDirection.Name = "tbDirection";
            this.tbDirection.Size = new System.Drawing.Size(46, 20);
            this.tbDirection.TabIndex = 58;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 422);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 13);
            this.label14.TabIndex = 63;
            this.label14.Text = "Enable Data Logging";
            // 
            // CbSaveToFile
            // 
            this.CbSaveToFile.Location = new System.Drawing.Point(9, 418);
            this.CbSaveToFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbSaveToFile.Name = "CbSaveToFile";
            this.CbSaveToFile.Size = new System.Drawing.Size(28, 22);
            this.CbSaveToFile.TabIndex = 60;
            this.CbSaveToFile.CheckedChanged += new System.EventHandler(this.CbSaveToFile_CheckedChanged);
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(9, 444);
            this.tbFileName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(121, 20);
            this.tbFileName.TabIndex = 61;
            this.tbFileName.Text = "Enter Output Filename...";
            // 
            // btSaveFile
            // 
            this.btSaveFile.Location = new System.Drawing.Point(136, 422);
            this.btSaveFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSaveFile.Name = "btSaveFile";
            this.btSaveFile.Size = new System.Drawing.Size(90, 39);
            this.btSaveFile.TabIndex = 62;
            this.btSaveFile.Text = "SAVE FILE";
            this.btSaveFile.Click += new System.EventHandler(this.BtSaveFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 481);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.CbSaveToFile);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.btSaveFile);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbDirection);
            this.Controls.Add(this.txtByte6);
            this.Controls.Add(this.chkByte6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbVelocity);
            this.Controls.Add(this.tbPosition);
            this.Controls.Add(this.ctData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btDCMode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDCPWM);
            this.Controls.Add(this.btDCCommand);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btDCDir);
            this.Controls.Add(this.cbDCEnable);
            this.Controls.Add(this.cbStepperSteps);
            this.Controls.Add(this.cbStepperRev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbStepperSpeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btStepperMode);
            this.Controls.Add(this.btStepperCommand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btStepperDir);
            this.Controls.Add(this.cbStepperEnable);
            this.Controls.Add(this.autoReconnectBox);
            this.Controls.Add(this.btnTransmitToComPort);
            this.Controls.Add(this.txtByte5);
            this.Controls.Add(this.txtByte4);
            this.Controls.Add(this.txtByte3);
            this.Controls.Add(this.txtByte2);
            this.Controls.Add(this.txtByte1);
            this.Controls.Add(this.chkByte3);
            this.Controls.Add(this.chkByte2);
            this.Controls.Add(this.chkByte1);
            this.Controls.Add(this.lblIncomingDataRate);
            this.Controls.Add(this.chkShowResponse);
            this.Controls.Add(this.txtRawSerial);
            this.Controls.Add(this.chkByte4);
            this.Controls.Add(this.chkByte5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox autoReconnectBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnTransmitToComPort;
        private System.Windows.Forms.TextBox txtByte5;
        private System.Windows.Forms.TextBox txtByte4;
        private System.Windows.Forms.TextBox txtByte3;
        private System.Windows.Forms.TextBox txtByte2;
        private System.Windows.Forms.TextBox txtByte1;
        private System.Windows.Forms.CheckBox chkByte3;
        private System.Windows.Forms.CheckBox chkByte2;
        private System.Windows.Forms.CheckBox chkByte1;
        private System.Windows.Forms.Label lblIncomingDataRate;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox chkShowResponse;
        private System.Windows.Forms.TextBox txtRawSerial;
        private System.Windows.Forms.ToolStripButton btnConnect;
        private System.Windows.Forms.CheckBox chkByte4;
        private System.Windows.Forms.ToolStripTextBox txtBaudRate;
        private System.Windows.Forms.CheckBox chkByte5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cmbComPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.CheckBox cbStepperEnable;
        private System.Windows.Forms.Button btStepperDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btStepperCommand;
        private System.Windows.Forms.Button btStepperMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbStepperSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbStepperRev;
        private System.Windows.Forms.CheckBox cbStepperSteps;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDCPWM;
        private System.Windows.Forms.Button btDCCommand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btDCDir;
        private System.Windows.Forms.CheckBox cbDCEnable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btDCMode;
        private System.Windows.Forms.DataVisualization.Charting.Chart ctData;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.TextBox tbVelocity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox txtByte6;
        private System.Windows.Forms.CheckBox chkByte6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbDirection;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox CbSaveToFile;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Button btSaveFile;
    }
}

