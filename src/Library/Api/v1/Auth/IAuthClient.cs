using ME.Sdk.Library.Api.v1.Auth.Response;

namespace ME.Sdk.Library.Api.v1.Auth
{
    public interface IAuthClient
{
    Task<GetTokenResponse> GetTokenAsync(CancellationToken cancellationToken);
    }
}
