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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.McpServerUserAccessBulkUpdateResponse> McpServerUserAccessBulkUpdateAsync(
            string mcpServerId,

            global::Portkey.BulkUpdateMcpServerUserAccess request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk Update MCP Server User Access
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="userAccess"></param>
        /// <param name="defaultUserAccess">
        /// Server default when user has no explicit override
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.McpServerUserAccessBulkUpdateResponse> McpServerUserAccessBulkUpdateAsync(
            string mcpServerId,
            global::System.Collections.Generic.IList<global::Portkey.BulkUpdateMcpServerUserAccessUserAcces>? userAccess = default,
            global::Portkey.BulkUpdateMcpServerUserAccessDefaultUserAccess? defaultUserAccess = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}