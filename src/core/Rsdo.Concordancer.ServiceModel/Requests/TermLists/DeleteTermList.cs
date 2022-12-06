using System;
using Rsdo.Concordancer.ServiceModel.Interfaces;
using Rsdo.Concordancer.ServiceModel.Shared;

namespace Rsdo.Concordancer.ServiceModel.Requests.TermLists;

public class DeleteTermList : IRequest<ExecutionResult>, IHaveCorpusId
{
    public Guid CorpusId { get; set; }

    public Guid TermListId { get; set; }
}