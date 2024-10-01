using ME.Sdk.Library.Api.v1.PreRequest.Request;
using ME.Sdk.Library.Api.v1.PreRequest.Response;

namespace ME.Sdk.Library.Api.v1.PreRequest;

public class PreRequestClient : IPreRequestClient
{
    private readonly IApiHttpClient _httpClient;

    public PreRequestClient(IApiHttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task<GetPreRequestResponse> GetPreRequestAsync(GetPreRequestRequest request, CancellationToken cancellationToken)
    {
        return await _httpClient.GetAsync<GetPreRequestResponse>($"/v1/pre-requests/{request.PreRequestId}", cancellationToken);
    }

    public async Task<ApprovePreRequestResponse> ApprovePreRequestAsync(ApprovePreRequestRequest request, string correlationId, CancellationToken cancellationToken)
    {
        return await _httpClient.PostAsync<ApprovePreRequestResponse>($"/v1/pre-requests/{request.PreRequestId}/approve", new {}, correlationId, cancellationToken);
    }

    public async Task<RejectPreRequestResponse> RejectPreRequestAsync(RejectPreRequestRequest request, string correlationId, CancellationToken cancellationToken)
    {
        return await _httpClient.PostAsync<RejectPreRequestResponse>($"/v1/pre-requests/{request.PreRequestId}/reject", new {}, correlationId, cancellationToken);
    }
}