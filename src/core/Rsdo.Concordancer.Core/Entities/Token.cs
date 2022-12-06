using Rsdo.Concordancer.ServiceModel.Types;

namespace Rsdo.Concordancer.Core.Entities;

public class Token : Entity
{
    public string Form { get; set; }

    public string Lemma { get; set; }

    public string Msd { get; set; }

    public int RecordOrder { get; set; }

    public Sentence Sentence { get; set; }

    public long SentenceAutoId { get; set; }

    public int TokenOrder { get; set; }

    public TokenType Type { get; set; }
}