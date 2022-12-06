using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.ServiceModel.Requests.Corpuses;
using Rsdo.Concordancer.ServiceModel.Types;
using Rsdo.Concordancer.Services.Framework.DbContext;

namespace Rsdo.Concordancer.Services.RequestHandlers.Corpuses;

public class GetCorpusStatisticsHandler : IRequestHandler<GetCorpusStatistics, GetCorpusStatisticsResponse>
{
    private readonly CorpusDbContext dbContext;

    public GetCorpusStatisticsHandler(CorpusDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<GetCorpusStatisticsResponse> Handle(GetCorpusStatistics request, CancellationToken cancellationToken)
    {
        var texts = await dbContext.Text.CountAsync(cancellationToken);
        var sentences = await dbContext.Sentence.CountAsync(cancellationToken);
        var words = await dbContext.Token.CountAsync(t => t.Type == TokenType.Word, cancellationToken);

        return new GetCorpusStatisticsResponse()
        {
            Texts = texts,
            Sentences = sentences,
            Words = words,
        };
    }
}