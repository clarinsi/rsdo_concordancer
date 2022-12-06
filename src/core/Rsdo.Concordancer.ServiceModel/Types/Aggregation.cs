using System.Collections.Generic;

namespace Rsdo.Concordancer.ServiceModel.Types;

public class Aggregation
{
    public List<AggregationItem> Items { get; set; }

    public AggregationType Type { get; set; }
}