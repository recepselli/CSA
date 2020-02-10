using Newtonsoft.Json;

namespace Csa.Entities.Period
{
    public class Destination
    {
        [JsonProperty("destinationId")]
        public string DestinationId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}