#nullable enable

namespace Portkey
{
    public partial interface IRateLimitsPoliciesClient
    {
        /// <summary>
        /// Update Rate Limits Policy<br/>
        /// Update an existing rate limits policy.
        /// </summary>
        /// <param name="rateLimitsPolicyId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateRateLimitsPolicyAsync(
            global::System.Guid rateLimitsPolicyId,

            global::Portkey.UpdateRateLimitsPolicyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Rate Limits Policy<br/>
        /// Update an existing rate limits policy.
        /// </summary>
        /// <param name="rateLimitsPolicyId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<string>> UpdateRateLimitsPolicyAsResponseAsync(
            global::System.Guid rateLimitsPolicyId,

            global::Portkey.UpdateRateLimitsPolicyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Rate Limits Policy<br/>
        /// Update an existing rate limits policy.
        /// </summary>
        /// <param name="rateLimitsPolicyId"></param>
        /// <param name="name">
        /// Policy name
        /// </param>
        /// <param name="unit">
        /// Rate unit
        /// </param>
        /// <param name="value">
        /// Rate limit value
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateRateLimitsPolicyAsync(
            global::System.Guid rateLimitsPolicyId,
            string? name = default,
            global::Portkey.UpdateRateLimitsPolicyRequestUnit? unit = default,
            double? value = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}