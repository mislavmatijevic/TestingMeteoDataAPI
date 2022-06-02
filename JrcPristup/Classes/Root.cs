using Newtonsoft.Json;

namespace Jrc.Classes
{
    public class Root
    {
        [JsonProperty("inputs")]
        public Inputs Inputs { get; set; }

        [JsonProperty("outputs")]
        public Outputs Outputs { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}
