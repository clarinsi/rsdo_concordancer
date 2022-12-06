using System.Threading.Tasks;

namespace Rsdo.Concordancer.Services.Services.PartOfSpeechService;

public interface IPartOfSpeechService
{
    Task<string> GetMsdDescriptionByCode(string code);
}