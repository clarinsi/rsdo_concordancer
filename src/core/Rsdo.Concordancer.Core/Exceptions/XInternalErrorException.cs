using System;

namespace Rsdo.Concordancer.Core.Exceptions;

public class XInternalErrorException : Exception
{
    public XInternalErrorException()
    {
    }

    public XInternalErrorException(string message)
        : base(message)
    {
    }

    public XInternalErrorException(string message, Exception inner)
        : base(message, inner)
    {
    }
}