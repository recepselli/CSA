namespace Csa.Repositories
{
    public class CachingPolicyConfiguration
    {
        public CachePolicyEntity PriceCachePolicyEntity { get; set; }
        public CachePolicyEntity PeriodCachePolicyEntity { get; set; }
    }

    public class CachePolicyEntity
    {
        public string CacheKey { get; set; }
        public int ExpirationTimeMs { get; set; }
    }
}
