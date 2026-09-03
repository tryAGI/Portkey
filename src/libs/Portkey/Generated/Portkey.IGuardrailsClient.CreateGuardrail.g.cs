#nullable enable

namespace Portkey
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// Create a new guardrail<br/>
        /// Creates a new guardrail with specified checks and actions
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.CreateGuardrailResponse> CreateGuardrailAsync(

            global::Portkey.CreateGuardrailRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new guardrail<br/>
        /// Creates a new guardrail with specified checks and actions
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.CreateGuardrailResponse>> CreateGuardrailAsResponseAsync(

            global::Portkey.CreateGuardrailRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new guardrail<br/>
        /// Creates a new guardrail with specified checks and actions
        /// </summary>
        /// <param name="name">
        /// Name of the guardrail<br/>
        /// Example: Content Safety Check
        /// </param>
        /// <param name="target">
        /// Target type for the guardrail. Use "llm" for LLM API requests (default) or "mcp_tools" for MCP tool calls.<br/>
        /// Default Value: llm
        /// </param>
        /// <param name="workspaceId">
        /// Workspace UUID (required if organisation_id not provided and not using API key)
        /// </param>
        /// <param name="organisationId">
        /// Organisation UUID (required if workspace_id not provided and not using API key)
        /// </param>
        /// <param name="checks">
        /// Array of guardrail checks to apply. Required for "llm" target; optional for "mcp_tools" target.
        /// </param>
        /// <param name="actions">
        /// Actions to take when guardrail checks fail or pass
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.CreateGuardrailResponse> CreateGuardrailAsync(
            string name,
            global::Portkey.CreateGuardrailRequestTarget? target = default,
            global::System.Guid? workspaceId = default,
            global::System.Guid? organisationId = default,
            global::System.Collections.Generic.IList<global::Portkey.GuardrailCheck>? checks = default,
            global::Portkey.GuardrailActions? actions = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}