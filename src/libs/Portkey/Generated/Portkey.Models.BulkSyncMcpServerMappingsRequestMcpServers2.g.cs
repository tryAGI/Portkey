
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BulkSyncMcpServerMappingsRequestMcpServers2
    {
        /// <summary>
        /// Stages at which the guardrail runs. Defaults to ["input", "output"] if not specified.<br/>
        /// Default Value: [input, output]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_on")]
        public global::System.Collections.Generic.IList<global::Portkey.BulkSyncMcpServerMappingsRequestMcpServersRunOnItem>? RunOn { get; set; }

        /// <summary>
        /// Optional list of tool capability UUIDs to scope the guardrail to specific tools. Omit or pass an empty array to apply to all tools on the server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_integration_capability_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? McpIntegrationCapabilityIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkSyncMcpServerMappingsRequestMcpServers2" /> class.
        /// </summary>
        /// <param name="runOn">
        /// Stages at which the guardrail runs. Defaults to ["input", "output"] if not specified.<br/>
        /// Default Value: [input, output]
        /// </param>
        /// <param name="mcpIntegrationCapabilityIds">
        /// Optional list of tool capability UUIDs to scope the guardrail to specific tools. Omit or pass an empty array to apply to all tools on the server.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkSyncMcpServerMappingsRequestMcpServers2(
            global::System.Collections.Generic.IList<global::Portkey.BulkSyncMcpServerMappingsRequestMcpServersRunOnItem>? runOn,
            global::System.Collections.Generic.IList<global::System.Guid>? mcpIntegrationCapabilityIds)
        {
            this.RunOn = runOn;
            this.McpIntegrationCapabilityIds = mcpIntegrationCapabilityIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkSyncMcpServerMappingsRequestMcpServers2" /> class.
        /// </summary>
        public BulkSyncMcpServerMappingsRequestMcpServers2()
        {
        }

    }
}