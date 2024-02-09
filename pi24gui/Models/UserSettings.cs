namespace pi24gui.Models
{
    public class UserSettings
    {
        public bool AppendLog { get; set; } = false;

        public bool AutoRefreshEnabled { get; set; } = false;

        public int AutoRefreshInterval { get; set; } = 5;

        public bool FlightAlertEnabled { get; set; } = false;

        public string FlightAlertCallSign { get; set; } = string.Empty;

        public bool FlightAlertNotification { get; set; } = false;

        public bool FlightAlertBeep { get; set; } = false;

        public string FeederURL { get; set; } = string.Empty;

        public int FeederPort { get; set; } = 8754;

    }
}
