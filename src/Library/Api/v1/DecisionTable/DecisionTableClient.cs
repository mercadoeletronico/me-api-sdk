using ME.Sdk.Library.Api.v1.DecisionTable.Request;
using ME.Sdk.Library.Api.v1.DecisionTable.Response;

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ME.Sdk.Library.Api.v1.DecisionTable
{
    public class DecisionTableClient : IDecisionTableClient
    {
        private readonly IApiHttpClient _httpClient;

        public DecisionTableClient(IApiHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CreateDecisionTableResponse> CreateAsync(CreateDecisionTableRequest request, string? correlationId, CancellationToken cancellationToken)
        {
            return await _httpClient.PostAsync<CreateDecisionTableResponse>($"/v1/decision-table", request, correlationId, cancellationToken);
        }

        public async Task<DeleteDecisionTableResponse> DeleteAsync(DeleteDecisionTableRequest request, string? correlationId, CancellationToken cancellationToken)
        {
            return await _httpClient.DeleteAsync<DeleteDecisionTableResponse>($"/v1/decision-table", request, correlationId, cancellationToken);
        }
    }
}
