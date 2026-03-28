#nullable enable

namespace Portkey
{
    public partial interface IMcpServersClient
    {
        /// <summary>
        /// Update MCP Server
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> McpServersUpdateAsync(
            string mcpServerId,

            global::Portkey.UpdateMcpServer request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update MCP Server
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> McpServersUpdateAsync(
            string mcpServerId,
            string? name = default,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}