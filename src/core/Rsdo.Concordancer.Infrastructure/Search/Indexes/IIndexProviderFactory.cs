using System.Collections.Generic;

namespace Rsdo.Concordancer.Infrastructure.Search.Indexes;

public interface IIndexProviderFactory
{
    IEnumerable<IIndexProvider> GetAllProviders();

    IIndexProvider<TModel> GetProvider<TModel>();
}