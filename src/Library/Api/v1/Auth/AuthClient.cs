using ME.Sdk.Library.Api.v1.Auth.Request;
using ME.Sdk.Library.Api.v1.Auth.Response;
using ME.Sdk.Library.Common.Http;

namespace ME.Sdk.Library.Api.v1.Auth
{

    public class AuthClient : IAuthClient
{
    private DateTime? _expiration;
    private GetTokenResponse? _cache;
    private readonly IHttpHandler _httpHandler;
    private readonly GetTokenRequest _credentials;

    public AuthClient(MEApiSettings settings, IHttpHandler httpHandler)
    {
        _httpHandler = httpHandler;
        _credentials = new GetTokenRequest { ClientId = settings.ClientId, ClientSecret = settings.ClientSecret };
    }

    public async Task<GetTokenResponse> GetTokenAsync(CancellationToken cancellationToken)
    {
        if (_expiration != null && _expiration > DateTime.Now)
            return _cache;

        var token = await _httpHandler.PostAsync<GetTokenResponse>("/v1/auth/tokens", _credentials,
            new HttpHandlerOptions { CancellationToken = cancellationToken });

        _cache = token;
        _expiration = DateTime.Now.AddSeconds(token.ExpiresIn - 30);
        return token;
    }
}
