﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Media;
using System.Threading.Tasks;

namespace LAB3_GUI
{
    public partial class Form1 : Form
    {

        public int numberOfDataPoints = 0;

        //PLOT Variables
        int plotLimit = 30;
        int cwEncoder = 0;
        int ccwEncoder = 0;
        int escEncoder = 0;
        int totalCount = 0;
        int position = 0;
        double velocity = 0.0;
        int previousTotalCount = 0;

        ConcurrentQueue<int> encoderQueue = new ConcurrentQueue<int>();

        public Form1()
        {
            InitializeComponent();
        }

        public void ComPortUpdate()
        {
            cmbComPort.Items.Clear();
            string[] comPortArray = System.IO.Ports.SerialPort.GetPortNames().ToArray();
            Array.Reverse(comPortArray);
            cmbComPort.Items.AddRange(comPortArray);
            if (cmbComPort.Items.Count != 0)
                cmbComPort.SelectedIndex = 0;
            else
                cmbComPort.Text = "No Ports Found!";
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            lblIncomingDataRate.Visible = false;
            chkShowResponse.Checked = false;
            chkByte1.Checked = false;
            chkByte2.Checked = false;
            chkByte3.Checked = false;
            chkByte4.Checked = false;
            chkByte5.Checked = false;
            chkByte6.Checked = false;
            txtByte1.Enabled = false;
            txtByte2.Enabled = false;
            txtByte3.Enabled = false;
            txtByte4.Enabled = false;
            txtByte5.Enabled = false;
            txtByte6.Enabled = false;
            ComPortUpdate();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect.Text == "Connect")
            {
                if (cmbComPort.Items.Count > 0)
                {
                    try
                    {
                        serialPort1.BaudRate = Convert.ToInt16(txtBaudRate.Text);
                        serialPort1.PortName = cmbComPort.SelectedItem.ToString();
                        serialPort1.Open();
                        btnConnect.Text = "Disconnect";
                        timer1.Enabled = true;
                        lblIncomingDataRate.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                try
                {
                    serialPort1.Close();
                    btnConnect.Text = "Connect";
                    timer1.Enabled = false;
                    lblIncomingDataRate.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void chkByte1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkByte1.Checked == true)
                txtByte1.Enabled = true;
            else
            {
                txtByte1.Clear();
                txtByte1.Enabled = false;
            }
        }

        private void chkByte2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkByte2.Checked == true)
                txtByte2.Enabled = true;
            else
            {
                txtByte2.Clear();
                txtByte2.Enabled = false;
            }
        }

