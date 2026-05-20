#nullable enable

namespace Portkey
{
    public partial interface IUsageLimitsPoliciesClient
    {
        /// <summary>
        /// List Usage Limits Policies<br/>
        /// List all usage limits policies with optional filtering.
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="status">
        /// Default Value: active
        /// </param>
        /// <param name="type"></param>
        /// <param name="pageSize"></param>
        /// <param name="currentPage"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.UsageLimitsPolicyListResponse> ListUsageLimitsPoliciesAsync(
            string? workspaceId = default,
            global::Portkey.ListUsageLimitsPoliciesStatus? status = default,
            global::Portkey.ListUsageLimitsPoliciesType? type = default,
            int? pageSize = default,
            int? currentPage = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Usage Limits Policies<br/>
        /// List all usage limits policies with optional filtering.
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="status">
        /// Default Value: active
        /// </param>
        /// <param name="type"></param>
        /// <param name="pageSize"></param>
        /// <param name="currentPage"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.UsageLimitsPolicyListResponse>> ListUsageLimitsPoliciesAsResponseAsync(
            string? workspaceId = default,
            global::Portkey.ListUsageLimitsPoliciesStatus? status = default,
            global::Portkey.ListUsageLimitsPoliciesType? type = default,
            int? pageSize = default,
            int? currentPage = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}