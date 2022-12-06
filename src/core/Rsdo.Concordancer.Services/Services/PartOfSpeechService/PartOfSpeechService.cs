using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Rsdo.Concordancer.Core.Constants;
using Rsdo.Concordancer.Core.Entities;
using Rsdo.Concordancer.Core.Exceptions;
using Rsdo.Concordancer.ServiceModel.Types;
using Rsdo.Concordancer.Services.Framework.DbContext;

namespace Rsdo.Concordancer.Services.Services.PartOfSpeechService;

public class PartOfSpeechService : IPartOfSpeechService
{
    private readonly MasterDbContext dbContext;
    private readonly IMemoryCache memoryCache;

    public PartOfSpeechService(MasterDbContext dbContext, IMemoryCache memoryCache)
    {
        this.dbContext = dbContext;
        this.memoryCache = memoryCache;
    }

    public async Task<string> GetMsdDescriptionByCode(string code)
    {
        if (string.IsNullOrEmpty(code))
        {
            return null;
        }

        var cacheKey = Cache.CacheKeys.Msd.ByCode(code);
        var msd = memoryCache.Get<Msd>(cacheKey);
        if (msd == null)
        {
            msd = await dbContext.Msd.SingleOrDefaultAsync(m => m.Code == code);
            if (msd == null)
            {
                throw new XNotFoundException(Errors.NotFound.EntityNotFound(EntityType.Msd, nameof(Msd.Code), code));
            }

            memoryCache.Set(cacheKey, msd, Cache.Duration.Long);
        }

        return msd.Description;
    }
}