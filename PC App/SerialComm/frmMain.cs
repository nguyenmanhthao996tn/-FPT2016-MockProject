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

        #endregion /* Variables */
        
        /* Constructor */
        public frmMain()
        {
            _splashScreen.Show();
            InitializeComponent();

            /* Additional initializeComponent */
            cmbPort.SelectedIndex = 0;
            cmbBaudRate.SelectedIndex = 16;
            cmbDataBits.SelectedIndex = 1;
            cmbStopBits.SelectedIndex = 0;
            cmbParity.SelectedIndex = 0;
            cmbHandshake.SelectedIndex = 0;

            tmSystem.Interval = 1500;
            tmSystem.Enabled = true;
            tmSystem.Start();
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
            cmbBaudRate.SelectedIndex = 16;
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
                if (_serialPort.IsOpen) /* If port is opening */
                {
                    _serialPort.Close();
                }

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
                    break;

                case Current_Panel_Enum.Bluetooth_Connection:
                    pnUartConnection.Visible = false;
                    pnBluetoothConnection.Visible = true;
                    pnControl.Visible = false;
                    break;

                case Current_Panel_Enum.Control:
                    pnUartConnection.Visible = false;
                    pnBluetoothConnection.Visible = false;
                    pnControl.Visible = true;
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

        #endregion /* Panel_Control */

        #region Form_closing_events
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
        #endregion /* Form_closing_events */

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
    }
}
