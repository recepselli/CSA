using System.Collections.Generic;
using Newtonsoft.Json;

namespace Csa.Entities.Period
{
    public class CityList
    {
        [JsonProperty("city")]
        public IList<City> City { get; set; }
    }
}