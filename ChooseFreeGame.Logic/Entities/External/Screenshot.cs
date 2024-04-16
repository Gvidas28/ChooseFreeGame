using Newtonsoft.Json;

namespace ChooseFreeGame.Logic.Entities.External
{
    public class Screenshot
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }
}