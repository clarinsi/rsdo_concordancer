using System;
using OpenSearch.Client;

namespace Rsdo.Concordancer.Infrastructure.Search.Model;

public class EsConcordance
{
    public Guid Id { get; set; }

    [Keyword]
    public Guid TextId { get; set; }

    public EsToken Token { get; set; }

    public EsToken TokenLeft1 { get; set; }

    public EsToken TokenLeft2 { get; set; }

    public EsToken TokenLeft3 { get; set; }

    public EsToken TokenLeft4 { get; set; }

    public EsToken TokenLeft5 { get; set; }

    public EsToken TokenLeft6 { get; set; }

    public EsToken TokenLeft7 { get; set; }

    public EsToken TokenLeft8 { get; set; }

    public EsToken TokenLeft9 { get; set; }

    public EsToken TokenLeft10 { get; set; }

    public EsToken TokenRight1 { get; set; }

    public EsToken TokenRight2 { get; set; }

    public EsToken TokenRight3 { get; set; }

    public EsToken TokenRight4 { get; set; }

    public EsToken TokenRight5 { get; set; }

    public EsToken TokenRight6 { get; set; }

    public EsToken TokenRight7 { get; set; }

    public EsToken TokenRight8 { get; set; }

    public EsToken TokenRight9 { get; set; }

    public EsToken TokenRight10 { get; set; }
}