#nullable enable

namespace Portkey
{
    public partial interface IUsageLimitsPoliciesClient
    {
        /// <summary>
        /// Reset Usage Limits Policy Entity<br/>
        /// Reset the current usage for a specific entity in a usage limits policy.
        /// </summary>
        /// <param name="policyUsageLimitsId"></param>
        /// <param name="entityId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ResetUsageLimitsPolicyEntityAsync(
            global::System.Guid policyUsageLimitsId,
            string entityId,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reset Usage Limits Policy Entity<br/>
        /// Reset the current usage for a specific entity in a usage limits policy.
        /// </summary>
        /// <param name="policyUsageLimitsId"></param>
        /// <param name="entityId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<string>> ResetUsageLimitsPolicyEntityAsResponseAsync(
            global::System.Guid policyUsageLimitsId,
            string entityId,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}