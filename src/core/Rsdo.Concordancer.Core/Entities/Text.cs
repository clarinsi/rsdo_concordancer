using System.Collections.Generic;
using System.IO;
using Rsdo.Concordancer.ServiceModel.Types;

namespace Rsdo.Concordancer.Core.Entities;

public class Text : Entity
{
    public string Author { get; set; }

    public List<Paragraph> Paragraphs { get; set; }

    public string SourceFile { get; set; }

    public ImportStatus Status { get; set; }

    public string Title { get; set; }

    public short? Year { get; set; }

    public string DisplayFileName => Path.GetFileNameWithoutExtension(SourceFile);
}