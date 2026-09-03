#nullable enable

namespace Portkey
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// Bulk sync MCP server mappings<br/>
        /// Declaratively sync all MCP server mappings for a guardrail. This replaces the entire set — servers not included in the request body are removed. The guardrail must have target "mcp_tools".
        /// </summary>
        /// <param name="guardrailId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.BulkSyncMcpServerMappingsResponse> BulkSyncGuardrailMcpServersAsync(
            string guardrailId,

            global::Portkey.BulkSyncMcpServerMappingsRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk sync MCP server mappings<br/>
        /// Declaratively sync all MCP server mappings for a guardrail. This replaces the entire set — servers not included in the request body are removed. The guardrail must have target "mcp_tools".
        /// </summary>
        /// <param name="guardrailId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.BulkSyncMcpServerMappingsResponse>> BulkSyncGuardrailMcpServersAsResponseAsync(
            string guardrailId,

            global::Portkey.BulkSyncMcpServerMappingsRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk sync MCP server mappings<br/>
        /// Declaratively sync all MCP server mappings for a guardrail. This replaces the entire set — servers not included in the request body are removed. The guardrail must have target "mcp_tools".
        /// </summary>
        /// <param name="guardrailId"></param>
        /// <param name="mcpServers">
        /// Map of MCP server UUID to its guardrail configuration. Servers not included in this map will have their mappings removed. Pass an empty object to remove all mappings.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.BulkSyncMcpServerMappingsResponse> BulkSyncGuardrailMcpServersAsync(
            string guardrailId,
            global::System.Collections.Generic.Dictionary<string, global::Portkey.BulkSyncMcpServerMappingsRequestMcpServers2> mcpServers,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}