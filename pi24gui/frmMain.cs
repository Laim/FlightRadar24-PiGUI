using pi24gui.Helpers;
using pi24gui.Models;
using System.Diagnostics;
using Newtonsoft.Json;
using pi24gui.Settings;

namespace pi24gui
{
    public partial class frmMain : Form
    {
        private readonly RadarClient _radarClient;
        IUserSettingsRepo settingsRepo = new FileSystemUserSettingsRepo();
        private UserSettings _userSettings = new();
        private System.Windows.Forms.Timer? _autoRefreshTimer = null;

        public frmMain()
        {
            InitializeComponent();

            _radarClient ??= new RadarClient();
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Updater.Updater updater = new Updater.Updater();
            if (updater.CheckForUpdate(Application.ProductVersion))
            {
                frmUpdateNotice frm = new frmUpdateNotice();
                frm.ShowDialog();
            }

            _userSettings = await settingsRepo.GetSettings();
        }

        private void btnFeederConnectDisconnect_Click(object sender, EventArgs e)
        {
            if (sender is not Button btn)
            {
                return;
            }

            btn.Enabled = false;

            if (btn.Text == "Connect")
            {
               Connect();
            }
            else
            {
                Disconnect(tabControlFeederData.TabPages[0]);
            }

            btn.Enabled = true;
        }

        private void GetLogs(string feederData)
        {
            if (cbAppendLog.Checked)
            {
                txtLogs.Text += Environment.NewLine + feederData.Replace("\n", Environment.NewLine);
                return;
            }

            txtLogs.Text = feederData.Replace("\n", Environment.NewLine);
        }

        private void GetFlights(string feederData)
        {
            Dictionary<string, List<object>>? jsonData = JsonConvert.DeserializeObject<Dictionary<string, List<object>>>(feederData);

            if (jsonData == null)
            {
                return;
            }

            List<Flight> flights = jsonData.Select(kvp => new Flight
            {
                ModeS = kvp.Value.ElementAtOrDefault(0)?.ToString() ?? "",
                Latitude = kvp.Value.ElementAtOrDefault(1)?.ToString() ?? "",
                Longitude = kvp.Value.ElementAtOrDefault(2)?.ToString() ?? "",
                Altitude = kvp.Value.ElementAtOrDefault(4)?.ToString() ?? "",
                Squawk = kvp.Value.ElementAtOrDefault(6)?.ToString() ?? "",
                Callsign = kvp.Value.ElementAtOrDefault(16)?.ToString() ?? ""
            }).ToList();

            foreach (var flight in flights)
            {
                dgvAircraft.Rows.Add(
                    new object[]
                    {
                        flight.ModeS,
                        flight.Callsign,
                        flight.Latitude,
                        flight.Longitude,
                        flight.Altitude,
                        flight.Squawk
                    }
                );
            }
        }

        private void GetOverview(string feederData)
        {
            // Deserialise the received data
            Overview? overview = JsonConvert.DeserializeObject<Overview>(feederData);

            if (overview == null)
            {
                MessageBox.Show($"Unable to deserialize monitor.json at {txtFeederUrl.Text}:{txtFeederPort.Text}/monitor.json");
                return;
            }

            lblAliasValue.Text = overview.feed_alias;
            lblConnectedValue.Text = overview.feed_current_mode;
            lblFeedTypeValue.Text = overview.feed_type;
            lblReceiverValue.Text = $"{overview.cfg_receiver}, {overview.feed_status}";

            // We do this to try and show thousand seperates, but worse case scenerio
            // just output the raw value.
            if (long.TryParse(overview.num_messages, out var numMessages))
            {
                lblMessagesValue.Text = $"{numMessages:N0}";
            }
            else
            {
                lblMessagesValue.Text = overview.num_messages;
            }

            lblLocalIpsValue.Text = overview.local_ips;

            lblAircraftTrackedACValue.Text = overview.ac_map_size;
            lblAircraftTrackedD11Value.Text = overview.d11_map_size;
            lblAircraftUploadedValue.Text = overview.feed_num_ac_tracked;

            SetTextColor(overview);
        }

