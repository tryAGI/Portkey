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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.McpIntegrationCapabilitiesBulkUpdateResponse> McpIntegrationCapabilitiesBulkUpdateAsync(
            string mcpIntegrationId,

            global::Portkey.BulkUpdateMcpIntegrationCapabilities request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk Update MCP Integration Capabilities
        /// </summary>
        /// <param name="mcpIntegrationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.McpIntegrationCapabilitiesBulkUpdateResponse>> McpIntegrationCapabilitiesBulkUpdateAsResponseAsync(
            string mcpIntegrationId,

            global::Portkey.BulkUpdateMcpIntegrationCapabilities request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk Update MCP Integration Capabilities
        /// </summary>
        /// <param name="mcpIntegrationId"></param>
        /// <param name="capabilities"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.McpIntegrationCapabilitiesBulkUpdateResponse> McpIntegrationCapabilitiesBulkUpdateAsync(
            string mcpIntegrationId,
            global::System.Collections.Generic.IList<global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitie> capabilities,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}