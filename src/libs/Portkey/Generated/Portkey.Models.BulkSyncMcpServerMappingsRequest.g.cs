
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BulkSyncMcpServerMappingsRequest
    {
        /// <summary>
        /// Map of MCP server UUID to its guardrail configuration. Servers not included in this map will have their mappings removed. Pass an empty object to remove all mappings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_servers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Portkey.BulkSyncMcpServerMappingsRequestMcpServers2> McpServers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkSyncMcpServerMappingsRequest" /> class.
        /// </summary>
        /// <param name="mcpServers">
        /// Map of MCP server UUID to its guardrail configuration. Servers not included in this map will have their mappings removed. Pass an empty object to remove all mappings.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkSyncMcpServerMappingsRequest(
            global::System.Collections.Generic.Dictionary<string, global::Portkey.BulkSyncMcpServerMappingsRequestMcpServers2> mcpServers)
        {
            this.McpServers = mcpServers ?? throw new global::System.ArgumentNullException(nameof(mcpServers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkSyncMcpServerMappingsRequest" /> class.
        /// </summary>
        public BulkSyncMcpServerMappingsRequest()
        {
        }

    }
}