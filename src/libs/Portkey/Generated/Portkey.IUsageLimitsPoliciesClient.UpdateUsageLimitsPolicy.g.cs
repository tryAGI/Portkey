#nullable enable

namespace Portkey
{
    public partial interface IUsageLimitsPoliciesClient
    {
        /// <summary>
        /// Update Usage Limits Policy<br/>
        /// Update an existing usage limits policy.
        /// </summary>
        /// <param name="policyUsageLimitsId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateUsageLimitsPolicyAsync(
            global::System.Guid policyUsageLimitsId,

            global::Portkey.UpdateUsageLimitsPolicyRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Usage Limits Policy<br/>
        /// Update an existing usage limits policy.
        /// </summary>
        /// <param name="policyUsageLimitsId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<string>> UpdateUsageLimitsPolicyAsResponseAsync(
            global::System.Guid policyUsageLimitsId,

            global::Portkey.UpdateUsageLimitsPolicyRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Usage Limits Policy<br/>
        /// Update an existing usage limits policy.
        /// </summary>
        /// <param name="policyUsageLimitsId"></param>
        /// <param name="name">
        /// Policy name
        /// </param>
        /// <param name="description">
        /// Policy description
        /// </param>
        /// <param name="conditions">
        /// Array of conditions that define which requests the policy applies to. If provided, this replaces the existing conditions on the policy.
        /// </param>
        /// <param name="creditLimit">
        /// Maximum usage allowed
        /// </param>
        /// <param name="alertThreshold">
        /// Threshold at which to send alerts. Must be less than credit_limit.
        /// </param>
        /// <param name="periodicReset">
        /// Reset period. Set to null to remove periodic reset. Cannot be combined with periodic_reset_days.
        /// </param>
        /// <param name="periodicResetDays">
        /// Number of days after which usage resets. Cannot be combined with periodic_reset.
        /// </param>
        /// <param name="nextUsageResetAt">
        /// ISO 8601 timestamp for the next scheduled usage reset.
        /// </param>
        /// <param name="resetUsageForValue">
        /// Reset usage for a specific value key (e.g., API key). This will reset the usage counter for that key to 0.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateUsageLimitsPolicyAsync(
            global::System.Guid policyUsageLimitsId,
            string? name = default,
            string? description = default,
            global::System.Collections.Generic.IList<global::Portkey.Condition>? conditions = default,
            double? creditLimit = default,
            double? alertThreshold = default,
            global::Portkey.UpdateUsageLimitsPolicyRequestPeriodicReset? periodicReset = default,
            int? periodicResetDays = default,
            global::System.DateTime? nextUsageResetAt = default,
            string? resetUsageForValue = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}