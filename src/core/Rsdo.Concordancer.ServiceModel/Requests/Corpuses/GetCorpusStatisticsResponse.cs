namespace Rsdo.Concordancer.ServiceModel.Requests.Corpuses;

public class GetCorpusStatisticsResponse
{
    public int Texts { get; set; }

    public int Sentences { get; set; }

    public int Words { get; set; }
}