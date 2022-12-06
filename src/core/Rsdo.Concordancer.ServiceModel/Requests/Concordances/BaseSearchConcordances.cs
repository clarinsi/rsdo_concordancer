using System;
using System.Collections.Generic;
using Rsdo.Concordancer.ServiceModel.Requests.Shared;

namespace Rsdo.Concordancer.ServiceModel.Requests.Concordances;

public abstract class BaseSearchConcordances<TResponse> : Search<TResponse>
{
    public SearchedMainWord MainWord { get; set; }

    public List<Guid> TextIds { get; set; }

    public List<SearchedWordInContext> WordsInContext { get; set; }
}