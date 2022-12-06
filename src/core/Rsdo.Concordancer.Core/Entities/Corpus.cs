using Rsdo.Concordancer.ServiceModel.Types;

namespace Rsdo.Concordancer.Core.Entities;

public class Corpus : Entity
{
    public string Description { get; set; }

    public CorpusStatus Status { get; set; }

    public string Title { get; set; }
}