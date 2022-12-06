namespace Rsdo.Concordancer.ServiceModel.Requests.TermLists;

public class ExportTermList : BaseSearchTermList<ExportTermListResponse>
{
    public int Rows { get; set; }
}