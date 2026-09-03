
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpsertMcpServerMappingResponse
    {
        /// <summary>
        /// Unique identifier of the created or updated mapping
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("map_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid MapId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertMcpServerMappingResponse" /> class.
        /// </summary>
        /// <param name="mapId">
        /// Unique identifier of the created or updated mapping
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpsertMcpServerMappingResponse(
            global::System.Guid mapId)
        {
            this.MapId = mapId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertMcpServerMappingResponse" /> class.
        /// </summary>
        public UpsertMcpServerMappingResponse()
        {
        }

    }
}