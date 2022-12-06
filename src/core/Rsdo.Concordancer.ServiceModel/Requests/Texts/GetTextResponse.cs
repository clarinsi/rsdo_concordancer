using System;
using Rsdo.Concordancer.ServiceModel.Types;

namespace Rsdo.Concordancer.ServiceModel.Requests.Texts;

public class GetTextResponse
{
    public string Author { get; set; }

    public Guid Id { get; set; }

    public string SourceFile { get; set; }

    public ImportStatus Status { get; set; }

    public string Title { get; set; }

    public short? Year { get; set; }
}