using System.Collections.Generic;

namespace Rsdo.Concordancer.Core.Search.Queries;

public class QueryResult
{
    public List<string> EntityIds { get; set; }

    public long Total { get; set; }
}