using System.Collections.Generic;

namespace Rsdo.Concordancer.Core.Search.Queries.TermLists;

public class SearchedTermQuery
{
    public string Form { get; set; }

    public List<string> Lemmas { get; set; }
}