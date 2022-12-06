﻿using System;
using Rsdo.Concordancer.ServiceModel.Interfaces;
using Rsdo.Concordancer.ServiceModel.Shared;

namespace Rsdo.Concordancer.ServiceModel.Requests.Texts;

public class DeleteTextFromIndex : IRequest<ExecutionResult>, IHaveCorpusId
{
    public Guid CorpusId { get; set; }

    public Guid TextId { get; set; }
}