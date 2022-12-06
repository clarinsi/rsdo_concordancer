using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.ServiceModel.Requests.Corpuses;
using Rsdo.Concordancer.Services.Framework.DbContext;

namespace Rsdo.Concordancer.Services.RequestHandlers.Corpuses;

public class GetCorpusHandler : IRequestHandler<GetCorpus, GetCorpusResponse>
{
    private readonly MasterDbContext dbContext;

    public GetCorpusHandler(MasterDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<GetCorpusResponse> Handle(GetCorpus request, CancellationToken cancellationToken)
    {
        // Get corpus
        var corpus = await dbContext.Corpus.SingleAsync(x => x.Id == request.CorpusId, cancellationToken);

        return new GetCorpusResponse()
        {
            Description = corpus.Description,
            Id = corpus.Id,
            Status = corpus.Status,
            Title = corpus.Title,
        };
    }
}