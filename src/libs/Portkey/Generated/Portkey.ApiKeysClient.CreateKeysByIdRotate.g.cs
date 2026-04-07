
#nullable enable

namespace Portkey
{
    public partial class ApiKeysClient
    {
        partial void PrepareCreateKeysByIdRotateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid id,
            global::Portkey.RotateApiKeyRequest request);
        partial void PrepareCreateKeysByIdRotateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid id,
            global::Portkey.RotateApiKeyRequest request);
        partial void ProcessCreateKeysByIdRotateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateKeysByIdRotateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Rotate API Key<br/>
        /// Rotates an existing API key and returns a newly generated key value.<br/>
        /// The previous key remains valid during the transition period and expires at `key_transition_expires_at`.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Portkey.RotateApiKeyResponse> CreateKeysByIdRotateAsync(
            global::System.Guid id,

            global::Portkey.RotateApiKeyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await CreateKeysByIdRotateAsResponseAsync(
                id: id,

                request: request,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Rotate API Key<br/>
        /// Rotates an existing API key and returns a newly generated key value.<br/>
        /// The previous key remains valid during the transition period and expires at `key_transition_expires_at`.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.RotateApiKeyResponse>> CreateKeysByIdRotateAsResponseAsync(
            global::System.Guid id,

            global::Portkey.RotateApiKeyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateKeysByIdRotateArguments(
                httpClient: HttpClient,
                id: ref id,
                request: request);

            var __pathBuilder = new global::Portkey.PathBuilder(
                path: $"/api-keys/{id}/rotate",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateKeysByIdRotateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                id: id,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateKeysByIdRotateResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCreateKeysByIdRotateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    var __value = global::Portkey.RotateApiKeyResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                    return new global::Portkey.AutoSDKHttpResponse<global::Portkey.RotateApiKeyResponse>(
                        statusCode: __response.StatusCode,
                        headers: global::Portkey.AutoSDKHttpResponse.CreateHeaders(__response),
                        body: __value);
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Portkey.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    var __value = await global::Portkey.RotateApiKeyResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                    return new global::Portkey.AutoSDKHttpResponse<global::Portkey.RotateApiKeyResponse>(
                        statusCode: __response.StatusCode,
                        headers: global::Portkey.AutoSDKHttpResponse.CreateHeaders(__response),
                        body: __value);
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Portkey.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Rotate API Key<br/>
        /// Rotates an existing API key and returns a newly generated key value.<br/>
        /// The previous key remains valid during the transition period and expires at `key_transition_expires_at`.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="keyTransitionPeriodMs">
        /// Optional transition period in milliseconds during which the previous key remains valid.<br/>
        /// Example: 3600000
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Portkey.RotateApiKeyResponse> CreateKeysByIdRotateAsync(
            global::System.Guid id,
            int? keyTransitionPeriodMs = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Portkey.RotateApiKeyRequest
            {
                KeyTransitionPeriodMs = keyTransitionPeriodMs,
            };

            return await CreateKeysByIdRotateAsync(
                id: id,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}