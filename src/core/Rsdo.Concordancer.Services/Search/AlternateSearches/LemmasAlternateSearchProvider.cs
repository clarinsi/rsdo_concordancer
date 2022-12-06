using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rsdo.Concordancer.Core.Extensions;
using Rsdo.Concordancer.Core.Model;
using Rsdo.Concordancer.Core.Search;
using Rsdo.Concordancer.Core.Search.Queries.Concordances;
using Rsdo.Concordancer.ServiceModel.Requests.Concordances;
using Rsdo.Concordancer.ServiceModel.Types;
using Rsdo.Concordancer.Services.Search.QueryFactories;
using Rsdo.Concordancer.Services.Services.LemmatizationService;

namespace Rsdo.Concordancer.Services.Search.AlternateSearches;

public class LemmasAlternateSearchProvider : IAlternateSearchProvider<SearchConcordances, SearchConcordancesResponse>
{
    private readonly ILemmatizationService lemmatizationService;
    private readonly IQueryFactory<SearchConcordances, ConcordancesQuery> queryFactory;
    private readonly ISearchEngine searchEngine;

    public LemmasAlternateSearchProvider(
        ILemmatizationService lemmatizationService,
        IQueryFactory<SearchConcordances, ConcordancesQuery> queryFactory,
        ISearchEngine searchEngine)
    {
        this.lemmatizationService = lemmatizationService;
        this.queryFactory = queryFactory;
        this.searchEngine = searchEngine;
    }

    public async Task<AlternateSearch<SearchConcordances, SearchConcordancesResponse>> Get(SearchConcordances request)
    {
        // Main word
        var lemmas = new List<List<string>>
        {
            await GetLemmasForWord(request.MainWord),
        };

        // Words in context
        if (!request.WordsInContext.IsNullOrEmpty())
        {
            foreach (var wordInContext in request.WordsInContext)
            {
                if (SkipWord(wordInContext))
                {
                    continue;
                }

                lemmas.Add(await GetLemmasForWord(wordInContext));
            }
        }

        var products = lemmas.CartesianProduct();
        var alternateSearch = new AlternateSearch<SearchConcordances, SearchConcordancesResponse>()
        {
            Items = new List<AlternateSearchItem<SearchConcordances, SearchConcordancesResponse>>(),
            OriginalSearch = GetOriginalSearch(request),
            Type = AlternateSearchType.Lemmas,
        };

        foreach (var product in products)
        {
            var productLemmas = product.ToList();
            var clone = request.Copy();

            // Main word
            clone.MainWord.Lemma = productLemmas[0];

            // Words in context
            if (!clone.WordsInContext.IsNullOrEmpty())
            {
                for (var i = 0; i < clone.WordsInContext.Count; i++)
                {
                    var wordInContext = clone.WordsInContext[i];
                    if (SkipWord(wordInContext))
                    {
                        continue;
                    }

                    wordInContext.Lemma = productLemmas[i + 1];
                }
            }

            // Count results
            var count = await GetCount(clone);
            if (count > 0)
            {
                alternateSearch.Items.Add(
                    new AlternateSearchItem<SearchConcordances, SearchConcordancesResponse>()
                    {
                        Count = count,
                        Search = clone,
                        Title = GetTitle(clone),
                    });
            }
        }

        return alternateSearch;
    }

    private static SearchConcordances GetOriginalSearch(SearchConcordances search)
    {
        var original = search.Copy();
        original.MainWord.Lemma = null;
        if (!original.WordsInContext.IsNullOrEmpty())
        {
            foreach (var wordInContext in original.WordsInContext)
            {
                wordInContext.Lemma = null;
            }
        }

        return original;
    }

    private static string GetTitle(SearchConcordances search)
    {
        var sb = new StringBuilder();
        sb.Append(search.MainWord.Lemma);
        if (!search.WordsInContext.IsNullOrEmpty())
        {
            foreach (var wordInContext in search.WordsInContext)
            {
                sb.Append(' ');
                sb.Append(wordInContext.Lemma);
            }
        }

        return sb.ToString();
    }

    private static bool SkipWord(SearchedWordInContext wordInContext)
    {
        return wordInContext.ConditionType == ConditionType.IsNot || (string.IsNullOrEmpty(wordInContext.Form) && string.IsNullOrEmpty(wordInContext.Lemma));
    }

    private async Task<long> GetCount(SearchConcordances search)
    {
        var query = await queryFactory.GetQuery(search);
        var results = await searchEngine.Search<Concordance, ConcordancesQuery>(query);
        return results.Total;
    }

    private async Task<List<string>> GetLemmasForWord(SearchedWord word)
    {
        if (!string.IsNullOrEmpty(word.Form))
        {
            return await lemmatizationService.GetLemmas(word.Form);
        }

        return new List<string>();
    }
}