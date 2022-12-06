using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rsdo.Concordancer.Core.Exceptions;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.ServiceModel.Requests.TermLists;
using Rsdo.Concordancer.ServiceModel.Shared;
using Rsdo.Concordancer.ServiceModel.Types;
using Rsdo.Concordancer.Services.Framework.DbContext;

namespace Rsdo.Concordancer.Services.RequestHandlers.TermLists;

public class DeleteTermListHandler : IRequestHandler<DeleteTermList, ExecutionResult>
{
    private readonly CorpusDbContext dbContext;
    private readonly IServiceBus serviceBus;

    public DeleteTermListHandler(CorpusDbContext dbContext, IServiceBus serviceBus)
    {
        this.dbContext = dbContext;
        this.serviceBus = serviceBus;
    }

    public async Task<ExecutionResult> Handle(DeleteTermList request, CancellationToken cancellationToken)
    {
        // Get term list
        var termList = await dbContext.TermList.SingleOrDefaultAsync(t => t.Id == request.TermListId, cancellationToken);
        if (termList == null)
        {
            throw new XNotFoundException(Errors.NotFound.EntityNotFound(EntityType.TermList, request.TermListId));
        }

        // Mark term list as deleted
        termList.Status = ImportStatus.Deleted;
        await dbContext.SaveChangesAsync(cancellationToken);

        // Send job to delete term list from index
        await serviceBus.Send(
            new DeleteTermListFromIndex()
            {
                CorpusId = request.CorpusId,
                TermListId = termList.Id,
            });

        return new ExecutionResult();
    }
}