#nullable enable

namespace Portkey
{
    public partial interface IVirtualKeysClient
    {
        /// <summary>
        /// Create a Virtual Key
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.CreateVirtualKeysResponse> CreateVirtualKeysAsync(

            global::Portkey.CreateVirtualKeysRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Virtual Key
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.CreateVirtualKeysResponse>> CreateVirtualKeysAsResponseAsync(

            global::Portkey.CreateVirtualKeysRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Virtual Key
        /// </summary>
        /// <param name="name"></param>
        /// <param name="provider"></param>
        /// <param name="key"></param>
        /// <param name="note"></param>
        /// <param name="apiVersion"></param>
        /// <param name="resourceName"></param>
        /// <param name="deploymentName"></param>
        /// <param name="workspaceId">
        /// optional, needed when using organisation admin API keys
        /// </param>
        /// <param name="deploymentConfig"></param>
        /// <param name="usageLimits">
        /// Example: {"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}
        /// </param>
        /// <param name="rateLimits"></param>
        /// <param name="expiresAt"></param>
        /// <param name="secretMappings">
        /// Dynamically resolve secrets from secret references at runtime. Valid target_field values are "key" or "model_config.&lt;field&gt;" (e.g. "model_config.awsSecretAccessKey"). Each target_field must be unique. When "key" is mapped, the key field becomes optional.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.CreateVirtualKeysResponse> CreateVirtualKeysAsync(
            string? name = default,
            global::Portkey.CreateVirtualKeysRequestProvider? provider = default,
            string? key = default,
            string? note = default,
            string? apiVersion = default,
            string? resourceName = default,
            string? deploymentName = default,
            global::System.Guid? workspaceId = default,
            global::System.Collections.Generic.IList<global::Portkey.CreateVirtualKeysRequestDeploymentConfigItem>? deploymentConfig = default,
            global::Portkey.UsageLimits? usageLimits = default,
            global::Portkey.RateLimits? rateLimits = default,
            global::System.DateTime? expiresAt = default,
            global::System.Collections.Generic.IList<global::Portkey.SecretMapping>? secretMappings = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}