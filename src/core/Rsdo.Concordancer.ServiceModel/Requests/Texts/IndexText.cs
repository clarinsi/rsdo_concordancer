﻿using System;
using Rsdo.Concordancer.ServiceModel.Interfaces;
using Rsdo.Concordancer.ServiceModel.Shared;

namespace Rsdo.Concordancer.ServiceModel.Requests.Texts;

public class IndexText : IRequest<ExecutionResult>, IHaveCorpusId
{
    public Guid CorpusId { get; set; }

    public Guid TextId { get; set; }
}