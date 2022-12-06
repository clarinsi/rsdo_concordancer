using System;
using System.Collections.Generic;
using System.Linq;
using OpenSearch.Client;
using Rsdo.Concordancer.Core.Extensions;
using Rsdo.Concordancer.Core.Search.Queries.Concordances;
using Rsdo.Concordancer.Infrastructure.Extensions;

namespace Rsdo.Concordancer.Infrastructure.Search.QueryBuilders;

public class ConcordancesQueryBuilder : IQueryBuilder<ConcordancesQuery>
{
    public QueryContainer Build(ConcordancesQuery query)
    {
        // Get filter queries
        var queries = GetFilterQueries(query);

        // Main word query
        queries.Add(GetMainWordEsQuery(query.MainWord));

        // Words in context queries
        if (!query.WordsInContext.IsNullOrEmpty())
        {
            queries.AddRange(query.WordsInContext.Select(GetWordInContextEsQuery));
        }

        // Merge queries
        var mergedQuery = queries.ToBooleanAndQuery();

        // Check if we should return random rows (used in export)
        if (query.ReturnRandomRows)
        {
            mergedQuery = new FunctionScoreQuery()
            {
                Query = mergedQuery,
                Functions = new List<IScoreFunction>()
                {
                    new RandomScoreFunction()
                    {
                        Seed = DateTime.Now.Ticks,
                    },
                },
            };
        }

        return mergedQuery;
    }

    private static List<QueryContainer> GetFilterQueries(ConcordancesQuery query)
    {
        var queries = new List<QueryContainer>();

        if (!query.TextIds.IsNullOrEmpty())
        {
            queries.Add(
                new TermsQuery()
                {
                    Field = "textId",
                    Terms = query.TextIds.Cast<object>(),
                });
        }

        return queries;
    }

    private static QueryContainer GetMainWordEsQuery(SearchedMainWordQuery mainWordQuery)
    {
        return GetWordEsQuery(mainWordQuery, GetTokenField(0));
    }

    private static QueryContainer GetWordEsQuery(SearchedWordQuery wordQuery, string tokenField)
    {
        var queries = new List<QueryContainer>();

        if (!string.IsNullOrEmpty(wordQuery.Form))
        {
            queries.Add(
                new TermQuery()
                {
                    Field = $"{tokenField}.formLower",
                    Value = wordQuery.Form.ToLower(),
                });
        }

        if (!wordQuery.Lemmas.IsNullOrEmpty())
        {
            queries.Add(
                new TermsQuery()
                {
                    Field = $"{tokenField}.lemma",
                    Terms = wordQuery.Lemmas,
                });
        }

        if (queries.Count == 0)
        {
            return new MatchNoneQuery();
        }

        if (!wordQuery.Msds.IsNullOrEmpty())
        {
            queries.Add(
                new TermsQuery()
                {
                    Field = $"{tokenField}.msd",
                    Terms = wordQuery.Msds,
                });
        }

        return queries.ToBooleanAndQuery();
    }

    private static QueryContainer GetWordInContextEsQuery(SearchedWordInContextQuery searchedWord)
    {
        var queries = new List<QueryContainer>();
        foreach (var position in searchedWord.Positions)
        {
            var positionQuery = GetWordEsQuery(searchedWord, GetTokenField(position));
            queries.Add(positionQuery);
        }

        var query = queries.ToBooleanOrQuery();
        return searchedWord.ConditionType == ServiceModel.Types.ConditionType.Is ? query : !query;
    }

    private static string GetTokenField(int position)
    {
        return position switch
        {
            < 0 => $"tokenLeft{-position}",
            > 0 => $"tokenRight{position}",
            _ => "token",
        };
    }
}