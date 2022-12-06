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

public class DeleteTextHandler : IRequestHandler<DeleteText, ExecutionResult>
{
    private readonly CorpusDbContext dbContext;
    private readonly IServiceBus serviceBus;

    public DeleteTextHandler(CorpusDbContext dbContext, IServiceBus serviceBus)
    {
        this.dbContext = dbContext;
        this.serviceBus = serviceBus;
    }

    public async Task<ExecutionResult> Handle(DeleteText request, CancellationToken cancellationToken)
    {
        // Get text
        var text = await dbContext.Text.SingleOrDefaultAsync(t => t.Id == request.TextId, cancellationToken);
        if (text == null)
        {
            throw new XNotFoundException(Errors.NotFound.EntityNotFound(EntityType.Text, request.TextId));
        }

        // Mark text as deleted
        text.Status = ImportStatus.Deleted;
        await dbContext.SaveChangesAsync(cancellationToken);

        // Send job to delete text from index
        await serviceBus.Send(
            new DeleteTextFromIndex()
            {
                CorpusId = request.CorpusId,
                TextId = text.Id,
            });

        return new ExecutionResult();
    }
}