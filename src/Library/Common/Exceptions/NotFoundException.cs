using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
namespace ME.Sdk.Library.Common.Exceptions
    {
    public class NotFoundException : MEApiClientException
        {
#if NET6_0_OR_GREATER
    public NotFoundException(string? message) : base(message)
        {
    }
#else
    public NotFoundException(string message) : base(message)
        {
    }
#endif
}
}
