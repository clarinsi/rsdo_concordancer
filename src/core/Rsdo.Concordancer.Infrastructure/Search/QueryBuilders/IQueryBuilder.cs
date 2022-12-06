using OpenSearch.Client;
using Rsdo.Concordancer.Core.Search.Queries;

namespace Rsdo.Concordancer.Infrastructure.Search.QueryBuilders;

public interface IQueryBuilder<TQuery>
    where TQuery : Query
{
    QueryContainer Build(TQuery query);
}