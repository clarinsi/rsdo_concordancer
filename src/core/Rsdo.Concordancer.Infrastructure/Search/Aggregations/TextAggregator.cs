using OpenSearch.Client;
using Rsdo.Concordancer.Infrastructure.Search.Indexes;
using Rsdo.Concordancer.Infrastructure.Search.QueryBuilders;

namespace Rsdo.Concordancer.Infrastructure.Search.Aggregations;

public class TextAggregator : BaseAggregator
{
    public TextAggregator(IOpenSearchClient client, IIndexProviderFactory indexProviderFactory, IQueryBuilderFactory queryBuilderFactory)
        : base(client, indexProviderFactory, queryBuilderFactory)
    {
    }

    protected override string FieldName => "textId";
}