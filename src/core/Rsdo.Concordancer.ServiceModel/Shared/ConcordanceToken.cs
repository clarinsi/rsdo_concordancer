using Rsdo.Concordancer.ServiceModel.Types;

namespace Rsdo.Concordancer.ServiceModel.Shared;

public class ConcordanceToken
{
    public string Form { get; set; }

    public bool IsCenterMatch { get; set; }

    public bool IsWordInContextMatch { get; set; }

    public string Lemma { get; set; }

    public string Msd { get; set; }

    public string MsdDescription { get; set; }

    public int TokenOrder { get; set; }

    public TokenType Type { get; set; }
}