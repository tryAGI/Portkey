
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Key-value tags for the MCP server. Replaces existing tags; pass null to clear.
    /// </summary>
    public sealed partial class UpdateMcpServerTags
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}