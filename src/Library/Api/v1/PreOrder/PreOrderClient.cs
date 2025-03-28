using ME.Sdk.Library.Api.v1.PreOrder.Request;
using ME.Sdk.Library.Api.v1.PreOrder.Response;

namespace ME.Sdk.Library.Api.v1.PreOrder
{
    public class PreOrderClient : IPreOrderClient
{
    private readonly IApiHttpClient _httpClient;

    public PreOrderClient(IApiHttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<GetPreOrderResponse> GetPreOrderAsync(GetPreOrderRequest request, CancellationToken cancellationToken)
    {
        return await _httpClient.GetAsync<GetPreOrderResponse>($"/v1/pre-orders/{request.PreOrderId}", cancellationToken);
    }
}
}
}
