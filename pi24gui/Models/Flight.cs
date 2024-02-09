using Newtonsoft.Json;

namespace pi24gui.Models
{
    public class Flight
    {
        //public string ModeS { get; set; }
        //public string Callsign { get; set; }
        //public string Latitude { get; set; }
        //public string Longitude { get; set; }
        //public string Altitude { get; set; } // feet
        //public string Squawk { get; set; }

        [JsonProperty("0")]
        public string ModeS { get; set; }

        [JsonProperty("1")]
        public string Latitude { get; set; }

        [JsonProperty("2")]
        public string Longitude { get; set; }

        [JsonProperty("4")]
        public string Altitude { get; set; }

        [JsonProperty("6")]
        public string Squawk { get; set; }

        [JsonProperty("16")]
        public string Callsign { get; set; }
    }
}
