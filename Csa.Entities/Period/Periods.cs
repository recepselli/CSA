using Newtonsoft.Json;

namespace Csa.Entities.Period
{
    public class Periods
    {
        [JsonProperty("airListOperationPeriod")]
        public AirListOperationPeriod AirListOperationPeriod { get; set; }
    }
}