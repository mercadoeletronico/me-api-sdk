using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ME.Sdk.Library.Api
{
    public interface IApiHttpClient
    {
        Task<TResponse> PostAsync<TResponse>(string endpoint, object payload, string? correlationId, CancellationToken cancellationToken);
        Task<TResponse> PutAsync<TResponse>(string endpoint, object payload, string? correlationId, CancellationToken cancellationToken);
        Task<TResponse> DeleteAsync<TResponse>(string endpoint, object payload, string? correlationId, CancellationToken cancellationToken);
        Task<TResponse> GetAsync<TResponse>(string endpoint, CancellationToken cancellationToken);
        Task<IList<TResponse>> GetPagingResultAsync<TResponse>(string endpoint, CancellationToken cancellationToken);
    }
}