        private void chkByte3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkByte3.Checked == true)
                txtByte3.Enabled = true;
            else
            {
                txtByte3.Clear();
                txtByte3.Enabled = false;
            }
        }

        private void genericTextBoxEventHandler(object sender, EventArgs e)
        {
            TextBox currentTextBox = sender as TextBox;
            short parseResult;
            if (Int16.TryParse((currentTextBox.Text), out parseResult))
            {
                if (parseResult > 255)
                    parseResult = 255;
                if (parseResult <= 0)
                    parseResult = 0;
                currentTextBox.Text = parseResult.ToString();
            }
            else
                currentTextBox.Text = "";
        }

        private void btnTransmitToComPort_Click(object sender, EventArgs e)
        {
            byte[] TxBytes = new Byte[6];

            try
            {
                if (serialPort1.IsOpen && (!cbDCEnable.Checked || !cbStepperEnable.Checked))
                {
                    if ((chkByte1.Checked && (txtByte1.Text == "")) || (chkByte2.Checked && (txtByte2.Text == "")) || (chkByte3.Checked && (txtByte3.Text == "")) || (chkByte4.Checked && (txtByte4.Text == "")) || (chkByte5.Checked && (txtByte5.Text == "")) || (chkByte6.Checked && (txtByte6.Text == "")))
                    {
                        MessageBox.Show("Occupy empty bytes...", "ERROR", 0);
                    }
                    else {
                        if (chkByte1.Checked && (txtByte1.Text != ""))
                        {
                            TxBytes[0] = Convert.ToByte(txtByte1.Text);
                            serialPort1.Write(TxBytes, 0, 1);
                            txtRawSerial.AppendText(TxBytes[0].ToString() + ", "); //prints to display box
                        }
                        if (chkByte2.Checked && (txtByte2.Text != ""))
                        {
                            TxBytes[1] = Convert.ToByte(txtByte2.Text);
                            serialPort1.Write(TxBytes, 1, 1);
                            txtRawSerial.AppendText(TxBytes[1].ToString() + ", ");
                        }
                        if (chkByte3.Checked && (txtByte3.Text != ""))
                        {
                            TxBytes[2] = Convert.ToByte(txtByte3.Text);
                            serialPort1.Write(TxBytes, 2, 1);
                            txtRawSerial.AppendText(TxBytes[2].ToString() + ", ");
                        }
                        if (chkByte4.Checked && (txtByte4.Text != ""))
                        {
                            TxBytes[3] = Convert.ToByte(txtByte4.Text);
                            serialPort1.Write(TxBytes, 3, 1);
                            txtRawSerial.AppendText(TxBytes[3].ToString() + ", ");
                        }
                        if (chkByte5.Checked && (txtByte5.Text != ""))
                        {
                            TxBytes[4] = Convert.ToByte(txtByte5.Text);
                            serialPort1.Write(TxBytes, 4, 1);
                            txtRawSerial.AppendText(TxBytes[4].ToString() + ", ");
                        }
                        if (chkByte6.Checked && (txtByte6.Text != ""))
                        {
                            TxBytes[5] = Convert.ToByte(txtByte6.Text);
                            serialPort1.Write(TxBytes, 5, 1);
                            txtRawSerial.AppendText(TxBytes[5].ToString() + ", ");
                        }
                    }
                }
                else {
                    if (serialPort1.IsOpen)
                    {
                        MessageBox.Show("No device connected...", "ERROR", 0);
                    }
                    if (cbStepperEnable.Checked)
                    {
                        MessageBox.Show("Disable Stepper motor mode...", "ERROR", 0);
                    }
                    if (cbDCEnable.Checked)
                    {
                        MessageBox.Show("Disable DC motor mode...", "ERROR", 0);
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void chkByte4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkByte4.Checked == true)
                txtByte4.Enabled = true;
            else
            {
                txtByte4.Clear();
                txtByte4.Enabled = false;
            }
        }

        private void chkByte5_CheckedChanged(object sender, EventArgs e)
        {
            if (chkByte5.Checked == true)
                txtByte5.Enabled = true;
            else
            {
                txtByte5.Clear();
                txtByte5.Enabled = false;
            }
        }

        private void chkByte6_CheckedChanged(object sender, EventArgs e)
        {
            if (chkByte6.Checked == true)
                txtByte6.Enabled = true;
            else
            {
                txtByte6.Clear();
                txtByte6.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblIncomingDataRate.Text = "Incoming data rate = " + numberOfDataPoints.ToString() + " [byte/s]";

            //Adding a check to reconect to the serial port if there is no data streaming
            if (autoReconnectBox.Checked == true && numberOfDataPoints == 0 && serialPort1.IsOpen == true)
            {

                try
                {
                    serialPort1.Close();
                    serialPort1.BaudRate = Convert.ToInt16(txtBaudRate.Text);
                    serialPort1.PortName = cmbComPort.SelectedItem.ToString();
                    serialPort1.Open();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }

            }

            numberOfDataPoints = 0;
        }

        private void cmbComPort_DropDown(object sender, EventArgs e)
        {
            ComPortUpdate();
        }


        //NEW CODE ADDED HERE DOWN --------------------------------------------------------


        //Receive Data
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //int currentByte = 0;
            //while (serialPort1.IsOpen && serialPort1.BytesToRead != 0)
            //{
            //    currentByte = serialPort1.ReadByte();
            //    numberOfDataPoints++;
            //    if (chkShowResponse.Checked)
            //        this.BeginInvoke(new EventHandler(delegate
            //        {
            //            txtRawSerial.AppendText(currentByte + ", ");
            //        }));
            //}

            //    if (currentByte == 255)
            //    {

            //    }




            while ((serialPort1.BytesToRead > 0) && serialPort1.IsOpen) //collects data from serial port and stores in queue
            {
                try
                {

                    if (serialPort1.ReadByte() == 255)
                    {
                        cwEncoder = serialPort1.ReadByte();
                        ccwEncoder = serialPort1.ReadByte();
                        escEncoder = serialPort1.ReadByte();

                    }


                    serialPort1.DiscardInBuffer(); //clears VS buffer so data collection stops in the background
                                                   //BytesToRead = 0;
                }

                //error handlers
                catch (System.InvalidOperationException) { }
                catch (System.IO.IOException) { }

            }

        }





        

        //Sets stepper direction: CW / CCW
        private void BtStepperDir_Click(object sender, EventArgs e)
        {
            if (btStepperDir.Text == "CW")
            {
                btStepperDir.Text = "CCW";
                return;
            }
            if (btStepperDir.Text == "CCW")
            {
                btStepperDir.Text = "STOP";
                return;
            }
            if (btStepperDir.Text == "STOP")
            {
                btStepperDir.Text = "CW";
                return;
            }
        }


        //Sets Stepper mode: Step / Constant 
        private void BtStepperMode_Click(object sender, EventArgs e)
        {
            if (btStepperMode.Text == "Step")
            {
                btStepperMode.Text = "Constant";
            }
            else
            {
                btStepperMode.Text = "Step";
            }
        }


        //Prevent Stepper Rev vs Step units from being selected at same time
        private void CbStepperRev_CheckedChanged(object sender, EventArgs e)
        {
            if (cbStepperRev.Checked && cbStepperSteps.Checked)
            {
                cbStepperSteps.Checked = false;
            }
        }

        private void CbStepperSteps_CheckedChanged(object sender, EventArgs e)
        {
            if (cbStepperRev.Checked && cbStepperSteps.Checked)
            {
                cbStepperRev.Checked = false;
            }

        }


        //Stepper Output
        private void BtStepperCommand_Click(object sender, EventArgs e)
        {
            byte[] TxBytes = new Byte[6]; //1 Start byte, 1 Dir byte, 1 Mode byte, 1 Speed byte

            //Set start byte
            TxBytes[0] = 255;

            //Sets Motor Byte
            TxBytes[1] = 1; //Stepper Mode [1]

            //Set mode byte
            if (btStepperMode.Text == "Step")
            {
                TxBytes[2] = 0;
            }
            if (btStepperMode.Text == "Constant")
            {
                TxBytes[2] = 1;
            }

            //Set direction byte
            if (btStepperDir.Text == "CW")
            {
                TxBytes[3] = 0;
            }
            if (btStepperDir.Text == "CCW")
            {
                TxBytes[3] = 1;
            }
            if (btStepperDir.Text == "STOP")
            {
                TxBytes[3] = 2;
            }

            //Set speed units
            if (cbStepperRev.Checked)
            {
                TxBytes[4] = 0; //Rev/s [0]
            }
            if (cbStepperSteps.Checked)
            {
                TxBytes[4] = 1; //Steps/s [1]
            }

            //Set Speed byte
            int speed = 0;
            if (btStepperMode.Text == "Constant")
            {
                Int32.TryParse(tbStepperSpeed.Text, out speed); //converts speed input to integer
                TxBytes[5] = (byte)(speed);
            }

            //Transmit bytes
            if (cbStepperEnable.Checked) //ERROR: Stepper mode enable check
            {
                //ERROR Checking
                if (btStepperMode.Text == "Constant" && (speed <= 0 || (!cbStepperRev.Checked && !cbStepperSteps.Checked)))
                {
                    //ERROR if non-integer input
                    if (speed <= 0)
                    {
                        MessageBox.Show("Invalid speed input, enter integer value from 0-255", "ERROR", 0);
                        tbStepperSpeed.Text = "";
                    }

                    //ERROR if no units selected
                    if (!cbStepperRev.Checked && !cbStepperSteps.Checked)
                    {
                        MessageBox.Show("No units selected...", "ERROR", 0);
                    }
                }

                //Send data
                else
                {
                    try
                    {
                        if (serialPort1.IsOpen) //ERROR Check Serial Port Open
                        {
                            int i;
                            for (i = 0; i < 6; i++) //Send bytes
                            {
                                serialPort1.Write(TxBytes, i, 1);
                                txtRawSerial.AppendText(TxBytes[i].ToString() + ", "); //DEBUG
                            }
                        }
                        else
                        {
                            MessageBox.Show("No device connected...", "ERROR", 0);
                        }
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Stepper Control not enabled...", "ERROR", 0);
            }

        }


        //Prevent DC Motor & Stepper from being enabled at same time
        private void CbStepperEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (cbStepperEnable.Checked && cbDCEnable.Checked)
            {
                cbDCEnable.Checked = false;
            }
        }

        private void CbDCEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (cbStepperEnable.Checked && cbDCEnable.Checked)
            {
                cbStepperEnable.Checked = false;
            }
        }


        //Sets stepper direction: CW / CCW
        private void BtDCDir_Click(object sender, EventArgs e)
        {
            if (btDCDir.Text == "CW")
            {
                btDCDir.Text = "CCW";
                return;
            }
            if (btDCDir.Text == "CCW")
            {
                btDCDir.Text = "STOP";
                return;
            }
            if (btDCDir.Text == "STOP")
            {
                btDCDir.Text = "CW";
                return;
            }
        }


        //DC Motor Output
        private void BtDCCommand_Click(object sender, EventArgs e)
        {
            byte[] TxBytes = new Byte[6]; //1 Start byte, 1 Dir byte, 2 PWM bytes (16bit)

            //Set start byte
            TxBytes[0] = 255;

            //Sets Motor Byte
            TxBytes[1] = 0; //DC Mode [0]

            //Set mode byte
            if (btDCMode.Text == "Pot") //Add error check for mode selection
            {
                TxBytes[2] = 0;
            }
            if (btDCMode.Text == "Duty")
            {
                TxBytes[2] = 1;
            }

            //Set direction byte
            if (btDCDir.Text == "CW")
            {
                TxBytes[3] = 0;
            }
            if (btDCDir.Text == "CCW")
            {
                TxBytes[3] = 1;
            }
            if (btDCDir.Text == "STOP")
            {
                TxBytes[3] = 2;
            }

            //Set PWM Duty byte
            int duty = 0;
            Int32.TryParse(tbDCPWM.Text, out duty); //converts speed input to integer
            int pwm = 65535 - ((65535 * duty) / 100); //gets appropriate count value based on PWM duty

            TxBytes[5] = (byte)(pwm & 0xff);
            TxBytes[4] = (byte)((pwm >> 8) & 0xff);


            //Transmit bytes
            if (cbDCEnable.Checked)
            {  //ERROR DC Motor enable check

                //ERROR: Check mode and appropriate input
                if (btDCMode.Text == "Duty" && (duty > 100 || duty <= 0)) //ERROR Invalid input check
                {
                    MessageBox.Show("Invalid PWM Duty input, enter integer value from 1-100...", "ERROR", 0);
                    tbDCPWM.Text = "";
                }

                //Transmit Data
                else
                {
                    try
                    {
                        if (serialPort1.IsOpen)//Serial port check if open
                        {
                            int i;
                            for (i = 0; i < 6; i++) //Send bytes
                            {
                                serialPort1.Write(TxBytes, i, 1);
                                txtRawSerial.AppendText(TxBytes[i].ToString() + ", "); //DEBUG
                            }
                        }
                        else
                        {
                            MessageBox.Show("No device connected...", "ERROR", 0);
                        }
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }

            }
            else
            {
                MessageBox.Show("DC Motor Control not enabled...", "ERROR", 0);
            }
        }


        //DC Mode Select
        private void BtDCMode_Click(object sender, EventArgs e)
        {
            //if (btDCMode.Text == "Pot")
            //{
            //    btDCMode.Text = "Duty";
            //    return;
            //}

            //if (btDCMode.Text == "Duty")
            //{
            //    btDCMode.Text = "Pot";
            //    return;
            //}
            return;
        }

        //TIMER: Data Recieve & Buffer
        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (chkShowResponse.Checked)
            {
                txtRawSerial.AppendText("255" + ", ");
                txtRawSerial.AppendText(cwEncoder.ToString() + ", ");
                txtRawSerial.AppendText(ccwEncoder.ToString() + ", ");
                txtRawSerial.AppendText(escEncoder.ToString() + ", ");
            }

            //Handle escape byte conversion of data
            if(escEncoder == 1)
            {
                cwEncoder = 255;
            }
            else if(escEncoder == 2)
            {
                ccwEncoder = 255;
            }
            else if(escEncoder == 3)
            {
                cwEncoder = 255;
                ccwEncoder = 255;
            }

            //Calculate Position & Velocity
            previousTotalCount = totalCount;
            totalCount += ccwEncoder - cwEncoder;

            position = totalCount % 2000; //400 counts per rev
            tbPosition.Text = Convert.ToString(position);

            velocity = (totalCount - previousTotalCount) * 10 * 60 / 2000;    // rpm
            tbVelocity.Text = Convert.ToString(velocity);

            if (velocity > 0)
                tbDirection.Text = "CW";
            if(velocity < 0)
                tbDirection.Text = "CCW";
            if (velocity == 0)
                tbDirection.Text = "Stopped";

            velocity = Math.Abs(velocity);
            position = Math.Abs(position);

            ctData.Series["RPM"].Points.AddY(velocity);
            ctData.Series["Position"].Points.AddY(position);

            //PLOT CONTROL
            if (ctData.Series["RPM"].Points.Count > plotLimit) //Limits plot size, and removes old data
            {
                ctData.Series["RPM"].Points.RemoveAt(0);
                ctData.Series["Position"].Points.RemoveAt(0);
                ctData.ChartAreas[0].AxisY.Maximum = 2000;
                ctData.ChartAreas[0].AxisY.Minimum = 0;
            }
        }
    }

}




        // Average all new data from serial buffer accumulated w/i time interval

