using ME.Sdk.Library.Api.v1.Invoice.Request;
using ME.Sdk.Library.Api.v1.Invoice.Response;

namespace ME.Sdk.Library.Api.v1.Invoice
{
    public class InvoiceClient : IInvoiceClient
{
    private readonly IApiHttpClient _httpClient;

    public InvoiceClient(IApiHttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<GetInvoiceResponse> GetInvoiceAsync(GetInvoiceRequest request, CancellationToken cancellationToken)
    {
        return await _httpClient.GetAsync<GetInvoiceResponse>($"/v1/invoices/{request.InvoiceId}", cancellationToken);  
    }

    public async Task<IList<GetInvoiceItemsResponse>> GetInvoiceItemsAsync(GetInvoiceItemsRequest request, CancellationToken cancellationToken)
    {
        return await _httpClient.GetPagingResultAsync<GetInvoiceItemsResponse>($"/v1/invoices/{request.InvoiceId}/items", cancellationToken); 
    }

    public async Task<IList<GetInvoiceAttributesResponse>> GetInvoiceAttributesAsync(GetInvoiceAttributesRequest request, CancellationToken cancellationToken)
    {
        return await _httpClient.GetPagingResultAsync<GetInvoiceAttributesResponse>($"/v1/invoices/{request.InvoiceId}/attributes", cancellationToken);
    }

    public async Task<IList<GetInvoiceBusinessOrganizationsResponse>> GetInvoiceBusinessOrganizationsAsync(GetInvoiceBusinessOrganizationsRequest request,
        CancellationToken cancellationToken)
    {
        return await _httpClient.GetPagingResultAsync<GetInvoiceBusinessOrganizationsResponse>($"/v1/invoices/{request.InvoiceId}/business-organizations", cancellationToken);
    }
}
}
