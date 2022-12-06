using System;
using System.Threading;
using System.Threading.Tasks;
using Rsdo.Concordancer.Core.Entities;
using Rsdo.Concordancer.Core.Extensions;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.ServiceModel.Requests.Corpuses;
using Rsdo.Concordancer.ServiceModel.Shared;
using Rsdo.Concordancer.ServiceModel.Types;
using Rsdo.Concordancer.Services.Framework.DbContext;

namespace Rsdo.Concordancer.Services.RequestHandlers.Corpuses;

public class CreateCorpusHandler : IRequestHandler<CreateCorpus, ExecutionResult>
{
    private readonly MasterDbContext dbContext;
    private readonly IServiceBus serviceBus;

    public CreateCorpusHandler(MasterDbContext dbContext, IServiceBus serviceBus)
    {
        this.dbContext = dbContext;
        this.serviceBus = serviceBus;
    }

    public async Task<ExecutionResult> Handle(CreateCorpus request, CancellationToken cancellationToken)
    {
        // Create new corpus and mark its status as Creating
        var corpus = new Corpus
        {
            Description = request.Description,
            Title = request.Title,
            Status = CorpusStatus.Creating,
        }.ApplyCreateValues();

        await dbContext.Corpus.AddAsync(corpus, cancellationToken);
        await dbContext.SaveChangesAsync(cancellationToken);

        // Send job to create corpus store
        await serviceBus.Send(
            new CreateCorpusStore
            {
                CorpusId = corpus.Id,
            });

        // Return result
        return new ExecutionResult().WithEntityInfo(EntityType.Corpus, corpus.Id);
    }
}