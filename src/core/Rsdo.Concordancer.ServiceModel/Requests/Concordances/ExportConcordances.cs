using Rsdo.Concordancer.ServiceModel.Types;

namespace Rsdo.Concordancer.ServiceModel.Requests.Concordances;

public class ExportConcordances : BaseSearchConcordances<ExportConcordancesResponse>
{
    public int Rows { get; set; }

    public ConcordanceExportType Type { get; set; }
}