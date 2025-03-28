using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
namespace ME.Sdk.Library.Common.Exceptions
    {
    public class BadRequestException : MEApiClientException
        {
#if NET6_0_OR_GREATER
    public BadRequestException(string? message) : base(message)
#else
    public BadRequestException(string message) : base(message)
#endif
        {
    }
}
}
