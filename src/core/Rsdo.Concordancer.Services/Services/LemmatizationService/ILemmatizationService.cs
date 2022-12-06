using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rsdo.Concordancer.Services.Services.LemmatizationService;

public interface ILemmatizationService
{
    Task<List<string>> GetLemmas(string form);
}