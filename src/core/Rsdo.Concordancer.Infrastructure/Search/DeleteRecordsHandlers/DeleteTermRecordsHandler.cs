using OpenSearch.Client;
using Rsdo.Concordancer.Infrastructure.Search.Indexes;
using Rsdo.Concordancer.Infrastructure.Search.Model;
using Term = Rsdo.Concordancer.Core.Entities.Term;

namespace Rsdo.Concordancer.Infrastructure.Search.DeleteRecordsHandlers;

public class DeleteTermRecordsHandler : BaseDeleteRecordsHandler<Term, EsTerm>
{
    public DeleteTermRecordsHandler(IOpenSearchClient client, IIndexProviderFactory indexProviderFactory)
        : base(client, indexProviderFactory)
    {
    }
}