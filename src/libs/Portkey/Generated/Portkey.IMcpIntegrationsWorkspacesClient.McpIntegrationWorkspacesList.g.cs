#nullable enable

namespace Portkey
{
    public partial interface IMcpIntegrationsWorkspacesClient
    {
        /// <summary>
        /// List MCP Integration Workspaces
        /// </summary>
        /// <param name="version"></param>
        /// <param name="mcpIntegrationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.OneOf<global::Portkey.McpIntegrationWorkspacesListResponse, global::Portkey.McpIntegrationWorkspacesLegacyResponse>> McpIntegrationWorkspacesListAsync(
            string mcpIntegrationId,
            string? version = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}