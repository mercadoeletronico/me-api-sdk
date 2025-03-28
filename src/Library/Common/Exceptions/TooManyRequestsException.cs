using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
namespace ME.Sdk.Library.Common.Exceptions
    {
    public class TooManyRequestsException : MEApiClientException
        {
    public int ResetInSeconds { get; set; }
#if NET6_0_OR_GREATER
    public TooManyRequestsException(string? message, int resetInSeconds) : base(message)
        {
        ResetInSeconds = resetInSeconds;
    }
#else
    public TooManyRequestsException(string message, int resetInSeconds) : base(message)
        {
        ResetInSeconds = resetInSeconds;
    }
#endif
}
}
