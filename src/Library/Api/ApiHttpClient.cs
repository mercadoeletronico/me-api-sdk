using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ME.Sdk.Library.Api.v1.Auth;
using ME.Sdk.Library.Common.Exceptions;
using ME.Sdk.Library.Common.Http;
using ME.Sdk.Library.Common.Model;

namespace ME.Sdk.Library.Api
{
public class ApiHttpClient : IApiHttpClient
{
    private readonly IHttpHandler _httpHandler;
    private readonly IAuthClient _authClient;

    public ApiHttpClient(IHttpHandler httpHandler, IAuthClient authClient)
    {
        _httpHandler = httpHandler;
        _authClient = authClient;
    }

    public async Task<TResponse> PostAsync<TResponse>(string endpoint, object payload, string? correlationId,
        CancellationToken cancellationToken)
    {
        return await Execute(async () =>
        {
            var bearer = await _authClient.GetTokenAsync(cancellationToken);
            return await _httpHandler.PostAsync<TResponse>(endpoint, payload,
                new HttpHandlerOptions
                {
                    BearerToken = bearer.AccessToken,
                    CorrelationId = correlationId,
                    CancellationToken = cancellationToken
                });
        }, cancellationToken);
    }

    public async Task<TResponse> DeleteAsync<TResponse>(string endpoint, object payload, string? correlationId,
        CancellationToken cancellationToken)
    {
        return await Execute(async () =>
        {
            var bearer = await _authClient.GetTokenAsync(cancellationToken);
            return await _httpHandler.DeleteAsync<TResponse>(endpoint, payload,
                new HttpHandlerOptions
                {
                    BearerToken = bearer.AccessToken,
                    CorrelationId = correlationId,
                    CancellationToken = cancellationToken
                });
        }, cancellationToken);
    }

    public async Task<TResponse> GetAsync<TResponse>(string endpoint, CancellationToken cancellationToken)
    {
        return await Execute(async () =>
        {
            var bearer = await _authClient.GetTokenAsync(cancellationToken);
            return await _httpHandler.GetAsync<TResponse>(endpoint,
                new HttpHandlerOptions { BearerToken = bearer.AccessToken, CancellationToken = cancellationToken });
        }, cancellationToken);
    }

    public async Task<IList<TResponse>> GetPagingResultAsync<TResponse>(string endpoint, CancellationToken cancellationToken)
    {
        var collection = new List<TResponse>();
        var pageNumber = 1;
        IList<TResponse> page;
        do
        {
            page = await Execute(async () =>
            {
                var bearer = await _authClient.GetTokenAsync(cancellationToken);
                var response = await _httpHandler.GetAsync<PagingResult<TResponse>>(
                    $"{endpoint}?pageNumber={pageNumber}&pageSize=100",
                    new HttpHandlerOptions {BearerToken = bearer.AccessToken, CancellationToken = cancellationToken});
                return response.Data;
            }, cancellationToken);
            pageNumber++;
            collection.AddRange(page);
        } while (page.Count >= 100);

        return collection;
    }

    public async Task<TResponse> PutAsync<TResponse>(string endpoint, object payload, string? correlationId,
        CancellationToken cancellationToken)
    {
        return await Execute(async () =>
        {
            var bearer = await _authClient.GetTokenAsync(cancellationToken);
            return await _httpHandler.PutAsync<TResponse>(endpoint, payload,
                new HttpHandlerOptions
                {
                    BearerToken = bearer.AccessToken,
                    CorrelationId = correlationId,
                    CancellationToken = cancellationToken
                });
        }, cancellationToken);
    }

    private static async Task<T> Execute<T>(Func<Task<T>> body, CancellationToken cancellationToken)
    {
        try
        {
            var data = await body();
            return data;
        }
        catch (TooManyRequestsException e)
        {
            if (e.ResetInSeconds < 0)
            {
                throw;
            }

            await Task.Delay((int)TimeSpan.FromSeconds(e.ResetInSeconds + 1).TotalMilliseconds, cancellationToken);
            return await body();
        }
    }
}
}
