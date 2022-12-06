using Rsdo.Concordancer.ServiceModel.Interfaces;

namespace Rsdo.Concordancer.ServiceModel.Requests.Concordances;

public class SearchConcordances : BaseSearchConcordances<SearchConcordancesResponse>, IPagedSearch
{
    public int From { get; set; } = 0;

    public int Size { get; set; } = 20;
}