using Newtonsoft.Json;

namespace pi24gui.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Overview
    {
        public string? ac_map_size { get; set; }
        public string? build_arch { get; set; }
        public string? build_flavour { get; set; }
        public string? build_os { get; set; }
        public string? build_revision { get; set; }
        public string? build_timetamp { get; set; }
        public string? build_version { get; set; }
        public string? cfg_baudrate { get; set; }
        public string? cfg_bs { get; set; }
        public string? cfg_host { get; set; }
        public string? cfg_mpx { get; set; }
        public string? cfg_path { get; set; }
        public string? cfg_raw { get; set; }
        public string? cfg_receiver { get; set; }
        public string? cfg_windowmode { get; set; }
        public string? d11_map_size { get; set; }

        [JsonProperty("df-stats")]
        public string? dfstats { get; set; }

        [JsonProperty("df-stats-since")]
        public string? dfstatssince { get; set; }
        public string? dns_queries { get; set; }
        public string? extended_ui { get; set; }
        public string? feed_alias { get; set; }
        public string? feed_configured_mode { get; set; }
        public string? feed_current_mode { get; set; }
        public string? feed_current_server { get; set; }
        public string? feed_last_ac_sent_num { get; set; }
        public string? feed_last_ac_sent_time { get; set; }
        public string? feed_last_attempt_time { get; set; }
        public string? feed_last_config_info { get; set; }
        public string? feed_last_config_result { get; set; }
        public string? feed_last_connected_time { get; set; }
        public string? feed_last_disconnected_time { get; set; }
        public string? feed_legacy_id { get; set; }
        public string? feed_num_ac_adsb_tracked { get; set; }
        public string? feed_num_ac_non_adsb_tracked { get; set; }
        public string? feed_num_ac_tracked { get; set; }
        public string? feed_status { get; set; }
        public string? feed_status_code { get; set; }
        public string? feed_status_message { get; set; }
        public string? feed_type { get; set; }
        public string? fr24key { get; set; }
        public string? gps_tods { get; set; }
        public string? last_json_utc { get; set; }
        public string? last_rx_connect_status { get; set; }
        public string? last_rx_connect_time { get; set; }
        public string? last_rx_connect_time_s { get; set; }
        public string? last_rx_global_timeout { get; set; }
        public string? local_ips { get; set; }
        public string? local_tods { get; set; }
        public string? msg_ring_full { get; set; }
        public string? msg_ring_length { get; set; }
        public string? ntp_queries { get; set; }
        public string? num_global_timeouts { get; set; }
        public string? num_messages { get; set; }
        public string? num_resyncs { get; set; }

        [JsonProperty("offline-mode")]
        public string? offlinemode { get; set; }
        public string? open_fds { get; set; }
        public string? rx_connected { get; set; }
        public string? shutdown { get; set; }
        public string? time_update_utc { get; set; }
        public string? time_update_utc_s { get; set; }
        public string? timestamp_source { get; set; }
        public string? timing_is_valid { get; set; }
        public string? timing_last_drift { get; set; }
        public string? timing_last_offset { get; set; }
        public string? timing_last_result { get; set; }
        public string? timing_source { get; set; }
        public string? timing_time_last_attempt { get; set; }
        public string? timing_time_last_success { get; set; }
        public string? timing_time_since_last_success { get; set; }
        public string? wifi_allowed { get; set; }
    }


}
