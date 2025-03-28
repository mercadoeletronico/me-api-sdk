using ME.Sdk.Library.Api.v1.User.Request;
using ME.Sdk.Library.Api.v1.User.Response;

namespace ME.Sdk.Library.Api.v1.User
{

    public class UserClient : IUserClient
{
    private readonly IApiHttpClient _httpClient;

    public UserClient(IApiHttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task<GetUserResponse> GetUserAsync(GetUserRequest request, CancellationToken cancellationToken)
    {
        return await _httpClient.GetAsync<GetUserResponse>($"/v1/users/{request.UserId}", cancellationToken);
    }

    public async Task<IList<GetUserBusinessOrganizationsResponse>> GetUserBusinessOrganizationsAsync(GetUserBusinessOrganizationsRequest request,
        CancellationToken cancellationToken)
    {
        return await _httpClient.GetPagingResultAsync<GetUserBusinessOrganizationsResponse>($"/v1/users/{request.UserId}/business-organizations", cancellationToken);
    }

    public async Task<IList<GetAllResponse>> GetAllAsync(GetAllRequest request, CancellationToken cancellationToken)
    {
        return await _httpClient.GetPagingResultAsync<GetAllResponse>($"/v1/users", cancellationToken);
    }
}
