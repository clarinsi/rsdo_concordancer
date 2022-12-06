using System.Collections.Generic;

namespace Rsdo.Concordancer.Core.Entities;

public class Sentence : Entity
{
    public Paragraph Paragraph { get; set; }

    public long ParagraphAutoId { get; set; }

    public int RecordOrder { get; set; }

    public List<Token> Tokens { get; set; }
}