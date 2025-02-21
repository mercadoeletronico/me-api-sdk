using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ME.Sdk.Library.Common.Http
{
    public interface IHttpHandler
    {
        Task<TResponse> PostAsync<TResponse>(string endpoint, object payload, HttpHandlerOptions options);
        Task<TResponse> DeleteAsync<TResponse>(string endpoint, object payload, HttpHandlerOptions options);
        Task<TResponse> GetAsync<TResponse>(string endpoint, HttpHandlerOptions options);
        Task<TResponse> PutAsync<TResponse>(string endpoint, object payload, HttpHandlerOptions options);
    }

    public sealed class HttpHandlerOptions
    {
        public string? BearerToken { get; set; }
        public string? CorrelationId { get; set; }
        public CancellationToken CancellationToken { get; set; } = new CancellationToken();
    }
}
