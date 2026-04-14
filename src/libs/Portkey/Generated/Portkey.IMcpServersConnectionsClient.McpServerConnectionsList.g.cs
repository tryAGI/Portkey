#nullable enable

namespace Portkey
{
    public partial interface IMcpServersConnectionsClient
    {
        /// <summary>
        /// List MCP Server Connections
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="currentPage">
        /// Default Value: 0
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 100
        /// </param>
        /// <param name="mcpServerId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.McpServerConnectionsListResponse> McpServerConnectionsListAsync(
            string mcpServerId,
            string? userId = default,
            string? workspaceId = default,
            int? currentPage = default,
            int? pageSize = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}