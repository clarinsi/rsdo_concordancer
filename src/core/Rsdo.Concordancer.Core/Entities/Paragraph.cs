using System.Collections.Generic;

namespace Rsdo.Concordancer.Core.Entities;

public class Paragraph : Entity
{
    public int RecordOrder { get; set; }

    public List<Sentence> Sentences { get; set; }

    public Text Text { get; set; }

    public long TextAutoId { get; set; }
}