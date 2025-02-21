using System;

namespace ME.Sdk.Library.Common.Exceptions
{
    public class MEApiClientException : Exception
    {
        public MEApiClientException(string? message) : base(message)
        {
        }
    }
}
