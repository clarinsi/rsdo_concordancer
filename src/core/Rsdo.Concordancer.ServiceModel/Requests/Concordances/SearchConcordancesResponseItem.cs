using System;
using System.Collections.Generic;
using Rsdo.Concordancer.ServiceModel.Shared;

namespace Rsdo.Concordancer.ServiceModel.Requests.Concordances;

public class SearchConcordancesResponseItem
{
    public ConcordanceToken CenterContext { get; set; }

    public List<ConcordanceToken> LeftContext { get; set; }

    public Guid ParagraphId { get; set; }

    public List<ConcordanceToken> RightContext { get; set; }
}