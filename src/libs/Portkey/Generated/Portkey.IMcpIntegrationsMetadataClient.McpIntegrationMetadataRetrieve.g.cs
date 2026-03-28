#nullable enable

namespace Portkey
{
    public partial interface IMcpIntegrationsMetadataClient
    {
        /// <summary>
        /// Get MCP Integration Metadata
        /// </summary>
        /// <param name="mcpIntegrationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.McpIntegrationMetadata> McpIntegrationMetadataRetrieveAsync(
            string mcpIntegrationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}