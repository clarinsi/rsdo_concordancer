using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rsdo.Concordancer.Core.Exceptions;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.ServiceModel.Requests.Texts;
using Rsdo.Concordancer.ServiceModel.Types;
using Rsdo.Concordancer.Services.Framework.DbContext;

namespace Rsdo.Concordancer.Services.RequestHandlers.Texts;

public class GetTextHandler : IRequestHandler<GetText, GetTextResponse>
{
    private readonly CorpusDbContext dbContext;

    public GetTextHandler(CorpusDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<GetTextResponse> Handle(GetText request, CancellationToken cancellationToken)
    {
        // Get text
        var text = await dbContext.Text.SingleOrDefaultAsync(t => t.Id == request.TextId, cancellationToken);
        if (text == null)
        {
            throw new XNotFoundException(Errors.NotFound.EntityNotFound(EntityType.Text, request.TextId));
        }

        return new GetTextResponse()
        {
            Author = text.Author,
            Id = text.Id,
            SourceFile = text.SourceFile,
            Status = text.Status,
            Title = text.Title,
            Year = text.Year,
        };
    }
}