using System;
using Rsdo.Concordancer.ServiceModel.Interfaces;

namespace Rsdo.Concordancer.ServiceModel.Requests.Texts;

public class GetText : IHaveCorpusId, IRequest<GetTextResponse>
{
    public Guid CorpusId { get; set; }

    public Guid TextId { get; set; }
}