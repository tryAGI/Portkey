#nullable enable

namespace Portkey
{
    public partial interface IMcpServersUserAccessClient
    {
        /// <summary>
        /// List MCP Server User Access
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 100
        /// </param>
        /// <param name="search"></param>
        /// <param name="mcpServerId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.McpServerUserAccessListResponse> McpServerUserAccessListAsync(
            string mcpServerId,
            int? page = default,
            int? pageSize = default,
            string? search = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List MCP Server User Access
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 100
        /// </param>
        /// <param name="search"></param>
        /// <param name="mcpServerId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.McpServerUserAccessListResponse>> McpServerUserAccessListAsResponseAsync(
            string mcpServerId,
            int? page = default,
            int? pageSize = default,
            string? search = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}