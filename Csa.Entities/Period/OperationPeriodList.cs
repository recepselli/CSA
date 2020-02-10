using System.Collections.Generic;
using Newtonsoft.Json;

namespace Csa.Entities
{
    public class OperationPeriodList
    {
        [JsonProperty("operationPeriod")]
        public IList<OperationPeriod> OperationPeriod { get; set; }
    }
}