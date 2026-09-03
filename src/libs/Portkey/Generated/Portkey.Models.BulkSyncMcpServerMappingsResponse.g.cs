
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Summary of changes made by the bulk sync operation.
    /// </summary>
    public sealed partial class BulkSyncMcpServerMappingsResponse
    {
        /// <summary>
        /// Whether any changes were made
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Changed { get; set; }

        /// <summary>
        /// Number of new MCP server mappings added
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Added { get; set; }

        /// <summary>
        /// Number of existing MCP server mappings updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Updated { get; set; }

        /// <summary>
        /// Number of MCP server mappings removed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Removed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkSyncMcpServerMappingsResponse" /> class.
        /// </summary>
        /// <param name="changed">
        /// Whether any changes were made
        /// </param>
        /// <param name="added">
        /// Number of new MCP server mappings added
        /// </param>
        /// <param name="updated">
        /// Number of existing MCP server mappings updated
        /// </param>
        /// <param name="removed">
        /// Number of MCP server mappings removed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkSyncMcpServerMappingsResponse(
            bool changed,
            int added,
            int updated,
            int removed)
        {
            this.Changed = changed;
            this.Added = added;
            this.Updated = updated;
            this.Removed = removed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkSyncMcpServerMappingsResponse" /> class.
        /// </summary>
        public BulkSyncMcpServerMappingsResponse()
        {
        }

    }
}