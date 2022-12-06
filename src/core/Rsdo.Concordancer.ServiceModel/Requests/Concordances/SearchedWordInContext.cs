using Rsdo.Concordancer.ServiceModel.Types;

namespace Rsdo.Concordancer.ServiceModel.Requests.Concordances;

public class SearchedWordInContext : SearchedWord
{
    public ConditionType ConditionType { get; set; }

    public DistanceType DistanceType { get; set; }

    public int LeftPosition { get; set; }

    public int RightPosition { get; set; }
}