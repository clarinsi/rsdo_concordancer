using System.Threading;
using Rsdo.Concordancer.Core.Interfaces;

namespace Rsdo.Concordancer.Core.Framework;

public static class CurrentContext
{
    private static readonly AsyncLocal<ICurrentContext> CurrentContextValue = new();

    public static ICurrentContext Current
    {
        get => CurrentContextValue.Value;
        set => CurrentContextValue.Value = value;
    }
}