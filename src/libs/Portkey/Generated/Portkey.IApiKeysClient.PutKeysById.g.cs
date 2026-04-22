#nullable enable

namespace Portkey
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Update API Keys<br/>
        /// Updates an existing API key. The API key type (user vs service) and associated user_id cannot be changed after creation.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PutKeysByIdAsync(
            global::System.Guid id,

            global::Portkey.UpdateApiKeyObject request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update API Keys<br/>
        /// Updates an existing API key. The API key type (user vs service) and associated user_id cannot be changed after creation.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<string>> PutKeysByIdAsResponseAsync(
            global::System.Guid id,

            global::Portkey.UpdateApiKeyObject request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update API Keys<br/>
        /// Updates an existing API key. The API key type (user vs service) and associated user_id cannot be changed after creation.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name">
        /// Example: Development API Key
        /// </param>
        /// <param name="description">
        /// Example: API key for development environment
        /// </param>
        /// <param name="rateLimits"></param>
        /// <param name="usageLimits">
        /// Example: {"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}
        /// </param>
        /// <param name="resetUsage">
        /// Whether to reset current usage. If the current status is exhausted, this will change it back to active.<br/>
        /// Example: true
        /// </param>
        /// <param name="scopes">
        /// Example: [completions.write]
        /// </param>
        /// <param name="defaults"></param>
        /// <param name="alertEmails"></param>
        /// <param name="expiresAt">
        /// ISO 8601 datetime at which this key expires.<br/>
        /// Example: 2026-12-31T23:59:59Z
        /// </param>
        /// <param name="rotationPolicy">
        /// Update or replace the automatic key rotation configuration. Requires either rotation_period or next_rotation_at.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> PutKeysByIdAsync(
            global::System.Guid id,
            string? name = default,
            string? description = default,
            global::System.Collections.Generic.IList<global::Portkey.UpdateApiKeyObjectRateLimit>? rateLimits = default,
            global::Portkey.UsageLimits? usageLimits = default,
            bool? resetUsage = default,
            global::System.Collections.Generic.IList<string>? scopes = default,
            global::Portkey.UpdateApiKeyObjectDefaults? defaults = default,
            global::System.Collections.Generic.IList<string>? alertEmails = default,
            global::System.DateTime? expiresAt = default,
            global::Portkey.UpdateApiKeyObjectRotationPolicy? rotationPolicy = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}