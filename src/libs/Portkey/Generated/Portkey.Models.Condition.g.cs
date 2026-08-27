
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Condition
    {
        /// <summary>
        /// Condition key. Valid keys depend on the policy target:<br/>
        /// **LLM policies (target: llm):**<br/>
        /// - `api_key` - Match by API key ID<br/>
        /// - `virtual_key` - Match by virtual key slug<br/>
        /// - `provider` - Match by provider (e.g., `openai`, `anthropic`, `azure-openai`)<br/>
        /// - `config` - Match by config slug<br/>
        /// - `prompt` - Match by prompt slug<br/>
        /// - `model` - Match by model (supports wildcards, e.g., `@openai/gpt-4o`, `@anthropic/*`)<br/>
        /// - `endpoint_type` - Match by endpoint type (e.g., `chatComplete`, `embed`, `imageGenerate`) — rate limit policies only<br/>
        /// - `metadata.*` - Match by request metadata (e.g., `metadata._user`, `metadata.team`)<br/>
        /// **MCP policies (target: mcp_tools):**<br/>
        /// - `api_key` - Match by API key ID<br/>
        /// - `workspace_id` - Match by workspace ID<br/>
        /// - `mcp_server` - Match by MCP server name<br/>
        /// - `mcp_tool` - Match by MCP tool name<br/>
        /// - `metadata.*` - Match by request metadata<br/>
        /// Example: api_key
        /// </summary>
        /// <example>api_key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Value(s) to match. Use `"*"` for wildcard matching.<br/>
        /// Can be a single string or an array of strings (OR logic for arrays).<br/>
        /// Example: *
        /// </summary>
        /// <example>*</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Portkey.OneOf<string, global::System.Collections.Generic.IList<string>> Value { get; set; }

        /// <summary>
        /// Value(s) to exclude from matching.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excludes")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Portkey.OneOf<string, global::System.Collections.Generic.IList<string>>? Excludes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Condition" /> class.
        /// </summary>
        /// <param name="key">
        /// Condition key. Valid keys depend on the policy target:<br/>
        /// **LLM policies (target: llm):**<br/>
        /// - `api_key` - Match by API key ID<br/>
        /// - `virtual_key` - Match by virtual key slug<br/>
        /// - `provider` - Match by provider (e.g., `openai`, `anthropic`, `azure-openai`)<br/>
        /// - `config` - Match by config slug<br/>
        /// - `prompt` - Match by prompt slug<br/>
        /// - `model` - Match by model (supports wildcards, e.g., `@openai/gpt-4o`, `@anthropic/*`)<br/>
        /// - `endpoint_type` - Match by endpoint type (e.g., `chatComplete`, `embed`, `imageGenerate`) — rate limit policies only<br/>
        /// - `metadata.*` - Match by request metadata (e.g., `metadata._user`, `metadata.team`)<br/>
        /// **MCP policies (target: mcp_tools):**<br/>
        /// - `api_key` - Match by API key ID<br/>
        /// - `workspace_id` - Match by workspace ID<br/>
        /// - `mcp_server` - Match by MCP server name<br/>
        /// - `mcp_tool` - Match by MCP tool name<br/>
        /// - `metadata.*` - Match by request metadata<br/>
        /// Example: api_key
        /// </param>
        /// <param name="value">
        /// Value(s) to match. Use `"*"` for wildcard matching.<br/>
        /// Can be a single string or an array of strings (OR logic for arrays).<br/>
        /// Example: *
        /// </param>
        /// <param name="excludes">
        /// Value(s) to exclude from matching.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Condition(
            string key,
            global::Portkey.OneOf<string, global::System.Collections.Generic.IList<string>> value,
            global::Portkey.OneOf<string, global::System.Collections.Generic.IList<string>>? excludes)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value;
            this.Excludes = excludes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Condition" /> class.
        /// </summary>
        public Condition()
        {
        }

    }
}