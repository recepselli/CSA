using Newtonsoft.Json;

namespace Csa.Entities.Period
{
    public class Dictionary
    {
        [JsonProperty("airportList")]
        public AirportList AirportList { get; set; }

        [JsonProperty("carrierList")]
        public CarrierList CarrierList { get; set; }

        [JsonProperty("cityList")]
        public CityList CityList { get; set; }

        [JsonProperty("continentList")]
        public ContinentList ContinentList { get; set; }

        [JsonProperty("countryList")]
        public CountryList CountryList { get; set; }
    }
}