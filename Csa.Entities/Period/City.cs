using Newtonsoft.Json;

namespace Csa.Entities.Period
{
    public class City
    {
        [JsonProperty("cityId")]
        public string CityId { get; set; }

        [JsonProperty("countryRef")]
        public string CountryRef { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}