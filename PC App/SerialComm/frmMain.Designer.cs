namespace SerialComm
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.nti_Main = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctms_nti_Main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctms_nti_Main_About = new System.Windows.Forms.ToolStripMenuItem();
            this.ctms_nti_Main_Separator = new System.Windows.Forms.ToolStripSeparator();
            this.ctms_nti_Main_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnUartConnection = new System.Windows.Forms.Panel();
            this.lblUARTConnection = new System.Windows.Forms.Label();
            this.ptbUARTConnection = new System.Windows.Forms.PictureBox();
            this.ptbKL46Z = new System.Windows.Forms.PictureBox();
            this.btnOpen_ptbUARTConnection = new DevExpress.XtraEditors.SimpleButton();
            this.btnDefault_ptbUARTConnection = new DevExpress.XtraEditors.SimpleButton();
            this.btnHelp_ptbUARTConnection = new DevExpress.XtraEditors.SimpleButton();
            this.cmbHandshake = new System.Windows.Forms.ComboBox();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.cmbStopBits = new System.Windows.Forms.ComboBox();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.lblHandshake = new System.Windows.Forms.Label();
            this.lblParity = new System.Windows.Forms.Label();
            this.lblStopBits = new System.Windows.Forms.Label();
            this.lblDataBits = new System.Windows.Forms.Label();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.btnRefresh_ptbUARTConnection = new DevExpress.XtraEditors.SimpleButton();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.pnControl = new System.Windows.Forms.Panel();
            this.btnBack_pnControl = new DevExpress.XtraEditors.SimpleButton();
            this.btnHelp_pnControl = new DevExpress.XtraEditors.SimpleButton();
            this.tcControl = new System.Windows.Forms.TabControl();
            this.tcPage_Leds_pnControl = new System.Windows.Forms.TabPage();
            this.ptbRedLedStatus_waiting = new System.Windows.Forms.PictureBox();
            this.ptbRedLedStatus_ok = new System.Windows.Forms.PictureBox();
            this.ptbGreenLedStatus_waiting = new System.Windows.Forms.PictureBox();
            this.ptbGreenLedStatus_ok = new System.Windows.Forms.PictureBox();
            this.ptbLed = new System.Windows.Forms.PictureBox();
            this.ptbRedLed = new System.Windows.Forms.PictureBox();
            this.ptbGreenLed = new System.Windows.Forms.PictureBox();
            this.lblRedLedHz = new System.Windows.Forms.Label();
            this.btnSetRedLedFrequency = new DevExpress.XtraEditors.SimpleButton();
            this.txtRedLedFrequency = new System.Windows.Forms.TextBox();
            this.lblRedLedFrequency = new System.Windows.Forms.Label();
            this.lblGreenLedHz = new System.Windows.Forms.Label();
            this.btnSetGreenLedFrequency = new DevExpress.XtraEditors.SimpleButton();
            this.txtGreenLedFrequency = new System.Windows.Forms.TextBox();
            this.lblGreenLedFrequency = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tcPage_Messages_pnControl = new System.Windows.Forms.TabPage();
            this.btnSend = new DevExpress.XtraEditors.SimpleButton();
            this.grbMessage = new System.Windows.Forms.GroupBox();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.grbChatbox = new System.Windows.Forms.GroupBox();
            this.rtbChatbox = new System.Windows.Forms.RichTextBox();
            this.pnBluetoothConnection = new System.Windows.Forms.Panel();
            this.ptbBluetooth = new System.Windows.Forms.PictureBox();
            this.btnSkip_pnBluetoothConnection = new DevExpress.XtraEditors.SimpleButton();
            this.btnBack_pnBluetoothConnection = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK_pnBluetoothConnection = new DevExpress.XtraEditors.SimpleButton();
            this.btnHelp_pnBluetoothConnection = new DevExpress.XtraEditors.SimpleButton();
            this.lblBluetoothConnection = new System.Windows.Forms.Label();
            this.tmSystem = new System.Windows.Forms.Timer(this.components);
            this.ctms_nti_Main.SuspendLayout();
            this.pnUartConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUARTConnection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbKL46Z)).BeginInit();
            this.pnControl.SuspendLayout();
            this.tcControl.SuspendLayout();
            this.tcPage_Leds_pnControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRedLedStatus_waiting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRedLedStatus_ok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGreenLedStatus_waiting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGreenLedStatus_ok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRedLed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGreenLed)).BeginInit();
            this.tcPage_Messages_pnControl.SuspendLayout();
            this.grbMessage.SuspendLayout();
            this.grbChatbox.SuspendLayout();
            this.pnBluetoothConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBluetooth)).BeginInit();
            this.SuspendLayout();
            // 
            // nti_Main
            // 
            this.nti_Main.ContextMenuStrip = this.ctms_nti_Main;
            this.nti_Main.Icon = ((System.Drawing.Icon)(resources.GetObject("nti_Main.Icon")));
            this.nti_Main.Text = "FreescaleBluetooth";
            this.nti_Main.Visible = true;
            // 
            // ctms_nti_Main
            // 
            this.ctms_nti_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctms_nti_Main_About,
            this.ctms_nti_Main_Separator,
            this.ctms_nti_Main_Exit});
            this.ctms_nti_Main.Name = "ctms_nti_Main";
            this.ctms_nti_Main.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ctms_nti_Main.Size = new System.Drawing.Size(108, 54);
            // 
            // ctms_nti_Main_About
            // 
            this.ctms_nti_Main_About.Image = ((System.Drawing.Image)(resources.GetObject("ctms_nti_Main_About.Image")));
            this.ctms_nti_Main_About.Name = "ctms_nti_Main_About";
            this.ctms_nti_Main_About.Size = new System.Drawing.Size(107, 22);
            this.ctms_nti_Main_About.Text = "About";
            this.ctms_nti_Main_About.Click += new System.EventHandler(this.ctms_nti_Main_About_Click);
            // 
            // ctms_nti_Main_Separator
            // 
            this.ctms_nti_Main_Separator.Name = "ctms_nti_Main_Separator";
            this.ctms_nti_Main_Separator.Size = new System.Drawing.Size(104, 6);
            // 
            // ctms_nti_Main_Exit
            // 
            this.ctms_nti_Main_Exit.Image = ((System.Drawing.Image)(resources.GetObject("ctms_nti_Main_Exit.Image")));
            this.ctms_nti_Main_Exit.Name = "ctms_nti_Main_Exit";
            this.ctms_nti_Main_Exit.Size = new System.Drawing.Size(107, 22);
            this.ctms_nti_Main_Exit.Text = "Exit";
            this.ctms_nti_Main_Exit.Click += new System.EventHandler(this.ctms_nti_Main_Exit_Click);
            // 
            // pnUartConnection
            // 
            this.pnUartConnection.BackColor = System.Drawing.Color.LightGray;
            this.pnUartConnection.Controls.Add(this.lblUARTConnection);
            this.pnUartConnection.Controls.Add(this.ptbUARTConnection);
            this.pnUartConnection.Controls.Add(this.ptbKL46Z);
            this.pnUartConnection.Controls.Add(this.btnOpen_ptbUARTConnection);
            this.pnUartConnection.Controls.Add(this.btnDefault_ptbUARTConnection);
            this.pnUartConnection.Controls.Add(this.btnHelp_ptbUARTConnection);
            this.pnUartConnection.Controls.Add(this.cmbHandshake);
            this.pnUartConnection.Controls.Add(this.cmbParity);
            this.pnUartConnection.Controls.Add(this.cmbStopBits);
            this.pnUartConnection.Controls.Add(this.cmbDataBits);
            this.pnUartConnection.Controls.Add(this.cmbBaudRate);
            this.pnUartConnection.Controls.Add(this.lblHandshake);
            this.pnUartConnection.Controls.Add(this.lblParity);
            this.pnUartConnection.Controls.Add(this.lblStopBits);
            this.pnUartConnection.Controls.Add(this.lblDataBits);
            this.pnUartConnection.Controls.Add(this.lblBaudRate);
            this.pnUartConnection.Controls.Add(this.btnRefresh_ptbUARTConnection);
            this.pnUartConnection.Controls.Add(this.cmbPort);
            this.pnUartConnection.Controls.Add(this.lblPort);
            this.pnUartConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnUartConnection.Location = new System.Drawing.Point(0, 0);
            this.pnUartConnection.Name = "pnUartConnection";
            this.pnUartConnection.Size = new System.Drawing.Size(690, 468);
            this.pnUartConnection.TabIndex = 1;
            // 
            // lblUARTConnection
            // 
            this.lblUARTConnection.AutoSize = true;
            this.lblUARTConnection.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblUARTConnection.Location = new System.Drawing.Point(39, 53);
            this.lblUARTConnection.Name = "lblUARTConnection";
            this.lblUARTConnection.Size = new System.Drawing.Size(368, 19);
            this.lblUARTConnection.TabIndex = 0;
            this.lblUARTConnection.Text = "Set up a serial connection with Board KL46Z";
            // 
            // ptbUARTConnection
            // 
            this.ptbUARTConnection.Image = ((System.Drawing.Image)(resources.GetObject("ptbUARTConnection.Image")));
            this.ptbUARTConnection.Location = new System.Drawing.Point(13, 49);
            this.ptbUARTConnection.Name = "ptbUARTConnection";
            this.ptbUARTConnection.Size = new System.Drawing.Size(24, 24);
            this.ptbUARTConnection.TabIndex = 18;
            this.ptbUARTConnection.TabStop = false;
            // 
            // ptbKL46Z
            // 
            this.ptbKL46Z.Image = ((System.Drawing.Image)(resources.GetObject("ptbKL46Z.Image")));
            this.ptbKL46Z.Location = new System.Drawing.Point(347, 49);
            this.ptbKL46Z.Name = "ptbKL46Z";
            this.ptbKL46Z.Size = new System.Drawing.Size(331, 378);
            this.ptbKL46Z.TabIndex = 17;
            this.ptbKL46Z.TabStop = false;
            // 
            // btnOpen_ptbUARTConnection
            // 
            this.btnOpen_ptbUARTConnection.Location = new System.Drawing.Point(603, 433);
            this.btnOpen_ptbUARTConnection.Name = "btnOpen_ptbUARTConnection";
            this.btnOpen_ptbUARTConnection.Size = new System.Drawing.Size(75, 23);
            this.btnOpen_ptbUARTConnection.TabIndex = 10;
            this.btnOpen_ptbUARTConnection.Text = "Open";
            this.btnOpen_ptbUARTConnection.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnDefault_ptbUARTConnection
            // 
            this.btnDefault_ptbUARTConnection.Location = new System.Drawing.Point(522, 433);
            this.btnDefault_ptbUARTConnection.Name = "btnDefault_ptbUARTConnection";
            this.btnDefault_ptbUARTConnection.Size = new System.Drawing.Size(75, 23);
            this.btnDefault_ptbUARTConnection.TabIndex = 9;
            this.btnDefault_ptbUARTConnection.Text = "Default";
            this.btnDefault_ptbUARTConnection.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnHelp_ptbUARTConnection
            // 
            this.btnHelp_ptbUARTConnection.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp_ptbUARTConnection.Image")));
            this.btnHelp_ptbUARTConnection.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnHelp_ptbUARTConnection.Location = new System.Drawing.Point(12, 433);
            this.btnHelp_ptbUARTConnection.Name = "btnHelp_ptbUARTConnection";
            this.btnHelp_ptbUARTConnection.Size = new System.Drawing.Size(25, 23);
            this.btnHelp_ptbUARTConnection.TabIndex = 8;
            this.btnHelp_ptbUARTConnection.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // cmbHandshake
            // 
            this.cmbHandshake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHandshake.FormattingEnabled = true;
            this.cmbHandshake.Items.AddRange(new object[] {
            "None",
            "XOnXOff",
            "RequestToSend",
            "RequestToSendXOnXOff"});
            this.cmbHandshake.Location = new System.Drawing.Point(127, 267);
            this.cmbHandshake.Name = "cmbHandshake";
            this.cmbHandshake.Size = new System.Drawing.Size(121, 21);
            this.cmbHandshake.TabIndex = 7;
            // 
            // cmbParity
            // 
            this.cmbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.cmbParity.Location = new System.Drawing.Point(127, 237);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(121, 21);
            this.cmbParity.TabIndex = 6;
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStopBits.FormattingEnabled = true;
            this.cmbStopBits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cmbStopBits.Location = new System.Drawing.Point(127, 207);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(121, 21);
            this.cmbStopBits.TabIndex = 5;
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataBits.FormattingEnabled = true;
            this.cmbDataBits.Items.AddRange(new object[] {
            "7",
            "8"});
            this.cmbDataBits.Location = new System.Drawing.Point(127, 177);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(121, 21);
            this.cmbDataBits.TabIndex = 4;
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Items.AddRange(new object[] {
            "50",
            "75",
            "110",
            "134",
            "150",
            "200",
            "300",
            "600",
            "1200",
            "1800",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cmbBaudRate.Location = new System.Drawing.Point(127, 147);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(121, 21);
            this.cmbBaudRate.TabIndex = 3;
            this.cmbBaudRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbBaudRate_KeyPress);
            // 
            // lblHandshake
            // 
            this.lblHandshake.AutoSize = true;
            this.lblHandshake.Location = new System.Drawing.Point(61, 270);
            this.lblHandshake.Name = "lblHandshake";
            this.lblHandshake.Size = new System.Drawing.Size(60, 13);
            this.lblHandshake.TabIndex = 8;
            this.lblHandshake.Text = "Handshake";
            // 
            // lblParity
            // 
            this.lblParity.AutoSize = true;
            this.lblParity.Location = new System.Drawing.Point(61, 240);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(35, 13);
            this.lblParity.TabIndex = 7;
            this.lblParity.Text = "Parity";
            // 
            // lblStopBits
            // 
            this.lblStopBits.AutoSize = true;
            this.lblStopBits.Location = new System.Drawing.Point(61, 210);
            this.lblStopBits.Name = "lblStopBits";
            this.lblStopBits.Size = new System.Drawing.Size(49, 13);
            this.lblStopBits.TabIndex = 6;
            this.lblStopBits.Text = "Stop Bits";
            // 
            // lblDataBits
            // 
            this.lblDataBits.AutoSize = true;
            this.lblDataBits.Location = new System.Drawing.Point(61, 180);
            this.lblDataBits.Name = "lblDataBits";
            this.lblDataBits.Size = new System.Drawing.Size(50, 13);
            this.lblDataBits.TabIndex = 5;
            this.lblDataBits.Text = "Data Bits";
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(61, 150);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(57, 13);
            this.lblBaudRate.TabIndex = 4;
            this.lblBaudRate.Text = "Baud Rate";
            // 
            // btnRefresh_ptbUARTConnection
            // 
            this.btnRefresh_ptbUARTConnection.Location = new System.Drawing.Point(254, 115);
            this.btnRefresh_ptbUARTConnection.Name = "btnRefresh_ptbUARTConnection";
            this.btnRefresh_ptbUARTConnection.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh_ptbUARTConnection.TabIndex = 2;
            this.btnRefresh_ptbUARTConnection.Text = "Refresh";
            this.btnRefresh_ptbUARTConnection.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cmbPort
            // 
            this.cmbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Items.AddRange(new object[] {
            "None"});
            this.cmbPort.Location = new System.Drawing.Point(127, 117);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(121, 21);
            this.cmbPort.TabIndex = 1;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(61, 120);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(27, 13);
            this.lblPort.TabIndex = 1;
            this.lblPort.Text = "Port";
            // 
            // pnControl
            // 
            this.pnControl.Controls.Add(this.btnBack_pnControl);
            this.pnControl.Controls.Add(this.btnHelp_pnControl);
            this.pnControl.Controls.Add(this.tcControl);
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnControl.Location = new System.Drawing.Point(0, 0);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(690, 468);
            this.pnControl.TabIndex = 3;
            this.pnControl.Visible = false;
            // 
            // btnBack_pnControl
            // 
            this.btnBack_pnControl.Location = new System.Drawing.Point(43, 433);
            this.btnBack_pnControl.Name = "btnBack_pnControl";
            this.btnBack_pnControl.Size = new System.Drawing.Size(75, 23);
            this.btnBack_pnControl.TabIndex = 22;
            this.btnBack_pnControl.Text = "Back";
            this.btnBack_pnControl.Click += new System.EventHandler(this.btnBack_pnControl_Click);
            // 
            // btnHelp_pnControl
            // 
            this.btnHelp_pnControl.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp_pnControl.Image")));
            this.btnHelp_pnControl.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnHelp_pnControl.Location = new System.Drawing.Point(12, 433);
            this.btnHelp_pnControl.Name = "btnHelp_pnControl";
            this.btnHelp_pnControl.Size = new System.Drawing.Size(25, 23);
            this.btnHelp_pnControl.TabIndex = 21;
            this.btnHelp_pnControl.TabStop = false;
            // 
            // tcControl
            // 
            this.tcControl.Controls.Add(this.tcPage_Leds_pnControl);
            this.tcControl.Controls.Add(this.tcPage_Messages_pnControl);
            this.tcControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcControl.Location = new System.Drawing.Point(0, 0);
            this.tcControl.Name = "tcControl";
            this.tcControl.SelectedIndex = 0;
            this.tcControl.Size = new System.Drawing.Size(690, 427);
            this.tcControl.TabIndex = 0;
            // 
            // tcPage_Leds_pnControl
            // 
            this.tcPage_Leds_pnControl.Controls.Add(this.ptbRedLedStatus_waiting);
            this.tcPage_Leds_pnControl.Controls.Add(this.ptbRedLedStatus_ok);
            this.tcPage_Leds_pnControl.Controls.Add(this.ptbGreenLedStatus_waiting);
            this.tcPage_Leds_pnControl.Controls.Add(this.ptbGreenLedStatus_ok);
            this.tcPage_Leds_pnControl.Controls.Add(this.ptbLed);
            this.tcPage_Leds_pnControl.Controls.Add(this.ptbRedLed);
            this.tcPage_Leds_pnControl.Controls.Add(this.ptbGreenLed);
            this.tcPage_Leds_pnControl.Controls.Add(this.lblRedLedHz);
            this.tcPage_Leds_pnControl.Controls.Add(this.btnSetRedLedFrequency);
            this.tcPage_Leds_pnControl.Controls.Add(this.txtRedLedFrequency);
            this.tcPage_Leds_pnControl.Controls.Add(this.lblRedLedFrequency);
            this.tcPage_Leds_pnControl.Controls.Add(this.lblGreenLedHz);
            this.tcPage_Leds_pnControl.Controls.Add(this.btnSetGreenLedFrequency);
            this.tcPage_Leds_pnControl.Controls.Add(this.txtGreenLedFrequency);
            this.tcPage_Leds_pnControl.Controls.Add(this.lblGreenLedFrequency);
            this.tcPage_Leds_pnControl.Controls.Add(this.label1);
            this.tcPage_Leds_pnControl.Location = new System.Drawing.Point(4, 22);
            this.tcPage_Leds_pnControl.Name = "tcPage_Leds_pnControl";
            this.tcPage_Leds_pnControl.Padding = new System.Windows.Forms.Padding(3);
            this.tcPage_Leds_pnControl.Size = new System.Drawing.Size(682, 401);
            this.tcPage_Leds_pnControl.TabIndex = 0;
            this.tcPage_Leds_pnControl.Text = "Leds";
            this.tcPage_Leds_pnControl.UseVisualStyleBackColor = true;
            // 
            // ptbRedLedStatus_waiting
            // 
            this.ptbRedLedStatus_waiting.Image = ((System.Drawing.Image)(resources.GetObject("ptbRedLedStatus_waiting.Image")));
            this.ptbRedLedStatus_waiting.Location = new System.Drawing.Point(403, 121);
            this.ptbRedLedStatus_waiting.Name = "ptbRedLedStatus_waiting";
            this.ptbRedLedStatus_waiting.Size = new System.Drawing.Size(24, 24);
            this.ptbRedLedStatus_waiting.TabIndex = 13;
            this.ptbRedLedStatus_waiting.TabStop = false;
            this.ptbRedLedStatus_waiting.Visible = false;
            // 
            // ptbRedLedStatus_ok
            // 
            this.ptbRedLedStatus_ok.Image = ((System.Drawing.Image)(resources.GetObject("ptbRedLedStatus_ok.Image")));
            this.ptbRedLedStatus_ok.Location = new System.Drawing.Point(403, 121);
            this.ptbRedLedStatus_ok.Name = "ptbRedLedStatus_ok";
            this.ptbRedLedStatus_ok.Size = new System.Drawing.Size(24, 24);
            this.ptbRedLedStatus_ok.TabIndex = 15;
            this.ptbRedLedStatus_ok.TabStop = false;
            this.ptbRedLedStatus_ok.Visible = false;
            // 
            // ptbGreenLedStatus_waiting
            // 
            this.ptbGreenLedStatus_waiting.Image = ((System.Drawing.Image)(resources.GetObject("ptbGreenLedStatus_waiting.Image")));
            this.ptbGreenLedStatus_waiting.Location = new System.Drawing.Point(403, 72);
            this.ptbGreenLedStatus_waiting.Name = "ptbGreenLedStatus_waiting";
            this.ptbGreenLedStatus_waiting.Size = new System.Drawing.Size(24, 24);
            this.ptbGreenLedStatus_waiting.TabIndex = 12;
            this.ptbGreenLedStatus_waiting.TabStop = false;
            this.ptbGreenLedStatus_waiting.Visible = false;
            // 
            // ptbGreenLedStatus_ok
            // 
            this.ptbGreenLedStatus_ok.Image = ((System.Drawing.Image)(resources.GetObject("ptbGreenLedStatus_ok.Image")));
            this.ptbGreenLedStatus_ok.Location = new System.Drawing.Point(403, 72);
            this.ptbGreenLedStatus_ok.Name = "ptbGreenLedStatus_ok";
            this.ptbGreenLedStatus_ok.Size = new System.Drawing.Size(24, 24);
            this.ptbGreenLedStatus_ok.TabIndex = 14;
            this.ptbGreenLedStatus_ok.TabStop = false;
            this.ptbGreenLedStatus_ok.Visible = false;
            // 
            // ptbLed
            // 
            this.ptbLed.Image = ((System.Drawing.Image)(resources.GetObject("ptbLed.Image")));
            this.ptbLed.Location = new System.Drawing.Point(13, 27);
            this.ptbLed.Name = "ptbLed";
            this.ptbLed.Size = new System.Drawing.Size(20, 20);
            this.ptbLed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLed.TabIndex = 11;
            this.ptbLed.TabStop = false;
            // 
            // ptbRedLed
            // 
            this.ptbRedLed.Image = ((System.Drawing.Image)(resources.GetObject("ptbRedLed.Image")));
            this.ptbRedLed.Location = new System.Drawing.Point(493, 218);
            this.ptbRedLed.Name = "ptbRedLed";
            this.ptbRedLed.Size = new System.Drawing.Size(100, 100);
            this.ptbRedLed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbRedLed.TabIndex = 10;
            this.ptbRedLed.TabStop = false;
            // 
            // ptbGreenLed
            // 
            this.ptbGreenLed.Image = ((System.Drawing.Image)(resources.GetObject("ptbGreenLed.Image")));
            this.ptbGreenLed.Location = new System.Drawing.Point(355, 218);
            this.ptbGreenLed.Name = "ptbGreenLed";
            this.ptbGreenLed.Size = new System.Drawing.Size(100, 100);
            this.ptbGreenLed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbGreenLed.TabIndex = 9;
            this.ptbGreenLed.TabStop = false;
            // 
            // lblRedLedHz
            // 
            this.lblRedLedHz.AutoSize = true;
            this.lblRedLedHz.Location = new System.Drawing.Point(297, 127);
            this.lblRedLedHz.Name = "lblRedLedHz";
            this.lblRedLedHz.Size = new System.Drawing.Size(19, 13);
            this.lblRedLedHz.TabIndex = 8;
            this.lblRedLedHz.Text = "Hz";
            // 
            // btnSetRedLedFrequency
            // 
            this.btnSetRedLedFrequency.Location = new System.Drawing.Point(322, 122);
            this.btnSetRedLedFrequency.Name = "btnSetRedLedFrequency";
            this.btnSetRedLedFrequency.Size = new System.Drawing.Size(75, 23);
            this.btnSetRedLedFrequency.TabIndex = 7;
            this.btnSetRedLedFrequency.Text = "Set";
            // 
            // txtRedLedFrequency
            // 
            this.txtRedLedFrequency.Location = new System.Drawing.Point(191, 123);
            this.txtRedLedFrequency.Name = "txtRedLedFrequency";
            this.txtRedLedFrequency.Size = new System.Drawing.Size(100, 21);
            this.txtRedLedFrequency.TabIndex = 6;
            this.txtRedLedFrequency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRedLedFrequency_KeyPress);
            // 
            // lblRedLedFrequency
            // 
            this.lblRedLedFrequency.AutoSize = true;
            this.lblRedLedFrequency.Location = new System.Drawing.Point(80, 128);
            this.lblRedLedFrequency.Name = "lblRedLedFrequency";
            this.lblRedLedFrequency.Size = new System.Drawing.Size(95, 13);
            this.lblRedLedFrequency.TabIndex = 5;
            this.lblRedLedFrequency.Text = "Red led frequency";
            // 
            // lblGreenLedHz
            // 
            this.lblGreenLedHz.AutoSize = true;
            this.lblGreenLedHz.Location = new System.Drawing.Point(297, 78);
            this.lblGreenLedHz.Name = "lblGreenLedHz";
            this.lblGreenLedHz.Size = new System.Drawing.Size(19, 13);
            this.lblGreenLedHz.TabIndex = 4;
            this.lblGreenLedHz.Text = "Hz";
            // 
            // btnSetGreenLedFrequency
            // 
            this.btnSetGreenLedFrequency.Location = new System.Drawing.Point(322, 73);
            this.btnSetGreenLedFrequency.Name = "btnSetGreenLedFrequency";
            this.btnSetGreenLedFrequency.Size = new System.Drawing.Size(75, 23);
            this.btnSetGreenLedFrequency.TabIndex = 3;
            this.btnSetGreenLedFrequency.Text = "Set";
            // 
            // txtGreenLedFrequency
            // 
            this.txtGreenLedFrequency.Location = new System.Drawing.Point(191, 74);
            this.txtGreenLedFrequency.Name = "txtGreenLedFrequency";
            this.txtGreenLedFrequency.Size = new System.Drawing.Size(100, 21);
            this.txtGreenLedFrequency.TabIndex = 2;
            this.txtGreenLedFrequency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGreenLedFrequency_KeyPress);
            // 
            // lblGreenLedFrequency
            // 
            this.lblGreenLedFrequency.AutoSize = true;
            this.lblGreenLedFrequency.Location = new System.Drawing.Point(80, 79);
            this.lblGreenLedFrequency.Name = "lblGreenLedFrequency";
            this.lblGreenLedFrequency.Size = new System.Drawing.Size(105, 13);
            this.lblGreenLedFrequency.TabIndex = 1;
            this.lblGreenLedFrequency.Text = "Green led frequency";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control Green and Red leds blink frequency";
            // 
            // tcPage_Messages_pnControl
            // 
            this.tcPage_Messages_pnControl.Controls.Add(this.btnSend);
            this.tcPage_Messages_pnControl.Controls.Add(this.grbMessage);
            this.tcPage_Messages_pnControl.Controls.Add(this.grbChatbox);
            this.tcPage_Messages_pnControl.Location = new System.Drawing.Point(4, 22);
            this.tcPage_Messages_pnControl.Name = "tcPage_Messages_pnControl";
            this.tcPage_Messages_pnControl.Padding = new System.Windows.Forms.Padding(3);
            this.tcPage_Messages_pnControl.Size = new System.Drawing.Size(682, 401);
            this.tcPage_Messages_pnControl.TabIndex = 1;
            this.tcPage_Messages_pnControl.Text = "Messages";
            this.tcPage_Messages_pnControl.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(579, 298);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(95, 95);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            // 
            // grbMessage
            // 
            this.grbMessage.Controls.Add(this.rtbMessage);
            this.grbMessage.Location = new System.Drawing.Point(0, 281);
            this.grbMessage.Name = "grbMessage";
            this.grbMessage.Size = new System.Drawing.Size(573, 117);
            this.grbMessage.TabIndex = 1;
            this.grbMessage.TabStop = false;
            this.grbMessage.Text = "Message";
            // 
            // rtbMessage
            // 
            this.rtbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMessage.Location = new System.Drawing.Point(3, 17);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(567, 97);
            this.rtbMessage.TabIndex = 0;
            this.rtbMessage.Text = "";
            // 
            // grbChatbox
            // 
            this.grbChatbox.Controls.Add(this.rtbChatbox);
            this.grbChatbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbChatbox.Location = new System.Drawing.Point(3, 3);
            this.grbChatbox.Name = "grbChatbox";
            this.grbChatbox.Size = new System.Drawing.Size(676, 272);
            this.grbChatbox.TabIndex = 0;
            this.grbChatbox.TabStop = false;
            this.grbChatbox.Text = "Chatbox";
            // 
            // rtbChatbox
            // 
            this.rtbChatbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbChatbox.Location = new System.Drawing.Point(3, 17);
            this.rtbChatbox.Name = "rtbChatbox";
            this.rtbChatbox.ReadOnly = true;
            this.rtbChatbox.Size = new System.Drawing.Size(670, 252);
            this.rtbChatbox.TabIndex = 0;
            this.rtbChatbox.Text = "";
            // 
            // pnBluetoothConnection
            // 
            this.pnBluetoothConnection.Controls.Add(this.ptbBluetooth);
            this.pnBluetoothConnection.Controls.Add(this.btnSkip_pnBluetoothConnection);
            this.pnBluetoothConnection.Controls.Add(this.btnBack_pnBluetoothConnection);
            this.pnBluetoothConnection.Controls.Add(this.btnOK_pnBluetoothConnection);
            this.pnBluetoothConnection.Controls.Add(this.btnHelp_pnBluetoothConnection);
            this.pnBluetoothConnection.Controls.Add(this.lblBluetoothConnection);
            this.pnBluetoothConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBluetoothConnection.Location = new System.Drawing.Point(0, 0);
            this.pnBluetoothConnection.Name = "pnBluetoothConnection";
            this.pnBluetoothConnection.Size = new System.Drawing.Size(690, 468);
            this.pnBluetoothConnection.TabIndex = 2;
            this.pnBluetoothConnection.Visible = false;
            // 
            // ptbBluetooth
            // 
            this.ptbBluetooth.Image = ((System.Drawing.Image)(resources.GetObject("ptbBluetooth.Image")));
            this.ptbBluetooth.Location = new System.Drawing.Point(557, 28);
            this.ptbBluetooth.Name = "ptbBluetooth";
            this.ptbBluetooth.Size = new System.Drawing.Size(75, 75);
            this.ptbBluetooth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBluetooth.TabIndex = 23;
            this.ptbBluetooth.TabStop = false;
            // 
            // btnSkip_pnBluetoothConnection
            // 
            this.btnSkip_pnBluetoothConnection.Location = new System.Drawing.Point(522, 433);
            this.btnSkip_pnBluetoothConnection.Name = "btnSkip_pnBluetoothConnection";
            this.btnSkip_pnBluetoothConnection.Size = new System.Drawing.Size(75, 23);
            this.btnSkip_pnBluetoothConnection.TabIndex = 22;
            this.btnSkip_pnBluetoothConnection.Text = "Skip";
            this.btnSkip_pnBluetoothConnection.Click += new System.EventHandler(this.btnSkip_pnBluetoothConnection_Click);
            // 
            // btnBack_pnBluetoothConnection
            // 
            this.btnBack_pnBluetoothConnection.Location = new System.Drawing.Point(43, 433);
            this.btnBack_pnBluetoothConnection.Name = "btnBack_pnBluetoothConnection";
            this.btnBack_pnBluetoothConnection.Size = new System.Drawing.Size(75, 23);
            this.btnBack_pnBluetoothConnection.TabIndex = 20;
            this.btnBack_pnBluetoothConnection.Text = "Back";
            this.btnBack_pnBluetoothConnection.Click += new System.EventHandler(this.btnBack_pnBluetoothConnection_Click);
            // 
            // btnOK_pnBluetoothConnection
            // 
            this.btnOK_pnBluetoothConnection.Location = new System.Drawing.Point(603, 433);
            this.btnOK_pnBluetoothConnection.Name = "btnOK_pnBluetoothConnection";
            this.btnOK_pnBluetoothConnection.Size = new System.Drawing.Size(75, 23);
            this.btnOK_pnBluetoothConnection.TabIndex = 21;
            this.btnOK_pnBluetoothConnection.Text = "OK";
            this.btnOK_pnBluetoothConnection.Click += new System.EventHandler(this.btnOK_pnBluetoothConnection_Click);
            // 
            // btnHelp_pnBluetoothConnection
            // 
            this.btnHelp_pnBluetoothConnection.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp_pnBluetoothConnection.Image")));
            this.btnHelp_pnBluetoothConnection.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnHelp_pnBluetoothConnection.Location = new System.Drawing.Point(12, 433);
            this.btnHelp_pnBluetoothConnection.Name = "btnHelp_pnBluetoothConnection";
            this.btnHelp_pnBluetoothConnection.Size = new System.Drawing.Size(25, 23);
            this.btnHelp_pnBluetoothConnection.TabIndex = 19;
            this.btnHelp_pnBluetoothConnection.TabStop = false;
            this.btnHelp_pnBluetoothConnection.Click += new System.EventHandler(this.btnHelp_pnBluetoothConnection_Click);
            // 
            // lblBluetoothConnection
            // 
            this.lblBluetoothConnection.AutoSize = true;
            this.lblBluetoothConnection.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblBluetoothConnection.Location = new System.Drawing.Point(39, 53);
            this.lblBluetoothConnection.Name = "lblBluetoothConnection";
            this.lblBluetoothConnection.Size = new System.Drawing.Size(462, 19);
            this.lblBluetoothConnection.TabIndex = 2;
            this.lblBluetoothConnection.Text = "Set up bluetooth connection with remote control device";
            // 
            // tmSystem
            // 
            this.tmSystem.Interval = 1500;
            this.tmSystem.Tick += new System.EventHandler(this.tmSystem_Tick);
            // 
            // frmMain
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 468);
            this.Controls.Add(this.pnUartConnection);
            this.Controls.Add(this.pnBluetoothConnection);
            this.Controls.Add(this.pnControl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FreescaleBluetooth";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.ctms_nti_Main.ResumeLayout(false);
            this.pnUartConnection.ResumeLayout(false);
            this.pnUartConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUARTConnection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbKL46Z)).EndInit();
            this.pnControl.ResumeLayout(false);
            this.tcControl.ResumeLayout(false);
            this.tcPage_Leds_pnControl.ResumeLayout(false);
            this.tcPage_Leds_pnControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRedLedStatus_waiting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRedLedStatus_ok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGreenLedStatus_waiting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGreenLedStatus_ok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRedLed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGreenLed)).EndInit();
            this.tcPage_Messages_pnControl.ResumeLayout(false);
            this.grbMessage.ResumeLayout(false);
            this.grbChatbox.ResumeLayout(false);
            this.pnBluetoothConnection.ResumeLayout(false);
            this.pnBluetoothConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBluetooth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon nti_Main;
        private System.Windows.Forms.ContextMenuStrip ctms_nti_Main;
        private System.Windows.Forms.ToolStripMenuItem ctms_nti_Main_About;
        private System.Windows.Forms.ToolStripSeparator ctms_nti_Main_Separator;
        private System.Windows.Forms.ToolStripMenuItem ctms_nti_Main_Exit;
        private System.Windows.Forms.Panel pnUartConnection;
        private System.Windows.Forms.Panel pnBluetoothConnection;
        private System.Windows.Forms.Panel pnControl;
        private System.Windows.Forms.Label lblUARTConnection;
        private System.Windows.Forms.ComboBox cmbHandshake;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.ComboBox cmbStopBits;
        private System.Windows.Forms.ComboBox cmbDataBits;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.Label lblHandshake;
        private System.Windows.Forms.Label lblParity;
        private System.Windows.Forms.Label lblStopBits;
        private System.Windows.Forms.Label lblDataBits;
        private System.Windows.Forms.Label lblBaudRate;
        private DevExpress.XtraEditors.SimpleButton btnRefresh_ptbUARTConnection;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.Label lblPort;
        private DevExpress.XtraEditors.SimpleButton btnOpen_ptbUARTConnection;
        private DevExpress.XtraEditors.SimpleButton btnDefault_ptbUARTConnection;
        private DevExpress.XtraEditors.SimpleButton btnHelp_ptbUARTConnection;
        private System.Windows.Forms.PictureBox ptbKL46Z;
        private System.Windows.Forms.PictureBox ptbUARTConnection;
        private DevExpress.XtraEditors.SimpleButton btnBack_pnBluetoothConnection;
        private DevExpress.XtraEditors.SimpleButton btnHelp_pnBluetoothConnection;
        private System.Windows.Forms.Label lblBluetoothConnection;
        private DevExpress.XtraEditors.SimpleButton btnSkip_pnBluetoothConnection;
        private DevExpress.XtraEditors.SimpleButton btnOK_pnBluetoothConnection;
        private DevExpress.XtraEditors.SimpleButton btnBack_pnControl;
        private DevExpress.XtraEditors.SimpleButton btnHelp_pnControl;
        private System.Windows.Forms.TabControl tcControl;
        private System.Windows.Forms.TabPage tcPage_Leds_pnControl;
        private System.Windows.Forms.TabPage tcPage_Messages_pnControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRedLedHz;
        private DevExpress.XtraEditors.SimpleButton btnSetRedLedFrequency;
        private System.Windows.Forms.TextBox txtRedLedFrequency;
        private System.Windows.Forms.Label lblRedLedFrequency;
        private System.Windows.Forms.Label lblGreenLedHz;
        private DevExpress.XtraEditors.SimpleButton btnSetGreenLedFrequency;
        private System.Windows.Forms.TextBox txtGreenLedFrequency;
        private System.Windows.Forms.Label lblGreenLedFrequency;
        private DevExpress.XtraEditors.SimpleButton btnSend;
        private System.Windows.Forms.GroupBox grbMessage;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.GroupBox grbChatbox;
        private System.Windows.Forms.RichTextBox rtbChatbox;
        private System.Windows.Forms.PictureBox ptbBluetooth;
        private System.Windows.Forms.PictureBox ptbRedLed;
        private System.Windows.Forms.PictureBox ptbGreenLed;
        private System.Windows.Forms.PictureBox ptbLed;
        private System.Windows.Forms.PictureBox ptbGreenLedStatus_waiting;
        private System.Windows.Forms.PictureBox ptbRedLedStatus_waiting;
        private System.Windows.Forms.PictureBox ptbRedLedStatus_ok;
        private System.Windows.Forms.PictureBox ptbGreenLedStatus_ok;
        private System.Windows.Forms.Timer tmSystem;

    }
}