        /// <summary>
        /// Converts the labels showing the data to their correct colors depending on the data from <see cref="Overview"/>
        /// </summary>
        /// <param name="overview">
        /// Deserialized Json model
        /// </param>
        private void SetTextColor(Overview overview)
        {
            if (overview == null)
            {
                return;
            }

            if (overview.feed_alias != null)
            {
                if (overview.feed_alias.Length > 0)
                {
                    lblAliasValue.ForeColor = Color.DarkGreen;
                }
            }

            if (overview.feed_status != null)
            {
                if (overview.feed_status == "connected")
                {
                    lblReceiverValue.ForeColor = Color.DarkGreen;
                    lblConnectedValue.ForeColor = Color.DarkGreen;
                }
            }

            if (overview.num_messages != null)
            {
                if (long.TryParse(overview.num_messages, out _))
                {
                    lblMessagesValue.ForeColor = Color.DarkGreen;
                }
                else
                {
                    lblMessagesValue.ForeColor = Color.OrangeRed;
                }
            }

            if (overview.local_ips != null)
            {
                lblLocalIpsValue.ForeColor = Color.DarkGreen;
            }

            if (overview.ac_map_size != null)
            {
                int count = Convert.ToInt32(overview.ac_map_size);
                if (count > 0)
                {
                    lblAircraftTrackedACValue.ForeColor = Color.DarkGreen;
                }
                else
                {
                    lblAircraftTrackedACValue.ForeColor = Color.Orange;
                }
            }

            if (overview.d11_map_size != null)
            {
                int count = Convert.ToInt32(overview.d11_map_size);
                if (count > 0)
                {
                    lblAircraftTrackedD11Value.ForeColor = Color.DarkGreen;
                }
                else
                {
                    lblAircraftTrackedD11Value.ForeColor = Color.Orange;
                }
            }

            if (overview.feed_num_ac_tracked != null)
            {
                int count = Convert.ToInt32(overview.feed_num_ac_tracked);

                if (count > 0)
                {
                    lblAircraftUploadedValue.ForeColor = Color.DarkGreen;
                }
                else
                {
                    lblAircraftUploadedValue.ForeColor = Color.Orange;
                }
            }
        }

        /// <summary>
        /// Loops through the TabControl and resets all of the relevant labels to their pre-populated stance
        /// </summary>
        /// <param name="controls">
        /// tabControlFeederData.TabPages[0] and any of it's children that have children
        /// </param>
        private void Disconnect(Control controls)
        {
            foreach (Control ctrl in controls.Controls)
            {
                if (ctrl is Label l)
                {
                    if (l.Name.Contains("Value"))
                    {
                        l.Text = "...";
                        l.ForeColor = Color.FromArgb(192, 0, 0);

                        if (l.Name == nameof(lblFeedTypeValue))
                        {
                            l.ForeColor = Color.FromArgb(0, 0, 192);
                        }
                    }
                }

                if (ctrl.HasChildren)
                {
                    Disconnect(ctrl);
                }
            }

            btnFeederConnectDisconnect.Text = "Connect";
            tabControlFeederData.Enabled = false;
            tabControlFeederData.SelectedIndex = 0;
            txtFeederUrl.Enabled = true;
            txtFeederPort.Enabled = true;
            tsConnectionTimeValue.Text = string.Empty;
            tsLastRefreshValue.Text = "Refresh Disabled";
            tsLastRefreshValue.ForeColor = Color.FromArgb(192, 0, 0);
            dgvAircraft.Rows.Clear();
            _autoRefreshTimer?.Dispose();
            cbRefresh.Checked = false;
        }

        private async void Connect()
        {
            try
            {
                LoadSettings();

                string feeder = $"{txtFeederUrl.Text}:{txtFeederPort.Text}";

                // Disable UI elements first, looks nicer
                btnFeederConnectDisconnect.Text = "Disconnect";
                txtFeederUrl.Enabled = false;
                txtFeederPort.Enabled = false;
                tsConnectionTimeValue.Text = "Connecting...";

                // Grab data
                GetOverview(await _radarClient.GetOverview(feeder));
                GetLogs(await _radarClient.GetLogs(feeder));
                GetFlights(await _radarClient.GetFlights(feeder));

                // Set the successful connection time
                tsConnectionTimeValue.Text = DateTime.Now.ToString();
                tabControlFeederData.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Feeder Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // If error, ensure that we 'disconnect'
                Disconnect(tabControlFeederData.TabPages[0]);
            }
        }

