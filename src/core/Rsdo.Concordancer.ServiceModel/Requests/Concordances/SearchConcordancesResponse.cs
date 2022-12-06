using System.Collections.Generic;
using Rsdo.Concordancer.ServiceModel.Interfaces;
using Rsdo.Concordancer.ServiceModel.Types;

namespace Rsdo.Concordancer.ServiceModel.Requests.Concordances;

public class SearchConcordancesResponse : IPagedResponse
{
    public List<Aggregation> Aggregations { get; set; }

    public List<SearchConcordancesResponseItem> Items { get; set; }

    public AlternateSearch<SearchConcordances, SearchConcordancesResponse> LemmasAlternateSearch { get; set; }

    public int Offset { get; set; }

    public long Total { get; set; }
}