using System.Collections.Generic;
using Rsdo.Concordancer.ServiceModel.Shared;

namespace Rsdo.Concordancer.ServiceModel.Requests.Concordances;

public class ConcordanceDetailsResponse
{
    public string Author { get; set; }

    public string SourceFile { get; set; }

    public string Title { get; set; }

    public List<ConcordanceToken> Tokens { get; set; }

    public short? Year { get; set; }
}