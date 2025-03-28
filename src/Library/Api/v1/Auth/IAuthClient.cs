using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ME.Sdk.Library.Api.v1.Auth.Response;

namespace ME.Sdk.Library.Api.v1.Auth
    {
    public interface IAuthClient
        {
        Task<GetTokenResponse> GetTokenAsync(CancellationToken cancellationToken);
    }
}
