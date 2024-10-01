using ME.Sdk.Library.Api.v1.Ledger.Request;
using ME.Sdk.Library.Api.v1.Ledger.Response;

namespace ME.Sdk.Library.Api.v1.Ledger;

public class LedgerClient : ILedgerClient
{
    private readonly IApiHttpClient _httpClient;

    public LedgerClient(IApiHttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<CreateLedgerResponse> CreateAsync(CreateLedgerRequest request, string? correlationId, CancellationToken cancellationToken)
    {
        return await _httpClient.PostAsync<CreateLedgerResponse>($"/v1/ledgers", request, correlationId, cancellationToken);
    }

    public async Task<UpdateLedgerResponse> UpdateAsync(UpdateLedgerRequest request, string code, string? correlationId, CancellationToken cancellationToken)
    {
        return await _httpClient.PutAsync<UpdateLedgerResponse>($"/v1/ledgers/{code}", request, correlationId, cancellationToken);
    }

    public async Task<IList<GetAllLedgerResponse>> GetAllAsync(GetAllLedgerRequest request, CancellationToken cancellationToken)
    {
        return await _httpClient.GetPagingResultAsync<GetAllLedgerResponse>($"/v1/ledgers", cancellationToken);
    }

    public async Task<DeleteLedgerResponse> DeleteAsync(DeleteLedgerRequest request, string code, string? correlationId, CancellationToken cancellationToken)
    {
        return await _httpClient.PostAsync<DeleteLedgerResponse>($"/v1/ledgers/{code}/relationships/delete", request, correlationId, cancellationToken);
    }
}