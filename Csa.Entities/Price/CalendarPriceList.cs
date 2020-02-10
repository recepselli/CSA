using System.Collections.Generic;
using Newtonsoft.Json;

namespace Csa.Entities.Price
{
    public class CalendarPriceList
    {
        [JsonProperty("sid")]
        public string Sid { get; set; }

        [JsonProperty("sectorId")]
        public long SectorId { get; set; }

        [JsonProperty("depIata")]
        public string DepIata { get; set; }

        [JsonProperty("arrIata")]
        public string ArrIata { get; set; }

        [JsonProperty("month")]
        public string Month { get; set; }

        [JsonProperty("saleLocation")]
        public string SaleLocation { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("dayList")]
        public IList<DayList> DayList { get; set; }
    }
}