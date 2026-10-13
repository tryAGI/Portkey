#nullable enable

namespace Portkey
{
    public partial interface IAccessPoliciesClient
    {
        /// <summary>
        /// Get Access Policy<br/>
        /// Get a single access policy, including its subjects and targets.
        /// </summary>
        /// <param name="accessPolicyId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AccessPolicy> GetAccessPolicyAsync(
            global::System.Guid accessPolicyId,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Access Policy<br/>
        /// Get a single access policy, including its subjects and targets.
        /// </summary>
        /// <param name="accessPolicyId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.AccessPolicy>> GetAccessPolicyAsResponseAsync(
            global::System.Guid accessPolicyId,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}