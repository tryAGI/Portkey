#nullable enable

namespace Portkey
{
    public partial interface IMcpIntegrationsClient
    {
        /// <summary>
        /// Update MCP Integration
        /// </summary>
        /// <param name="mcpIntegrationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> McpIntegrationsUpdateAsync(
            string mcpIntegrationId,

            global::Portkey.UpdateMcpIntegration request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update MCP Integration
        /// </summary>
        /// <param name="mcpIntegrationId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="configurations">
        /// Auth/config key-value pairs (e.g. headers, client credentials)
        /// </param>
        /// <param name="url"></param>
        /// <param name="authType"></param>
        /// <param name="transport"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> McpIntegrationsUpdateAsync(
            string mcpIntegrationId,
            string? name = default,
            string? description = default,
            global::Portkey.UpdateMcpIntegrationConfigurations? configurations = default,
            string? url = default,
            global::Portkey.UpdateMcpIntegrationAuthType? authType = default,
            global::Portkey.UpdateMcpIntegrationTransport? transport = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}