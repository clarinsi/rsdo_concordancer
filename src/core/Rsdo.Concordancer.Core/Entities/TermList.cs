using System.Collections.Generic;
using Rsdo.Concordancer.ServiceModel.Types;

namespace Rsdo.Concordancer.Core.Entities;

public class TermList : Entity
{
    public string SourceFile { get; set; }

    public ImportStatus Status { get; set; }

    public List<Term> Terms { get; set; }
}