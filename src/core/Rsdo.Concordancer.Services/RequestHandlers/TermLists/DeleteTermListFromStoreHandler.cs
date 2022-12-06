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

public class DeleteTermListFromStoreHandler : IRequestHandler<DeleteTermListFromStore, ExecutionResult>
{
    private readonly CorpusDbContext dbContext;

    public DeleteTermListFromStoreHandler(CorpusDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<ExecutionResult> Handle(DeleteTermListFromStore request, CancellationToken cancellationToken)
    {
        // Get term list
        var termList = await dbContext.TermList.SingleOrDefaultAsync(t => t.Id == request.TermListId, cancellationToken);
        if (termList == null)
        {
            throw new XNotFoundException(Errors.NotFound.EntityNotFound(EntityType.TermList, request.TermListId));
        }

        // Delete term list and all depending objects
        dbContext.TermList.Remove(termList);

        // Save changes to database
        await dbContext.SaveChangesAsync(cancellationToken);

        return new ExecutionResult();
    }
}