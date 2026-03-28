#nullable enable

namespace Portkey
{
    public partial interface IMcpServersCapabilitiesClient
    {
        /// <summary>
        /// Bulk Update MCP Server Capabilities
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.McpServerCapabilitiesBulkUpdateResponse> McpServerCapabilitiesBulkUpdateAsync(
            string mcpServerId,

            global::Portkey.BulkUpdateMcpServerCapabilities request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk Update MCP Server Capabilities
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="capabilities"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.McpServerCapabilitiesBulkUpdateResponse> McpServerCapabilitiesBulkUpdateAsync(
            string mcpServerId,
            global::System.Collections.Generic.IList<global::Portkey.BulkUpdateMcpServerCapabilitiesCapabilitie> capabilities,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}