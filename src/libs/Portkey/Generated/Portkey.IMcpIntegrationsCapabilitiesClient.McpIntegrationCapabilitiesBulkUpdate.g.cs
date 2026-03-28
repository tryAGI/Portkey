#nullable enable

namespace Portkey
{
    public partial interface IMcpIntegrationsCapabilitiesClient
    {
        /// <summary>
        /// Bulk Update MCP Integration Capabilities
        /// </summary>
        /// <param name="mcpIntegrationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.McpIntegrationCapabilitiesBulkUpdateResponse> McpIntegrationCapabilitiesBulkUpdateAsync(
            string mcpIntegrationId,

            global::Portkey.BulkUpdateMcpIntegrationCapabilities request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk Update MCP Integration Capabilities
        /// </summary>
        /// <param name="mcpIntegrationId"></param>
        /// <param name="capabilities"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.McpIntegrationCapabilitiesBulkUpdateResponse> McpIntegrationCapabilitiesBulkUpdateAsync(
            string mcpIntegrationId,
            global::System.Collections.Generic.IList<global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitie> capabilities,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}