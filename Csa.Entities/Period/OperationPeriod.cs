using Newtonsoft.Json;

namespace Csa.Entities
{
    public class OperationPeriod
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("weekDays")] 
        public long WeekDays { get; set; }
    }
}