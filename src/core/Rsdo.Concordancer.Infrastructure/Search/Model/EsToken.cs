using OpenSearch.Client;

namespace Rsdo.Concordancer.Infrastructure.Search.Model;

public class EsToken
{
    [Keyword]
    public string Form { get; set; }

    [Keyword]
    public string FormLower { get; set; }

    [Keyword]
    public string Lemma { get; set; }

    [Keyword]
    public string LemmaLower { get; set; }

    [Keyword]
    public string Msd { get; set; }
}