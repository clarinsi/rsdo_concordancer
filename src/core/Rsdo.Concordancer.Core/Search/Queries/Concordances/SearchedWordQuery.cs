using System.Collections.Generic;

namespace Rsdo.Concordancer.Core.Search.Queries.Concordances;

public abstract class SearchedWordQuery
{
    public string Form { get; set; }

    public List<string> Lemmas { get; set; }

    public List<string> Msds { get; set; }
}