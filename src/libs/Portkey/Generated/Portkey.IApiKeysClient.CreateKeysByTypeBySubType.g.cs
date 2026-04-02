#nullable enable

namespace Portkey
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Create API Keys<br/>
        /// Creates a new API key.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="subType"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.CreateKeysResponse> CreateKeysByTypeBySubTypeAsync(
            global::Portkey.CreateKeysType type,
            global::Portkey.CreateKeysSubType subType,

            global::Portkey.CreateApiKeyObject request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create API Keys<br/>
        /// Creates a new API key.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="subType"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.CreateKeysResponse>> CreateKeysByTypeBySubTypeAsResponseAsync(
            global::Portkey.CreateKeysType type,
            global::Portkey.CreateKeysSubType subType,

            global::Portkey.CreateApiKeyObject request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create API Keys<br/>
        /// Creates a new API key.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="subType"></param>
        /// <param name="name">
        /// Example: Development API Key
        /// </param>
        /// <param name="description">
        /// Example: API key for development environment
        /// </param>
        /// <param name="workspaceId">
        /// Example: ws-myworkspace
        /// </param>
        /// <param name="userId">
        /// **Required** when sub-type path parameter is 'user'. Not required when sub-type is 'service'.<br/>
        /// Example: c3d4e5f6-a7b8-6c7d-0e1f-2a3b4c5d6e7f
        /// </param>
        /// <param name="rateLimits"></param>
        /// <param name="usageLimits">
        /// Example: {"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}
        /// </param>
        /// <param name="scopes">
        /// Example: [completions.write]
        /// </param>
        /// <param name="defaults"></param>
        /// <param name="alertEmails"></param>
        /// <param name="expiresAt"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.CreateKeysResponse> CreateKeysByTypeBySubTypeAsync(
            global::Portkey.CreateKeysType type,
            global::Portkey.CreateKeysSubType subType,
            string name,
            global::System.Collections.Generic.IList<string> scopes,
            string? description = default,
            string? workspaceId = default,
            global::System.Guid? userId = default,
            global::System.Collections.Generic.IList<global::Portkey.CreateApiKeyObjectRateLimit>? rateLimits = default,
            global::Portkey.UsageLimits? usageLimits = default,
            global::Portkey.CreateApiKeyObjectDefaults? defaults = default,
            global::System.Collections.Generic.IList<string>? alertEmails = default,
            global::System.DateTime? expiresAt = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}