using Newtonsoft.Json;

namespace Csa.Entities.Period
{
    public class CarrierList
    {
        [JsonProperty("carrier")]
        public Carrier Carrier { get; set; }
    }
}