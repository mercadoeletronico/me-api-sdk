using System;

namespace ME.Sdk.Library.Common.Exceptions
{
    public class UnauthorizedException : MEApiClientException
    {
        public UnauthorizedException(string? message) : base(message)
        {
        }
    }
}
