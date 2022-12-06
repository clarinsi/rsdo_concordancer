using System.Collections.Generic;
using Rsdo.Concordancer.ServiceModel.Interfaces;

namespace Rsdo.Concordancer.ServiceModel.Requests.TermLists;

public class SearchTermListResponse : IPagedResponse
{
    public List<SearchTermListResponseItem> Items { get; set; }

    public int Offset { get; set; }

    public long Total { get; set; }
}