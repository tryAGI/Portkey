
#nullable enable

namespace Portkey
{
    public partial class DeploymentsClient
    {

        private static readonly global::Portkey.AutoSDKServer[] s_ListDeploymentsServers = new global::Portkey.AutoSDKServer[]
        {            new global::Portkey.AutoSDKServer(
                id: "https-api-portkey-ai-v1",
                name: "Portkey API Public Endpoint",
                url: "https://api.portkey.ai/v1",
                description: "Portkey API Public Endpoint"),
            new global::Portkey.AutoSDKServer(
                id: "self-hosted-control-plane-url",
                name: "Self-Hosted Control Plane URL",
                url: "SELF_HOSTED_CONTROL_PLANE_URL",
                description: "Self-Hosted Control Plane URL"),
        };


        private static readonly global::Portkey.EndPointSecurityRequirement s_ListDeploymentsSecurityRequirement0 =
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
        private static readonly global::Portkey.EndPointSecurityRequirement[] s_ListDeploymentsSecurityRequirements =
            new global::Portkey.EndPointSecurityRequirement[]
            {                s_ListDeploymentsSecurityRequirement0,
            };
        partial void PrepareListDeploymentsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid? organisationId,
            ref global::Portkey.ListDeploymentsStatus? status,
            ref global::Portkey.ListDeploymentsType? type,
            global::System.Collections.Generic.IList<string>? workspaceSlug,
            ref string? search,
            ref global::Portkey.OneOf<string, global::System.Collections.Generic.Dictionary<string, string>>? tags);
        partial void PrepareListDeploymentsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid? organisationId,
            global::Portkey.ListDeploymentsStatus? status,
            global::Portkey.ListDeploymentsType? type,
            global::System.Collections.Generic.IList<string>? workspaceSlug,
            string? search,
            global::Portkey.OneOf<string, global::System.Collections.Generic.Dictionary<string, string>>? tags);
        partial void ProcessListDeploymentsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListDeploymentsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List All Gateway Deployments<br/>
        /// List deployments with optional filters. Tags can be filtered using either<br/>
        /// a JSON string or bracket-notation query parameters.
        /// </summary>
        /// <param name="organisationId"></param>
        /// <param name="status"></param>
        /// <param name="type"></param>
        /// <param name="workspaceSlug"></param>
        /// <param name="search"></param>
        /// <param name="tags"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Portkey.ListDeploymentsResponse> ListDeploymentsAsync(
            global::System.Guid? organisationId = default,
            global::Portkey.ListDeploymentsStatus? status = default,
            global::Portkey.ListDeploymentsType? type = default,
            global::System.Collections.Generic.IList<string>? workspaceSlug = default,
            string? search = default,
            global::Portkey.OneOf<string, global::System.Collections.Generic.Dictionary<string, string>>? tags = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await ListDeploymentsAsResponseAsync(
                organisationId: organisationId,
                status: status,
                type: type,
                workspaceSlug: workspaceSlug,
                search: search,
                tags: tags,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// List All Gateway Deployments<br/>
        /// List deployments with optional filters. Tags can be filtered using either<br/>
        /// a JSON string or bracket-notation query parameters.
        /// </summary>
        /// <param name="organisationId"></param>
        /// <param name="status"></param>
        /// <param name="type"></param>
        /// <param name="workspaceSlug"></param>
        /// <param name="search"></param>
        /// <param name="tags"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.ListDeploymentsResponse>> ListDeploymentsAsResponseAsync(
            global::System.Guid? organisationId = default,
            global::Portkey.ListDeploymentsStatus? status = default,
            global::Portkey.ListDeploymentsType? type = default,
            global::System.Collections.Generic.IList<string>? workspaceSlug = default,
            string? search = default,
            global::Portkey.OneOf<string, global::System.Collections.Generic.Dictionary<string, string>>? tags = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListDeploymentsArguments(
                httpClient: HttpClient,
                organisationId: ref organisationId,
                status: ref status,
                type: ref type,
                workspaceSlug: workspaceSlug,
                search: ref search,
                tags: ref tags);


            var __authorizations = global::Portkey.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ListDeploymentsSecurityRequirements,
                operationName: "ListDeploymentsAsync");

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
                                path: "/deployments",
                                baseUri: ResolveBaseUri(
                                servers: s_ListDeploymentsServers,
                                defaultBaseUrl: "https://api.portkey.ai/v1"));
                            __pathBuilder
                                .AddOptionalParameter("organisation_id", organisationId?.ToString())
                                .AddOptionalParameter("status", status?.ToValueString())
                                .AddOptionalParameter("type", type?.ToValueString())
                                .AddOptionalParameter("workspace_slug", workspaceSlug, delimiter: ",", explode: true)
                                .AddOptionalParameter("search", search)
                                .AddOptionalParameter("tags", tags?.ToString())
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Portkey.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
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
                global::Portkey.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareListDeploymentsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    organisationId: organisationId,
                    status: status,
                    type: type,
                    workspaceSlug: workspaceSlug,
                    search: search,
                    tags: tags);

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
                                operationId: "ListDeployments",
                                methodName: "ListDeploymentsAsync",
                                pathTemplate: "\"/deployments\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
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
                                operationId: "ListDeployments",
                                methodName: "ListDeploymentsAsync",
                                pathTemplate: "\"/deployments\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
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
                                operationId: "ListDeployments",
                                methodName: "ListDeploymentsAsync",
                                pathTemplate: "\"/deployments\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
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
                ProcessListDeploymentsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Portkey.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Portkey.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListDeployments",
                                methodName: "ListDeploymentsAsync",
                                pathTemplate: "\"/deployments\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
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
                                operationId: "ListDeployments",
                                methodName: "ListDeploymentsAsync",
                                pathTemplate: "\"/deployments\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
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
                                ProcessListDeploymentsResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Portkey.ListDeploymentsResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Portkey.AutoSDKHttpResponse<global::Portkey.ListDeploymentsResponse>(
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

                                    var __value = await global::Portkey.ListDeploymentsResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Portkey.AutoSDKHttpResponse<global::Portkey.ListDeploymentsResponse>(
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
    }
}