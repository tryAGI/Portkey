#nullable enable

namespace Portkey
{
    public partial interface IMcpIntegrationsClient
    {
        /// <summary>
        /// Get MCP Integration
        /// </summary>
        /// <param name="mcpIntegrationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.McpIntegration> McpIntegrationsRetrieveAsync(
            string mcpIntegrationId,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}