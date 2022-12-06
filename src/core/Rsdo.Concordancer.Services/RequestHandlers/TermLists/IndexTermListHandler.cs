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

public class IndexTermListHandler : IRequestHandler<IndexTermList, ExecutionResult>
{
    private readonly CorpusDbContext dbContext;
    private readonly ISearchEngine searchEngine;

    public IndexTermListHandler(CorpusDbContext dbContext, ISearchEngine searchEngine)
    {
        this.dbContext = dbContext;
        this.searchEngine = searchEngine;
    }

    public async Task<ExecutionResult> Handle(IndexTermList request, CancellationToken cancellationToken)
    {
        // Get term list
        var termList = await dbContext.TermList.SingleOrDefaultAsync(t => t.Id == request.TermListId, cancellationToken);
        if (termList == null)
        {
            throw new XNotFoundException(Errors.NotFound.EntityNotFound(EntityType.TermList, request.TermListId));
        }

        try
        {
            // Change status to indexing
            await ChangeStatus(termList, ImportStatus.Indexing, cancellationToken);

            // Index term list
            await IndexTermList(termList, cancellationToken);

            // Change status to indexing completed and active
            await ChangeStatus(termList, ImportStatus.IndexingCompleted, cancellationToken);
            await ChangeStatus(termList, ImportStatus.Active, cancellationToken);

            return new ExecutionResult();
        }
        catch (Exception)
        {
            await ChangeStatus(termList, ImportStatus.IndexingFaulted, cancellationToken);
            throw;
        }
    }

    private async Task IndexTermList(TermList termList, CancellationToken cancellationToken)
    {
        // Loop through terms
        List<Term> terms;
        var lastAutoId = 0L;
        while ((terms = await GetNextTerms(termList, lastAutoId, cancellationToken)).Any())
        {
            // Index terms
            await searchEngine.Add(terms);

            lastAutoId = terms.Max(t => t.AutoId);
        }

        // Commit indexed terms
        await searchEngine.Commit();
    }

    private async Task<List<Term>> GetNextTerms(TermList termList, long lastAutoId, CancellationToken cancellationToken)
    {
        return await dbContext.Term.Where(t => t.TermListAutoId == termList.AutoId && t.AutoId > lastAutoId)
            .OrderBy(t => t.AutoId)
            .Take(500)
            .ToListAsync(cancellationToken);
    }

    private async Task ChangeStatus(TermList termList, ImportStatus newStatus, CancellationToken cancellationToken)
    {
        termList.Status = newStatus;
        await dbContext.SaveChangesAsync(cancellationToken);
    }
}