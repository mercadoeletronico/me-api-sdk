using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
namespace ME.Sdk.Library.Api
    {
    public interface IApiHttpClient
        {
#if NET6_0_OR_GREATER
        Task<TResponse> PostAsync<TResponse>(string endpoint, object payload, string? correlationId, CancellationToken cancellationToken);
        Task<TResponse> PutAsync<TResponse>(string endpoint, object payload, string? correlationId, CancellationToken cancellationToken);
        Task<TResponse> DeleteAsync<TResponse>(string endpoint, object payload, string? correlationId, CancellationToken cancellationToken);
#else
        Task<TResponse> PostAsync<TResponse>(string endpoint, object payload, string correlationId, CancellationToken cancellationToken);
        Task<TResponse> PutAsync<TResponse>(string endpoint, object payload, string correlationId, CancellationToken cancellationToken);
        Task<TResponse> DeleteAsync<TResponse>(string endpoint, object payload, string correlationId, CancellationToken cancellationToken);
#endif
        Task<TResponse> GetAsync<TResponse>(string endpoint, CancellationToken cancellationToken);
        Task<IList<TResponse>> GetPagingResultAsync<TResponse>(string endpoint, CancellationToken cancellationToken);
    }
}
