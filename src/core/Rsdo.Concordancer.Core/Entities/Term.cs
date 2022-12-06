namespace Rsdo.Concordancer.Core.Entities;

public class Term : Entity
{
    public string Form { get; set; }

    public int Frequency { get; set; }

    public string Lemma { get; set; }

    public string Msd { get; set; }

    public TermList TermList { get; set; }

    public long TermListAutoId { get; set; }

    public decimal Weight { get; set; }
}