
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Map of MCP server UUID to its guardrail configuration. Servers not included in this map will have their mappings removed. Pass an empty object to remove all mappings.
    /// </summary>
    public sealed partial class BulkSyncMcpServerMappingsRequestMcpServers
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}