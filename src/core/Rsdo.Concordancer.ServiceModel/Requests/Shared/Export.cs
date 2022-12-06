using System.IO;

namespace Rsdo.Concordancer.ServiceModel.Requests.Shared;

public abstract class Export
{
    public string ContentType { get; set; }

    public string FileName { get; set; }

    public Stream Stream { get; set; }
}