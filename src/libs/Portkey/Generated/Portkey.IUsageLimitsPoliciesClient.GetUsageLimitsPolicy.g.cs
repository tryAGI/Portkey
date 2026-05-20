#nullable enable

namespace Portkey
{
    public partial interface IUsageLimitsPoliciesClient
    {
        /// <summary>
        /// Get Usage Limits Policy<br/>
        /// Get a single usage limits policy by ID.
        /// </summary>
        /// <param name="policyUsageLimitsId"></param>
        /// <param name="status">
        /// Default Value: active
        /// </param>
        /// <param name="includeUsage">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.UsageLimitsPolicyResponse> GetUsageLimitsPolicyAsync(
            global::System.Guid policyUsageLimitsId,
            global::Portkey.GetUsageLimitsPolicyStatus? status = default,
            bool? includeUsage = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Usage Limits Policy<br/>
        /// Get a single usage limits policy by ID.
        /// </summary>
        /// <param name="policyUsageLimitsId"></param>
        /// <param name="status">
        /// Default Value: active
        /// </param>
        /// <param name="includeUsage">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.UsageLimitsPolicyResponse>> GetUsageLimitsPolicyAsResponseAsync(
            global::System.Guid policyUsageLimitsId,
            global::Portkey.GetUsageLimitsPolicyStatus? status = default,
            bool? includeUsage = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}