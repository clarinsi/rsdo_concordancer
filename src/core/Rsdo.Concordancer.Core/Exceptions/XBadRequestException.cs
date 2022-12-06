using System;

namespace Rsdo.Concordancer.Core.Exceptions;

public class XBadRequestException : Exception
{
    public XBadRequestException()
    {
    }

    public XBadRequestException(string message)
        : base(message)
    {
    }

    public XBadRequestException(string message, Exception inner)
        : base(message, inner)
    {
    }
}