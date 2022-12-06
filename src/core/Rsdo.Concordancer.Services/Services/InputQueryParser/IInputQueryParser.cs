using System.Collections.Generic;
using System.Threading.Tasks;
using Rsdo.Concordancer.ServiceModel.Requests.Concordances;

namespace Rsdo.Concordancer.Services.Services.InputQueryParser;

public interface IInputQueryParser
{
    Task<(SearchedMainWord mainWord, List<SearchedWordInContext> wordsInContext)> Parse(string query);

    Task<List<(string word, bool inPhrase)>> ParseDefault(string query);
}