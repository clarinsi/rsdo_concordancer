using System;
using System.Collections.Generic;
using System.Linq;
using Rsdo.Concordancer.Core.Extensions;
using Rsdo.Concordancer.Core.Search.Queries.Concordances;
using Rsdo.Concordancer.ServiceModel.Shared;
using Rsdo.Concordancer.ServiceModel.Types;

namespace Rsdo.Concordancer.Services.Extensions;

public static class HighlighterExtensions
{
    public static void Highlight(this List<ConcordanceToken> tokens, ConcordancesQuery query, int centerTokenIndex)
    {
        var wordsInContextIndexes = query.WordsInContext.IsNullOrEmpty()
            ? new HashSet<int>()
            : GetWordsInContextIndexes(tokens, query, centerTokenIndex).ToHashSet();
        for (var i = 0; i < tokens.Count; i++)
        {
            // Center word
            if (i == centerTokenIndex)
            {
                tokens[i].IsCenterMatch = true;
            }

            if (wordsInContextIndexes.Contains(i))
            {
                tokens[i].IsWordInContextMatch = true;
            }
        }
    }

    private static bool CheckCandidateToken(List<ConcordanceToken> tokens, ConcordancesQuery query, int relativeTokenIndex, int absoluteTokenIndex)
    {
        foreach (var wordInContext in query.WordsInContext)
        {
            // Try to find candidates only on positive criteria
            if (wordInContext.ConditionType != ConditionType.Is)
            {
                continue;
            }

            var candidate = tokens[absoluteTokenIndex];

            if (!wordInContext.Positions.Contains(relativeTokenIndex))
            {
                continue;
            }

            if (!wordInContext.Form.IsNullOrEmpty())
            {
                if (!candidate.Form.Equals(wordInContext.Form, StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }
            }

            if (!wordInContext.Lemmas.IsNullOrEmpty())
            {
                if (!wordInContext.Lemmas.Any(l => l.Equals(candidate.Lemma, StringComparison.OrdinalIgnoreCase)))
                {
                    continue;
                }
            }

            return true;
        }

        return false;
    }

    private static IEnumerable<int> GetWordsInContextIndexes(List<ConcordanceToken> tokens, ConcordancesQuery query, int centerTokenIndex)
    {
        // Check up to 10 tokens to the right, since we cannot search in the left context of the main word
        var candidateTokenIndices = new List<int>();
        for (var i = centerTokenIndex + 1; i < tokens.Count; i++)
        {
            if (candidateTokenIndices.Count >= 10)
            {
                break;
            }

            if (tokens[i].Type is TokenType.Word or TokenType.PunctuationCharacter)
            {
                candidateTokenIndices.Add(i);
            }
        }

        for (var i = 0; i < candidateTokenIndices.Count; i++)
        {
            if (CheckCandidateToken(tokens, query, i + 1, candidateTokenIndices[i]))
            {
                yield return candidateTokenIndices[i];
            }
        }
    }
}