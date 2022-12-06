using System.Threading.Tasks;
using OpenSearch.Client;
using Rsdo.Concordancer.Core.Framework;
using Rsdo.Concordancer.Infrastructure.Search.Extensions;

namespace Rsdo.Concordancer.Infrastructure.Search.Indexes;

public abstract class BaseIndexProvider<TModel> : IIndexProvider<TModel>
    where TModel : class
{
    private readonly IOpenSearchClient client;

    protected BaseIndexProvider(IOpenSearchClient client)
    {
        this.client = client;
    }

    public string IndexName => $"rsdo_{typeof(TModel).Name.ToLower()}_{CurrentContext.Current.CorpusId:N}";

    public async Task Create()
    {
        var response = await client.Indices.CreateAsync(
            IndexName,
            c => c.Settings(s => s.NumberOfShards(3).NumberOfReplicas(0)).Map(ms => ms.AutoMap<TModel>().SourceField(sf => sf.Enabled(false))));
        response.ThrowIfInvalid();
    }

    public async Task Delete()
    {
        var response = await client.Indices.DeleteAsync(IndexName);
        response.ThrowIfInvalid();
    }

    public async Task<bool> Exists()
    {
        return (await client.Indices.ExistsAsync(IndexName)).Exists;
    }

    public async Task Refresh()
    {
        var response = await client.Indices.RefreshAsync(IndexName);
        response.ThrowIfInvalid();
    }
}