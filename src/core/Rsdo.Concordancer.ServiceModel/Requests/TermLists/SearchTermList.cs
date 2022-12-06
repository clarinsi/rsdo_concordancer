using Rsdo.Concordancer.ServiceModel.Interfaces;

namespace Rsdo.Concordancer.ServiceModel.Requests.TermLists;

public class SearchTermList : BaseSearchTermList<SearchTermListResponse>, IPagedSearch
{
    public int From { get; set; } = 0;

    public int Size { get; set; } = 20;
}