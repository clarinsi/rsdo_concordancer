using System.Threading;
using System.Threading.Tasks;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.ServiceModel.Interfaces;
using Rsdo.Concordancer.ServiceModel.Requests.Concordances;
using Rsdo.Concordancer.Services.Services.InputQueryParser;

namespace Rsdo.Concordancer.Services.Framework.Decorators;

public class SearchConcordancesDecorator<TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    private readonly IRequestHandler<TRequest, TResponse> decoratedHandler;
    private readonly IInputQueryParser inputQueryParser;

    public SearchConcordancesDecorator(IRequestHandler<TRequest, TResponse> decoratedHandler, IInputQueryParser inputQueryParser)
    {
        this.decoratedHandler = decoratedHandler;
        this.inputQueryParser = inputQueryParser;
    }

    public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken)
    {
        if (request is BaseSearchConcordances<TResponse> search)
        {
            if (!string.IsNullOrEmpty(search.Query))
            {
                var parsed = await inputQueryParser.Parse(search.Query);
                search.MainWord = parsed.mainWord;
                search.WordsInContext = parsed.wordsInContext;
            }
        }

        return await decoratedHandler.Handle(request, cancellationToken);
    }
}