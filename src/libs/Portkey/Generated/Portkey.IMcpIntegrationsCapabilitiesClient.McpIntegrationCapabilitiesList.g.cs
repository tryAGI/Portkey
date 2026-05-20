#nullable enable

namespace Portkey
{
    public partial interface IMcpIntegrationsCapabilitiesClient
    {
        /// <summary>
        /// List MCP Integration Capabilities
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 100
        /// </param>
        /// <param name="type"></param>
        /// <param name="mcpIntegrationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.McpIntegrationCapabilitiesListResponse> McpIntegrationCapabilitiesListAsync(
            string mcpIntegrationId,
            int? page = default,
            int? pageSize = default,
            global::Portkey.McpIntegrationCapabilitiesListType? type = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List MCP Integration Capabilities
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 100
        /// </param>
        /// <param name="type"></param>
        /// <param name="mcpIntegrationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.McpIntegrationCapabilitiesListResponse>> McpIntegrationCapabilitiesListAsResponseAsync(
            string mcpIntegrationId,
            int? page = default,
            int? pageSize = default,
            global::Portkey.McpIntegrationCapabilitiesListType? type = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}