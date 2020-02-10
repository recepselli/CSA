using System.Collections.Generic;
using Newtonsoft.Json;

namespace Csa.Entities.Period
{
    public class CountryList
    {
        [JsonProperty("country")]
        public IList<Country> Country { get; set; }
    }
}