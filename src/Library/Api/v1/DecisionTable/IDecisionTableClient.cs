using ME.Sdk.Library.Api.v1.DecisionTable.Request;
using ME.Sdk.Library.Api.v1.DecisionTable.Response;

namespace ME.Sdk.Library.Api.v1.DecisionTable;

public interface IDecisionTableClient
{
    Task<CreateDecisionTableResponse> CreateAsync(CreateDecisionTableRequest request, string? correlationId, CancellationToken cancellationToken);
    Task<DeleteDecisionTableResponse> DeleteAsync(DeleteDecisionTableRequest request, string? correlationId, CancellationToken cancellationToken);
}