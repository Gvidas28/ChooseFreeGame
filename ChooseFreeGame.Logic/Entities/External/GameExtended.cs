using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChooseFreeGame.Logic.Entities.External
{
    public class GameExtended
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("short_description")]
        public string ShortDescription { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("game_url")]
        public string GameURL { get; set; }

        [JsonProperty("genre")]
        public string Genre { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("publisher")]
        public string Publisher { get; set; }

        [JsonProperty("developer")]
        public string Developer { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }

        [JsonProperty("freetogame_profile_url")]
        public string FreeToGameProfileURL { get; set; }

        [JsonProperty("minimum_system_requirements")]
        public MinimumSystemRequirements MinimumSystemRequirements { get; set; }

        [JsonProperty("screenshots")]
        public List<Screenshot> Screenshots { get; set; }
    }
}