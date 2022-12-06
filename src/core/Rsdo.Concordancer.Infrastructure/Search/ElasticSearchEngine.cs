using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenSearch.Client;
using Rsdo.Concordancer.Core.Model;
using Rsdo.Concordancer.Core.Search;
using Rsdo.Concordancer.Core.Search.Queries;
using Rsdo.Concordancer.Infrastructure.Search.AddRecordsHandlers;
using Rsdo.Concordancer.Infrastructure.Search.DeleteRecordsHandlers;
using Rsdo.Concordancer.Infrastructure.Search.Extensions;
using Rsdo.Concordancer.Infrastructure.Search.Indexes;
using Rsdo.Concordancer.Infrastructure.Search.Model;
using Rsdo.Concordancer.Infrastructure.Search.QueryBuilders;
using Term = Rsdo.Concordancer.Core.Entities.Term;

namespace Rsdo.Concordancer.Infrastructure.Search;

public class ElasticSearchEngine : ISearchEngine
{
    private readonly IAddRecordsHandlerFactory addRecordsHandlerFactory;
    private readonly IOpenSearchClient client;
    private readonly IDeleteRecordsHandlerFactory deleteRecordsHandlerFactory;
    private readonly IIndexProviderFactory indexProviderFactory;
    private readonly IQueryBuilderFactory queryBuilderFactory;

    public ElasticSearchEngine(
        IAddRecordsHandlerFactory addRecordsHandlerFactory,
        IOpenSearchClient client,
        IDeleteRecordsHandlerFactory deleteRecordsHandlerFactory,
        IIndexProviderFactory indexProviderFactory,
        IQueryBuilderFactory queryBuilderFactory)
    {
        this.addRecordsHandlerFactory = addRecordsHandlerFactory;
        this.client = client;
        this.deleteRecordsHandlerFactory = deleteRecordsHandlerFactory;
        this.indexProviderFactory = indexProviderFactory;
        this.queryBuilderFactory = queryBuilderFactory;
    }

    public Task Add<TEntity>(IEnumerable<TEntity> entities)
    {
        var handler = addRecordsHandlerFactory.GetHandler<TEntity>();
        return handler.Add(entities);
    }

    public async Task Commit()
    {
        foreach (var provider in indexProviderFactory.GetAllProviders())
        {
            await provider.Refresh();
        }
    }

    public async Task CreateSchema()
    {
        foreach (var provider in indexProviderFactory.GetAllProviders())
        {
            await provider.Create();
        }
    }

    public Task Delete<TEntity>(IEnumerable<Guid> entityIds)
    {
        var handler = deleteRecordsHandlerFactory.GetHandler<TEntity>();
        return handler.Delete(entityIds);
    }

    public async Task DeleteSchema()
    {
        foreach (var provider in indexProviderFactory.GetAllProviders())
        {
            if (await provider.Exists())
            {
                await provider.Delete();
            }
        }
    }

    public async Task<QueryResult> Search<TEntity, TQuery>(TQuery query)
        where TEntity : class
        where TQuery : Query
    {
        // Get search request
        var searchRequest = GetSearchRequest<TEntity, TQuery>(query);

        // Execute search
        var searchResponse = await client.SearchAsync<TEntity>(searchRequest);
        searchResponse.ThrowIfInvalid();

        // Return result
        return new QueryResult()
        {
            EntityIds = searchResponse.Hits?.Select(h => h.Id).ToList(),
            Total = searchResponse.Total,
        };
    }

    private IIndexProvider GetIndexProvider<TEntity>()
    {
        // ToDo: this should be done with some kind of mapper
        if (typeof(TEntity) == typeof(Concordance))
        {
            return indexProviderFactory.GetProvider<EsConcordance>();
        }

        if (typeof(TEntity) == typeof(Term))
        {
            return indexProviderFactory.GetProvider<EsTerm>();
        }

        throw new ArgumentOutOfRangeException($"Entity type {typeof(TEntity)} is not supported as a search type in Elastic!");
    }

    private SearchRequest GetSearchRequest<TEntity, TQuery>(TQuery query)
        where TQuery : Query
    {
        // Get query builder
        var queryBuilder = queryBuilderFactory.GetBuilder<TQuery>();

        // Build elastic query
        var elasticQuery = queryBuilder.Build(query);

        // Get index provider
        var indexProvider = GetIndexProvider<TEntity>();

        // Return search request
        return new SearchRequest(indexProvider.IndexName)
        {
            From = query.From,
            Size = query.Size,
            TrackTotalHits = true,
            Query = elasticQuery,
        };
    }
}