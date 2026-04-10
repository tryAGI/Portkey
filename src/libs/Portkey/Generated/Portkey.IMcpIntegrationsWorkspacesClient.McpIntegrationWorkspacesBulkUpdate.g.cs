#nullable enable

namespace Portkey
{
    public partial interface IMcpIntegrationsWorkspacesClient
    {
        /// <summary>
        /// Bulk Update MCP Integration Workspaces
        /// </summary>
        /// <param name="mcpIntegrationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> McpIntegrationWorkspacesBulkUpdateAsync(
            string mcpIntegrationId,

            global::Portkey.BulkUpdateMcpIntegrationWorkspaces request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk Update MCP Integration Workspaces
        /// </summary>
        /// <param name="mcpIntegrationId"></param>
        /// <param name="workspaces"></param>
        /// <param name="globalWorkspaceAccess"></param>
        /// <param name="overrideExistingWorkspaceAccess">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> McpIntegrationWorkspacesBulkUpdateAsync(
            string mcpIntegrationId,
            global::System.Collections.Generic.IList<global::Portkey.BulkUpdateMcpIntegrationWorkspacesWorkspace> workspaces,
            global::Portkey.BulkUpdateMcpIntegrationWorkspacesGlobalWorkspaceAccess? globalWorkspaceAccess = default,
            bool? overrideExistingWorkspaceAccess = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}