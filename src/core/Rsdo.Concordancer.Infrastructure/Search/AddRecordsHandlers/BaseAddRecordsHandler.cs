using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OpenSearch.Client;
using Rsdo.Concordancer.Infrastructure.Search.Extensions;
using Rsdo.Concordancer.Infrastructure.Search.Indexes;

namespace Rsdo.Concordancer.Infrastructure.Search.AddRecordsHandlers;

public abstract class BaseAddRecordsHandler<TEntity, TElasticEntity> : IAddRecordsHandler<TEntity>
    where TElasticEntity : class
{
    private readonly IOpenSearchClient client;
    private readonly IIndexProviderFactory indexProviderFactory;

    protected BaseAddRecordsHandler(IOpenSearchClient client, IIndexProviderFactory indexProviderFactory)
    {
        this.client = client;
        this.indexProviderFactory = indexProviderFactory;
    }

    public async Task Add(IEnumerable<TEntity> entities)
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
        foreach (var entity in entities)
        {
            var elasticEntity = ConvertEntity(entity);
            request.Operations.Add(new BulkIndexOperation<TElasticEntity>(elasticEntity));
        }

        // Get response
        var response = await client.BulkAsync(request);
        response.ThrowIfInvalid();
    }

    protected abstract TElasticEntity ConvertEntity(TEntity entity);
}