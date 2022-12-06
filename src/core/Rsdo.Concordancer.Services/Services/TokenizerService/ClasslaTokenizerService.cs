using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Rsdo.Concordancer.Core.Constants;

namespace Rsdo.Concordancer.Services.Services.TokenizerService;

public class ClasslaTokenizerService : BaseTokenizerService
{
    private readonly IConfiguration configuration;
    private readonly IHttpClientFactory httpClientFactory;
    private readonly ILogger<ClasslaTokenizerService> logger;
    private readonly IMemoryCache memoryCache;

    public ClasslaTokenizerService(
        IConfiguration configuration,
        IHttpClientFactory httpClientFactory,
        ILogger<ClasslaTokenizerService> logger,
        IMemoryCache memoryCache)
    {
        this.configuration = configuration;
        this.httpClientFactory = httpClientFactory;
        this.logger = logger;
        this.memoryCache = memoryCache;
    }

    protected override async Task<string> GetXml(string query)
    {
        var cacheKey = Cache.CacheKeys.Tokenizer.ByQuery(query);
        var tokenized = memoryCache.Get<string>(cacheKey);
        if (tokenized == null)
        {
            tokenized = await GetXmlFromWebService(query);
            memoryCache.Set(cacheKey, tokenized, Cache.Duration.Short);
        }

        return tokenized;
    }

    private async Task<string> GetXmlFromWebService(string query)
    {
        var data = new[]
        {
            new KeyValuePair<string, string>("text", query),
            new KeyValuePair<string, string>("tags", string.Empty),
            new KeyValuePair<string, string>("model", "standard"),
            new KeyValuePair<string, string>("text-type", "raw"),
            new KeyValuePair<string, string>("tag-language", "slo"),
            new KeyValuePair<string, string>("synt-dep", "ud+jos"),
            new KeyValuePair<string, string>("morph-scheme", "ud+jos"),
        };

        var url = configuration[ConfigurationKey.Tokenizer.ClasslaTokenizerUrl];
        var client = httpClientFactory.CreateClient();
        client.Timeout = TimeSpan.FromMilliseconds(2000);
        try
        {
            var response = await client.PostAsync(url, new FormUrlEncodedContent(data));
            if (response.IsSuccessStatusCode)
            {
                using (var streamReader = new StreamReader(await response.Content.ReadAsStreamAsync()))
                {
                    using (var jsonReader = new JsonTextReader(streamReader))
                    {
                        var json = await JObject.LoadAsync(jsonReader);
                        return json["tei"].Value<string>();
                    }
                }
            }

            throw new Exception($"Invalid status code: {(int)response.StatusCode}.");
        }
        catch (Exception e)
        {
            logger.LogError(e, "Error when tokenizing query '{query}'.", query);
            throw;
        }
    }
}