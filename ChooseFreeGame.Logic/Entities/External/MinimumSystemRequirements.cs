using Newtonsoft.Json;

namespace ChooseFreeGame.Logic.Entities.External
{
    public class MinimumSystemRequirements
    {
        [JsonProperty("os")]
        public string OS { get; set; }

        [JsonProperty("processor")]
        public string Processor { get; set; }

        [JsonProperty("memory")]
        public string Memory { get; set; }

        [JsonProperty("graphics")]
        public string Graphics { get; set; }

        [JsonProperty("storage")]
        public string Storage { get; set; }
    }
}