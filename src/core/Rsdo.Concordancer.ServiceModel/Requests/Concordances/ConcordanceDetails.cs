using System;

namespace Rsdo.Concordancer.ServiceModel.Requests.Concordances;

public class ConcordanceDetails : BaseSearchConcordances<ConcordanceDetailsResponse>
{
    public Guid ParagraphId { get; set; }

    public int TokenOrder { get; set; }
}