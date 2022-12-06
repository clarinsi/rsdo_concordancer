using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rsdo.Concordancer.Core.Search.Aggregations;
using Rsdo.Concordancer.ServiceModel.Types;
using Rsdo.Concordancer.Services.Framework.DbContext;

namespace Rsdo.Concordancer.Services.Search.Aggregations;

public class TextAggregationProvider : BaseAggregationProvider
{
    private readonly CorpusDbContext dbContext;

    public TextAggregationProvider(IAggregatorFactory aggregatorFactory, CorpusDbContext dbContext)
        : base(aggregatorFactory)
    {
        this.dbContext = dbContext;
    }

    public override AggregationType Type => AggregationType.Text;

    protected override async Task<List<AggregationItem>> GetItems(IDictionary<string, long> items)
    {
        var ids = items.Select(i => Guid.Parse(i.Key)).ToList();
        var texts = await dbContext.Text.Where(t => ids.Contains(t.Id)).ToListAsync();

        return (from item in items
            let id = Guid.Parse(item.Key)
            join text in texts on id equals text.Id
            orderby item.Value descending, text.SourceFile
            select new AggregationItem
            {
                Count = item.Value,
                Key = text.Id,
                Title = text.DisplayFileName,
            }).ToList();
    }
}