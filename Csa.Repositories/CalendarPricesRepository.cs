using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Csa.Entities.Period;
using Csa.Entities.Price;
using Flurl;
using Flurl.Http;

namespace Csa.Repositories
{
    public class CalendarPricesRepository : ICalendarPricesRepository
    {
        private readonly CachingPolicyConfiguration cachingPolicy;
        private readonly ILogger logger;
        private readonly IMemoryCache cache;
        private readonly SemaphoreSlim sem;

        private readonly string baseURL;
        private const string endpointURL = "CalendarPricesCache/{0}/?DEP={1}&ARR={2}";

        public CalendarPricesRepository(
            IConfiguration configuration,
            IOptions<CachingPolicyConfiguration> cachingPolicy,
            ILoggerFactory loggerFactory,
            IMemoryCache _cache)
        {
            baseURL = configuration["CSAApi"];
            this.cachingPolicy = cachingPolicy.Value;
            logger = loggerFactory.CreateLogger(nameof(CalendarPricesRepository));
            cache = _cache;
            sem = new SemaphoreSlim(1, 1);
        }

        public async Task<TicketPrice> GetPrices(string departureAirport, string arrivalAirport)
        {
            string endpoint = string.Concat(GetEndPointURL("GetPrices", departureAirport, arrivalAirport),
                $"&MONTH_SEL={GetCurrenyDate()}&SECTOR_ID=0&LANG=cs&ID_LOCATION=cz");

            if (!cache.TryGetValue(cachingPolicy.PriceCachePolicyEntity.CacheKey, out TicketPrice prices))
            {
                logger.LogInformation("Start getting flight ticket prices from CSA API.");
                using (sem.WaitAsync())
                {
                    prices = await Url.Combine(baseURL, endpoint).GetJsonAsync<TicketPrice>();
                    InsertPricesInCache(prices);
                    sem.Release();
                }
            }
            else
            {
                logger.LogInformation("Retrieving flight ticket prices from cache.");
            }

            return prices;
        }

        public async Task<Periods> GetPeriod(string departureAirport, string arrivalAirport)
        {
            string endpoint = GetEndPointURL("GetOperationPeriod", departureAirport, arrivalAirport);

            if (!cache.TryGetValue(cachingPolicy.PeriodCachePolicyEntity.CacheKey, out Periods periods))
            {
                logger.LogInformation("Start getting operation periods from CSA API.");
                using (sem.WaitAsync())
                {
                    periods = await Url.Combine(baseURL, endpoint).GetJsonAsync<Periods>();
                    InsertPeriodsInCache(periods);
                    sem.Release();
                }
            }
            else
            {
                logger.LogInformation("Retrieving operation periods from cache.");
            }

            return periods;
        }

        private string GetEndPointURL(string endpoint, string departureAirport, string arrivalAirport)
        {
            return string.Format(endpointURL, endpoint, departureAirport, arrivalAirport);
        }

        private string GetCurrenyDate()
        {
            return $"{DateTime.Now.Month.ToString("d2")}/{DateTime.Now.Year}";
        }

        private void InsertPricesInCache(TicketPrice prices)
        {
            var cacheEntryOptions = new MemoryCacheEntryOptions()
                .SetAbsoluteExpiration(TimeSpan.FromMilliseconds(cachingPolicy.PriceCachePolicyEntity.ExpirationTimeMs));
            cache.Set(cachingPolicy.PriceCachePolicyEntity.CacheKey, prices, cacheEntryOptions);
        }

        private void InsertPeriodsInCache(Periods periods)
        {
            var cacheEntryOptions = new MemoryCacheEntryOptions()
                .SetAbsoluteExpiration(TimeSpan.FromMilliseconds(cachingPolicy.PeriodCachePolicyEntity.ExpirationTimeMs));
            cache.Set(cachingPolicy.PeriodCachePolicyEntity.CacheKey, periods, cacheEntryOptions);
        }
    }
}