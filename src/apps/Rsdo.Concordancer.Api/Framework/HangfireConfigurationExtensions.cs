using Hangfire;
using Newtonsoft.Json;

namespace Rsdo.Concordancer.Api.Framework;

public static class HangfireConfigurationExtensions
{
    public static void UseMediator(this IGlobalConfiguration configuration)
    {
        var jsonSettings = new JsonSerializerSettings()
        {
            TypeNameHandling = TypeNameHandling.All,
        };
        configuration.UseSerializerSettings(jsonSettings);
    }
}