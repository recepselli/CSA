using System.Threading.Tasks;
using Csa.Entities.Period;
using Csa.Entities.Price;

namespace Csa.Repositories
{
    public interface ICalendarPricesRepository
    {
        Task<TicketPrice> GetPrices(string departureAirport, string arrivalAirport);

        Task<Periods> GetPeriod(string departureAirport, string arrivalAirport);
    }
}