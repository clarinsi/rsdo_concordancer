using System.Linq;
using Microsoft.Extensions.Caching.Memory;
using Rsdo.Concordancer.Services.Framework.DbContext;

namespace Rsdo.Concordancer.Services.Framework.Cache;

public class PartOfSpeechCacheWarmUp : ICacheWarmUp
{
    private readonly MasterDbContext dbContext;
    private readonly IMemoryCache memoryCache;

    public PartOfSpeechCacheWarmUp(MasterDbContext dbContext, IMemoryCache memoryCache)
    {
        this.dbContext = dbContext;
        this.memoryCache = memoryCache;
    }

    public void WarmUp()
    {
        CacheMsds();
    }

    private void CacheMsds()
    {
        // Get all msds
        var msds = dbContext.Msd.ToList();

        // Cache individual msd by code
        foreach (var msd in msds)
        {
            memoryCache.Set(Core.Constants.Cache.CacheKeys.Msd.ByCode(msd.Code), msd, Core.Constants.Cache.Duration.Long);
        }
    }
}