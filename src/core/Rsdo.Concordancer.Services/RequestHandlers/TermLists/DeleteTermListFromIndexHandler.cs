using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rsdo.Concordancer.Core.Entities;
using Rsdo.Concordancer.Core.Exceptions;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.Core.Search;
using Rsdo.Concordancer.ServiceModel.Requests.TermLists;
using Rsdo.Concordancer.ServiceModel.Shared;
using Rsdo.Concordancer.ServiceModel.Types;
using Rsdo.Concordancer.Services.Framework.DbContext;

namespace Rsdo.Concordancer.Services.RequestHandlers.TermLists;

public class DeleteTermListFromIndexHandler : IRequestHandler<DeleteTermListFromIndex, ExecutionResult>
{
    private readonly CorpusDbContext dbContext;
    private readonly ISearchEngine searchEngine;
    private readonly IServiceBus serviceBus;

    public DeleteTermListFromIndexHandler(CorpusDbContext dbContext, ISearchEngine searchEngine, IServiceBus serviceBus)
    {
        this.dbContext = dbContext;
        this.searchEngine = searchEngine;
        this.serviceBus = serviceBus;
    }

    public async Task<ExecutionResult> Handle(DeleteTermListFromIndex request, CancellationToken cancellationToken)
    {
        // Get term list
        var termList = await dbContext.TermList.SingleOrDefaultAsync(t => t.Id == request.TermListId, cancellationToken);
        if (termList == null)
        {
            throw new XNotFoundException(Errors.NotFound.EntityNotFound(EntityType.TermList, request.TermListId));
        }

        // Loop through terms in batches and delete terms from index
        int skip = 0;
        List<Guid> entityIds;
        while ((entityIds = await dbContext.Term.Where(t => t.TermListAutoId == termList.AutoId)
                   .OrderBy(t => t.AutoId)
                   .Skip(skip)
                   .Take(1000)
                   .Select(t => t.Id)
                   .ToListAsync(cancellationToken)).Any())
        {
            await searchEngine.Delete<Term>(entityIds);
            skip += entityIds.Count;
        }

        // Commit changes in index
        await searchEngine.Commit();

        // Send job to delete term list from store
        await serviceBus.Send(
            new DeleteTermListFromStore()
            {
                CorpusId = request.CorpusId,
                TermListId = termList.Id,
            });

        return new ExecutionResult();
    }
}