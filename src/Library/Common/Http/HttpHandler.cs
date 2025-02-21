using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using ME.Sdk.Library.Common.Exceptions;
using ME.Sdk.Library.Common.Model;
using Microsoft.Extensions.Logging;
using Polly;
using Polly.Retry;

namespace ME.Sdk.Library.Common.Http
{
    public class HttpHandler : IHttpHandler, IDisposable
{
    private readonly HttpClient _client;
    private const string CorrelationHeader = "X-ME-CORRELATION-ID";
    private const string RateLimitResetHeader = "RateLimit-Reset";
    private readonly ILogger<HttpHandler> _logger;
    private readonly AsyncRetryPolicy<HttpResponseMessage> _policy;

    public HttpHandler(MEApiSettings settings)
    {
        _logger = new LoggerFactory().CreateLogger<HttpHandler>();
        _client = new HttpClient {BaseAddress = new Uri(settings.BaseAddress)};
        _client.DefaultRequestHeaders.Add("User-Agent", "ME-SDK");
        _policy = Policy
            .Handle<HttpRequestException>()
            .OrResult<HttpResponseMessage>(r => r.StatusCode >= HttpStatusCode.InternalServerError)
            .WaitAndRetryAsync(settings.Retries, attempt => TimeSpan.FromSeconds(settings.SleepDurationInSeconds * attempt),
                (exception, timeSpan, retryCount, context) =>
                {
                    _logger.LogWarning(exception.Exception, "Attempt {retryCount} failed. Retrying again...",
                        retryCount);
                });
    }

    public Task<TResponse> PostAsync<TResponse>(string endpoint, object payload, HttpHandlerOptions options)
    {
        return SendAsync<TResponse>(HttpMethod.Post, endpoint, payload, options);
    }

    public Task<TResponse> PutAsync<TResponse>(string endpoint, object payload, HttpHandlerOptions options)
    {
        return SendAsync<TResponse>(HttpMethod.Put, endpoint, payload, options);
    }

    public Task<TResponse> DeleteAsync<TResponse>(string endpoint, object payload, HttpHandlerOptions options)
    {
        return SendAsync<TResponse>(HttpMethod.Delete, endpoint, payload, options);
    }

    public async Task<TResponse> GetAsync<TResponse>(string endpoint, HttpHandlerOptions options)
    {
        var response = await _policy.ExecuteAsync(() =>
        {
            var request = new HttpRequestMessage(HttpMethod.Get, endpoint);
            if (!string.IsNullOrEmpty(options.BearerToken))
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", options.BearerToken);
            if (!string.IsNullOrEmpty(options.CorrelationId))
                request.Headers.Add(CorrelationHeader, options.CorrelationId);            
            return _client.SendAsync(request, options.CancellationToken);
        });
        if (!response.IsSuccessStatusCode)
            await HandleError(response, options.CancellationToken, _logger);

        var responseContent = response.Content.ReadAsStringAsync().Result;
        return JsonSerializer.Deserialize<TResponse>(responseContent,
            options: new JsonSerializerOptions {PropertyNameCaseInsensitive = true})!;
    }

    private async Task<TResponse> SendAsync<TResponse>(HttpMethod method, string endpoint, object payload,
        HttpHandlerOptions options)
    {

        var response = await _policy.ExecuteAsync(() =>
        {
            var request = new HttpRequestMessage(method, endpoint);
            if (payload is MultiPartUpload multiPart)
            {
                var fileContent = new StreamContent(multiPart.Stream);
                fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");
                request.Content = new MultipartFormDataContent {{fileContent, multiPart.Name, multiPart.FileName}};
            }
            else
            {
                request.Content = new StringContent(
                    JsonSerializer.Serialize(payload,
                        options: new JsonSerializerOptions {PropertyNamingPolicy = JsonNamingPolicy.CamelCase}),
                    Encoding.UTF8, "application/json");
            }

            if (!string.IsNullOrEmpty(options.BearerToken))
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", options.BearerToken);
            if (!string.IsNullOrEmpty(options.CorrelationId))
                request.Headers.Add(CorrelationHeader, options.CorrelationId);

            return _client.SendAsync(request, options.CancellationToken);
        });
        if (!response.IsSuccessStatusCode)
            await HandleError(response, options.CancellationToken, _logger);

        var responseContent = response.Content.ReadAsStringAsync().Result;
        return JsonSerializer.Deserialize<TResponse>(responseContent,
            options: new JsonSerializerOptions {PropertyNameCaseInsensitive = true})!;
    }

    private static async Task HandleError(HttpResponseMessage response, CancellationToken cancellationToken, ILogger logger)
    {
        switch (response.StatusCode)
        {
            case (HttpStatusCode)429: // TooManyRequests
                {
                    if (response.Headers.TryGetValues(RateLimitResetHeader, out var values))
                    {
                        if (int.TryParse(values.First(), out int reset))
                        {
                            logger.LogWarning("Too many requests, waiting for {Seconds} seconds", reset);
                            throw new TooManyRequestsException("too many exception", reset);
                        }
                    }

                    throw new TooManyRequestsException("too many exception", -1);
                }

            case HttpStatusCode.Unauthorized:
                throw new UnauthorizedException("unauthorized");
        }

        var error = JsonSerializer.Deserialize<HttpErrorResponse>(
            await response.Content.ReadAsStringAsync(),
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        var message = error?.Detail ?? error?.Title ?? "Something went wrong.";

        throw response.StatusCode switch
        {
            HttpStatusCode.NotFound => new NotFoundException(message),
            HttpStatusCode.BadRequest => new BadRequestException(message),
            HttpStatusCode.Forbidden => new ForbiddenException(message),
            _ => new MEApiClientException(message)
        };
    }

    public void Dispose()
    {
        _client.Dispose();
    }
}
}
