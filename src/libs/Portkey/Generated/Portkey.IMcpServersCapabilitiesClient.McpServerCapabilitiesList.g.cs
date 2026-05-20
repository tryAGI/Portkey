#nullable enable

namespace Portkey
{
    public partial interface IMcpServersCapabilitiesClient
    {
        /// <summary>
        /// List MCP Server Capabilities
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 100
        /// </param>
        /// <param name="type"></param>
        /// <param name="mcpServerId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.McpServerCapabilitiesListResponse> McpServerCapabilitiesListAsync(
            string mcpServerId,
            int? page = default,
            int? pageSize = default,
            global::Portkey.McpServerCapabilitiesListType? type = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List MCP Server Capabilities
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 100
        /// </param>
        /// <param name="type"></param>
        /// <param name="mcpServerId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.McpServerCapabilitiesListResponse>> McpServerCapabilitiesListAsResponseAsync(
            string mcpServerId,
            int? page = default,
            int? pageSize = default,
            global::Portkey.McpServerCapabilitiesListType? type = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}