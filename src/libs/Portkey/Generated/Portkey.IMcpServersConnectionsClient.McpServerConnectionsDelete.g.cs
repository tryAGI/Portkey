#nullable enable

namespace Portkey
{
    public partial interface IMcpServersConnectionsClient
    {
        /// <summary>
        /// Delete MCP Server Connection
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="mcpServerId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.McpServerConnectionDeleteResponse> McpServerConnectionsDeleteAsync(
            string mcpServerId,
            global::System.Guid? userId = default,
            string? workspaceId = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}