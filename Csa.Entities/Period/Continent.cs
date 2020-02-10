using Newtonsoft.Json;

namespace Csa.Entities.Period
{
    public class Continent
    {
        [JsonProperty("continentId")]
        public string ContinentId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}