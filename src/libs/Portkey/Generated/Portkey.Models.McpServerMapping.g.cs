
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Represents a mapping between a guardrail and an MCP server.
    /// </summary>
    public sealed partial class McpServerMapping
    {
        /// <summary>
        /// Unique identifier of the mapping
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// UUID of the guardrail
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrail_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid GuardrailId { get; set; }

        /// <summary>
        /// UUID of the MCP server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid McpServerId { get; set; }

        /// <summary>
        /// Stages at which the guardrail runs. "input" runs on tool call arguments (before execution), "output" runs on tool call results (after execution).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_on")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Portkey.McpServerMappingRunOnItem> RunOn { get; set; }

        /// <summary>
        /// Optional list of MCP tool capability UUIDs to scope this guardrail to. When empty or omitted, the guardrail applies to all tools on the server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capability_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? CapabilityIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerMapping" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the mapping
        /// </param>
        /// <param name="guardrailId">
        /// UUID of the guardrail
        /// </param>
        /// <param name="mcpServerId">
        /// UUID of the MCP server
        /// </param>
        /// <param name="runOn">
        /// Stages at which the guardrail runs. "input" runs on tool call arguments (before execution), "output" runs on tool call results (after execution).
        /// </param>
        /// <param name="capabilityIds">
        /// Optional list of MCP tool capability UUIDs to scope this guardrail to. When empty or omitted, the guardrail applies to all tools on the server.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpServerMapping(
            global::System.Guid id,
            global::System.Guid guardrailId,
            global::System.Guid mcpServerId,
            global::System.Collections.Generic.IList<global::Portkey.McpServerMappingRunOnItem> runOn,
            global::System.Collections.Generic.IList<global::System.Guid>? capabilityIds)
        {
            this.Id = id;
            this.GuardrailId = guardrailId;
            this.McpServerId = mcpServerId;
            this.RunOn = runOn ?? throw new global::System.ArgumentNullException(nameof(runOn));
            this.CapabilityIds = capabilityIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerMapping" /> class.
        /// </summary>
        public McpServerMapping()
        {
        }

    }
}