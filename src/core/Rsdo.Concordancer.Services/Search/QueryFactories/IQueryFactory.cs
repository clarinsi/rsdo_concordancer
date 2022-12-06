using System.Threading.Tasks;
using Rsdo.Concordancer.Core.Search.Queries;

namespace Rsdo.Concordancer.Services.Search.QueryFactories;

public interface IQueryFactory<TRequest, TQuery>
    where TQuery : Query
{
    Task<TQuery> GetQuery(TRequest request);
}