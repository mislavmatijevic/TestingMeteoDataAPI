using Newtonsoft.Json;
using System.Collections.Generic;

namespace JrcPristup.Classes.JSON
{
    public class Outputs : JsonClass
    {
        [JsonProperty("months_selected")]
        public List<MonthsSelected> MonthsSelected { get; set; }

        [JsonProperty("tmy_hourly")]
        public List<TmyHourly> TmyHourly { get; set; }
    }

    public class MonthsSelected : JsonClass
    {
        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class TmyHourly : JsonClass
    {
        [JsonProperty("time(UTC)")]
        public string TimeUTC { get; set; }

        [JsonProperty("T2m")]
        public double T2m { get; set; }

        [JsonProperty("RH")]
        public double RH { get; set; }

        [JsonProperty("G(h)")]
        public double GH { get; set; }

        [JsonProperty("Gb(n)")]
        public double GbN { get; set; }

        [JsonProperty("Gd(h)")]
        public double GdH { get; set; }

        [JsonProperty("IR(h)")]
        public double IRH { get; set; }

        [JsonProperty("WS10m")]
        public double WS10m { get; set; }

        [JsonProperty("WD10m")]
        public double WD10m { get; set; }

        [JsonProperty("SP")]
        public double SP { get; set; }
    }
}
