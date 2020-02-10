using System.Collections.Generic;
using Newtonsoft.Json;

namespace Csa.Entities.Price
{
    public partial class DayList
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("seats")]
        public string Seats { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("flightsCount")]
        public string FlightsCount { get; set; }

        [JsonProperty("rbd", NullValueHandling = NullValueHandling.Ignore)]
        public string Rbd { get; set; }

        [JsonProperty("flights", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Flight> Flights { get; set; }
    }
}