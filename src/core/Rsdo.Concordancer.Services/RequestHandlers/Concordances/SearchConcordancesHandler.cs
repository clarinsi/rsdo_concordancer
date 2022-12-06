using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Rsdo.Concordancer.Core.Extensions;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.Core.Model;
using Rsdo.Concordancer.Core.Search;
using Rsdo.Concordancer.Core.Search.Queries.Concordances;
using Rsdo.Concordancer.ServiceModel.Requests.Concordances;
using Rsdo.Concordancer.ServiceModel.Types;
using Rsdo.Concordancer.Services.Search.Aggregations;
using Rsdo.Concordancer.Services.Search.AlternateSearches;
using Rsdo.Concordancer.Services.Search.QueryFactories;
using Rsdo.Concordancer.Services.Services.ParagraphService;

namespace Rsdo.Concordancer.Services.RequestHandlers.Concordances;

public class SearchConcordancesHandler : BaseSearchConcordancesHandler, IRequestHandler<SearchConcordances, SearchConcordancesResponse>
{
    private readonly IAggregationProviderFactory aggregationProviderFactory;
    private readonly IAlternateSearchProvider<SearchConcordances, SearchConcordancesResponse> lemmasAlternateSearchProvider;
    private readonly IQueryFactory<SearchConcordances, ConcordancesQuery> queryFactory;
    private readonly ISearchEngine searchEngine;

    public SearchConcordancesHandler(
        IAggregationProviderFactory aggregationProviderFactory,
        IAlternateSearchProvider<SearchConcordances, SearchConcordancesResponse> lemmasAlternateSearchProvider,
        IParagraphService paragraphService,
        IQueryFactory<SearchConcordances, ConcordancesQuery> queryFactory,
        ISearchEngine searchEngine)
        : base(paragraphService)
    {
        this.aggregationProviderFactory = aggregationProviderFactory;
        this.lemmasAlternateSearchProvider = lemmasAlternateSearchProvider;
        this.queryFactory = queryFactory;
        this.searchEngine = searchEngine;
    }

    public async Task<SearchConcordancesResponse> Handle(SearchConcordances request, CancellationToken cancellationToken)
    {
        // Convert request to search query
        var query = await queryFactory.GetQuery(request);

        // Execute search
        var result = await searchEngine.Search<Concordance, ConcordancesQuery>(query);

        return new SearchConcordancesResponse()
        {
            Items = await GetItems(query, result.EntityIds),
            Aggregations = new List<Aggregation>()
            {
                await GetAggregation(AggregationType.Text, c => c.TextIds?.Clear()),
            },
            LemmasAlternateSearch = await lemmasAlternateSearchProvider.Get(request),
            Offset = request.From,
            Total = result.Total,
        };

        Task<Aggregation> GetAggregation(AggregationType aggregationType, Action<ConcordancesQuery> modifyAction)
        {
            // Clone query
            var clonedQuery = query.Copy();
            modifyAction(clonedQuery);

            // Get aggregation
            var provider = aggregationProviderFactory.GetProvider(aggregationType);
            return provider.Get(clonedQuery);
        }
    }
}