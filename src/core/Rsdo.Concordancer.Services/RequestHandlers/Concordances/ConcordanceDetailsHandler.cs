using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.Core.Search.Queries.Concordances;
using Rsdo.Concordancer.ServiceModel.Requests.Concordances;
using Rsdo.Concordancer.Services.Extensions;
using Rsdo.Concordancer.Services.Framework.DbContext;
using Rsdo.Concordancer.Services.Search.QueryFactories;
using Rsdo.Concordancer.Services.Services.ParagraphService;

namespace Rsdo.Concordancer.Services.RequestHandlers.Concordances;

public class ConcordanceDetailsHandler : IRequestHandler<ConcordanceDetails, ConcordanceDetailsResponse>
{
    private readonly CorpusDbContext dbContext;
    private readonly IQueryFactory<ConcordanceDetails, ConcordancesQuery> queryFactory;
    private readonly IParagraphService paragraphService;

    public ConcordanceDetailsHandler(
        CorpusDbContext dbContext,
        IQueryFactory<ConcordanceDetails, ConcordancesQuery> queryFactory,
        IParagraphService paragraphService)
    {
        this.dbContext = dbContext;
        this.queryFactory = queryFactory;
        this.paragraphService = paragraphService;
    }

    public async Task<ConcordanceDetailsResponse> Handle(ConcordanceDetails request, CancellationToken cancellationToken)
    {
        // Get text
        var text = await dbContext.Paragraph.Include(p => p.Text).Where(p => p.Id == request.ParagraphId).Select(x => x.Text).SingleAsync(cancellationToken);

        // Get tokens in paragraph
        var tokens = await paragraphService.GetTokens(x => x.Sentence.Paragraph.Id == request.ParagraphId);

        // Highlight tokens
        var centerTokenIndex = tokens.FindIndex(t => t.TokenOrder == request.TokenOrder);
        if (centerTokenIndex != -1)
        {
            var query = await queryFactory.GetQuery(request);
            tokens.Highlight(query, centerTokenIndex);
        }

        return new ConcordanceDetailsResponse()
        {
            Author = text.Author,
            Title = text.Title,
            Tokens = tokens,
            Year = text.Year,
            SourceFile = text.DisplayFileName,
        };
    }
}