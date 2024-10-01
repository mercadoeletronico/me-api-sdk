using ME.Sdk.Library.Api.v1.Ledger.Request;
using ME.Sdk.Library.Api.v1.Ledger.Response;

namespace ME.Sdk.Library.Api.v1.Ledger;

public interface ILedgerClient
{
    Task<CreateLedgerResponse> CreateAsync(CreateLedgerRequest request, string? correlationId, CancellationToken cancellationToken);
    Task<UpdateLedgerResponse> UpdateAsync(UpdateLedgerRequest request, string code, string? correlationId, CancellationToken cancellationToken);
    Task<IList<GetAllLedgerResponse>> GetAllAsync(GetAllLedgerRequest request, CancellationToken cancellationToken);
    Task<DeleteLedgerResponse> DeleteAsync(DeleteLedgerRequest request, string code, string? correlationId, CancellationToken cancellationToken);
}