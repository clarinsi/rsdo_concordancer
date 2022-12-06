using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rsdo.Concordancer.Core.Exceptions;
using Rsdo.Concordancer.Core.Framework;
using Rsdo.Concordancer.Core.Framework.CurrentContexts;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.ServiceModel.Interfaces;
using Rsdo.Concordancer.ServiceModel.Requests.Corpuses;
using Rsdo.Concordancer.ServiceModel.Types;
using Rsdo.Concordancer.Services.Framework.DbContext;

namespace Rsdo.Concordancer.Services.Framework.Decorators;

public class CurrentContextInitializationDecorator<TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    private readonly IRequestHandler<TRequest, TResponse> decoratedHandler;
    private readonly MasterDbContext dbContext;

    public CurrentContextInitializationDecorator(IRequestHandler<TRequest, TResponse> decoratedHandler, MasterDbContext dbContext)
    {
        this.decoratedHandler = decoratedHandler;
        this.dbContext = dbContext;
    }

    public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken)
    {
        // Check if current context is set-up
        CurrentContext.Current ??= new DefaultCurrentContext();

        // Get corpus ID
        if (request is IHaveCorpusId haveCorpus)
        {
            await ValidateCorpus(request, haveCorpus.CorpusId);
            CurrentContext.Current.CorpusId = haveCorpus.CorpusId;
        }

        return await decoratedHandler.Handle(request, cancellationToken);
    }

    private async Task ValidateCorpus(TRequest request, Guid corpusId)
    {
        // Corpus must exist
        var corpus = await dbContext.Corpus.SingleOrDefaultAsync(c => c.Id == corpusId);
        if (corpus == null)
        {
            throw new XNotFoundException(Errors.NotFound.EntityNotFound(EntityType.Corpus, corpusId));
        }

        // Corpus status must be active
        if (request is not (CreateCorpusStore or DeleteCorpusStore) && corpus.Status != CorpusStatus.Active)
        {
            throw new XForbiddenException(Errors.Forbidden.CorpusStatusIsNotValid(corpus.Status, CorpusStatus.Active));
        }
    }
}