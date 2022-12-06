using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OpenSearch.Client;
using Rsdo.Concordancer.Infrastructure.Search.Extensions;
using Rsdo.Concordancer.Infrastructure.Search.Indexes;

namespace Rsdo.Concordancer.Infrastructure.Search.DeleteRecordsHandlers;

public abstract class BaseDeleteRecordsHandler<TEntity, TElasticEntity> : IDeleteRecordsHandler<TEntity>
    where TElasticEntity : class
{
    private readonly IOpenSearchClient client;
    private readonly IIndexProviderFactory indexProviderFactory;

    protected BaseDeleteRecordsHandler(IOpenSearchClient client, IIndexProviderFactory indexProviderFactory)
    {
        this.client = client;
        this.indexProviderFactory = indexProviderFactory;
    }

    public async Task Delete(IEnumerable<Guid> entityIds)
    {
        // Get index provider
        var indexProvider = indexProviderFactory.GetProvider<TElasticEntity>();

        // Get index name
        var indexName = indexProvider.IndexName;

        // Create request
        var request = new BulkRequest(indexName)
        {
            Operations = new List<IBulkOperation>(),
            Timeout = TimeSpan.FromMinutes(5),
        };

        // Convert entities to elastic entities
        foreach (var entityId in entityIds)
        {
            request.Operations.Add(new BulkDeleteDescriptor<TElasticEntity>().Id(entityId));
        }

        // Get response
        var response = await client.BulkAsync(request);
        response.ThrowIfInvalid();
    }
}