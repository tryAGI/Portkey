
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateGuardrailRequest
    {
        /// <summary>
        /// Name of the guardrail<br/>
        /// Example: Content Safety Check
        /// </summary>
        /// <example>Content Safety Check</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Target type for the guardrail. Use "llm" for LLM API requests (default) or "mcp_tools" for MCP tool calls.<br/>
        /// Default Value: llm
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.CreateGuardrailRequestTargetJsonConverter))]
        public global::Portkey.CreateGuardrailRequestTarget? Target { get; set; }

        /// <summary>
        /// Workspace UUID (required if organisation_id not provided and not using API key)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public global::System.Guid? WorkspaceId { get; set; }

        /// <summary>
        /// Organisation UUID (required if workspace_id not provided and not using API key)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organisation_id")]
        public global::System.Guid? OrganisationId { get; set; }

        /// <summary>
        /// Array of guardrail checks to apply. Required for "llm" target; optional for "mcp_tools" target.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        public global::System.Collections.Generic.IList<global::Portkey.GuardrailCheck>? Checks { get; set; }

        /// <summary>
        /// Actions to take when guardrail checks fail or pass
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        public global::Portkey.GuardrailActions? Actions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGuardrailRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGuardrailRequest(
            string name,
            global::Portkey.CreateGuardrailRequestTarget? target,
            global::System.Guid? workspaceId,
            global::System.Guid? organisationId,
            global::System.Collections.Generic.IList<global::Portkey.GuardrailCheck>? checks,
            global::Portkey.GuardrailActions? actions)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Target = target;
            this.WorkspaceId = workspaceId;
            this.OrganisationId = organisationId;
            this.Checks = checks;
            this.Actions = actions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGuardrailRequest" /> class.
        /// </summary>
        public CreateGuardrailRequest()
        {
        }

    }
}