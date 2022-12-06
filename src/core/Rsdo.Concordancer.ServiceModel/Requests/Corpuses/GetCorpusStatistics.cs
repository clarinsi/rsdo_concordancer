using System;
using Rsdo.Concordancer.ServiceModel.Interfaces;

namespace Rsdo.Concordancer.ServiceModel.Requests.Corpuses;

public class GetCorpusStatistics : IHaveCorpusId, IRequest<GetCorpusStatisticsResponse>
{
    public Guid CorpusId { get; set; }
}