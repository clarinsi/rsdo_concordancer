using System;
using OpenSearch.Client;

namespace Rsdo.Concordancer.Infrastructure.Search.Extensions;

public static class ElasticResponseExtensions
{
    public static void ThrowIfInvalid(this IResponse response)
    {
        if (!response.IsValid)
        {
            throw new Exception($"Invalid Elastic response: {response.DebugInformation}!");
        }
    }
}