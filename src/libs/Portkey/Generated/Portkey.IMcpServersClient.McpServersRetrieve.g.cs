#nullable enable

namespace Portkey
{
    public partial interface IMcpServersClient
    {
        /// <summary>
        /// Get MCP Server
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.McpServer> McpServersRetrieveAsync(
            string mcpServerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}