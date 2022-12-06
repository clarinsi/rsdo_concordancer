using System;

namespace Rsdo.Concordancer.Core.Search.Queries;

public abstract class Query
{
    public int From { get; set; } = 0;

    public int Size { get; set; } = 20;
}