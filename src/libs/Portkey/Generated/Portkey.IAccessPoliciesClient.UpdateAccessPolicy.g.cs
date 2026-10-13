#nullable enable

namespace Portkey
{
    public partial interface IAccessPoliciesClient
    {
        /// <summary>
        /// Update Access Policy<br/>
        /// Replace an access policy's subjects and targets. `subjects`, `targets`, and `version` are required; `name`, `description`, `effect`, and `enabled` keep their stored values when omitted.<br/>
        /// `version` must match the policy's current version (optimistic concurrency). A mismatch returns `409`.
        /// </summary>
        /// <param name="accessPolicyId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateAccessPolicyAsync(
            global::System.Guid accessPolicyId,

            global::Portkey.UpdateAccessPolicyRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Access Policy<br/>
        /// Replace an access policy's subjects and targets. `subjects`, `targets`, and `version` are required; `name`, `description`, `effect`, and `enabled` keep their stored values when omitted.<br/>
        /// `version` must match the policy's current version (optimistic concurrency). A mismatch returns `409`.
        /// </summary>
        /// <param name="accessPolicyId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<string>> UpdateAccessPolicyAsResponseAsync(
            global::System.Guid accessPolicyId,

            global::Portkey.UpdateAccessPolicyRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Access Policy<br/>
        /// Replace an access policy's subjects and targets. `subjects`, `targets`, and `version` are required; `name`, `description`, `effect`, and `enabled` keep their stored values when omitted.<br/>
        /// `version` must match the policy's current version (optimistic concurrency). A mismatch returns `409`.
        /// </summary>
        /// <param name="accessPolicyId"></param>
        /// <param name="version">
        /// Current version of the policy, as returned by Get Access Policy
        /// </param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="effect">
        /// Keeps the stored effect when omitted
        /// </param>
        /// <param name="subjects"></param>
        /// <param name="targets"></param>
        /// <param name="enabled"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateAccessPolicyAsync(
            global::System.Guid accessPolicyId,
            int version,
            global::System.Collections.Generic.IList<global::Portkey.AccessPolicySubject> subjects,
            global::System.Collections.Generic.IList<global::Portkey.AccessPolicyTarget> targets,
            string? name = default,
            string? description = default,
            global::Portkey.UpdateAccessPolicyRequestEffect? effect = default,
            bool? enabled = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}