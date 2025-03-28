using ME.Sdk.Library.Api.v1.DecisionTable.Request;
using ME.Sdk.Library.Api.v1.DecisionTable.Response;

namespace ME.Sdk.Library.Api.v1.DecisionTable
{

    public interface IDecisionTableClient
{
    Task<CreateDecisionTableResponse> CreateAsync(CreateDecisionTableRequest request,
#if NET6_0_OR_GREATER
        string? correlationId,
#else
        string correlationId,
#endif
        CancellationToken cancellationToken);
    Task<DeleteDecisionTableResponse> DeleteAsync(DeleteDecisionTableRequest request,
#if NET6_0_OR_GREATER
        string? correlationId,
#else
        string correlationId,
#endif
        CancellationToken cancellationToken);
    Task<IList<GetDecisionTableResponse>> GetAsync(GetDecisionTableRequest request, CancellationToken cancellationToken);
}
}
