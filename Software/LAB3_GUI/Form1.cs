using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LAB3_GUI
{
    public partial class Form1 : Form
    {
        public int numberOfDataPoints = 0;

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

        private void Form1_Load(object sender, EventArgs e)
        {
            lblIncomingDataRate.Visible = false;
            chkShowResponse.Checked = true;
            chkByte1.Checked = false;
            chkByte2.Checked = false;
            chkByte3.Checked = false;
            chkByte4.Checked = false;
            chkByte5.Checked = false;
            txtByte1.Enabled = false;
            txtByte2.Enabled = false;
            txtByte3.Enabled = false;
            txtByte4.Enabled = false;
            txtByte5.Enabled = false;
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

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            while (serialPort1.IsOpen && serialPort1.BytesToRead != 0)
            {
                int currentByte = serialPort1.ReadByte();
                numberOfDataPoints++;
                if (chkShowResponse.Checked)
                    this.BeginInvoke(new EventHandler(delegate
                    {
                        txtRawSerial.AppendText(currentByte.ToString() + ", ");
                    }));
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
            byte[] TxBytes = new Byte[5];

            try
            {
                if (serialPort1.IsOpen)
                {
                    if (chkByte1.Checked && (txtByte1.Text != ""))
                    {
                        TxBytes[0] = Convert.ToByte(txtByte1.Text);
                        serialPort1.Write(TxBytes, 0, 1);
                    }
                    if (chkByte2.Checked && (txtByte2.Text != ""))
                    {
                        TxBytes[1] = Convert.ToByte(txtByte2.Text);
                        serialPort1.Write(TxBytes, 1, 1);
                    }
                    if (chkByte3.Checked && (txtByte3.Text != ""))
                    {
                        TxBytes[2] = Convert.ToByte(txtByte3.Text);
                        serialPort1.Write(TxBytes, 2, 1);
                    }
                    if (chkByte4.Checked && (txtByte4.Text != ""))
                    {
                        TxBytes[3] = Convert.ToByte(txtByte4.Text);
                        serialPort1.Write(TxBytes, 3, 1);
                    }
                    if (chkByte5.Checked && (txtByte5.Text != ""))
                    {
                        TxBytes[4] = Convert.ToByte(txtByte5.Text);
                        serialPort1.Write(TxBytes, 4, 1);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblIncomingDataRate.Text = "Incoming data rate = " + numberOfDataPoints.ToString() + " bytes per second";

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


        //Sets stepper direction: CW / CCW
        private void BtStepperDir_Click(object sender, EventArgs e)
        {
            if(btStepperDir.Text == "CW")
            {
                btStepperDir.Text = "CCW";
            }
            else
            {
                btStepperDir.Text = "CW";
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
            int result = 0;
            Int32.TryParse(tbStepperSpeed.Text, out result); //converts speed input to integer

            if (cbStepperEnable.Checked)
            {
                if (btStepperMode.Text == "Constant")
                {
                    //ERROR Checking
                    if (result <= 0 || (!cbStepperRev.Checked && !cbStepperSteps.Checked))
                    {
                        //ERROR if non-integer input
                        if (result <= 0)
                        {
                            MessageBox.Show("Invalid speed input, enter integer value...", "ERROR", 0);
                            tbStepperSpeed.Text = "";
                        }

                        //ERROR if no units selected
                        if(!cbStepperRev.Checked && !cbStepperSteps.Checked)
                        {
                            MessageBox.Show("No units selected...", "ERROR", 0);
                        }
                    }

                    //Send data
                    else
                    {
                        //Insert code to send command via uart
                    }
                }

                if (btStepperMode.Text == "Step")
                {
                    //Insert code to send command via uart
                }
            }
            else
            {
                MessageBox.Show("Stepper Control not enabled...", "ERROR",0);
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
            }
            else
            {
                btDCDir.Text = "CW";
            }
        }


        //DC Motor Output
        private void BtDCCommand_Click(object sender, EventArgs e)
        {
            if (cbDCEnable.Checked)
            {
                ////Insert code to send command via uart
            }
            else
            {
                MessageBox.Show("DC Motor Control not enabled...", "ERROR", 0);
            }
        }
    }
}
