using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenSearch.Client;
using Rsdo.Concordancer.Core.Search.Aggregations;
using Rsdo.Concordancer.Core.Search.Queries;
using Rsdo.Concordancer.Infrastructure.Search.Extensions;
using Rsdo.Concordancer.Infrastructure.Search.Indexes;
using Rsdo.Concordancer.Infrastructure.Search.Model;
using Rsdo.Concordancer.Infrastructure.Search.QueryBuilders;

namespace Rsdo.Concordancer.Infrastructure.Search.Aggregations;

public abstract class BaseAggregator : IAggregator
{
    private readonly IOpenSearchClient client;
    private readonly IIndexProviderFactory indexProviderFactory;
    private readonly IQueryBuilderFactory queryBuilderFactory;

    protected BaseAggregator(IOpenSearchClient client, IIndexProviderFactory indexProviderFactory, IQueryBuilderFactory queryBuilderFactory)
    {
        this.client = client;
        this.indexProviderFactory = indexProviderFactory;
        this.queryBuilderFactory = queryBuilderFactory;
    }

    protected abstract string FieldName { get; }

    public async Task<IDictionary<string, long>> Get<TQuery>(TQuery query)
        where TQuery : Query
    {
        // Get elastic query
        var queryBuilder = queryBuilderFactory.GetBuilder<TQuery>();
        var elasticQuery = queryBuilder.Build(query);

        // Get and execute search request
        var searchRequest = GetSearchRequest(elasticQuery);
        var response = await client.SearchAsync<EsConcordance>(searchRequest);
        response.ThrowIfInvalid();

        // Read response
        return ReadAggregations(response);
    }

    private static IDictionary<string, long> ReadAggregations(ISearchResponse<EsConcordance> response)
    {
        var terms = response.Aggregations.Terms("agg");
        return terms?.Buckets?.ToDictionary(x => x.Key, x => x.DocCount ?? 0);
    }

    private SearchRequest GetSearchRequest(QueryContainer query)
    {
        var indexProvider = indexProviderFactory.GetProvider<EsConcordance>();
        var indexName = indexProvider.IndexName;

        return new SearchRequest(indexName)
        {
            From = 0,
            Size = 0,
            Query = query,
            Aggregations = new AggregationDictionary()
            {
                {
                    "agg", new TermsAggregation("terms")
                    {
                        Field = FieldName,
                        Size = 100,
                    }
                },
            },
        };
    }
}