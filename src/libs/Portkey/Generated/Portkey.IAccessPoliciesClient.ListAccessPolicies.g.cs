#nullable enable

namespace Portkey
{
    public partial interface IAccessPoliciesClient
    {
        /// <summary>
        /// List Access Policies<br/>
        /// List active access policies with optional filtering, newest first.
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="effect"></param>
        /// <param name="enabled"></param>
        /// <param name="userId"></param>
        /// <param name="agentId"></param>
        /// <param name="serverId"></param>
        /// <param name="search"></param>
        /// <param name="createdBy"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="pageSize"></param>
        /// <param name="currentPage"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.ListAccessPoliciesResponse> ListAccessPoliciesAsync(
            string? workspaceId = default,
            global::Portkey.ListAccessPoliciesEffect? effect = default,
            bool? enabled = default,
            string? userId = default,
            string? agentId = default,
            string? serverId = default,
            string? search = default,
            string? createdBy = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            int? pageSize = default,
            int? currentPage = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Access Policies<br/>
        /// List active access policies with optional filtering, newest first.
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="effect"></param>
        /// <param name="enabled"></param>
        /// <param name="userId"></param>
        /// <param name="agentId"></param>
        /// <param name="serverId"></param>
        /// <param name="search"></param>
        /// <param name="createdBy"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="pageSize"></param>
        /// <param name="currentPage"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.ListAccessPoliciesResponse>> ListAccessPoliciesAsResponseAsync(
            string? workspaceId = default,
            global::Portkey.ListAccessPoliciesEffect? effect = default,
            bool? enabled = default,
            string? userId = default,
            string? agentId = default,
            string? serverId = default,
            string? search = default,
            string? createdBy = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            int? pageSize = default,
            int? currentPage = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}