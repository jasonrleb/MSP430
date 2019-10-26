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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.label13 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctData)).BeginInit();
            this.SuspendLayout();
            // 
            // autoReconnectBox
            // 
            this.autoReconnectBox.AutoSize = true;
            this.autoReconnectBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.autoReconnectBox.Location = new System.Drawing.Point(409, 54);
            this.autoReconnectBox.Margin = new System.Windows.Forms.Padding(4);
            this.autoReconnectBox.Name = "autoReconnectBox";
            this.autoReconnectBox.Size = new System.Drawing.Size(131, 21);
            this.autoReconnectBox.TabIndex = 23;
            this.autoReconnectBox.Text = "Auto Reconnect";
            this.autoReconnectBox.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnTransmitToComPort
            // 
            this.btnTransmitToComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnTransmitToComPort.Location = new System.Drawing.Point(9, 160);
            this.btnTransmitToComPort.Margin = new System.Windows.Forms.Padding(4);
            this.btnTransmitToComPort.Name = "btnTransmitToComPort";
            this.btnTransmitToComPort.Size = new System.Drawing.Size(539, 43);
            this.btnTransmitToComPort.TabIndex = 22;
            this.btnTransmitToComPort.Text = "Transmit to Com Port";
            this.btnTransmitToComPort.UseVisualStyleBackColor = true;
            this.btnTransmitToComPort.Click += new System.EventHandler(this.btnTransmitToComPort_Click);
            // 
            // txtByte5
            // 
            this.txtByte5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtByte5.Location = new System.Drawing.Point(447, 119);
            this.txtByte5.Margin = new System.Windows.Forms.Padding(4);
            this.txtByte5.Name = "txtByte5";
            this.txtByte5.Size = new System.Drawing.Size(100, 30);
            this.txtByte5.TabIndex = 20;
            this.txtByte5.TextChanged += new System.EventHandler(this.genericTextBoxEventHandler);
            // 
            // txtByte4
            // 
            this.txtByte4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtByte4.Location = new System.Drawing.Point(337, 119);
            this.txtByte4.Margin = new System.Windows.Forms.Padding(4);
            this.txtByte4.Name = "txtByte4";
            this.txtByte4.Size = new System.Drawing.Size(100, 30);
            this.txtByte4.TabIndex = 19;
            this.txtByte4.TextChanged += new System.EventHandler(this.genericTextBoxEventHandler);
            // 
            // txtByte3
            // 
            this.txtByte3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtByte3.Location = new System.Drawing.Point(228, 119);
            this.txtByte3.Margin = new System.Windows.Forms.Padding(4);
            this.txtByte3.Name = "txtByte3";
            this.txtByte3.Size = new System.Drawing.Size(100, 30);
            this.txtByte3.TabIndex = 18;
            this.txtByte3.TextChanged += new System.EventHandler(this.genericTextBoxEventHandler);
            // 
            // txtByte2
            // 
            this.txtByte2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtByte2.Location = new System.Drawing.Point(119, 119);
            this.txtByte2.Margin = new System.Windows.Forms.Padding(4);
            this.txtByte2.Name = "txtByte2";
            this.txtByte2.Size = new System.Drawing.Size(100, 30);
            this.txtByte2.TabIndex = 17;
            this.txtByte2.TextChanged += new System.EventHandler(this.genericTextBoxEventHandler);
            // 
            // txtByte1
            // 
            this.txtByte1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtByte1.Location = new System.Drawing.Point(9, 119);
            this.txtByte1.Margin = new System.Windows.Forms.Padding(4);
            this.txtByte1.Name = "txtByte1";
            this.txtByte1.Size = new System.Drawing.Size(100, 30);
            this.txtByte1.TabIndex = 16;
            this.txtByte1.TextChanged += new System.EventHandler(this.genericTextBoxEventHandler);
            // 
            // chkByte3
            // 
            this.chkByte3.AutoSize = true;
            this.chkByte3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chkByte3.Location = new System.Drawing.Point(228, 86);
            this.chkByte3.Margin = new System.Windows.Forms.Padding(4);
            this.chkByte3.Name = "chkByte3";
            this.chkByte3.Size = new System.Drawing.Size(78, 21);
            this.chkByte3.TabIndex = 15;
            this.chkByte3.Text = "Byte #3";
            this.chkByte3.UseVisualStyleBackColor = true;
            this.chkByte3.CheckedChanged += new System.EventHandler(this.chkByte3_CheckedChanged);
            // 
            // chkByte2
            // 
            this.chkByte2.AutoSize = true;
            this.chkByte2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chkByte2.Location = new System.Drawing.Point(119, 86);
            this.chkByte2.Margin = new System.Windows.Forms.Padding(4);
            this.chkByte2.Name = "chkByte2";
            this.chkByte2.Size = new System.Drawing.Size(78, 21);
            this.chkByte2.TabIndex = 14;
            this.chkByte2.Text = "Byte #2";
            this.chkByte2.UseVisualStyleBackColor = true;
            this.chkByte2.CheckedChanged += new System.EventHandler(this.chkByte2_CheckedChanged);
            // 
            // chkByte1
            // 
            this.chkByte1.AutoSize = true;
            this.chkByte1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chkByte1.Location = new System.Drawing.Point(9, 86);
            this.chkByte1.Margin = new System.Windows.Forms.Padding(4);
            this.chkByte1.Name = "chkByte1";
            this.chkByte1.Size = new System.Drawing.Size(78, 21);
            this.chkByte1.TabIndex = 13;
            this.chkByte1.Text = "Byte #1";
            this.chkByte1.UseVisualStyleBackColor = true;
            this.chkByte1.CheckedChanged += new System.EventHandler(this.chkByte1_CheckedChanged);
            // 
            // lblIncomingDataRate
            // 
            this.lblIncomingDataRate.AutoSize = true;
            this.lblIncomingDataRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblIncomingDataRate.Location = new System.Drawing.Point(891, 0);
            this.lblIncomingDataRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIncomingDataRate.Name = "lblIncomingDataRate";
            this.lblIncomingDataRate.Size = new System.Drawing.Size(199, 17);
            this.lblIncomingDataRate.TabIndex = 8;
            this.lblIncomingDataRate.Text = "Incoming data rate = 0 [byte/s]";
            // 
            // chkShowResponse
            // 
            this.chkShowResponse.AutoSize = true;
            this.chkShowResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chkShowResponse.Location = new System.Drawing.Point(177, 54);
            this.chkShowResponse.Margin = new System.Windows.Forms.Padding(4);
            this.chkShowResponse.Name = "chkShowResponse";
            this.chkShowResponse.Size = new System.Drawing.Size(188, 21);
            this.chkShowResponse.TabIndex = 12;
            this.chkShowResponse.Text = "Response from Com Port";
            this.chkShowResponse.UseVisualStyleBackColor = true;
            // 
            // txtRawSerial
            // 
            this.txtRawSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRawSerial.Location = new System.Drawing.Point(12, 434);
            this.txtRawSerial.Margin = new System.Windows.Forms.Padding(4);
            this.txtRawSerial.Multiline = true;
            this.txtRawSerial.Name = "txtRawSerial";
            this.txtRawSerial.Size = new System.Drawing.Size(1081, 75);
            this.txtRawSerial.TabIndex = 21;
            // 
            // btnConnect
            // 
            this.btnConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnConnect.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect.Image")));
            this.btnConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(67, 28);
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // chkByte4
            // 
            this.chkByte4.AutoSize = true;
            this.chkByte4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chkByte4.Location = new System.Drawing.Point(337, 86);
            this.chkByte4.Margin = new System.Windows.Forms.Padding(4);
            this.chkByte4.Name = "chkByte4";
            this.chkByte4.Size = new System.Drawing.Size(78, 21);
            this.chkByte4.TabIndex = 11;
            this.chkByte4.Text = "Byte #4";
            this.chkByte4.UseVisualStyleBackColor = true;
            this.chkByte4.CheckedChanged += new System.EventHandler(this.chkByte4_CheckedChanged);
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(92, 28);
            this.txtBaudRate.Text = "9600";
            // 
            // chkByte5
            // 
            this.chkByte5.AutoSize = true;
            this.chkByte5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chkByte5.Location = new System.Drawing.Point(447, 86);
            this.chkByte5.Margin = new System.Windows.Forms.Padding(4);
            this.chkByte5.Name = "chkByte5";
            this.chkByte5.Size = new System.Drawing.Size(78, 21);
            this.chkByte5.TabIndex = 10;
            this.chkByte5.Text = "Byte #5";
            this.chkByte5.UseVisualStyleBackColor = true;
            this.chkByte5.CheckedChanged += new System.EventHandler(this.chkByte5_CheckedChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(80, 25);
            this.toolStripLabel1.Text = "Baud Rate:";
            // 
            // cmbComPort
            // 
            this.cmbComPort.Name = "cmbComPort";
            this.cmbComPort.Size = new System.Drawing.Size(159, 28);
            this.cmbComPort.DropDown += new System.EventHandler(this.cmbComPort_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(4, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
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
            this.toolStrip1.Size = new System.Drawing.Size(1116, 31);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cbStepperEnable
            // 
            this.cbStepperEnable.AutoSize = true;
            this.cbStepperEnable.Location = new System.Drawing.Point(276, 239);
            this.cbStepperEnable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStepperEnable.Name = "cbStepperEnable";
            this.cbStepperEnable.Size = new System.Drawing.Size(177, 21);
            this.cbStepperEnable.TabIndex = 25;
            this.cbStepperEnable.Text = "Stepper Control Enable";
            this.cbStepperEnable.UseVisualStyleBackColor = true;
            this.cbStepperEnable.CheckedChanged += new System.EventHandler(this.CbStepperEnable_CheckedChanged);
            // 
            // btStepperDir
            // 
            this.btStepperDir.Location = new System.Drawing.Point(276, 266);
            this.btStepperDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btStepperDir.Name = "btStepperDir";
            this.btStepperDir.Size = new System.Drawing.Size(91, 37);
            this.btStepperDir.TabIndex = 26;
            this.btStepperDir.Text = "CW";
            this.btStepperDir.UseVisualStyleBackColor = true;
            this.btStepperDir.Click += new System.EventHandler(this.BtStepperDir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Toggle Direction";
            // 
            // btStepperCommand
            // 
            this.btStepperCommand.Location = new System.Drawing.Point(276, 385);
            this.btStepperCommand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btStepperCommand.Name = "btStepperCommand";
            this.btStepperCommand.Size = new System.Drawing.Size(427, 36);
            this.btStepperCommand.TabIndex = 28;
            this.btStepperCommand.Text = "Send Command";
            this.btStepperCommand.UseVisualStyleBackColor = true;
            this.btStepperCommand.Click += new System.EventHandler(this.BtStepperCommand_Click);
            // 
            // btStepperMode
            // 
            this.btStepperMode.Location = new System.Drawing.Point(276, 309);
            this.btStepperMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btStepperMode.Name = "btStepperMode";
            this.btStepperMode.Size = new System.Drawing.Size(91, 39);
            this.btStepperMode.TabIndex = 29;
            this.btStepperMode.Text = "Step";
            this.btStepperMode.UseVisualStyleBackColor = true;
            this.btStepperMode.Click += new System.EventHandler(this.BtStepperMode_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Toggle Mode";
            // 
            // tbStepperSpeed
            // 
            this.tbStepperSpeed.Location = new System.Drawing.Point(276, 354);
            this.tbStepperSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbStepperSpeed.Name = "tbStepperSpeed";
            this.tbStepperSpeed.Size = new System.Drawing.Size(91, 22);
            this.tbStepperSpeed.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Constant Mode Speed";
            // 
            // cbStepperRev
            // 
            this.cbStepperRev.AutoSize = true;
            this.cbStepperRev.Location = new System.Drawing.Point(627, 352);
            this.cbStepperRev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStepperRev.Name = "cbStepperRev";
            this.cbStepperRev.Size = new System.Drawing.Size(69, 21);
            this.cbStepperRev.TabIndex = 33;
            this.cbStepperRev.Text = "[rev/s]";
            this.cbStepperRev.UseVisualStyleBackColor = true;
            this.cbStepperRev.CheckedChanged += new System.EventHandler(this.CbStepperRev_CheckedChanged);
            // 
            // cbStepperSteps
            // 
            this.cbStepperSteps.AutoSize = true;
            this.cbStepperSteps.Location = new System.Drawing.Point(532, 352);
            this.cbStepperSteps.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStepperSteps.Name = "cbStepperSteps";
            this.cbStepperSteps.Size = new System.Drawing.Size(83, 21);
            this.cbStepperSteps.TabIndex = 34;
            this.cbStepperSteps.Text = "[steps/s]";
            this.cbStepperSteps.UseVisualStyleBackColor = true;
            this.cbStepperSteps.CheckedChanged += new System.EventHandler(this.CbStepperSteps_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "PWM Duty [%]";
            // 
            // tbDCPWM
            // 
            this.tbDCPWM.Location = new System.Drawing.Point(12, 353);
            this.tbDCPWM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDCPWM.Name = "tbDCPWM";
            this.tbDCPWM.Size = new System.Drawing.Size(91, 22);
            this.tbDCPWM.TabIndex = 41;
            // 
            // btDCCommand
            // 
            this.btDCCommand.Location = new System.Drawing.Point(12, 385);
            this.btDCCommand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDCCommand.Name = "btDCCommand";
            this.btDCCommand.Size = new System.Drawing.Size(235, 36);
            this.btDCCommand.TabIndex = 38;
            this.btDCCommand.Text = "Send Command";
            this.btDCCommand.UseVisualStyleBackColor = true;
            this.btDCCommand.Click += new System.EventHandler(this.BtDCCommand_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "Toggle Direction";
            // 
            // btDCDir
            // 
            this.btDCDir.Location = new System.Drawing.Point(12, 266);
            this.btDCDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDCDir.Name = "btDCDir";
            this.btDCDir.Size = new System.Drawing.Size(91, 37);
            this.btDCDir.TabIndex = 36;
            this.btDCDir.Text = "CW";
            this.btDCDir.UseVisualStyleBackColor = true;
            this.btDCDir.Click += new System.EventHandler(this.BtDCDir_Click);
            // 
            // cbDCEnable
            // 
            this.cbDCEnable.AutoSize = true;
            this.cbDCEnable.Location = new System.Drawing.Point(12, 239);
            this.cbDCEnable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDCEnable.Name = "cbDCEnable";
            this.cbDCEnable.Size = new System.Drawing.Size(186, 21);
            this.cbDCEnable.TabIndex = 35;
            this.cbDCEnable.Text = "DC Motor Control Enable";
            this.cbDCEnable.UseVisualStyleBackColor = true;
            this.cbDCEnable.CheckedChanged += new System.EventHandler(this.CbDCEnable_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "Toggle PWM Mode";
            // 
            // btDCMode
            // 
            this.btDCMode.Location = new System.Drawing.Point(12, 309);
            this.btDCMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDCMode.Name = "btDCMode";
            this.btDCMode.Size = new System.Drawing.Size(91, 37);
            this.btDCMode.TabIndex = 43;
            this.btDCMode.Text = "Pot";
            this.btDCMode.UseVisualStyleBackColor = true;
            this.btDCMode.Click += new System.EventHandler(this.BtDCMode_Click);
            // 
            // ctData
            // 
            chartArea6.Name = "ChartArea1";
            this.ctData.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            legend6.Position.Auto = false;
            legend6.Position.Height = 12.70903F;
            legend6.Position.Width = 25.41806F;
            legend6.Position.X = 20F;
            legend6.Position.Y = 3F;
            this.ctData.Legends.Add(legend6);
            this.ctData.Location = new System.Drawing.Point(577, 34);
            this.ctData.Margin = new System.Windows.Forms.Padding(4);
            this.ctData.Name = "ctData";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series11.Legend = "Legend1";
            series11.LegendText = "[rpm]";
            series11.Name = "RPM";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.Legend = "Legend1";
            series12.LegendText = "[Hz]";
            series12.Name = "Hz";
            this.ctData.Series.Add(series11);
            this.ctData.Series.Add(series12);
            this.ctData.Size = new System.Drawing.Size(517, 300);
            this.ctData.TabIndex = 45;
            this.ctData.Text = "chart1";
            // 
            // tbPosition
            // 
            this.tbPosition.Location = new System.Drawing.Point(957, 351);
            this.tbPosition.Margin = new System.Windows.Forms.Padding(4);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(60, 22);
            this.tbPosition.TabIndex = 46;
            // 
            // tbVelocity
            // 
            this.tbVelocity.Location = new System.Drawing.Point(957, 383);
            this.tbVelocity.Margin = new System.Windows.Forms.Padding(4);
            this.tbVelocity.Name = "tbVelocity";
            this.tbVelocity.Size = new System.Drawing.Size(60, 22);
            this.tbVelocity.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(891, 356);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 48;
            this.label8.Text = "Position";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(891, 386);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 49;
            this.label9.Text = "Velocity";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(736, 354);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 17);
            this.label10.TabIndex = 50;
            this.label10.Text = "Instantaneous Motor: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1027, 386);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 17);
            this.label11.TabIndex = 52;
            this.label11.Text = "[mm/s]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1027, 356);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 51;
            this.label12.Text = "[degrees]";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label13.Location = new System.Drawing.Point(16, 528);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 17);
            this.label13.TabIndex = 53;
            this.label13.Text = "Data logging here...";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 575);
            this.Controls.Add(this.label13);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Timer timer2;
    }
}

