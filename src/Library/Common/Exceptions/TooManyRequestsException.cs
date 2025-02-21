using System;

namespace ME.Sdk.Library.Common.Exceptions
{
    public class TooManyRequestsException : MEApiClientException
    {
        public int ResetInSeconds { get; set; }
        public TooManyRequestsException(string? message, int resetInSeconds) : base(message)
        {
            ResetInSeconds = resetInSeconds;
        }
    }
}
