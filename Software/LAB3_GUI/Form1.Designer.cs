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
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // autoReconnectBox
            // 
            this.autoReconnectBox.AutoSize = true;
            this.autoReconnectBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoReconnectBox.Location = new System.Drawing.Point(360, 200);
            this.autoReconnectBox.Margin = new System.Windows.Forms.Padding(4);
            this.autoReconnectBox.Name = "autoReconnectBox";
            this.autoReconnectBox.Size = new System.Drawing.Size(173, 29);
            this.autoReconnectBox.TabIndex = 23;
            this.autoReconnectBox.Text = "Auto Reconnect";
            this.autoReconnectBox.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // btnTransmitToComPort
            // 
            this.btnTransmitToComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransmitToComPort.Location = new System.Drawing.Point(13, 150);
            this.btnTransmitToComPort.Margin = new System.Windows.Forms.Padding(4);
            this.btnTransmitToComPort.Name = "btnTransmitToComPort";
            this.btnTransmitToComPort.Size = new System.Drawing.Size(539, 43);
            this.btnTransmitToComPort.TabIndex = 22;
            this.btnTransmitToComPort.Text = "Transmit to Com Port";
            this.btnTransmitToComPort.UseVisualStyleBackColor = true;
            // 
            // txtByte5
            // 
            this.txtByte5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtByte5.Location = new System.Drawing.Point(450, 110);
            this.txtByte5.Margin = new System.Windows.Forms.Padding(4);
            this.txtByte5.Name = "txtByte5";
            this.txtByte5.Size = new System.Drawing.Size(100, 30);
            this.txtByte5.TabIndex = 20;
            // 
            // txtByte4
            // 
            this.txtByte4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtByte4.Location = new System.Drawing.Point(341, 110);
            this.txtByte4.Margin = new System.Windows.Forms.Padding(4);
            this.txtByte4.Name = "txtByte4";
            this.txtByte4.Size = new System.Drawing.Size(100, 30);
            this.txtByte4.TabIndex = 19;
            // 
            // txtByte3
            // 
            this.txtByte3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtByte3.Location = new System.Drawing.Point(232, 110);
            this.txtByte3.Margin = new System.Windows.Forms.Padding(4);
            this.txtByte3.Name = "txtByte3";
            this.txtByte3.Size = new System.Drawing.Size(100, 30);
            this.txtByte3.TabIndex = 18;
            // 
            // txtByte2
            // 
            this.txtByte2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtByte2.Location = new System.Drawing.Point(122, 110);
            this.txtByte2.Margin = new System.Windows.Forms.Padding(4);
            this.txtByte2.Name = "txtByte2";
            this.txtByte2.Size = new System.Drawing.Size(100, 30);
            this.txtByte2.TabIndex = 17;
            // 
            // txtByte1
            // 
            this.txtByte1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtByte1.Location = new System.Drawing.Point(13, 110);
            this.txtByte1.Margin = new System.Windows.Forms.Padding(4);
            this.txtByte1.Name = "txtByte1";
            this.txtByte1.Size = new System.Drawing.Size(100, 30);
            this.txtByte1.TabIndex = 16;
            // 
            // chkByte3
            // 
            this.chkByte3.AutoSize = true;
            this.chkByte3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkByte3.Location = new System.Drawing.Point(232, 76);
            this.chkByte3.Margin = new System.Windows.Forms.Padding(4);
            this.chkByte3.Name = "chkByte3";
            this.chkByte3.Size = new System.Drawing.Size(93, 28);
            this.chkByte3.TabIndex = 15;
            this.chkByte3.Text = "Byte #3";
            this.chkByte3.UseVisualStyleBackColor = true;
            // 
            // chkByte2
            // 
            this.chkByte2.AutoSize = true;
            this.chkByte2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkByte2.Location = new System.Drawing.Point(122, 76);
            this.chkByte2.Margin = new System.Windows.Forms.Padding(4);
            this.chkByte2.Name = "chkByte2";
            this.chkByte2.Size = new System.Drawing.Size(93, 28);
            this.chkByte2.TabIndex = 14;
            this.chkByte2.Text = "Byte #2";
            this.chkByte2.UseVisualStyleBackColor = true;
            // 
            // chkByte1
            // 
            this.chkByte1.AutoSize = true;
            this.chkByte1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkByte1.Location = new System.Drawing.Point(13, 76);
            this.chkByte1.Margin = new System.Windows.Forms.Padding(4);
            this.chkByte1.Name = "chkByte1";
            this.chkByte1.Size = new System.Drawing.Size(93, 28);
            this.chkByte1.TabIndex = 13;
            this.chkByte1.Text = "Byte #1";
            this.chkByte1.UseVisualStyleBackColor = true;
            // 
            // lblIncomingDataRate
            // 
            this.lblIncomingDataRate.AutoSize = true;
            this.lblIncomingDataRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomingDataRate.Location = new System.Drawing.Point(7, 297);
            this.lblIncomingDataRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIncomingDataRate.Name = "lblIncomingDataRate";
            this.lblIncomingDataRate.Size = new System.Drawing.Size(369, 25);
            this.lblIncomingDataRate.TabIndex = 8;
            this.lblIncomingDataRate.Text = "Incoming Data Rate = 0 bytes per second";
            // 
            // chkShowResponse
            // 
            this.chkShowResponse.AutoSize = true;
            this.chkShowResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowResponse.Location = new System.Drawing.Point(13, 200);
            this.chkShowResponse.Margin = new System.Windows.Forms.Padding(4);
            this.chkShowResponse.Name = "chkShowResponse";
            this.chkShowResponse.Size = new System.Drawing.Size(252, 29);
            this.chkShowResponse.TabIndex = 12;
            this.chkShowResponse.Text = "Response from Com Port";
            this.chkShowResponse.UseVisualStyleBackColor = true;
            // 
            // txtRawSerial
            // 
            this.txtRawSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRawSerial.Location = new System.Drawing.Point(12, 237);
            this.txtRawSerial.Margin = new System.Windows.Forms.Padding(4);
            this.txtRawSerial.Multiline = true;
            this.txtRawSerial.Name = "txtRawSerial";
            this.txtRawSerial.Size = new System.Drawing.Size(531, 44);
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
            // 
            // chkByte4
            // 
            this.chkByte4.AutoSize = true;
            this.chkByte4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkByte4.Location = new System.Drawing.Point(341, 76);
            this.chkByte4.Margin = new System.Windows.Forms.Padding(4);
            this.chkByte4.Name = "chkByte4";
            this.chkByte4.Size = new System.Drawing.Size(93, 28);
            this.chkByte4.TabIndex = 11;
            this.chkByte4.Text = "Byte #4";
            this.chkByte4.UseVisualStyleBackColor = true;
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(92, 31);
            this.txtBaudRate.Text = "9600";
            // 
            // chkByte5
            // 
            this.chkByte5.AutoSize = true;
            this.chkByte5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkByte5.Location = new System.Drawing.Point(450, 76);
            this.chkByte5.Margin = new System.Windows.Forms.Padding(4);
            this.chkByte5.Name = "chkByte5";
            this.chkByte5.Size = new System.Drawing.Size(93, 28);
            this.chkByte5.TabIndex = 10;
            this.chkByte5.Text = "Byte #5";
            this.chkByte5.UseVisualStyleBackColor = true;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(80, 28);
            this.toolStripLabel1.Text = "Baud Rate:";
            // 
            // cmbComPort
            // 
            this.cmbComPort.Name = "cmbComPort";
            this.cmbComPort.Size = new System.Drawing.Size(159, 31);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Data Packet:";
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
            this.toolStrip1.Size = new System.Drawing.Size(565, 31);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cbStepperEnable
            // 
            this.cbStepperEnable.AutoSize = true;
            this.cbStepperEnable.Location = new System.Drawing.Point(12, 494);
            this.cbStepperEnable.Name = "cbStepperEnable";
            this.cbStepperEnable.Size = new System.Drawing.Size(177, 21);
            this.cbStepperEnable.TabIndex = 25;
            this.cbStepperEnable.Text = "Stepper Control Enable";
            this.cbStepperEnable.UseVisualStyleBackColor = true;
            this.cbStepperEnable.CheckedChanged += new System.EventHandler(this.CbStepperEnable_CheckedChanged);
            // 
            // btStepperDir
            // 
            this.btStepperDir.Location = new System.Drawing.Point(14, 521);
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
            this.label2.Location = new System.Drawing.Point(111, 531);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Toggle Direction";
            // 
            // btStepperCommand
            // 
            this.btStepperCommand.Location = new System.Drawing.Point(12, 641);
            this.btStepperCommand.Name = "btStepperCommand";
            this.btStepperCommand.Size = new System.Drawing.Size(396, 36);
            this.btStepperCommand.TabIndex = 28;
            this.btStepperCommand.Text = "Send Command";
            this.btStepperCommand.UseVisualStyleBackColor = true;
            this.btStepperCommand.Click += new System.EventHandler(this.BtStepperCommand_Click);
            // 
            // btStepperMode
            // 
            this.btStepperMode.Location = new System.Drawing.Point(14, 564);
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
            this.label3.Location = new System.Drawing.Point(111, 575);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Toggle Mode";
            // 
            // tbStepperSpeed
            // 
            this.tbStepperSpeed.Location = new System.Drawing.Point(14, 610);
            this.tbStepperSpeed.Name = "tbStepperSpeed";
            this.tbStepperSpeed.Size = new System.Drawing.Size(91, 22);
            this.tbStepperSpeed.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 613);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Constant Mode Speed";
            // 
            // cbStepperRev
            // 
            this.cbStepperRev.AutoSize = true;
            this.cbStepperRev.Location = new System.Drawing.Point(266, 610);
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
            this.cbStepperSteps.Location = new System.Drawing.Point(341, 611);
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
            this.label5.Location = new System.Drawing.Point(111, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "PWM Value [?]";
            // 
            // tbDCPWM
            // 
            this.tbDCPWM.Location = new System.Drawing.Point(14, 406);
            this.tbDCPWM.Name = "tbDCPWM";
            this.tbDCPWM.Size = new System.Drawing.Size(91, 22);
            this.tbDCPWM.TabIndex = 41;
            // 
            // btDCCommand
            // 
            this.btDCCommand.Location = new System.Drawing.Point(12, 437);
            this.btDCCommand.Name = "btDCCommand";
            this.btDCCommand.Size = new System.Drawing.Size(396, 36);
            this.btDCCommand.TabIndex = 38;
            this.btDCCommand.Text = "Send Command";
            this.btDCCommand.UseVisualStyleBackColor = true;
            this.btDCCommand.Click += new System.EventHandler(this.BtDCCommand_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "Toggle Direction";
            // 
            // btDCDir
            // 
            this.btDCDir.Location = new System.Drawing.Point(14, 363);
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
            this.cbDCEnable.Location = new System.Drawing.Point(12, 336);
            this.cbDCEnable.Name = "cbDCEnable";
            this.cbDCEnable.Size = new System.Drawing.Size(186, 21);
            this.cbDCEnable.TabIndex = 35;
            this.cbDCEnable.Text = "DC Motor Control Enable";
            this.cbDCEnable.UseVisualStyleBackColor = true;
            this.cbDCEnable.CheckedChanged += new System.EventHandler(this.CbDCEnable_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 688);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
    }
}

