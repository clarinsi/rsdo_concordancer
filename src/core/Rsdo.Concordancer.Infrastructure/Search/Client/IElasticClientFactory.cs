using OpenSearch.Client;

namespace Rsdo.Concordancer.Infrastructure.Search.Client;

public interface IElasticClientFactory
{
    IOpenSearchClient Get();
}