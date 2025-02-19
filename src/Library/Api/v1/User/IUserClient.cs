using ME.Sdk.Library.Api.v1.User.Request;
using ME.Sdk.Library.Api.v1.User.Response;

namespace ME.Sdk.Library.Api.v1.User;

public interface IUserClient
{
    Task<GetUserResponse> GetUserAsync(GetUserRequest request, CancellationToken cancellationToken);
    Task<IList<GetUserBusinessOrganizationsResponse>> GetUserBusinessOrganizationsAsync(GetUserBusinessOrganizationsRequest request, CancellationToken cancellationToken);
    Task<IList<GetAllResponse>> GetAllAsync(GetAllRequest request, CancellationToken cancellationToken);
    Task<CreateUserResponse> CreateAsync(CreateUserRequest request, string? correlationId, CancellationToken cancellationToken);
    Task<UpdateUserResponse> UpdateAsync(UpdateUserRequest request, string? correlationId, CancellationToken cancellationToken);
    Task<IList<GetUserPurchasingGroupsResponse>> GetUserPurchasingGroupsAsync(GetUserPurchasingGroupsRequest request, CancellationToken cancellationToken);
    Task<IList<GetUserCostCentersResponse>> GetUserCostCentersAsync(GetUserCostCentersRequest request, CancellationToken cancellationToken);
}
