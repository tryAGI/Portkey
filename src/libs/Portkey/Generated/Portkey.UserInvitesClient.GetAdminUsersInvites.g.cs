
#nullable enable

namespace Portkey
{
    public partial class UserInvitesClient
    {
        partial void PrepareGetAdminUsersInvitesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? pageSize,
            ref int? currentPage,
            ref global::Portkey.GetAdminUsersInvitesRole? role,
            ref string? email,
            ref global::Portkey.GetAdminUsersInvitesStatus? status);
        partial void PrepareGetAdminUsersInvitesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? pageSize,
            int? currentPage,
            global::Portkey.GetAdminUsersInvitesRole? role,
            string? email,
            global::Portkey.GetAdminUsersInvitesStatus? status);
        partial void ProcessGetAdminUsersInvitesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetAdminUsersInvitesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get All Invites
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="currentPage"></param>
        /// <param name="role"></param>
        /// <param name="email"></param>
        /// <param name="status"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Portkey.InviteList> GetAdminUsersInvitesAsync(
            int? pageSize = default,
            int? currentPage = default,
            global::Portkey.GetAdminUsersInvitesRole? role = default,
            string? email = default,
            global::Portkey.GetAdminUsersInvitesStatus? status = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GetAdminUsersInvitesAsResponseAsync(
                pageSize: pageSize,
                currentPage: currentPage,
                role: role,
                email: email,
                status: status,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Get All Invites
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="currentPage"></param>
        /// <param name="role"></param>
        /// <param name="email"></param>
        /// <param name="status"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.InviteList>> GetAdminUsersInvitesAsResponseAsync(
            int? pageSize = default,
            int? currentPage = default,
            global::Portkey.GetAdminUsersInvitesRole? role = default,
            string? email = default,
            global::Portkey.GetAdminUsersInvitesStatus? status = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetAdminUsersInvitesArguments(
                httpClient: HttpClient,
                pageSize: ref pageSize,
                currentPage: ref currentPage,
                role: ref role,
                email: ref email,
                status: ref status);

            var __pathBuilder = new global::Portkey.PathBuilder(
                path: "/admin/users/invites",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("pageSize", pageSize?.ToString())
                .AddOptionalParameter("currentPage", currentPage?.ToString())
                .AddOptionalParameter("role", role?.ToValueString())
                .AddOptionalParameter("email", email)
                .AddOptionalParameter("status", status?.ToValueString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetAdminUsersInvitesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                pageSize: pageSize,
                currentPage: currentPage,
                role: role,
                email: email,
                status: status);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetAdminUsersInvitesResponse(
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
                ProcessGetAdminUsersInvitesResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    var __value = global::Portkey.InviteList.FromJson(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                    return new global::Portkey.AutoSDKHttpResponse<global::Portkey.InviteList>(
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

                    var __value = await global::Portkey.InviteList.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                    return new global::Portkey.AutoSDKHttpResponse<global::Portkey.InviteList>(
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
    }
}