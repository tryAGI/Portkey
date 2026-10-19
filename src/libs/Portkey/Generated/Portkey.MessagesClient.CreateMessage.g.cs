
#nullable enable

namespace Portkey
{
    public partial class MessagesClient
    {

        private static readonly global::Portkey.AutoSDKServer[] s_CreateMessageServers = new global::Portkey.AutoSDKServer[]
        {            new global::Portkey.AutoSDKServer(
                id: "https-api-portkey-ai-v1",
                name: "Portkey API Public Endpoint",
                url: "https://api.portkey.ai/v1",
                description: "Portkey API Public Endpoint"),
            new global::Portkey.AutoSDKServer(
                id: "self-hosted-gateway-url",
                name: "Self-Hosted Gateway URL",
                url: "SELF_HOSTED_GATEWAY_URL",
                description: "Self-Hosted Gateway URL"),
        };


        private static readonly global::Portkey.EndPointSecurityRequirement s_CreateMessageSecurityRequirement0 =
            new global::Portkey.EndPointSecurityRequirement
            {
                Authorizations = new global::Portkey.EndPointAuthorizationRequirement[]
                {                    new global::Portkey.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "ApikeyXPortkeyApiKey",
                        Location = "Header",
                        Name = "x-portkey-api-key",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::Portkey.EndPointSecurityRequirement[] s_CreateMessageSecurityRequirements =
            new global::Portkey.EndPointSecurityRequirement[]
            {                s_CreateMessageSecurityRequirement0,
            };
        partial void PrepareCreateMessageArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xPortkeyTraceId,
            ref string? xPortkeySpanId,
            ref string? xPortkeyParentSpanId,
            ref string? xPortkeySpanName,
            object? xPortkeyMetadata,
            global::Portkey.CreateMessageRequest request);
        partial void PrepareCreateMessageRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xPortkeyTraceId,
            string? xPortkeySpanId,
            string? xPortkeyParentSpanId,
            string? xPortkeySpanName,
            object? xPortkeyMetadata,
            global::Portkey.CreateMessageRequest request);
        partial void ProcessCreateMessageResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateMessageResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Messages<br/>
        /// Anthropic-native Messages API. Send a structured list of input messages with text, image, or document content and receive a response from Claude.<br/>
        /// This endpoint proxies the [Anthropic Messages API](https://docs.anthropic.com/en/api/messages) and supports all Claude-compatible providers:<br/>
        /// - **Anthropic** (direct)<br/>
        /// - **AWS Bedrock** (Claude models)<br/>
        /// - **Google Vertex AI** (Claude models)<br/>
        /// - **Azure AI Foundry** (Anthropic models) — set `azure_foundry_url` in your provider to `https://{resource}.services.ai.azure.com/anthropic`<br/>
        /// Native Anthropic features like extended thinking, prompt caching, streaming with `x-portkey-*` headers, and tool use are all fully supported.
        /// </summary>
        /// <param name="xPortkeyTraceId"></param>
        /// <param name="xPortkeySpanId"></param>
        /// <param name="xPortkeyParentSpanId"></param>
        /// <param name="xPortkeySpanName"></param>
        /// <param name="xPortkeyMetadata"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Portkey.CreateMessageResponse> CreateMessageAsync(

            global::Portkey.CreateMessageRequest request,
            string? xPortkeyTraceId = default,
            string? xPortkeySpanId = default,
            string? xPortkeyParentSpanId = default,
            string? xPortkeySpanName = default,
            object? xPortkeyMetadata = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await CreateMessageAsResponseAsync(

                request: request,
                xPortkeyTraceId: xPortkeyTraceId,
                xPortkeySpanId: xPortkeySpanId,
                xPortkeyParentSpanId: xPortkeyParentSpanId,
                xPortkeySpanName: xPortkeySpanName,
                xPortkeyMetadata: xPortkeyMetadata,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Messages<br/>
        /// Anthropic-native Messages API. Send a structured list of input messages with text, image, or document content and receive a response from Claude.<br/>
        /// This endpoint proxies the [Anthropic Messages API](https://docs.anthropic.com/en/api/messages) and supports all Claude-compatible providers:<br/>
        /// - **Anthropic** (direct)<br/>
        /// - **AWS Bedrock** (Claude models)<br/>
        /// - **Google Vertex AI** (Claude models)<br/>
        /// - **Azure AI Foundry** (Anthropic models) — set `azure_foundry_url` in your provider to `https://{resource}.services.ai.azure.com/anthropic`<br/>
        /// Native Anthropic features like extended thinking, prompt caching, streaming with `x-portkey-*` headers, and tool use are all fully supported.
        /// </summary>
        /// <param name="xPortkeyTraceId"></param>
        /// <param name="xPortkeySpanId"></param>
        /// <param name="xPortkeyParentSpanId"></param>
        /// <param name="xPortkeySpanName"></param>
        /// <param name="xPortkeyMetadata"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.CreateMessageResponse>> CreateMessageAsResponseAsync(

            global::Portkey.CreateMessageRequest request,
            string? xPortkeyTraceId = default,
            string? xPortkeySpanId = default,
            string? xPortkeyParentSpanId = default,
            string? xPortkeySpanName = default,
            object? xPortkeyMetadata = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateMessageArguments(
                httpClient: HttpClient,
                xPortkeyTraceId: ref xPortkeyTraceId,
                xPortkeySpanId: ref xPortkeySpanId,
                xPortkeyParentSpanId: ref xPortkeyParentSpanId,
                xPortkeySpanName: ref xPortkeySpanName,
                xPortkeyMetadata: xPortkeyMetadata,
                request: request);


            var __authorizations = global::Portkey.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateMessageSecurityRequirements,
                operationName: "CreateMessageAsync");

