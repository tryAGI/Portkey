#nullable enable

namespace Portkey
{
    public partial interface IMcpServersClient
    {
        /// <summary>
        /// Delete MCP Server
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> McpServersDeleteAsync(
            string mcpServerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}