using OpenSearch.Client;
using Rsdo.Concordancer.Infrastructure.Search.Model;

namespace Rsdo.Concordancer.Infrastructure.Search.Indexes;

public class TermIndexProvider : BaseIndexProvider<EsTerm>
{
    public TermIndexProvider(IOpenSearchClient client)
        : base(client)
    {
    }
}