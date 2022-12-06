using Rsdo.Concordancer.Core.Search.Queries;

namespace Rsdo.Concordancer.Infrastructure.Search.QueryBuilders;

public interface IQueryBuilderFactory
{
    IQueryBuilder<TQuery> GetBuilder<TQuery>()
        where TQuery : Query;
}