        private void cbRefresh_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox chk)
            {
                if (chk.Checked)
                {
                    gbAutomaticRefresh.Enabled = true;
                    cbFlightAlert.Enabled = true; // see comment below

                    tsLastRefreshValue.ForeColor = Color.Green;
                    tsLastRefreshValue.Text = "...";

                    _autoRefreshTimer = new();
                    _autoRefreshTimer.Tick += new EventHandler(AutomaticRefresh);
                    _autoRefreshTimer.Interval = Convert.ToInt32(numRefreshTime.Value * 1000);
                    _autoRefreshTimer.Start();

                    return;
                }

                gbAutomaticRefresh.Enabled = false;

                // Flight Alert requires automatic refresh so 
                // if we turn automatic refresh off, we need to also
                // turn off flight alert
                cbFlightAlert.Enabled = false;
                cbFlightAlert.Checked = false;

                _autoRefreshTimer?.Stop();
                _autoRefreshTimer?.Dispose();
                tsLastRefreshValue.Text = "Refresh Disabled";
                tsLastRefreshValue.ForeColor = Color.FromArgb(192, 0, 0);
            }
        }

        private void AutomaticRefresh(object sender, EventArgs e)
        {
            dgvAircraft.Rows.Clear();

            Connect();
            tsLastRefreshValue.Text = DateTime.Now.ToString();
        }

        private void cbFlightAlert_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox chk)
            {
                if (chk.Checked)
                {
                    gbFlightAlert.Enabled = true;
                    return;
                }

                gbFlightAlert.Enabled = false;
            }
        }

        private void lnkHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(
                new ProcessStartInfo("https://github.com/Laim/pi24-GUI/blob/main/HELP.md")
                {
                    UseShellExecute = true
                }
           );
        }

        /// <summary>
        /// Loads the user settings from appsettings.json
        /// </summary>
        private void LoadSettings()
        {

            txtFeederUrl.Text = _userSettings.FeederURL;
            txtFeederPort.Text = _userSettings.FeederPort.ToString();
            if (!string.IsNullOrEmpty(_userSettings.FeederURL))
            {
                cbSaveFeeder.Checked = true;
            }

            cbAppendLog.Checked = _userSettings.AppendLog;

            cbRefresh.Checked = _userSettings.AutoRefreshEnabled;
            numRefreshTime.Value = _userSettings.AutoRefreshInterval;

            cbFlightAlert.Checked = _userSettings.FlightAlertEnabled;
            txtCallSign.Text = _userSettings.FlightAlertCallSign;
            cbFlightAlertNotification.Checked = _userSettings.FlightAlertNotification;
            cbFlightAlertBeep.Checked = _userSettings.FlightAlertBeep;
        }

        /// <summary>
        /// Saves the user settings to appsettings.json
        /// </summary>
        private async void SaveSettings()
        {
            if (_userSettings == null)
            {
                MessageBox.Show("User Settings are not initialized for some reason", "This shouldn't happen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                _userSettings = new();
                _userSettings.FeederURL = txtFeederUrl.Text;
                _userSettings.FeederPort = Convert.ToInt32(txtFeederPort.Text);

                _userSettings.AppendLog = cbAppendLog.Checked;

                _userSettings.AutoRefreshEnabled = cbRefresh.Checked;
                _userSettings.AutoRefreshInterval = Convert.ToInt32(numRefreshTime.Value);

                _userSettings.FlightAlertEnabled = cbFlightAlert.Checked;
                _userSettings.FlightAlertCallSign = txtCallSign.Text;
                _userSettings.FlightAlertNotification = cbFlightAlertNotification.Checked;
                _userSettings.FlightAlertBeep = cbFlightAlertBeep.Checked;

                await settingsRepo.SaveSettings(_userSettings);


                MessageBox.Show("Saved Successfully", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Feeder Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOptionsSave_Click(object sender, EventArgs e)
        {
            SaveSettings();

            if(cbRefresh.Checked)
            {
                if(_autoRefreshTimer != null)
                {
                    _autoRefreshTimer.Interval = Convert.ToInt32(numRefreshTime.Value * 1000);
                }
            }
        }
    }
}
