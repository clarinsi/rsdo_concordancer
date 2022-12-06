using System.Threading;
using System.Threading.Tasks;
using Rsdo.Concordancer.Core.Entities;
using Rsdo.Concordancer.Core.Extensions;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.ServiceModel.Requests.TermLists;
using Rsdo.Concordancer.ServiceModel.Shared;
using Rsdo.Concordancer.ServiceModel.Types;
using Rsdo.Concordancer.Services.Framework.DbContext;

namespace Rsdo.Concordancer.Services.RequestHandlers.TermLists;

public class CreateTermListHandler : IRequestHandler<CreateTermList, ExecutionResult>
{
    private readonly CorpusDbContext dbContext;
    private readonly IServiceBus serviceBus;

    public CreateTermListHandler(CorpusDbContext dbContext, IServiceBus serviceBus)
    {
        this.dbContext = dbContext;
        this.serviceBus = serviceBus;
    }

    public async Task<ExecutionResult> Handle(CreateTermList request, CancellationToken cancellationToken)
    {
        // Create new term list
        var termList = new TermList()
        {
            SourceFile = request.SourceFile,
            Status = ImportStatus.Waiting,
        }.ApplyCreateValues();

        await dbContext.TermList.AddAsync(termList, cancellationToken);
        await dbContext.SaveChangesAsync(cancellationToken);

        // Send job to import term list
        await serviceBus.Send(
            new ImportTermList()
            {
                CorpusId = request.CorpusId,
                TermListId = termList.Id,
            });

        // Return result
        return new ExecutionResult().WithEntityInfo(EntityType.TermList, termList.Id);
    }
}