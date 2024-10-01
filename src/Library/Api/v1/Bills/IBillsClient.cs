using ME.Sdk.Library.Api.v1.Bills.Request;
using ME.Sdk.Library.Api.v1.Bills.Response;

namespace ME.Sdk.Library.Api.v1.Bills;

public interface IBillsClient
{
    Task<BulkInsertAccountsPayableResponse> BulkCreateAccountsPayableAsync(BulkCreateAccountsPayableRequest request, string? correlationId, CancellationToken cancellationToken);
}
