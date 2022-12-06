using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.Core.Search;
using Rsdo.Concordancer.ServiceModel.Requests.Corpuses;
using Rsdo.Concordancer.ServiceModel.Shared;
using Rsdo.Concordancer.Services.Framework.DatabaseManager;
using Rsdo.Concordancer.Services.Framework.DbContext;

namespace Rsdo.Concordancer.Services.RequestHandlers.Corpuses;

public class DeleteCorpusStoreHandler : IRequestHandler<DeleteCorpusStore, ExecutionResult>
{
    private readonly IDatabaseManager databaseManager;
    private readonly MasterDbContext dbContext;
    private readonly ISearchEngine searchEngine;

    public DeleteCorpusStoreHandler(IDatabaseManager databaseManager, MasterDbContext dbContext, ISearchEngine searchEngine)
    {
        this.databaseManager = databaseManager;
        this.dbContext = dbContext;
        this.searchEngine = searchEngine;
    }

    public async Task<ExecutionResult> Handle(DeleteCorpusStore request, CancellationToken cancellationToken)
    {
        // Get corpus
        var corpus = await dbContext.Corpus.SingleAsync(x => x.Id == request.CorpusId, cancellationToken);

        // Create database for corpus
        var deleteDbTask = databaseManager.DeleteCorpusDatabase();

        // Create elastic indexes
        var deleteSchemaTask = searchEngine.DeleteSchema();

        // Wait to finish
        await Task.WhenAll(deleteDbTask, deleteSchemaTask);

        // Remove corpus
        dbContext.Corpus.Remove(corpus);
        await dbContext.SaveChangesAsync(cancellationToken);

        // Return result
        return new ExecutionResult();
    }
}