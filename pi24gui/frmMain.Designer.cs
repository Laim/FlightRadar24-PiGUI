namespace pi24gui
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            lblFeederUrl = new Label();
            txtFeederUrl = new TextBox();
            lblFeederPort = new Label();
            txtFeederPort = new TextBox();
            tabControlFeederData = new TabControl();
            tabOverview = new TabPage();
            lblLocalIpsValue = new Label();
            lblLocalIps = new Label();
            gbOverviewAircraftData = new GroupBox();
            lblAircraftTrackedD11Value = new Label();
            lblAircraftTrackedD11 = new Label();
            lblAircraftUploadedValue = new Label();
            lblAircraftUploaded = new Label();
            lblAircraftTrackedACValue = new Label();
            lblAircraftTrackedAC = new Label();
            lblMessagesValue = new Label();
            lblMessages = new Label();
            lblReceiverValue = new Label();
            lblReceiver = new Label();
            lblFeedTypeValue = new Label();
            lblFeedType = new Label();
            lblConnectedValue = new Label();
            lblConnectedMode = new Label();
            lblAliasValue = new Label();
            lblAlias = new Label();
            tabTrackList = new TabPage();
            dgvAircraft = new DataGridView();
            ModeS = new DataGridViewTextBoxColumn();
            Callsign = new DataGridViewTextBoxColumn();
            Latitude = new DataGridViewTextBoxColumn();
            Longitude = new DataGridViewTextBoxColumn();
            Altitude = new DataGridViewTextBoxColumn();
            Squawk = new DataGridViewTextBoxColumn();
            tabLogs = new TabPage();
            txtLogs = new TextBox();
            tabOptions = new TabPage();
            btnOptionsData = new Button();
            btnOptionsSave = new Button();
            cbAppendLog = new CheckBox();
            gbFlightAlert = new GroupBox();
            cbFlightAlertBeep = new CheckBox();
            cbFlightAlertNotification = new CheckBox();
            txtCallSign = new TextBox();
            lblFlightAlertCallSign = new Label();
            cbFlightAlert = new CheckBox();
            gbAutomaticRefresh = new GroupBox();
            lblRefreshTime = new Label();
            numRefreshTime = new NumericUpDown();
            cbRefresh = new CheckBox();
            cbSaveFeeder = new CheckBox();
            tabAbout = new TabPage();
            lblVersion = new Label();
            pbPlane = new PictureBox();
            txtAbout = new TextBox();
            lnkHelp = new LinkLabel();
            lblCopyright = new Label();
            lblAppName = new Label();
            btnFeederConnectDisconnect = new Button();
            toolStripMain = new ToolStrip();
            tsLastRefresh = new ToolStripLabel();
            tsLastRefreshValue = new ToolStripLabel();
            tsSpacer = new ToolStripLabel();
            tsConnectionTime = new ToolStripLabel();
            tsConnectionTimeValue = new ToolStripLabel();
            tabControlFeederData.SuspendLayout();
            tabOverview.SuspendLayout();
            gbOverviewAircraftData.SuspendLayout();
            tabTrackList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAircraft).BeginInit();
            tabLogs.SuspendLayout();
            tabOptions.SuspendLayout();
            gbFlightAlert.SuspendLayout();
            gbAutomaticRefresh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numRefreshTime).BeginInit();
            tabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPlane).BeginInit();
            toolStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // lblFeederUrl
            // 
            lblFeederUrl.AutoSize = true;
            lblFeederUrl.Location = new Point(20, 20);
            lblFeederUrl.Name = "lblFeederUrl";
            lblFeederUrl.Size = new Size(84, 20);
            lblFeederUrl.TabIndex = 0;
            lblFeederUrl.Text = "Feeder URL";
            // 
            // txtFeederUrl
            // 
            txtFeederUrl.Location = new Point(110, 17);
            txtFeederUrl.Name = "txtFeederUrl";
            txtFeederUrl.Size = new Size(279, 27);
            txtFeederUrl.TabIndex = 1;
            txtFeederUrl.Text = "http://192.168.0.128";
            // 
            // lblFeederPort
            // 
            lblFeederPort.AutoSize = true;
            lblFeederPort.Location = new Point(395, 20);
            lblFeederPort.Name = "lblFeederPort";
            lblFeederPort.Size = new Size(84, 20);
            lblFeederPort.TabIndex = 2;
            lblFeederPort.Text = "Feeder Port";
            // 
            // txtFeederPort
            // 
            txtFeederPort.Location = new Point(485, 17);
            txtFeederPort.Name = "txtFeederPort";
            txtFeederPort.Size = new Size(279, 27);
            txtFeederPort.TabIndex = 3;
            txtFeederPort.Text = "8754";
            // 
            // tabControlFeederData
            // 
            tabControlFeederData.Controls.Add(tabOverview);
            tabControlFeederData.Controls.Add(tabTrackList);
            tabControlFeederData.Controls.Add(tabLogs);
            tabControlFeederData.Controls.Add(tabOptions);
            tabControlFeederData.Controls.Add(tabAbout);
            tabControlFeederData.Enabled = false;
            tabControlFeederData.Location = new Point(20, 59);
            tabControlFeederData.Name = "tabControlFeederData";
            tabControlFeederData.SelectedIndex = 0;
            tabControlFeederData.Size = new Size(744, 379);
            tabControlFeederData.TabIndex = 4;
            // 
            // tabOverview
            // 
            tabOverview.Controls.Add(lblLocalIpsValue);
            tabOverview.Controls.Add(lblLocalIps);
            tabOverview.Controls.Add(gbOverviewAircraftData);
            tabOverview.Controls.Add(lblMessagesValue);
            tabOverview.Controls.Add(lblMessages);
            tabOverview.Controls.Add(lblReceiverValue);
            tabOverview.Controls.Add(lblReceiver);
            tabOverview.Controls.Add(lblFeedTypeValue);
            tabOverview.Controls.Add(lblFeedType);
            tabOverview.Controls.Add(lblConnectedValue);
            tabOverview.Controls.Add(lblConnectedMode);
            tabOverview.Controls.Add(lblAliasValue);
            tabOverview.Controls.Add(lblAlias);
            tabOverview.Location = new Point(4, 29);
            tabOverview.Name = "tabOverview";
            tabOverview.Padding = new Padding(3);
            tabOverview.Size = new Size(736, 346);
            tabOverview.TabIndex = 0;
            tabOverview.Text = "Overview";
            tabOverview.UseVisualStyleBackColor = true;
            // 
            // lblLocalIpsValue
            // 
            lblLocalIpsValue.Cursor = Cursors.Hand;
            lblLocalIpsValue.ForeColor = Color.FromArgb(192, 0, 0);
            lblLocalIpsValue.Location = new Point(126, 140);
            lblLocalIpsValue.Name = "lblLocalIpsValue";
            lblLocalIpsValue.Size = new Size(512, 59);
            lblLocalIpsValue.TabIndex = 12;
            lblLocalIpsValue.Text = "...";
            lblLocalIpsValue.Click += lblLocalIpsValue_Click;
            // 
            // lblLocalIps
            // 
            lblLocalIps.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLocalIps.Location = new Point(20, 140);
            lblLocalIps.Name = "lblLocalIps";
            lblLocalIps.Size = new Size(100, 20);
            lblLocalIps.TabIndex = 11;
            lblLocalIps.Text = "Local IP(s)";
            lblLocalIps.TextAlign = ContentAlignment.TopRight;
            // 
            // gbOverviewAircraftData
            // 
            gbOverviewAircraftData.Controls.Add(lblAircraftTrackedD11Value);
            gbOverviewAircraftData.Controls.Add(lblAircraftTrackedD11);
            gbOverviewAircraftData.Controls.Add(lblAircraftUploadedValue);
            gbOverviewAircraftData.Controls.Add(lblAircraftUploaded);
            gbOverviewAircraftData.Controls.Add(lblAircraftTrackedACValue);
            gbOverviewAircraftData.Controls.Add(lblAircraftTrackedAC);
            gbOverviewAircraftData.Location = new Point(20, 202);
            gbOverviewAircraftData.Name = "gbOverviewAircraftData";
            gbOverviewAircraftData.Size = new Size(692, 124);
            gbOverviewAircraftData.TabIndex = 10;
            gbOverviewAircraftData.TabStop = false;
            gbOverviewAircraftData.Text = "Aircraft Data";
            // 
            // lblAircraftTrackedD11Value
            // 
            lblAircraftTrackedD11Value.ForeColor = Color.FromArgb(192, 0, 0);
            lblAircraftTrackedD11Value.Location = new Point(126, 80);
            lblAircraftTrackedD11Value.Name = "lblAircraftTrackedD11Value";
            lblAircraftTrackedD11Value.Size = new Size(200, 20);
            lblAircraftTrackedD11Value.TabIndex = 15;
            lblAircraftTrackedD11Value.Text = "...";
            // 
            // lblAircraftTrackedD11
            // 
            lblAircraftTrackedD11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAircraftTrackedD11.Location = new Point(10, 80);
            lblAircraftTrackedD11.Name = "lblAircraftTrackedD11";
            lblAircraftTrackedD11.Size = new Size(110, 20);
            lblAircraftTrackedD11.TabIndex = 14;
            lblAircraftTrackedD11.Text = "Tracked (D11)";
            lblAircraftTrackedD11.TextAlign = ContentAlignment.TopRight;
            // 
            // lblAircraftUploadedValue
            // 
            lblAircraftUploadedValue.ForeColor = Color.FromArgb(192, 0, 0);
            lblAircraftUploadedValue.Location = new Point(448, 40);
            lblAircraftUploadedValue.Name = "lblAircraftUploadedValue";
            lblAircraftUploadedValue.Size = new Size(200, 20);
            lblAircraftUploadedValue.TabIndex = 13;
            lblAircraftUploadedValue.Text = "...";
            // 
            // lblAircraftUploaded
            // 
            lblAircraftUploaded.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAircraftUploaded.Location = new Point(332, 40);
            lblAircraftUploaded.Name = "lblAircraftUploaded";
            lblAircraftUploaded.Size = new Size(110, 20);
            lblAircraftUploaded.TabIndex = 12;
            lblAircraftUploaded.Text = "Uploaded";
            lblAircraftUploaded.TextAlign = ContentAlignment.TopRight;
            // 
            // lblAircraftTrackedACValue
            // 
            lblAircraftTrackedACValue.ForeColor = Color.FromArgb(192, 0, 0);
            lblAircraftTrackedACValue.Location = new Point(126, 40);
            lblAircraftTrackedACValue.Name = "lblAircraftTrackedACValue";
            lblAircraftTrackedACValue.Size = new Size(200, 20);
            lblAircraftTrackedACValue.TabIndex = 11;
            lblAircraftTrackedACValue.Text = "...";
            // 
            // lblAircraftTrackedAC
            // 
            lblAircraftTrackedAC.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAircraftTrackedAC.Location = new Point(10, 40);
            lblAircraftTrackedAC.Name = "lblAircraftTrackedAC";
            lblAircraftTrackedAC.Size = new Size(110, 20);
            lblAircraftTrackedAC.TabIndex = 1;
            lblAircraftTrackedAC.Text = "Tracked (AC)";
            lblAircraftTrackedAC.TextAlign = ContentAlignment.TopRight;
            // 
            // lblMessagesValue
            // 
            lblMessagesValue.ForeColor = Color.FromArgb(192, 0, 0);
            lblMessagesValue.Location = new Point(438, 60);
            lblMessagesValue.Name = "lblMessagesValue";
            lblMessagesValue.Size = new Size(200, 20);
            lblMessagesValue.TabIndex = 9;
            lblMessagesValue.Text = "...";
            // 
            // lblMessages
            // 
            lblMessages.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMessages.Location = new Point(332, 60);
            lblMessages.Name = "lblMessages";
            lblMessages.Size = new Size(100, 20);
            lblMessages.TabIndex = 8;
            lblMessages.Text = "Messages";
            lblMessages.TextAlign = ContentAlignment.TopRight;
            // 
            // lblReceiverValue
            // 
            lblReceiverValue.ForeColor = Color.FromArgb(192, 0, 0);
            lblReceiverValue.Location = new Point(438, 20);
            lblReceiverValue.Name = "lblReceiverValue";
            lblReceiverValue.Size = new Size(200, 20);
            lblReceiverValue.TabIndex = 7;
            lblReceiverValue.Text = "...";
            // 
            // lblReceiver
            // 
            lblReceiver.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblReceiver.Location = new Point(332, 20);
            lblReceiver.Name = "lblReceiver";
            lblReceiver.Size = new Size(100, 20);
            lblReceiver.TabIndex = 6;
            lblReceiver.Text = "Receiver";
            lblReceiver.TextAlign = ContentAlignment.TopRight;
            // 
            // lblFeedTypeValue
            // 
            lblFeedTypeValue.ForeColor = Color.FromArgb(0, 0, 192);
            lblFeedTypeValue.Location = new Point(126, 100);
            lblFeedTypeValue.Name = "lblFeedTypeValue";
            lblFeedTypeValue.Size = new Size(200, 20);
            lblFeedTypeValue.TabIndex = 5;
            lblFeedTypeValue.Text = "...";
            // 
            // lblFeedType
            // 
            lblFeedType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFeedType.Location = new Point(20, 100);
            lblFeedType.Name = "lblFeedType";
            lblFeedType.Size = new Size(100, 20);
            lblFeedType.TabIndex = 4;
            lblFeedType.Text = "Feed Type";
            lblFeedType.TextAlign = ContentAlignment.TopRight;
            // 
            // lblConnectedValue
            // 
            lblConnectedValue.ForeColor = Color.FromArgb(192, 0, 0);
            lblConnectedValue.Location = new Point(126, 60);
            lblConnectedValue.Name = "lblConnectedValue";
            lblConnectedValue.Size = new Size(200, 20);
            lblConnectedValue.TabIndex = 3;
            lblConnectedValue.Text = "...";
            // 
            // lblConnectedMode
            // 
            lblConnectedMode.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblConnectedMode.Location = new Point(20, 60);
            lblConnectedMode.Name = "lblConnectedMode";
            lblConnectedMode.Size = new Size(100, 20);
            lblConnectedMode.TabIndex = 2;
            lblConnectedMode.Text = "Link";
            lblConnectedMode.TextAlign = ContentAlignment.TopRight;
            // 
            // lblAliasValue
            // 
            lblAliasValue.Cursor = Cursors.Hand;
            lblAliasValue.ForeColor = Color.FromArgb(192, 0, 0);
            lblAliasValue.Location = new Point(126, 20);
            lblAliasValue.Name = "lblAliasValue";
            lblAliasValue.Size = new Size(200, 20);
            lblAliasValue.TabIndex = 1;
            lblAliasValue.Text = "...";
            lblAliasValue.Click += lblAliasValue_Click;
            // 
            // lblAlias
            // 
            lblAlias.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAlias.Location = new Point(20, 20);
            lblAlias.Name = "lblAlias";
            lblAlias.Size = new Size(100, 20);
            lblAlias.TabIndex = 0;
            lblAlias.Text = "Radar Code";
            lblAlias.TextAlign = ContentAlignment.TopRight;
            // 
            // tabTrackList
            // 
            tabTrackList.Controls.Add(dgvAircraft);
            tabTrackList.Location = new Point(4, 29);
            tabTrackList.Name = "tabTrackList";
            tabTrackList.Padding = new Padding(3);
            tabTrackList.Size = new Size(736, 346);
            tabTrackList.TabIndex = 1;
            tabTrackList.Text = "Tracked Aircraft";
            tabTrackList.UseVisualStyleBackColor = true;
            // 
            // dgvAircraft
            // 
            dgvAircraft.AllowUserToAddRows = false;
            dgvAircraft.AllowUserToDeleteRows = false;
            dgvAircraft.BackgroundColor = Color.White;
            dgvAircraft.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAircraft.Columns.AddRange(new DataGridViewColumn[] { ModeS, Callsign, Latitude, Longitude, Altitude, Squawk });
            dgvAircraft.Dock = DockStyle.Fill;
            dgvAircraft.GridColor = Color.White;
            dgvAircraft.Location = new Point(3, 3);
            dgvAircraft.Name = "dgvAircraft";
            dgvAircraft.ReadOnly = true;
            dgvAircraft.RowHeadersVisible = false;
            dgvAircraft.RowHeadersWidth = 51;
            dgvAircraft.ShowCellErrors = false;
            dgvAircraft.ShowCellToolTips = false;
            dgvAircraft.ShowEditingIcon = false;
            dgvAircraft.ShowRowErrors = false;
            dgvAircraft.Size = new Size(730, 340);
            dgvAircraft.TabIndex = 0;
            dgvAircraft.CellDoubleClick += dgvAircraft_CellDoubleClick;
            // 
            // ModeS
            // 
            ModeS.Frozen = true;
            ModeS.HeaderText = "Modes";
            ModeS.MinimumWidth = 6;
            ModeS.Name = "ModeS";
            ModeS.ReadOnly = true;
            ModeS.Width = 125;
            // 
            // Callsign
            // 
            Callsign.Frozen = true;
            Callsign.HeaderText = "Callsign";
            Callsign.MinimumWidth = 6;
            Callsign.Name = "Callsign";
            Callsign.ReadOnly = true;
            Callsign.Width = 125;
            // 
            // Latitude
            // 
            Latitude.Frozen = true;
            Latitude.HeaderText = "Latitude";
            Latitude.MinimumWidth = 6;
            Latitude.Name = "Latitude";
            Latitude.ReadOnly = true;
            Latitude.Width = 125;
            // 
            // Longitude
            // 
            Longitude.Frozen = true;
            Longitude.HeaderText = "Longitude";
            Longitude.MinimumWidth = 6;
            Longitude.Name = "Longitude";
            Longitude.ReadOnly = true;
            Longitude.Width = 125;
            // 
            // Altitude
            // 
            Altitude.Frozen = true;
            Altitude.HeaderText = "Altitude";
            Altitude.MinimumWidth = 6;
            Altitude.Name = "Altitude";
            Altitude.ReadOnly = true;
            Altitude.Width = 125;
            // 
            // Squawk
            // 
            Squawk.Frozen = true;
            Squawk.HeaderText = "Squawk";
            Squawk.MinimumWidth = 6;
            Squawk.Name = "Squawk";
            Squawk.ReadOnly = true;
            Squawk.Width = 125;
            // 
            // tabLogs
            // 
            tabLogs.AutoScroll = true;
            tabLogs.Controls.Add(txtLogs);
            tabLogs.Location = new Point(4, 29);
            tabLogs.Name = "tabLogs";
            tabLogs.Size = new Size(736, 346);
            tabLogs.TabIndex = 2;
            tabLogs.Text = "Logs";
            tabLogs.UseVisualStyleBackColor = true;
            // 
            // txtLogs
            // 
            txtLogs.BorderStyle = BorderStyle.None;
            txtLogs.Dock = DockStyle.Fill;
            txtLogs.Location = new Point(0, 0);
            txtLogs.Multiline = true;
            txtLogs.Name = "txtLogs";
            txtLogs.ScrollBars = ScrollBars.Both;
            txtLogs.ShortcutsEnabled = false;
            txtLogs.Size = new Size(736, 346);
            txtLogs.TabIndex = 0;
            txtLogs.WordWrap = false;
            // 
            // tabOptions
            // 
            tabOptions.Controls.Add(btnOptionsData);
            tabOptions.Controls.Add(btnOptionsSave);
            tabOptions.Controls.Add(cbAppendLog);
            tabOptions.Controls.Add(gbFlightAlert);
            tabOptions.Controls.Add(cbFlightAlert);
            tabOptions.Controls.Add(gbAutomaticRefresh);
            tabOptions.Controls.Add(cbRefresh);
            tabOptions.Controls.Add(cbSaveFeeder);
            tabOptions.Location = new Point(4, 29);
            tabOptions.Name = "tabOptions";
            tabOptions.Padding = new Padding(3);
            tabOptions.Size = new Size(736, 346);
            tabOptions.TabIndex = 3;
            tabOptions.Text = "Options";
            tabOptions.UseVisualStyleBackColor = true;
            // 
            // btnOptionsData
            // 
            btnOptionsData.Location = new Point(20, 302);
            btnOptionsData.Name = "btnOptionsData";
            btnOptionsData.Size = new Size(94, 29);
            btnOptionsData.TabIndex = 7;
            btnOptionsData.Text = "Data";
            btnOptionsData.UseVisualStyleBackColor = true;
            btnOptionsData.Click += btnOptionsData_Click;
            // 
            // btnOptionsSave
            // 
            btnOptionsSave.Location = new Point(622, 302);
            btnOptionsSave.Name = "btnOptionsSave";
            btnOptionsSave.Size = new Size(94, 29);
            btnOptionsSave.TabIndex = 6;
            btnOptionsSave.Text = "Save";
            btnOptionsSave.UseVisualStyleBackColor = true;
            btnOptionsSave.Click += btnOptionsSave_Click;
            // 
            // cbAppendLog
            // 
            cbAppendLog.AutoSize = true;
            cbAppendLog.Location = new Point(371, 20);
            cbAppendLog.Name = "cbAppendLog";
            cbAppendLog.Size = new Size(113, 24);
            cbAppendLog.TabIndex = 4;
            cbAppendLog.Text = "Append Log";
            cbAppendLog.UseVisualStyleBackColor = true;
            // 
            // gbFlightAlert
            // 
            gbFlightAlert.Controls.Add(cbFlightAlertBeep);
            gbFlightAlert.Controls.Add(cbFlightAlertNotification);
            gbFlightAlert.Controls.Add(txtCallSign);
            gbFlightAlert.Controls.Add(lblFlightAlertCallSign);
            gbFlightAlert.Enabled = false;
            gbFlightAlert.Location = new Point(371, 90);
            gbFlightAlert.Name = "gbFlightAlert";
            gbFlightAlert.Size = new Size(345, 125);
            gbFlightAlert.TabIndex = 3;
            gbFlightAlert.TabStop = false;
            gbFlightAlert.Text = "Flight Alert";
            gbFlightAlert.Visible = false;
            // 
            // cbFlightAlertBeep
            // 
            cbFlightAlertBeep.AutoSize = true;
            cbFlightAlertBeep.Location = new Point(136, 80);
            cbFlightAlertBeep.Name = "cbFlightAlertBeep";
            cbFlightAlertBeep.Size = new Size(65, 24);
            cbFlightAlertBeep.TabIndex = 4;
            cbFlightAlertBeep.Text = "Beep";
            cbFlightAlertBeep.UseVisualStyleBackColor = true;
            // 
            // cbFlightAlertNotification
            // 
            cbFlightAlertNotification.AutoSize = true;
            cbFlightAlertNotification.Location = new Point(20, 80);
            cbFlightAlertNotification.Name = "cbFlightAlertNotification";
            cbFlightAlertNotification.Size = new Size(110, 24);
            cbFlightAlertNotification.TabIndex = 3;
            cbFlightAlertNotification.Text = "Notification";
            cbFlightAlertNotification.UseVisualStyleBackColor = true;
            // 
            // txtCallSign
            // 
            txtCallSign.Location = new Point(98, 38);
            txtCallSign.Name = "txtCallSign";
            txtCallSign.Size = new Size(229, 27);
            txtCallSign.TabIndex = 2;
            // 
            // lblFlightAlertCallSign
            // 
            lblFlightAlertCallSign.AutoSize = true;
            lblFlightAlertCallSign.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFlightAlertCallSign.Location = new Point(20, 40);
            lblFlightAlertCallSign.Name = "lblFlightAlertCallSign";
            lblFlightAlertCallSign.Size = new Size(72, 20);
            lblFlightAlertCallSign.TabIndex = 1;
            lblFlightAlertCallSign.Text = "Call Sign:";
            // 
            // cbFlightAlert
            // 
            cbFlightAlert.AutoSize = true;
            cbFlightAlert.Enabled = false;
            cbFlightAlert.Location = new Point(371, 60);
            cbFlightAlert.Name = "cbFlightAlert";
            cbFlightAlert.Size = new Size(104, 24);
            cbFlightAlert.TabIndex = 3;
            cbFlightAlert.Text = "Flight Alert";
            cbFlightAlert.UseVisualStyleBackColor = true;
            cbFlightAlert.Visible = false;
            cbFlightAlert.CheckedChanged += cbFlightAlert_CheckedChanged;
            // 
            // gbAutomaticRefresh
            // 
            gbAutomaticRefresh.Controls.Add(lblRefreshTime);
            gbAutomaticRefresh.Controls.Add(numRefreshTime);
            gbAutomaticRefresh.Enabled = false;
            gbAutomaticRefresh.Location = new Point(20, 90);
            gbAutomaticRefresh.Name = "gbAutomaticRefresh";
            gbAutomaticRefresh.Size = new Size(345, 125);
            gbAutomaticRefresh.TabIndex = 2;
            gbAutomaticRefresh.TabStop = false;
            gbAutomaticRefresh.Text = "Automatic Refresh";
            // 
            // lblRefreshTime
            // 
            lblRefreshTime.AutoSize = true;
            lblRefreshTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRefreshTime.Location = new Point(20, 40);
            lblRefreshTime.Name = "lblRefreshTime";
            lblRefreshTime.Size = new Size(137, 20);
            lblRefreshTime.TabIndex = 1;
            lblRefreshTime.Text = "Interval (Seconds)";
            // 
            // numRefreshTime
            // 
            numRefreshTime.Location = new Point(163, 38);
            numRefreshTime.Maximum = new decimal(new int[] { 3600, 0, 0, 0 });
            numRefreshTime.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numRefreshTime.Name = "numRefreshTime";
            numRefreshTime.Size = new Size(150, 27);
            numRefreshTime.TabIndex = 0;
            numRefreshTime.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // cbRefresh
            // 
            cbRefresh.AutoSize = true;
            cbRefresh.Location = new Point(20, 60);
            cbRefresh.Name = "cbRefresh";
            cbRefresh.Size = new Size(153, 24);
            cbRefresh.TabIndex = 1;
            cbRefresh.Text = "Automatic Refresh";
            cbRefresh.UseVisualStyleBackColor = true;
            cbRefresh.CheckedChanged += cbRefresh_CheckedChanged;
            // 
            // cbSaveFeeder
            // 
            cbSaveFeeder.AutoSize = true;
            cbSaveFeeder.Location = new Point(20, 20);
            cbSaveFeeder.Name = "cbSaveFeeder";
            cbSaveFeeder.Size = new Size(111, 24);
            cbSaveFeeder.TabIndex = 0;
            cbSaveFeeder.Text = "Save Feeder";
            cbSaveFeeder.UseVisualStyleBackColor = true;
            // 
            // tabAbout
            // 
            tabAbout.Controls.Add(lblVersion);
            tabAbout.Controls.Add(pbPlane);
            tabAbout.Controls.Add(txtAbout);
            tabAbout.Controls.Add(lnkHelp);
            tabAbout.Controls.Add(lblCopyright);
            tabAbout.Controls.Add(lblAppName);
            tabAbout.Location = new Point(4, 29);
            tabAbout.Name = "tabAbout";
            tabAbout.Padding = new Padding(3);
            tabAbout.Size = new Size(736, 346);
            tabAbout.TabIndex = 4;
            tabAbout.Text = "About";
            tabAbout.UseVisualStyleBackColor = true;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(20, 92);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(60, 20);
            lblVersion.TabIndex = 9;
            lblVersion.Text = "{0.0.0.0}";
            // 
            // pbPlane
            // 
            pbPlane.ErrorImage = Properties.Resources.airplane;
            pbPlane.Image = Properties.Resources.airplane;
            pbPlane.Location = new Point(644, 20);
            pbPlane.Name = "pbPlane";
            pbPlane.Size = new Size(70, 70);
            pbPlane.SizeMode = PictureBoxSizeMode.Zoom;
            pbPlane.TabIndex = 8;
            pbPlane.TabStop = false;
            // 
            // txtAbout
            // 
            txtAbout.Location = new Point(20, 115);
            txtAbout.Multiline = true;
            txtAbout.Name = "txtAbout";
            txtAbout.Size = new Size(694, 200);
            txtAbout.TabIndex = 7;
            txtAbout.Text = "Plane icon created by Freepik - Flaticon, available from https://www.flaticon.com/free-icons/plane";
            // 
            // lnkHelp
            // 
            lnkHelp.AutoSize = true;
            lnkHelp.Location = new Point(597, 70);
            lnkHelp.Name = "lnkHelp";
            lnkHelp.Size = new Size(41, 20);
            lnkHelp.TabIndex = 6;
            lnkHelp.TabStop = true;
            lnkHelp.Text = "Help";
            lnkHelp.LinkClicked += lnkHelp_LinkClicked;
            // 
            // lblCopyright
            // 
            lblCopyright.AutoSize = true;
            lblCopyright.Location = new Point(20, 70);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(199, 20);
            lblCopyright.TabIndex = 2;
            lblCopyright.Text = "Copyright (c) Laim McKenzie";
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.Location = new Point(20, 20);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(116, 38);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "pi24gui";
            lblAppName.TextAlign = ContentAlignment.TopRight;
            // 
            // btnFeederConnectDisconnect
            // 
            btnFeederConnectDisconnect.Location = new Point(670, 50);
            btnFeederConnectDisconnect.Name = "btnFeederConnectDisconnect";
            btnFeederConnectDisconnect.Size = new Size(94, 29);
            btnFeederConnectDisconnect.TabIndex = 5;
            btnFeederConnectDisconnect.Text = "Connect";
            btnFeederConnectDisconnect.UseVisualStyleBackColor = true;
            btnFeederConnectDisconnect.Click += btnFeederConnectDisconnect_Click;
            // 
            // toolStripMain
            // 
            toolStripMain.Dock = DockStyle.Bottom;
            toolStripMain.ImageScalingSize = new Size(20, 20);
            toolStripMain.Items.AddRange(new ToolStripItem[] { tsLastRefresh, tsLastRefreshValue, tsSpacer, tsConnectionTime, tsConnectionTimeValue });
            toolStripMain.Location = new Point(0, 445);
            toolStripMain.Name = "toolStripMain";
            toolStripMain.Size = new Size(785, 25);
            toolStripMain.TabIndex = 6;
            toolStripMain.Text = "toolStrip1";
            // 
            // tsLastRefresh
            // 
            tsLastRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tsLastRefresh.Name = "tsLastRefresh";
            tsLastRefresh.Size = new Size(100, 22);
            tsLastRefresh.Text = "Last Refresh:";
            // 
            // tsLastRefreshValue
            // 
            tsLastRefreshValue.ForeColor = Color.FromArgb(192, 0, 0);
            tsLastRefreshValue.Name = "tsLastRefreshValue";
            tsLastRefreshValue.Size = new Size(121, 22);
            tsLastRefreshValue.Text = "Refresh Disabled";
            // 
            // tsSpacer
            // 
            tsSpacer.AutoSize = false;
            tsSpacer.Name = "tsSpacer";
            tsSpacer.Size = new Size(250, 22);
            // 
            // tsConnectionTime
            // 
            tsConnectionTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tsConnectionTime.Name = "tsConnectionTime";
            tsConnectionTime.RightToLeft = RightToLeft.No;
            tsConnectionTime.Size = new Size(126, 22);
            tsConnectionTime.Text = "Time Connected:";
            tsConnectionTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tsConnectionTimeValue
            // 
            tsConnectionTimeValue.Name = "tsConnectionTimeValue";
            tsConnectionTimeValue.Size = new Size(0, 22);
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 470);
            Controls.Add(toolStripMain);
            Controls.Add(btnFeederConnectDisconnect);
            Controls.Add(tabControlFeederData);
            Controls.Add(txtFeederPort);
            Controls.Add(lblFeederPort);
            Controls.Add(txtFeederUrl);
            Controls.Add(lblFeederUrl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "pi24gui";
            tabControlFeederData.ResumeLayout(false);
            tabOverview.ResumeLayout(false);
            gbOverviewAircraftData.ResumeLayout(false);
            tabTrackList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAircraft).EndInit();
            tabLogs.ResumeLayout(false);
            tabLogs.PerformLayout();
            tabOptions.ResumeLayout(false);
            tabOptions.PerformLayout();
            gbFlightAlert.ResumeLayout(false);
            gbFlightAlert.PerformLayout();
            gbAutomaticRefresh.ResumeLayout(false);
            gbAutomaticRefresh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numRefreshTime).EndInit();
            tabAbout.ResumeLayout(false);
            tabAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPlane).EndInit();
            toolStripMain.ResumeLayout(false);
            toolStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFeederUrl;
        private TextBox txtFeederUrl;
        private Label lblFeederPort;
        private TextBox txtFeederPort;
        private TabControl tabControlFeederData;
        private TabPage tabOverview;
        private TabPage tabTrackList;
        private Button btnFeederConnectDisconnect;
        private TabPage tabLogs;
        private Label lblAliasValue;
        private Label lblAlias;
        private Label lblConnectedMode;
        private Label lblConnectedValue;
        private Label lblFeedTypeValue;
        private Label lblFeedType;
        private Label lblReceiver;
        private Label lblReceiverValue;
        private Label lblMessages;
        private Label lblMessagesValue;
        private GroupBox gbOverviewAircraftData;
        private Label lblAircraftTrackedAC;
        private Label lblAircraftTrackedACValue;
        private Label lblAircraftUploadedValue;
        private Label lblAircraftUploaded;
        private Label lblAircraftTrackedD11Value;
        private Label lblAircraftTrackedD11;
        private Label lblLocalIps;
        private Label lblLocalIpsValue;
        private TextBox txtLogs;
        private TabPage tabOptions;
        private CheckBox cbSaveFeeder;
        private GroupBox gbAutomaticRefresh;
        private CheckBox cbRefresh;
        private Label lblRefreshTime;
        private NumericUpDown numRefreshTime;
        private GroupBox gbFlightAlert;
        private CheckBox cbFlightAlert;
        private TextBox txtCallSign;
        private Label lblFlightAlertCallSign;
        private CheckBox cbFlightAlertBeep;
        private CheckBox cbFlightAlertNotification;
        private ToolStrip toolStripMain;
        private ToolStripLabel tsLastRefresh;
        private ToolStripLabel tsLastRefreshValue;
        private ToolStripLabel tsSpacer;
        private ToolStripLabel tsConnectionTime;
        private ToolStripLabel tsConnectionTimeValue;
        private CheckBox cbAppendLog;
        private DataGridView dgvAircraft;
        private DataGridViewTextBoxColumn ModeS;
        private DataGridViewTextBoxColumn Callsign;
        private DataGridViewTextBoxColumn Latitude;
        private DataGridViewTextBoxColumn Longitude;
        private DataGridViewTextBoxColumn Altitude;
        private DataGridViewTextBoxColumn Squawk;
        private Button btnOptionsSave;
        private TabPage tabAbout;
        private Label lblAppName;
        private Label lblCopyright;
        private LinkLabel lnkHelp;
        private TextBox txtAbout;
        private PictureBox pbPlane;
        private Label lblVersion;
        private Button btnOptionsData;
    }
}
