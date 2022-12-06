using System;
using Rsdo.Concordancer.ServiceModel.Types;

namespace Rsdo.Concordancer.ServiceModel.Requests.TermLists;

public class GetTermListResponse
{
    public Guid Id { get; set; }

    public string SourceFile { get; set; }

    public ImportStatus Status { get; set; }
}