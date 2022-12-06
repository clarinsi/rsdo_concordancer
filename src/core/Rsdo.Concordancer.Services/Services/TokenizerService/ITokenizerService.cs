using System.Collections.Generic;
using System.Threading.Tasks;
using Rsdo.Concordancer.ServiceModel.Types;

namespace Rsdo.Concordancer.Services.Services.TokenizerService;

public interface ITokenizerService
{
    Task<IEnumerable<(TokenType type, string form)>> Tokenize(string query);
}