using System.Collections.Generic;
using Newtonsoft.Json;

namespace Csa.Entities.Period
{
    public class AirportList
    {
        [JsonProperty("airport")]
        public IList<Airport> airport { get; set; }
    }
}