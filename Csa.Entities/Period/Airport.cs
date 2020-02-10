using Newtonsoft.Json;

namespace Csa.Entities.Period
{
    public class Airport
    {
        [JsonProperty("airportId")]
        public string AirportId { get; set; }

        [JsonProperty("cityRef")]
        public string CityRef { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}