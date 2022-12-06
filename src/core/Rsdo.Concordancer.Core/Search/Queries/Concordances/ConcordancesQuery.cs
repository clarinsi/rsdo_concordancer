using System;
using System.Collections.Generic;

namespace Rsdo.Concordancer.Core.Search.Queries.Concordances;

public class ConcordancesQuery : Query
{
    public SearchedMainWordQuery MainWord { get; set; }

    public bool ReturnRandomRows { get; set; }

    public List<Guid> TextIds { get; set; }

    public List<SearchedWordInContextQuery> WordsInContext { get; set; }
}