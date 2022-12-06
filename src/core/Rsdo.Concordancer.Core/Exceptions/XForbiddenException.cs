using System;

namespace Rsdo.Concordancer.Core.Exceptions;

public class XForbiddenException : Exception
{
    public XForbiddenException()
    {
    }

    public XForbiddenException(string message)
        : base(message)
    {
    }

    public XForbiddenException(string message, Exception inner)
        : base(message, inner)
    {
    }
}