//        private void processData()
//        {
//            var objPositionSeries = chartPosition.Series["Position"];
//            var objVelocitySeries = chartVelocity.Series["Velocity"];

//            while (dataQueue.Count > 0)
//            {
//                int data;
//                dataQueue.TryDequeue(out data);
//                if (data == 255 && count == 0)
//                {
//                    ++count;
//                }
//                else if (count == 1)
//                {
//                    ref1 = data;
//                    ++count;
//                }
//                else if (count == 2)
//                {
//                    ref2 = data;
//                    ++count;
//                }
//                else if (count == 3)
//                {
//                    if (data == 1) { ref1 = 255; }
//                    else if (data == 2)
//                    {
//                        ref2 = 255;
//                    }
//                    else if (data == 3)
//                    {
//                        ref1 = 255;
//                        ref2 = 255;
//                    }
//                    count = 0;
//                    previousTotalCount = totalCount;
//                    previousPosition = position;

//                    totalCount += ref1 - ref2;
//                    position = totalCount % 400;         // encoder counts per revolution
//                    velocity = (totalCount - previousTotalCount) * 45.75 * 60 / 100;    // rpm
//                    if (velocity > 0)
//                        txtDirection.Text = "CW";
//                    else
//                        txtDirection.Text = "CCW";

//                    objPositionSeries.Points.AddY(position);
//                    objVelocitySeries.Points.AddY(velocity);

//                    if (objPositionSeries.Points.Count() > maxPlotWidth)
//                    {
//                        objPositionSeries.Points.RemoveAt(0);
//                        objVelocitySeries.Points.RemoveAt(0);
//                    }

//                    // Display it on the text boxes
//                    txtPosition.Text = Convert.ToString(position);
//                    txtRPM.Text = Convert.ToString(velocity);
//                    txtHz.Text = Convert.ToString(velocity / 60);
//                }
//            }
//        }
//    }
//}

