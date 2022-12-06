namespace Rsdo.Concordancer.ServiceModel.Requests.TermLists;

public class SearchTermListResponseItem
{
    public string Form { get; set; }

    public int Frequency { get; set; }

    public string Lemma { get; set; }

    public decimal Weight { get; set; }
}