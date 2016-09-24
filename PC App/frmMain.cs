using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace SerialComm
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        #region Variables

        /* Enum & Variable storing current panel */
        enum Current_Panel_Enum
        {
            UART_Connection,
            Bluetooth_Connection,
            Control
        }
        private Current_Panel_Enum _currentPanel = Current_Panel_Enum.UART_Connection;

        /* Variable storing state of bluetooth connection */
        private bool _isBluetoothConnected = false;

        /* Seria Port Communication Component */
        SerialPort _serialPort = new SerialPort();

        /* Loading form */
        private frmSplashScreen _splashScreen = new frmSplashScreen();

        /* Receving string type enum */
        enum ReceivingStringType
        {
            None,
            Message,
            Config
        }

        /* Receving string type variable */
        private ReceivingStringType currentReceivingStringType = ReceivingStringType.None;

        /* my buffer */
        private string myBuffer = "";

        /* ignore DataReceiveHandler */
        private bool isIgnoreDataRecerveHandler = false;

        #endregion /* Variables */

        /* Constructor */
        public frmMain()
        {
            _splashScreen.Show();
            InitializeComponent();

            /* Additional initializeComponent */
            cmbPort.SelectedIndex = 0;
            cmbBaudRate.SelectedIndex = 12;
            cmbDataBits.SelectedIndex = 1;
            cmbStopBits.SelectedIndex = 0;
            cmbParity.SelectedIndex = 0;
            cmbHandshake.SelectedIndex = 0;

            tmSystem.Interval = 1500;
            tmSystem.Enabled = true;
            tmSystem.Start();
        }

        /* Send a byte array to UART */
        private void send_UART_Data(byte[] data, uint offset, uint count)
        {
            for (int i = (int)offset; i < (offset + count); i++)
            {
                _serialPort.Write(data, i, 1);
                Thread.Sleep(20);
            }
        }

        #region Panel_Uart_Connection

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cmbPort.Items.Clear();
            cmbPort.Items.Add("None");
            foreach (string s in SerialPort.GetPortNames())
            {
                cmbPort.Items.Add(s);
            }
            cmbPort.SelectedIndex = (cmbPort.Items.Count > 1) ? 1 : 0;
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            /* Reset to default value */
            cmbBaudRate.SelectedIndex = 12;
            cmbDataBits.SelectedIndex = 1;
            cmbStopBits.SelectedIndex = 0;
            cmbParity.SelectedIndex = 0;
            cmbHandshake.SelectedIndex = 0;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            /* Handle with open serial port event */
            if (cmbPort.SelectedIndex <= 0) /* Check if port selected */
            {
                MessageBox.Show("You must connect your KL46Z to PC and select a port to communicate with it!", "Warning: Port unselected!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }

            if (cmbBaudRate.SelectedIndex == -1) /* if user enter a baud rate */
            {
                try
                {
                    int.Parse(cmbBaudRate.Text);
                }
                catch
                {
                    MessageBox.Show("You must select a Baud rate from available list or enter an integer!", "Warning: Unavailable Baud rate!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    cmbBaudRate.Focus();
                    return;
                }
            }

            /* Set up UART characteristics */
            try
            {
                if (_serialPort.IsOpen) /* Check if port is opening */
                {
                    _serialPort.Close();
                }

                /* Set SerialConnection characteristics */
                _serialPort.PortName = cmbPort.Text;
                _serialPort.BaudRate = int.Parse(cmbBaudRate.Text);
                _serialPort.DataBits = int.Parse(cmbDataBits.Text);
                switch (cmbStopBits.SelectedIndex)
                {
                    case 0:
                        _serialPort.StopBits = StopBits.One;
                        break;
                    case 1:
                        _serialPort.StopBits = StopBits.OnePointFive;
                        break;
                    case 2:
                        _serialPort.StopBits = StopBits.Two;
                        break;
                    default:
                        _serialPort.StopBits = StopBits.One;
                        break;
                }
                switch (cmbParity.SelectedIndex)
                {
                    case 0:
                        _serialPort.Parity = Parity.None;
                        break;
                    case 1:
                        _serialPort.Parity = Parity.Even;
                        break;
                    case 2:
                        _serialPort.Parity = Parity.Odd;
                        break;
                    default:
                        _serialPort.Parity = Parity.None;
                        break;
                }
                switch (cmbHandshake.SelectedIndex)
                {
                    case 0:
                        _serialPort.Handshake = Handshake.None;
                        break;
                    case 1:
                        _serialPort.Handshake = Handshake.XOnXOff;
                        break;
                    case 2:
                        _serialPort.Handshake = Handshake.RequestToSend;
                        break;
                    case 3:
                        _serialPort.Handshake = Handshake.RequestToSendXOnXOff;
                        break;
                    default:
                        _serialPort.Handshake = Handshake.None;
                        break;
                }

                _serialPort.ReadTimeout = 50; /* Read timeout = 10ms */
                _serialPort.DataReceived += _serialPort_DataReceived; /* add receive data handler */
                _serialPort.Open();
                if (!_serialPort.IsOpen)
                {
                    MessageBox.Show("Port can't be opened!\nTry again later!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception ex)
            {
                string msg = "Message: " + ex.Message;
                MessageBox.Show(msg, "Open serial port fail!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            /* If opening successful, inform to user */
            MessageBox.Show("Connection is opened successfully!", "Successed!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            /* Change page */
            changePage(Current_Panel_Enum.Bluetooth_Connection);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string msg = @"
Follow these steps to set up a connection:
    1.  Connect Board KL46Z with your PC with USB cable
    2.  Click 'Refresh' button to refresh port name list
    3.  Select a port from the list that your board is connected to
    4.  Config other characteristics OR click on
       'Default' button to use default setting
    5.  Click 'Open'
";
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void cmbBaudRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion /* Panel_Uart_Connection */

        #region Change_panel_handlers
        private void changePage(Current_Panel_Enum page)
        {
            _currentPanel = page;
            switch (_currentPanel)
            {
                case Current_Panel_Enum.UART_Connection:
                    pnUartConnection.Visible = true;
                    pnBluetoothConnection.Visible = false;
                    pnControl.Visible = false;
                    tmUpdateCurrentFrequency.Stop();
                    break;

                case Current_Panel_Enum.Bluetooth_Connection:
                    pnUartConnection.Visible = false;
                    pnBluetoothConnection.Visible = true;
                    pnControl.Visible = false;
                    tmUpdateCurrentFrequency.Stop();
                    break;

                case Current_Panel_Enum.Control:
                    pnUartConnection.Visible = false;
                    pnBluetoothConnection.Visible = false;
                    pnControl.Visible = true;
                    lblGreenLedCurrentFrequency.Text = get_GLed_frequency().ToString() + " Hz";
                    lblRedLedCurrentFrequency.Text = get_RLed_frequency().ToString() + " Hz";
                    tmUpdateCurrentFrequency.Start();
                    break;

                default:
                    /* error */
                    break;
            }
        }
        private void isBluetoothConnected(bool b)
        {
            _isBluetoothConnected = b;
            if (_isBluetoothConnected)
            {
                btnSetGreenLedFrequency.Enabled = btnSetRedLedFrequency.Enabled = false;
                txtGreenLedFrequency.ReadOnly = txtRedLedFrequency.ReadOnly = true;
                rtbMessage.ReadOnly = false;
                btnSend.Enabled = true;
            }
            else
            {
                btnSetGreenLedFrequency.Enabled = btnSetRedLedFrequency.Enabled = true;
                txtGreenLedFrequency.ReadOnly = txtRedLedFrequency.ReadOnly = false;
                rtbMessage.ReadOnly = true;
                btnSend.Enabled = false;
            }
        }
        #endregion /* Change_panel_handlers */

        #region Panel_Bluetooth_Connection
        private void btnBack_pnBluetoothConnection_Click(object sender, EventArgs e)
        {
            changePage(Current_Panel_Enum.UART_Connection);
        }

        private void btnSkip_pnBluetoothConnection_Click(object sender, EventArgs e)
        {
            /* Deassert _isBluetoothConnected flag & navigate page */
            isBluetoothConnected(false);
            changePage(Current_Panel_Enum.Control);
        }

        private void btnOK_pnBluetoothConnection_Click(object sender, EventArgs e)
        {
            /* Check error for entered information */

            /* Open Bluetootn connection */

            /* Inform to user that bluetooth connection is successfull */

            /* Assert _isBluetoothConnected flag & navigate page */
            isBluetoothConnected(true);
            changePage(Current_Panel_Enum.Control);
        }

        private void btnHelp_pnBluetoothConnection_Click(object sender, EventArgs e)
        {
            string msg = @"Bluetooth connection help";
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
        private void tmUpdateCurrentFrequency_Tick(object sender, EventArgs e)
        {
            lblGreenLedCurrentFrequency.Text = get_GLed_frequency().ToString("N3") + " Hz";
            lblRedLedCurrentFrequency.Text = get_RLed_frequency().ToString("N3") + " Hz";
        }

        #endregion /* Panel_Bluetooth_Connection */

        #region Panel_Control
        private void btnBack_pnControl_Click(object sender, EventArgs e)
        {
            changePage(Current_Panel_Enum.Bluetooth_Connection);
        }

        private void txtGreenLedFrequency_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtRedLedFrequency_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        /* Set green led frequency */
        private void set_Gled_frequency(double frequency)
        {
            UInt32 ldval = calculate_ldval(frequency);

            /* Create a data structure */
            byte[] tmpData = new byte[7];
            tmpData[0] = 0x00; /* Start byte */
            tmpData[1] = 0x02; /* Set green led frequency code */
            tmpData[6] = 0x01; /* Stop byte */

            /* add ldval to tmpData */
            tmpData[2] = (byte)((ldval >> 24) & 0xff);
            tmpData[3] = (byte)((ldval >> 16) & 0xff);
            tmpData[4] = (byte)((ldval >> 8) & 0xff);
            tmpData[5] = (byte)(ldval & 0xff);

            /* display loading icon */
            ptbGreenLedStatus_waiting.Visible = true;
            ptbGreenLedStatus_ok.Visible = false;

            /* send tmpData */
            send_UART_Data(tmpData, 0, 7);

            /* display completed icon */
            ptbGreenLedStatus_waiting.Visible = false;
            ptbGreenLedStatus_ok.Visible = true;
        }
        /* Set red led frequency */
        private void set_Rled_frequency(double frequency)
        {
            UInt32 ldval = calculate_ldval(frequency);

            /* Create a data structure */
            byte[] tmpData = new byte[7];
            tmpData[0] = 0x00; /* Start byte */
            tmpData[1] = 0x04; /* Set red led frequency code */
            tmpData[6] = 0x01; /* Stop byte */

            /* add ldval to tmpData */
            tmpData[2] = (byte)((ldval >> 24) & 0xff);
            tmpData[3] = (byte)((ldval >> 16) & 0xff);
            tmpData[4] = (byte)((ldval >> 8) & 0xff);
            tmpData[5] = (byte)(ldval & 0xff);

            /* display loading icon */
            ptbRedLedStatus_waiting.Visible = true;
            ptbRedLedStatus_ok.Visible = false;

            /* send tmpData */
            send_UART_Data(tmpData, 0, 7);

            /* display completed icon */
            ptbRedLedStatus_waiting.Visible = false;
            ptbRedLedStatus_ok.Visible = true;
        }

        /* Calculate PIT ldval for set led frequency events */
        private UInt32 calculate_ldval(double frequency)
        {
            frequency *= 2; /* double frequency, because a period is once on and once off */
            UInt32 ldval = (UInt32)(24000000 / frequency) - 1; /* Calculate ldval for PIT */
            if (ldval > 4294967295) /* check if ldval is available */
            {
                MessageBox.Show("Frequency is unavailable!\nTry again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return 0;
            }
            else
            {
                return ldval;
            }
        }

        /* receive green led frequency */
        private double get_GLed_frequency()
        {
            byte[] tmpData = new byte[3] { 0x00, 0x03, 0x01 }; /* Start byte, function code, stop byte */
            Int32 ldval = 0;
            try
            {
                _serialPort.DiscardInBuffer(); /* clear receive buffer */
                isIgnoreDataRecerveHandler = true; /* disable DataReceiveHandler */
                send_UART_Data(tmpData, 0, 2); /* send data */

                byte[] res = new byte[4];
                res[0] = (byte)(_serialPort.ReadByte());
                res[1] = (byte)(_serialPort.ReadByte());
                res[2] = (byte)(_serialPort.ReadByte());
                res[3] = (byte)(_serialPort.ReadByte());
                isIgnoreDataRecerveHandler = false; /* enable DataReceiveHandler */

                send_UART_Data(tmpData, 2, 1); /* send stop byte */
                ldval = (res[0] << 24) | (res[1] << 16) | (res[2] << 8) | (res[3]);
            }
            catch (TimeoutException ex)
            {
                isIgnoreDataRecerveHandler = false; /* enable DataReceiveHandler */
                return 0;
            }
            catch (Exception ex)
            {
                isIgnoreDataRecerveHandler = false; /* enable DataReceiveHandler */
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return 0;
            }
            return 1 / ((2.0 / 24000000) * (ldval + 1));
        }

        /* receive red led frequency */
        private double get_RLed_frequency()
        {
            byte[] tmpData = new byte[3] { 0x00, 0x05, 0x01 }; /* Start byte, function code, stop byte */
            Int32 ldval = 0;
            try
            {
                _serialPort.DiscardInBuffer(); /* clear receive buffer */
                isIgnoreDataRecerveHandler = true; /* disable DataReceiveHandler */
                send_UART_Data(tmpData, 0, 2); /* send data */

                byte[] res = new byte[4];
                res[0] = (byte)(_serialPort.ReadByte());
                res[1] = (byte)(_serialPort.ReadByte());
                res[2] = (byte)(_serialPort.ReadByte());
                res[3] = (byte)(_serialPort.ReadByte());
                isIgnoreDataRecerveHandler = false; /* enable DataReceiveHandler */

                send_UART_Data(tmpData, 2, 1); /* send Stop Byte */
                ldval = (res[0] << 24) | (res[1] << 16) | (res[2] << 8) | (res[3]);
            }
            catch (TimeoutException ex)
            {
                isIgnoreDataRecerveHandler = false; /* enable DataReceiveHandler */
                return 0;
            }
            catch (Exception ex)
            {
                isIgnoreDataRecerveHandler = false; /* enable DataReceiveHandler */
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return 0;
            }
            return 1 / ((2.0 / 24000000) * (ldval + 1));
        }

        private void btnSetGreenLedFrequency_Click(object sender, EventArgs e)
        {
            double frequency = 0;

            /* Check if user enter the frequency */
            if (txtGreenLedFrequency.Text.Length <= 0)
            {
                MessageBox.Show("You must enter the frequency of green led!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            /* Convert frequency to double type */
            try
            {
                frequency = double.Parse(txtGreenLedFrequency.Text);
            }
            catch
            {
                MessageBox.Show("Frequency is unavailable!\nTry again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            /* set green led frequency */
            set_Gled_frequency(frequency);
        }

        private void btnSetRedLedFrequency_Click(object sender, EventArgs e)
        {
            double frequency = 0;

            /* Check if user enter the frequency */
            if (txtRedLedFrequency.Text.Length <= 0)
            {
                MessageBox.Show("You must enter the frequency of red led!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            /* Convert frequency to double type */
            try
            {
                frequency = double.Parse(txtRedLedFrequency.Text);
            }
            catch
            {
                MessageBox.Show("Frequency is unavailable!\nTry again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            /* set red led frequency */
            set_Rled_frequency(frequency);
        }

        #endregion /* Panel_Control */

        #region Form_events_and_functions
        private void ctms_nti_Main_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Exit application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2); /* Exit confirm */
            if (res == System.Windows.Forms.DialogResult.No)
            { /* Cancel exitting */
                e.Cancel = true;
            }
            else
            { /* Exit */
                if (_serialPort.IsOpen) /* Check if port is opened */
                {
                    _serialPort.Close(); /* Close opening port */
                }
            }
        }

        private void tmSystem_Tick(object sender, EventArgs e)
        {
            tmSystem.Stop();
            _splashScreen.Close();
        }

        private void ctms_nti_Main_About_Click(object sender, EventArgs e)
        {
            frmAbout _about = new frmAbout();
            _about.ShowDialog();
        }

        #endregion /* Form_events_and_functions */



        void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (isIgnoreDataRecerveHandler)
            {
                return;
            }
            else
            {
                byte rev = (byte)_serialPort.ReadChar();
                if (currentReceivingStringType != ReceivingStringType.None)
                {
                    if (rev == 0x01) /* Stop byte */
                    {
                        currentReceivingStringType = ReceivingStringType.None;
                        Thread p = new Thread(StringReceiveProcess);
                        p.Start();
                    }

                    myBuffer += (char)rev;
                }

                if (rev == 0x06) /* Message_Recieve */
                {
                    currentReceivingStringType = ReceivingStringType.Message;
                }

                if (rev == 0x07) /* Bluetooth_Config */
                {
                    currentReceivingStringType = ReceivingStringType.Config;
                }
            }
        }

        private void StringReceiveProcess()
        {
            string tmp = myBuffer;
            myBuffer = "";

            SetText("Receive: " + tmp + "\n");
        }

        private void tcControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcControl.SelectedIndex == 0)
            { /* Page led is selected */
                tmUpdateCurrentFrequency.Start();
            }
            else
            { /* Page message is selected */
                tmUpdateCurrentFrequency.Stop();
            }
        }

        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            if (this.rtbChatbox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.rtbChatbox.AppendText(text);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] a = { 0x00, 0x06, 0x01 };
            byte[] tmp = System.Text.ASCIIEncoding.Default.GetBytes(rtbMessage.Text);
            _serialPort.Write(a, 0, 1); /* Start byte */
            Thread.Sleep(1);
            _serialPort.Write(a, 1, 1); /* function code: message */
            Thread.Sleep(1);
            send_UART_Data(tmp, 0, (uint)tmp.Length);
            _serialPort.Write(a, 2, 1); /* Stop byte */
            SetText("Send: " + rtbMessage.Text + "\n");
            rtbMessage.Clear();
        }

        private void rtbMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend_Click(this, new EventArgs());
                e.Handled = true;
            }
        }

        private void btnHelp_pnControl_Click(object sender, EventArgs e)
        {
            string msg;
            if (tcControl.SelectedIndex == 0)
            { /* In Led Control Tab */
                msg = @"Enter the frequency value to the box and click on corresponding Set button to set the frequency for led.";
            }
            else
            { /* In Message Tab */
                msg = @"Enter the message to the Message box and press Enter or click on Send button to send.";
            }

            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                switch (_currentPanel)
                {
                    case Current_Panel_Enum.UART_Connection:
                        btnHelp_Click(this, new EventArgs());
                        break;
                    case Current_Panel_Enum.Bluetooth_Connection:
                        btnHelp_pnBluetoothConnection_Click(this, new EventArgs());
                        break;
                    case Current_Panel_Enum.Control:
                        btnHelp_pnControl_Click(this, new EventArgs());
                        break;
                    default:
                        break;
                }
            }
            if (e.KeyCode == Keys.F5)
            {
                btnRefresh_Click(this, new EventArgs());
            }
            if (e.KeyCode == Keys.Escape)
            {
                switch (_currentPanel)
                {
                    case Current_Panel_Enum.Bluetooth_Connection:
                        btnBack_pnBluetoothConnection_Click(this, new EventArgs());
                        break;
                    case Current_Panel_Enum.Control:
                        btnBack_pnControl_Click(this, new EventArgs());
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
