using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rsdo.Concordancer.ServiceModel.Requests.TermLists;
using Rsdo.Concordancer.Services.Framework.DbContext;

namespace Rsdo.Concordancer.Services.RequestHandlers.TermLists;

public abstract class BaseSearchTermListHandler
{
    private readonly CorpusDbContext dbContext;

    protected BaseSearchTermListHandler(CorpusDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    protected async Task<List<SearchTermListResponseItem>> GetItems(List<string> entityIds)
    {
        var ids = entityIds.Select(Guid.Parse).ToList();
        var terms = await dbContext.Term.Where(t => ids.Contains(t.Id)).ToListAsync();

        return (from entityId in entityIds
            let termId = Guid.Parse(entityId)
            join term in terms on termId equals term.Id
            select new SearchTermListResponseItem()
            {
                Form = term.Form,
                Frequency = term.Frequency,
                Lemma = term.Lemma,
                Weight = term.Weight,
            }).ToList();
    }
}