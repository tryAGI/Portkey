#nullable enable

namespace Portkey
{
    public partial interface IRateLimitsPoliciesClient
    {
        /// <summary>
        /// Get Rate Limits Policy<br/>
        /// Get a single rate limits policy by ID.
        /// </summary>
        /// <param name="rateLimitsPolicyId"></param>
        /// <param name="status">
        /// Default Value: active
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.RateLimitsPolicyResponse> GetRateLimitsPolicyAsync(
            global::System.Guid rateLimitsPolicyId,
            global::Portkey.GetRateLimitsPolicyStatus? status = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Rate Limits Policy<br/>
        /// Get a single rate limits policy by ID.
        /// </summary>
        /// <param name="rateLimitsPolicyId"></param>
        /// <param name="status">
        /// Default Value: active
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.RateLimitsPolicyResponse>> GetRateLimitsPolicyAsResponseAsync(
            global::System.Guid rateLimitsPolicyId,
            global::Portkey.GetRateLimitsPolicyStatus? status = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}