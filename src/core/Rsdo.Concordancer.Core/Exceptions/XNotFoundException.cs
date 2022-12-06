using System;

namespace Rsdo.Concordancer.Core.Exceptions;

public class XNotFoundException : Exception
{
    public XNotFoundException()
    {
    }

    public XNotFoundException(string message)
        : base(message)
    {
    }

    public XNotFoundException(string message, Exception inner)
        : base(message, inner)
    {
    }
}