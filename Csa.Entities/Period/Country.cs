using Newtonsoft.Json;

namespace Csa.Entities.Period
{
    public class Country
    {
        [JsonProperty("continentRef")]
        public string ContinentRef { get; set; }

        [JsonProperty("countryId")]
        public string CountryId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}