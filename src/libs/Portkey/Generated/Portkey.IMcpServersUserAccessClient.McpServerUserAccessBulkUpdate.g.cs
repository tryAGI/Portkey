#nullable enable

namespace Portkey
{
    public partial interface IMcpServersUserAccessClient
    {
        /// <summary>
        /// Bulk Update MCP Server User Access
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.McpServerUserAccessBulkUpdateResponse> McpServerUserAccessBulkUpdateAsync(
            string mcpServerId,

            global::Portkey.BulkUpdateMcpServerUserAccess request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk Update MCP Server User Access
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.McpServerUserAccessBulkUpdateResponse>> McpServerUserAccessBulkUpdateAsResponseAsync(
            string mcpServerId,

            global::Portkey.BulkUpdateMcpServerUserAccess request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk Update MCP Server User Access
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="userAccess"></param>
        /// <param name="defaultUserAccess">
        /// Server default when user has no explicit override
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.McpServerUserAccessBulkUpdateResponse> McpServerUserAccessBulkUpdateAsync(
            string mcpServerId,
            global::System.Collections.Generic.IList<global::Portkey.BulkUpdateMcpServerUserAccessUserAcces>? userAccess = default,
            global::Portkey.BulkUpdateMcpServerUserAccessDefaultUserAccess? defaultUserAccess = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}