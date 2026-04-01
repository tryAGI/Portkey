
#nullable enable

namespace Portkey
{
    public partial class ApiKeysClient
    {
        partial void PrepareCreateKeysByTypeBySubTypeArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::Portkey.CreateKeysType type,
            ref global::Portkey.CreateKeysSubType subType,
            global::Portkey.CreateApiKeyObject request);
        partial void PrepareCreateKeysByTypeBySubTypeRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Portkey.CreateKeysType type,
            global::Portkey.CreateKeysSubType subType,
            global::Portkey.CreateApiKeyObject request);
        partial void ProcessCreateKeysByTypeBySubTypeResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateKeysByTypeBySubTypeResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create API Keys<br/>
        /// Creates a new API key.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="subType"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Portkey.CreateKeysResponse> CreateKeysByTypeBySubTypeAsync(
            global::Portkey.CreateKeysType type,
            global::Portkey.CreateKeysSubType subType,

            global::Portkey.CreateApiKeyObject request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateKeysByTypeBySubTypeArguments(
                httpClient: HttpClient,
                type: ref type,
                subType: ref subType,
                request: request);

            var __pathBuilder = new global::Portkey.PathBuilder(
                path: $"/api-keys/{type}/{subType}",
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
            PrepareCreateKeysByTypeBySubTypeRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                type: type,
                subType: subType,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateKeysByTypeBySubTypeResponse(
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
                ProcessCreateKeysByTypeBySubTypeResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Portkey.CreateKeysResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
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

                    return
                        await global::Portkey.CreateKeysResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
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
        /// Create API Keys<br/>
        /// Creates a new API key.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="subType"></param>
        /// <param name="name">
        /// Example: Development API Key
        /// </param>
        /// <param name="description">
        /// Example: API key for development environment
        /// </param>
        /// <param name="workspaceId">
        /// Example: ws-myworkspace
        /// </param>
        /// <param name="userId">
        /// **Required** when sub-type path parameter is 'user'. Not required when sub-type is 'service'.<br/>
        /// Example: c3d4e5f6-a7b8-6c7d-0e1f-2a3b4c5d6e7f
        /// </param>
        /// <param name="rateLimits"></param>
        /// <param name="usageLimits">
        /// Example: {"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}
        /// </param>
        /// <param name="scopes">
        /// Example: [completions.write]
        /// </param>
        /// <param name="defaults"></param>
        /// <param name="alertEmails"></param>
        /// <param name="expiresAt"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Portkey.CreateKeysResponse> CreateKeysByTypeBySubTypeAsync(
            global::Portkey.CreateKeysType type,
            global::Portkey.CreateKeysSubType subType,
            string name,
            global::System.Collections.Generic.IList<string> scopes,
            string? description = default,
            string? workspaceId = default,
            global::System.Guid? userId = default,
            global::System.Collections.Generic.IList<global::Portkey.CreateApiKeyObjectRateLimit>? rateLimits = default,
            global::Portkey.UsageLimits? usageLimits = default,
            global::Portkey.CreateApiKeyObjectDefaults? defaults = default,
            global::System.Collections.Generic.IList<string>? alertEmails = default,
            global::System.DateTime? expiresAt = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::Portkey.CreateApiKeyObject
            {
                Name = name,
                Description = description,
                WorkspaceId = workspaceId,
                UserId = userId,
                RateLimits = rateLimits,
                UsageLimits = usageLimits,
                Scopes = scopes,
                Defaults = defaults,
                AlertEmails = alertEmails,
                ExpiresAt = expiresAt,
            };

            return await CreateKeysByTypeBySubTypeAsync(
                type: type,
                subType: subType,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}