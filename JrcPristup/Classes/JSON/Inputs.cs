using Newtonsoft.Json;

namespace JRC.Classes
{
    public class Inputs : JsonClass
    {
        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("meteo_data")]
        public MeteoData MeteoData { get; set; }
    }

    public class Location : JsonClass
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("elevation")]
        public double Elevation { get; set; }
    }
    public class MeteoData : JsonClass
    {
        [JsonProperty("radiation_db")]
        public string RadiationDb { get; set; }

        [JsonProperty("meteo_db")]
        public string MeteoDb { get; set; }

        [JsonProperty("year_min")]
        public int YearMin { get; set; }

        [JsonProperty("year_max")]
        public int YearMax { get; set; }

        [JsonProperty("use_horizon")]
        public bool UseHorizon { get; set; }

        [JsonProperty("horizon_db")]
        public string HorizonDb { get; set; }
    }
}
