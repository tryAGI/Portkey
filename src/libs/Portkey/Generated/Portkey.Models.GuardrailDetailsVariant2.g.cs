
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GuardrailDetailsVariant2
    {
        /// <summary>
        /// Array of configured guardrail checks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        public global::System.Collections.Generic.IList<global::Portkey.GuardrailCheck>? Checks { get; set; }

        /// <summary>
        /// Actions to take when guardrail checks fail or pass
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        public global::Portkey.GuardrailActions? Actions { get; set; }

        /// <summary>
        /// MCP server mappings for this guardrail. Only included when target is "mcp_tools".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_mappings")]
        public global::System.Collections.Generic.IList<global::Portkey.McpServerMapping>? McpServerMappings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailDetailsVariant2" /> class.
        /// </summary>
        /// <param name="checks">
        /// Array of configured guardrail checks
        /// </param>
        /// <param name="actions">
        /// Actions to take when guardrail checks fail or pass
        /// </param>
        /// <param name="mcpServerMappings">
        /// MCP server mappings for this guardrail. Only included when target is "mcp_tools".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailDetailsVariant2(
            global::System.Collections.Generic.IList<global::Portkey.GuardrailCheck>? checks,
            global::Portkey.GuardrailActions? actions,
            global::System.Collections.Generic.IList<global::Portkey.McpServerMapping>? mcpServerMappings)
        {
            this.Checks = checks;
            this.Actions = actions;
            this.McpServerMappings = mcpServerMappings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailDetailsVariant2" /> class.
        /// </summary>
        public GuardrailDetailsVariant2()
        {
        }

    }
}