using OpenSearch.Client;
using Rsdo.Concordancer.Core.Model;
using Rsdo.Concordancer.Infrastructure.Search.Indexes;
using Rsdo.Concordancer.Infrastructure.Search.Model;

namespace Rsdo.Concordancer.Infrastructure.Search.DeleteRecordsHandlers;

public class DeleteConcordanceRecordsHandler : BaseDeleteRecordsHandler<Concordance, EsConcordance>
{
    public DeleteConcordanceRecordsHandler(IOpenSearchClient client, IIndexProviderFactory indexProviderFactory)
        : base(client, indexProviderFactory)
    {
    }
}