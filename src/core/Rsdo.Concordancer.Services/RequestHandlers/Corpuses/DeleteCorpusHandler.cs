using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.ServiceModel.Requests.Corpuses;
using Rsdo.Concordancer.ServiceModel.Shared;
using Rsdo.Concordancer.ServiceModel.Types;
using Rsdo.Concordancer.Services.Framework.DbContext;

namespace Rsdo.Concordancer.Services.RequestHandlers.Corpuses;

public class DeleteCorpusHandler : IRequestHandler<DeleteCorpus, ExecutionResult>
{
    private readonly MasterDbContext dbContext;
    private readonly IServiceBus serviceBus;

    public DeleteCorpusHandler(MasterDbContext dbContext, IServiceBus serviceBus)
    {
        this.dbContext = dbContext;
        this.serviceBus = serviceBus;
    }

    public async Task<ExecutionResult> Handle(DeleteCorpus request, CancellationToken cancellationToken)
    {
        // Get corpus
        var corpus = await dbContext.Corpus.SingleAsync(x => x.Id == request.CorpusId, cancellationToken);

        // Set status to deleted
        corpus.Status = CorpusStatus.Deleted;
        await dbContext.SaveChangesAsync(cancellationToken);

        // Send job to create corpus store
        await serviceBus.Send(
            new DeleteCorpusStore
            {
                CorpusId = corpus.Id,
            });

        return new ExecutionResult();
    }
}