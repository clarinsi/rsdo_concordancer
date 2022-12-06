using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Rsdo.Concordancer.Core.Entities;
using Rsdo.Concordancer.Core.Search.Queries.Concordances;
using Rsdo.Concordancer.ServiceModel.Requests.Concordances;
using Rsdo.Concordancer.Services.Extensions;
using Rsdo.Concordancer.Services.Services.ParagraphService;

namespace Rsdo.Concordancer.Services.RequestHandlers.Concordances;

public abstract class BaseSearchConcordancesHandler
{
    private readonly IParagraphService paragraphService;

    protected BaseSearchConcordancesHandler(IParagraphService paragraphService)
    {
        this.paragraphService = paragraphService;
    }

    protected async Task<List<SearchConcordancesResponseItem>> GetItems(ConcordancesQuery query, List<string> entityIds)
    {
        var items = new List<SearchConcordancesResponseItem>();
        foreach (var entityId in entityIds)
        {
            items.Add(await GetItem(query, entityId));
        }

        return items;
    }

    private async Task<SearchConcordancesResponseItem> GetItem(ConcordancesQuery query, string entityId)
    {
        var centerTokenId = Guid.Parse(entityId);
        var centerToken = await paragraphService.GetToken(centerTokenId);
        var paragraphId = centerToken.Sentence.Paragraph.Id;

        var orderStart = Math.Max(centerToken.TokenOrder - 20, 1);
        var orderEnd = centerToken.TokenOrder + 20;

        // Get predicate for tokens limitation
        Expression<Func<Token, bool>> predicate = t =>
            t.Sentence.Paragraph.Id == paragraphId && t.TokenOrder >= orderStart && t.TokenOrder <= orderEnd;

        // Get tokens
        var tokens = await paragraphService.GetTokens(predicate);

        // Get center token index
        var centerTokenIndex = tokens.FindIndex(t => t.TokenOrder == centerToken.TokenOrder);

        // Highlight tokens
        tokens.Highlight(query, centerTokenIndex);

        // Return response item
        return new SearchConcordancesResponseItem()
        {
            ParagraphId = paragraphId,
            LeftContext = tokens.GetRange(0, centerTokenIndex),
            CenterContext = tokens[centerTokenIndex],
            RightContext = tokens.GetRange(centerTokenIndex + 1, tokens.Count - centerTokenIndex - 1),
        };
    }
}