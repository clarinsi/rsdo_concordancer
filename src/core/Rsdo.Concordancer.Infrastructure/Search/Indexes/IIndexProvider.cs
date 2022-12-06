using System.Threading.Tasks;

namespace Rsdo.Concordancer.Infrastructure.Search.Indexes;

public interface IIndexProvider<TModel> : IIndexProvider
{
}

public interface IIndexProvider
{
    string IndexName { get; }

    Task Create();

    Task Delete();

    Task<bool> Exists();

    Task Refresh();
}