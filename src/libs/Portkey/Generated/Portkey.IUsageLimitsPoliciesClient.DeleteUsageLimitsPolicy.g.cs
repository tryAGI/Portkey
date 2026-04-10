#nullable enable

namespace Portkey
{
    public partial interface IUsageLimitsPoliciesClient
    {
        /// <summary>
        /// Delete Usage Limits Policy<br/>
        /// Archive (soft delete) a usage limits policy.
        /// </summary>
        /// <param name="policyUsageLimitsId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteUsageLimitsPolicyAsync(
            global::System.Guid policyUsageLimitsId,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Usage Limits Policy<br/>
        /// Archive (soft delete) a usage limits policy.
        /// </summary>
        /// <param name="policyUsageLimitsId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<string>> DeleteUsageLimitsPolicyAsResponseAsync(
            global::System.Guid policyUsageLimitsId,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}