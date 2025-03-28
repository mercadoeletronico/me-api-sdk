using ME.Sdk.Library.Api.v1.Bills.Request;
using ME.Sdk.Library.Api.v1.Bills.Response;
using ME.Sdk.Library.Common.Model;

namespace ME.Sdk.Library.Api.v1.Bills
{
    public class BillsClient : IBillsClient
{
    private readonly IApiHttpClient _httpClient;

    public BillsClient(IApiHttpClient httpClient)
    {
        _httpClient = httpClient;
    }

#if NET6_0_OR_GREATER
    public async Task<BulkInsertAccountsPayableResponse> BulkCreateAccountsPayableAsync(BulkCreateAccountsPayableRequest request, string? correlationId, CancellationToken cancellationToken)
    {
        return await _httpClient.PostAsync<BulkInsertAccountsPayableResponse>($"/v1/bills/accounts-payable/bulk",new MultiPartUpload(request.FileStream, request.FileName), correlationId, cancellationToken);
    }
#else
    public async Task<BulkInsertAccountsPayableResponse> BulkCreateAccountsPayableAsync(BulkCreateAccountsPayableRequest request, string correlationId, CancellationToken cancellationToken)
    {
        return await _httpClient.PostAsync<BulkInsertAccountsPayableResponse>($"/v1/bills/accounts-payable/bulk",new MultiPartUpload(request.FileStream, request.FileName), correlationId, cancellationToken);
    }
#endif
    }
}
