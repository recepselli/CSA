using Newtonsoft.Json;

namespace Csa.Entities.Period
{
    public class Carrier
    {
        [JsonProperty("carrierId")]
        public string CarrierId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}