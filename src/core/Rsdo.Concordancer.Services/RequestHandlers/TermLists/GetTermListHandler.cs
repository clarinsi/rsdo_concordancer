using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rsdo.Concordancer.Core.Exceptions;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.ServiceModel.Requests.TermLists;
using Rsdo.Concordancer.ServiceModel.Types;
using Rsdo.Concordancer.Services.Framework.DbContext;

namespace Rsdo.Concordancer.Services.RequestHandlers.TermLists;

public class GetTermListHandler : IRequestHandler<GetTermList, GetTermListResponse>
{
    private readonly CorpusDbContext dbContext;

    public GetTermListHandler(CorpusDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<GetTermListResponse> Handle(GetTermList request, CancellationToken cancellationToken)
    {
        // Get term list
        var termList = await dbContext.TermList.SingleOrDefaultAsync(t => t.Id == request.TermListId, cancellationToken);
        if (termList == null)
        {
            throw new XNotFoundException(Errors.NotFound.EntityNotFound(EntityType.TermList, request.TermListId));
        }

        return new GetTermListResponse()
        {
            Id = termList.Id,
            SourceFile = termList.SourceFile,
            Status = termList.Status,
        };
    }
}