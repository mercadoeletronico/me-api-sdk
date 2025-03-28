using ME.Sdk.Library.Api.v1.PreOrder.Request;
using ME.Sdk.Library.Api.v1.PreOrder.Response;

namespace ME.Sdk.Library.Api.v1.PreOrder
{
    public interface IPreOrderClient
{
    Task<GetPreOrderResponse> GetPreOrderAsync(GetPreOrderRequest request, CancellationToken cancellationToken);
    }
}
}
