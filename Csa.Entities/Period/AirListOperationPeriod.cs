using Newtonsoft.Json;

namespace Csa.Entities.Period
{
    public class AirListOperationPeriod
    {
        [JsonProperty("departureDestination")]
        public Destination DepartureDestination { get; set; }

        [JsonProperty("arrivalDestination")]
        public Destination ArrivalDestination { get; set; }

        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        [JsonProperty("operationPeriodList")]
        public OperationPeriodList OperationPeriodList { get; set; }

        [JsonProperty("dictionary")]
        public Dictionary Dictionary { get; set; }

        [JsonProperty("sid")]
        public string Sid { get; set; }
    }
}