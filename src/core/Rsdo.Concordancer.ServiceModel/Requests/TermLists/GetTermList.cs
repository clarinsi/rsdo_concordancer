using System;
using Rsdo.Concordancer.ServiceModel.Interfaces;

namespace Rsdo.Concordancer.ServiceModel.Requests.TermLists;

public class GetTermList : IHaveCorpusId, IRequest<GetTermListResponse>
{
    public Guid CorpusId { get; set; }

    public Guid TermListId { get; set; }
}