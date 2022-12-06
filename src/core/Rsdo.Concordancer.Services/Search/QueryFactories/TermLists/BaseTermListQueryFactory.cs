using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rsdo.Concordancer.Core.Search.Queries.TermLists;
using Rsdo.Concordancer.ServiceModel.Requests.TermLists;
using Rsdo.Concordancer.Services.Services.InputQueryParser;
using Rsdo.Concordancer.Services.Services.LemmatizationService;

namespace Rsdo.Concordancer.Services.Search.QueryFactories.TermLists;

public class BaseTermListQueryFactory
{
    private readonly IInputQueryParser inputQueryParser;
    private readonly ILemmatizationService lemmatizationService;

    public BaseTermListQueryFactory(IInputQueryParser inputQueryParser, ILemmatizationService lemmatizationService)
    {
        this.inputQueryParser = inputQueryParser;
        this.lemmatizationService = lemmatizationService;
    }

    protected async Task<TermListQuery> GetQuery<TRequest, TResponse>(TRequest request)
        where TRequest : BaseSearchTermList<TResponse>
    {
        // Parse query
        var words = await inputQueryParser.ParseDefault(request.Query);

        var wordQueries = new List<SearchedTermQuery>();
        foreach (var word in words)
        {
            var wordQuery = new SearchedTermQuery();
            if (word.inPhrase)
            {
                wordQuery.Form = word.word;
            }
            else
            {
                wordQuery.Lemmas = await lemmatizationService.GetLemmas(word.word);
            }

            wordQueries.Add(wordQuery);
        }

        // Return query
        return new TermListQuery
        {
            Words = wordQueries,
        };
    }
}