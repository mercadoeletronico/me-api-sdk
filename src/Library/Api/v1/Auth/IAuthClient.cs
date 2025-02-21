using ME.Sdk.Library.Api.v1.Auth.Response;
using System.Threading;
using System.Threading.Tasks;

namespace ME.Sdk.Library.Api.v1.Auth
{
    public interface IAuthClient
    {
        Task<GetTokenResponse> GetTokenAsync(CancellationToken cancellationToken);
    }
}
