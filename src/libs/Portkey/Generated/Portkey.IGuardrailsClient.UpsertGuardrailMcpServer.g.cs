#nullable enable

namespace Portkey
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// Upsert single MCP server mapping<br/>
        /// Create or update a guardrail mapping for a single MCP server. The guardrail must have target "mcp_tools". If a mapping already exists for this MCP server, it is updated; otherwise a new mapping is created.
        /// </summary>
        /// <param name="guardrailId"></param>
        /// <param name="mcpServerId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.UpsertMcpServerMappingResponse> UpsertGuardrailMcpServerAsync(
            string guardrailId,
            string mcpServerId,

            global::Portkey.UpsertMcpServerMappingRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert single MCP server mapping<br/>
        /// Create or update a guardrail mapping for a single MCP server. The guardrail must have target "mcp_tools". If a mapping already exists for this MCP server, it is updated; otherwise a new mapping is created.
        /// </summary>
        /// <param name="guardrailId"></param>
        /// <param name="mcpServerId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.UpsertMcpServerMappingResponse>> UpsertGuardrailMcpServerAsResponseAsync(
            string guardrailId,
            string mcpServerId,

            global::Portkey.UpsertMcpServerMappingRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert single MCP server mapping<br/>
        /// Create or update a guardrail mapping for a single MCP server. The guardrail must have target "mcp_tools". If a mapping already exists for this MCP server, it is updated; otherwise a new mapping is created.
        /// </summary>
        /// <param name="guardrailId"></param>
        /// <param name="mcpServerId"></param>
        /// <param name="runOn">
        /// Stages at which the guardrail runs. Defaults to ["input", "output"] if not specified.<br/>
        /// Default Value: [input, output]
        /// </param>
        /// <param name="mcpIntegrationCapabilityIds">
        /// Optional list of tool capability UUIDs to scope the guardrail to specific tools. Omit or pass an empty array to apply to all tools on the server.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.UpsertMcpServerMappingResponse> UpsertGuardrailMcpServerAsync(
            string guardrailId,
            string mcpServerId,
            global::System.Collections.Generic.IList<global::Portkey.UpsertMcpServerMappingRequestRunOnItem>? runOn = default,
            global::System.Collections.Generic.IList<global::System.Guid>? mcpIntegrationCapabilityIds = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}