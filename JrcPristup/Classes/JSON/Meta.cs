using Newtonsoft.Json;

namespace JRC.Classes
{
    public class Meta : JsonClass
    {
        [JsonProperty("inputs")]
        public MetaInputs Inputs { get; set; }

        [JsonProperty("outputs")]
        public MetaOutputs Outputs { get; set; }
    }

    public class MetaElevation : JsonClass
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class MetaGbN : JsonClass
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class MetaGdH : JsonClass
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class MetaGH : JsonClass
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class MetaHorizonDb : JsonClass
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class MetaInputs : JsonClass
    {
        [JsonProperty("location")]
        public MetaLocation Location { get; set; }

        [JsonProperty("meteo_data")]
        public MetaMeteoData MeteoData { get; set; }
    }

    public class MetaIRH : JsonClass
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class MetaLatitude : JsonClass
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class MetaLocation : JsonClass
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("variables")]
        public MetaVariables Variables { get; set; }
    }

    public class MetaLongitude : JsonClass
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class MetaMeteoData : JsonClass
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("variables")]
        public MetaVariables Variables { get; set; }
    }

    public class MetaMeteoDb : JsonClass
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class MetaMonthsSelected : JsonClass
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class MetaOutputs : JsonClass
    {
        [JsonProperty("months_selected")]
        public MetaMonthsSelected MonthsSelected { get; set; }

        [JsonProperty("tmy_hourly")]
        public MetaTmyHourly TmyHourly { get; set; }
    }

    public class MetaRadiationDb : JsonClass
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class MetaRH : JsonClass
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class MetaSP : JsonClass
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class MetaT2m : JsonClass
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class MetaTmyHourly : JsonClass
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("variables")]
        public MetaVariables Variables { get; set; }
    }

    public class MetaUseHorizon : JsonClass
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class MetaVariables : JsonClass
    {
        [JsonProperty("latitude")]
        public MetaLatitude Latitude { get; set; }

        [JsonProperty("longitude")]
        public MetaLongitude Longitude { get; set; }

        [JsonProperty("elevation")]
        public MetaElevation Elevation { get; set; }

        [JsonProperty("radiation_db")]
        public MetaRadiationDb RadiationDb { get; set; }

        [JsonProperty("meteo_db")]
        public MetaMeteoDb MeteoDb { get; set; }

        [JsonProperty("year_min")]
        public MetaYearMin YearMin { get; set; }

        [JsonProperty("year_max")]
        public MetaYearMax YearMax { get; set; }

        [JsonProperty("use_horizon")]
        public MetaUseHorizon UseHorizon { get; set; }

        [JsonProperty("horizon_db")]
        public MetaHorizonDb HorizonDb { get; set; }

        [JsonProperty("T2m")]
        public MetaT2m T2m { get; set; }

        [JsonProperty("RH")]
        public MetaRH RH { get; set; }

        [JsonProperty("G(h)")]
        public MetaGH GH { get; set; }

        [JsonProperty("Gb(n)")]
        public MetaGbN GbN { get; set; }

        [JsonProperty("Gd(h)")]
        public MetaGdH GdH { get; set; }

        [JsonProperty("IR(h)")]
        public MetaIRH IRH { get; set; }

        [JsonProperty("WS10m")]
        public MetaWS10m WS10m { get; set; }

        [JsonProperty("WD10m")]
        public MetaWD10m WD10m { get; set; }

        [JsonProperty("SP")]
        public MetaSP SP { get; set; }
    }

    public class MetaWD10m : JsonClass
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class MetaWS10m : JsonClass
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class MetaYearMax : JsonClass
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class MetaYearMin : JsonClass
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
