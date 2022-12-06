using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rsdo.Concordancer.Core.Exceptions;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.ServiceModel.Requests.Texts;
using Rsdo.Concordancer.ServiceModel.Shared;
using Rsdo.Concordancer.ServiceModel.Types;
using Rsdo.Concordancer.Services.Framework.DbContext;

namespace Rsdo.Concordancer.Services.RequestHandlers.Texts;

public class DeleteTextFromStoreHandler : IRequestHandler<DeleteTextFromStore, ExecutionResult>
{
    private readonly CorpusDbContext dbContext;

    public DeleteTextFromStoreHandler(CorpusDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<ExecutionResult> Handle(DeleteTextFromStore request, CancellationToken cancellationToken)
    {
        // Get text
        var text = await dbContext.Text.SingleOrDefaultAsync(t => t.Id == request.TextId, cancellationToken);
        if (text == null)
        {
            throw new XNotFoundException(Errors.NotFound.EntityNotFound(EntityType.Text, request.TextId));
        }

        // Delete text and all depending objects
        dbContext.Text.Remove(text);

        // Save changes to database
        await dbContext.SaveChangesAsync(cancellationToken);

        return new ExecutionResult();
    }
}