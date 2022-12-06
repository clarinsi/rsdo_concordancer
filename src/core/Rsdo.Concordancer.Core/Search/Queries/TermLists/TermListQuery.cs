using System.Collections.Generic;

namespace Rsdo.Concordancer.Core.Search.Queries.TermLists;

public class TermListQuery : Query
{
    public List<SearchedTermQuery> Words { get; set; }
}