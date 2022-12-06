using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rsdo.Concordancer.Core.Exceptions;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.Core.Model;
using Rsdo.Concordancer.Core.Search;
using Rsdo.Concordancer.ServiceModel.Requests.Texts;
using Rsdo.Concordancer.ServiceModel.Shared;
using Rsdo.Concordancer.ServiceModel.Types;
using Rsdo.Concordancer.Services.Framework.DbContext;

namespace Rsdo.Concordancer.Services.RequestHandlers.Texts;

public class DeleteTextFromIndexHandler : IRequestHandler<DeleteTextFromIndex, ExecutionResult>
{
    private readonly CorpusDbContext dbContext;
    private readonly ISearchEngine searchEngine;
    private readonly IServiceBus serviceBus;

    public DeleteTextFromIndexHandler(CorpusDbContext dbContext, ISearchEngine searchEngine, IServiceBus serviceBus)
    {
        this.dbContext = dbContext;
        this.searchEngine = searchEngine;
        this.serviceBus = serviceBus;
    }

    public async Task<ExecutionResult> Handle(DeleteTextFromIndex request, CancellationToken cancellationToken)
    {
        // Get text
        var text = await dbContext.Text.SingleOrDefaultAsync(t => t.Id == request.TextId, cancellationToken);
        if (text == null)
        {
            throw new XNotFoundException(Errors.NotFound.EntityNotFound(EntityType.Text, request.TextId));
        }

        // Loop through tokens in batches and delete concordances from index
        int skip = 0;
        List<Guid> entityIds;
        while ((entityIds = await dbContext.Token.Include(t => t.Sentence)
                   .ThenInclude(t => t.Paragraph)
                   .Where(t => t.Sentence.Paragraph.TextAutoId == text.AutoId && t.Type != TokenType.Character)
                   .OrderBy(t => t.AutoId)
                   .Skip(skip)
                   .Take(1000)
                   .Select(t => t.Id)
                   .ToListAsync(cancellationToken)).Any())
        {
            await searchEngine.Delete<Concordance>(entityIds);
            skip += entityIds.Count;
        }

        // Commit changes in index
        await searchEngine.Commit();

        // Send job to delete text from store
        await serviceBus.Send(
            new DeleteTextFromStore()
            {
                CorpusId = request.CorpusId,
                TextId = text.Id,
            });

        return new ExecutionResult();
    }
}