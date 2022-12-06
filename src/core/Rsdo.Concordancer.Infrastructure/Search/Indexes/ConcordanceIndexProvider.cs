using OpenSearch.Client;
using Rsdo.Concordancer.Infrastructure.Search.Model;

namespace Rsdo.Concordancer.Infrastructure.Search.Indexes;

public class ConcordanceIndexProvider : BaseIndexProvider<EsConcordance>
{
    public ConcordanceIndexProvider(IOpenSearchClient client)
        : base(client)
    {
    }
}