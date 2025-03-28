using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
namespace ME.Sdk.Library.Common.Exceptions
    {
    public class ForbiddenException : MEApiClientException
        {
#if NET6_0_OR_GREATER
    public ForbiddenException(string? message) : base(message)
#else
    public ForbiddenException(string message) : base(message)
#endif
        {
    }
}
}
