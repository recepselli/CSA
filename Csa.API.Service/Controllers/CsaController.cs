using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Csa.Repositories;
using Csa.Entities.Price;
using Csa.Entities.Period;

namespace CSA.Controllers
{
    [Route("api/csa")]
    [ApiController]
    public class CsaController : ControllerBase
    {
        private readonly ICalendarPricesRepository calendarPricesRepository;

        public CsaController(ICalendarPricesRepository _calendarPricesRepository)
        {
            calendarPricesRepository = _calendarPricesRepository;
        }

        [HttpGet("Prices")]
        [ProducesResponseType(typeof(TicketPrice), 200)]
        public async Task<TicketPrice> GetPrices(string departureAirport, string arrivalAirport)
        {
            return await calendarPricesRepository.GetPrices(departureAirport, arrivalAirport);
        }

        [HttpGet("Period")]
        [ProducesResponseType(typeof(Periods), 200)]
        public async Task<Periods> GetPeriod(string departureAirport, string arrivalAirport)
        {
            return await calendarPricesRepository.GetPeriod(departureAirport, arrivalAirport);
        }
    }
}