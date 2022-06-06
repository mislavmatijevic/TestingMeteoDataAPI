using Newtonsoft.Json;

namespace JRC.Classes
{
    public class JrcResponse
    {
        [JsonProperty("inputs")]
        public Inputs Inputs { get; set; }

        [JsonProperty("outputs")]
        public Outputs Outputs { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}