            using var __timeoutCancellationTokenSource = global::Portkey.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Portkey.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Portkey.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Portkey.PathBuilder(
                                path: "/messages",
                                baseUri: ResolveBaseUri(
                                servers: s_CreateMessageServers,
                                defaultBaseUrl: "https://api.portkey.ai/v1"));
                            var __path = __pathBuilder.ToString();
                __path = global::Portkey.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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

            if (xPortkeyTraceId != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-portkey-trace-id", xPortkeyTraceId.ToString());
            }
            if (xPortkeySpanId != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-portkey-span-id", xPortkeySpanId.ToString());
            }
            if (xPortkeyParentSpanId != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-portkey-parent-span-id", xPortkeyParentSpanId.ToString());
            }
            if (xPortkeySpanName != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-portkey-span-name", xPortkeySpanName.ToString());
            }
            if (xPortkeyMetadata != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-portkey-metadata", xPortkeyMetadata.ToString());
            }

                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::Portkey.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateMessageRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    xPortkeyTraceId: xPortkeyTraceId,
                    xPortkeySpanId: xPortkeySpanId,
                    xPortkeyParentSpanId: xPortkeyParentSpanId,
                    xPortkeySpanName: xPortkeySpanName,
                    xPortkeyMetadata: xPortkeyMetadata,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Portkey.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Portkey.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateMessage",
                                methodName: "CreateMessageAsync",
                                pathTemplate: "\"/messages\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Portkey.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Portkey.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Portkey.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateMessage",
                                methodName: "CreateMessageAsync",
                                pathTemplate: "\"/messages\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Portkey.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Portkey.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Portkey.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Portkey.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Portkey.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateMessage",
                                methodName: "CreateMessageAsync",
                                pathTemplate: "\"/messages\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Portkey.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessCreateMessageResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Portkey.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Portkey.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateMessage",
                                methodName: "CreateMessageAsync",
                                pathTemplate: "\"/messages\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Portkey.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Portkey.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateMessage",
                                methodName: "CreateMessageAsync",
                                pathTemplate: "\"/messages\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessCreateMessageResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Portkey.CreateMessageResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Portkey.AutoSDKHttpResponse<global::Portkey.CreateMessageResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Portkey.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Portkey.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Portkey.CreateMessageResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Portkey.AutoSDKHttpResponse<global::Portkey.CreateMessageResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Portkey.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::Portkey.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Messages<br/>
        /// Anthropic-native Messages API. Send a structured list of input messages with text, image, or document content and receive a response from Claude.<br/>
        /// This endpoint proxies the [Anthropic Messages API](https://docs.anthropic.com/en/api/messages) and supports all Claude-compatible providers:<br/>
        /// - **Anthropic** (direct)<br/>
        /// - **AWS Bedrock** (Claude models)<br/>
        /// - **Google Vertex AI** (Claude models)<br/>
        /// - **Azure AI Foundry** (Anthropic models) — set `azure_foundry_url` in your provider to `https://{resource}.services.ai.azure.com/anthropic`<br/>
        /// Native Anthropic features like extended thinking, prompt caching, streaming with `x-portkey-*` headers, and tool use are all fully supported.
        /// </summary>
        /// <param name="xPortkeyTraceId"></param>
        /// <param name="xPortkeySpanId"></param>
        /// <param name="xPortkeyParentSpanId"></param>
        /// <param name="xPortkeySpanName"></param>
        /// <param name="xPortkeyMetadata"></param>
        /// <param name="role">
        /// The role of the entity that is creating the message. Allowed values include:<br/>
        /// - `user`: Indicates the message is sent by an actual user and should be used in most cases to represent user-generated messages.<br/>
        /// - `assistant`: Indicates the message is generated by the assistant. Use this value to insert messages from the assistant into the conversation.
        /// </param>
        /// <param name="content"></param>
        /// <param name="attachments">
        /// A list of files attached to the message, and the tools they should be added to.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Portkey.CreateMessageResponse> CreateMessageAsync(
            global::Portkey.CreateMessageRequestRole role,
            global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.MessageContentImageFileObject, global::Portkey.MessageContentImageUrlObject, global::Portkey.MessageRequestContentTextObject>>> content,
            string? xPortkeyTraceId = default,
            string? xPortkeySpanId = default,
            string? xPortkeyParentSpanId = default,
            string? xPortkeySpanName = default,
            object? xPortkeyMetadata = default,
            global::System.Collections.Generic.IList<global::Portkey.CreateMessageRequestAttachment>? attachments = default,
            object? metadata = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Portkey.CreateMessageRequest
            {
                Role = role,
                Content = content,
                Attachments = attachments,
                Metadata = metadata,
            };

            return await CreateMessageAsync(
                xPortkeyTraceId: xPortkeyTraceId,
                xPortkeySpanId: xPortkeySpanId,
                xPortkeyParentSpanId: xPortkeyParentSpanId,
                xPortkeySpanName: xPortkeySpanName,
                xPortkeyMetadata: xPortkeyMetadata,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}