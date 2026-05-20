#nullable enable

namespace Portkey
{
    public partial interface IIntegrationsWorkspacesClient
    {
        /// <summary>
        /// Bulk update workspace access<br/>
        /// Updates workspace access permissions, usage limits, and rate limits for an integration.<br/>
        /// Can configure global workspace access or per-workspace settings.
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PutIntegrationsBySlugWorkspacesAsync(
            string slug,

            global::Portkey.BulkUpdateWorkspacesRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk update workspace access<br/>
        /// Updates workspace access permissions, usage limits, and rate limits for an integration.<br/>
        /// Can configure global workspace access or per-workspace settings.
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<string>> PutIntegrationsBySlugWorkspacesAsResponseAsync(
            string slug,

            global::Portkey.BulkUpdateWorkspacesRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk update workspace access<br/>
        /// Updates workspace access permissions, usage limits, and rate limits for an integration.<br/>
        /// Can configure global workspace access or per-workspace settings.
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="workspaces"></param>
        /// <param name="globalWorkspaceAccess"></param>
        /// <param name="overrideExistingWorkspaceAccess">
        /// Whether to override existing workspace access settings
        /// </param>
        /// <param name="createDefaultProvider">
        /// Whether to automatically create a default provider when granting workspace access. Defaults to true. Can be overridden per workspace.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="defaultProviderSlug">
        /// Custom slug for the auto-created default provider. Applies to all workspaces unless overridden per workspace. If the slug already exists, the request will fail with a validation error.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> PutIntegrationsBySlugWorkspacesAsync(
            string slug,
            global::System.Collections.Generic.IList<global::Portkey.WorkspaceUpdateRequest>? workspaces = default,
            global::Portkey.GlobalWorkspaceAccess? globalWorkspaceAccess = default,
            bool? overrideExistingWorkspaceAccess = default,
            bool? createDefaultProvider = default,
            string? defaultProviderSlug = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}