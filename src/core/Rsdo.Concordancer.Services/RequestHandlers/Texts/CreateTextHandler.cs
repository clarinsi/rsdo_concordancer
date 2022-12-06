using System.Threading;
using System.Threading.Tasks;
using Rsdo.Concordancer.Core.Entities;
using Rsdo.Concordancer.Core.Extensions;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.ServiceModel.Requests.Texts;
using Rsdo.Concordancer.ServiceModel.Shared;
using Rsdo.Concordancer.ServiceModel.Types;
using Rsdo.Concordancer.Services.Framework.DbContext;

namespace Rsdo.Concordancer.Services.RequestHandlers.Texts;

public class CreateTextHandler : IRequestHandler<CreateText, ExecutionResult>
{
    private readonly CorpusDbContext dbContext;
    private readonly IServiceBus serviceBus;

    public CreateTextHandler(CorpusDbContext dbContext, IServiceBus serviceBus)
    {
        this.dbContext = dbContext;
        this.serviceBus = serviceBus;
    }

    public async Task<ExecutionResult> Handle(CreateText request, CancellationToken cancellationToken)
    {
        // Create new text
        var text = new Text()
        {
            Author = request.Author,
            SourceFile = request.SourceFile,
            Status = ImportStatus.Waiting,
            Title = request.Title,
            Year = request.Year,
        }.ApplyCreateValues();

        await dbContext.Text.AddAsync(text, cancellationToken);
        await dbContext.SaveChangesAsync(cancellationToken);

        // Send job to import text
        await serviceBus.Send(
            new ImportText()
            {
                CorpusId = request.CorpusId,
                TextId = text.Id,
            });

        // Return result
        return new ExecutionResult().WithEntityInfo(EntityType.Text, text.Id);
    }
}