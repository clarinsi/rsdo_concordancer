using System.Linq;
using System.Threading.Tasks;

namespace Rsdo.Concordancer.Services.Services.TokenizerService;

public class DefaultTokenizerService : BaseTokenizerService
{
    protected override Task<string> GetXml(string query)
    {
        var words = query.Split(' ').Where(s => !string.IsNullOrEmpty(s)).ToList();
        var xml = "<p>" + string.Join(string.Empty, words.Select(w => $"<w>{w}</w>").ToArray()) + "</p>";
        return Task.FromResult(xml);
    }
}