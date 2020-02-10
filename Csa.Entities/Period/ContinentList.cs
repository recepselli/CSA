using Newtonsoft.Json;

namespace Csa.Entities.Period
{
    public class ContinentList
    {
        [JsonProperty("continent")]
        public Continent Continent { get; set; }
    }
}