using System.Collections.Generic;
using System.Threading.Tasks;
using Rsdo.Concordancer.Core.Extensions;
using Rsdo.Concordancer.Core.Search.Queries.Concordances;
using Rsdo.Concordancer.ServiceModel.Requests.Concordances;
using Rsdo.Concordancer.ServiceModel.Types;
using Rsdo.Concordancer.Services.Services.LemmatizationService;

namespace Rsdo.Concordancer.Services.Search.QueryFactories.Concordances;

public abstract class BaseConcordancesQueryFactory
{
    private readonly ILemmatizationService lemmatizationService;

    protected BaseConcordancesQueryFactory(ILemmatizationService lemmatizationService)
    {
        this.lemmatizationService = lemmatizationService;
    }

    protected async Task<ConcordancesQuery> GetQuery<TRequest, TResponse>(TRequest request)
        where TRequest : BaseSearchConcordances<TResponse>
    {
        // Return query
        return new ConcordancesQuery
        {
            MainWord = await GetMainWordQuery(request.MainWord),
            TextIds = request.TextIds,
            WordsInContext = await GetWordInContextQueries(request.WordsInContext),
        };
    }

    private static List<int> GetPositions(SearchedWordInContext wordInContext)
    {
        var positions = new List<int>();
        AddPositions(wordInContext.LeftPosition, wordInContext.DistanceType, true);
        AddPositions(wordInContext.RightPosition, wordInContext.DistanceType, false);
        return positions;

        void AddPositions(int position, DistanceType distanceType, bool negative)
        {
            if (position == 0)
            {
                return;
            }

            if (distanceType == DistanceType.Position)
            {
                positions.Add(negative ? -position : position);
            }
            else
            {
                for (var i = 1; i <= position; i++)
                {
                    positions.Add(negative ? -i : i);
                }
            }
        }
    }

    private async Task<SearchedMainWordQuery> GetMainWordQuery(SearchedWord mainWord)
    {
        return await GetWordQuery<SearchedMainWordQuery>(mainWord);
    }

    private async Task<List<SearchedWordInContextQuery>> GetWordInContextQueries(List<SearchedWordInContext> wordsInContext)
    {
        if (wordsInContext.IsNullOrEmpty())
        {
            return null;
        }

        var wordInContextQueries = new List<SearchedWordInContextQuery>();
        foreach (var wordInContext in wordsInContext)
        {
            var wordInContextQuery = await GetWordInContextQuery(wordInContext);
            wordInContextQueries.Add(wordInContextQuery);
        }

        return wordInContextQueries;
    }

    private async Task<SearchedWordInContextQuery> GetWordInContextQuery(SearchedWordInContext wordInContext)
    {
        var query = await GetWordQuery<SearchedWordInContextQuery>(wordInContext);
        query.ConditionType = wordInContext.ConditionType;
        query.Positions = GetPositions(wordInContext);
        return query;
    }

    private async Task<T> GetWordQuery<T>(SearchedWord word)
        where T : SearchedWordQuery, new()
    {
        var query = new T();

        var lemmas = (List<string>)null;
        if (!string.IsNullOrEmpty(word.Lemma))
        {
            lemmas = new List<string>
            {
                word.Lemma,
            };
        }

        if (!string.IsNullOrEmpty(word.Form))
        {
            if (word.FormSearchType == FormSearchType.ExactForm)
            {
                query.Form = word.Form;
            }
            else
            {
                if (lemmas.IsNullOrEmpty())
                {
                    lemmas = await lemmatizationService.GetLemmas(word.Form);
                }
            }
        }

        query.Lemmas = lemmas;
        return query;
    }
}