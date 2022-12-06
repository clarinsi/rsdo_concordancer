using System.Collections.Generic;
using Rsdo.Concordancer.ServiceModel.Types;

namespace Rsdo.Concordancer.Core.Search.Queries.Concordances;

public class SearchedWordInContextQuery : SearchedWordQuery
{
    public ConditionType ConditionType { get; set; }

    public List<int> Positions { get; set; }
}