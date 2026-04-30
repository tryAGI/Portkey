
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetScimWorkspacesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mappings")]
        public global::System.Collections.Generic.IList<global::Portkey.GetScimWorkspacesResponseMapping>? Mappings { get; set; }

        /// <summary>
        /// Total number of mappings returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetScimWorkspacesResponse" /> class.
        /// </summary>
        /// <param name="mappings"></param>
        /// <param name="totalCount">
        /// Total number of mappings returned.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetScimWorkspacesResponse(
            global::System.Collections.Generic.IList<global::Portkey.GetScimWorkspacesResponseMapping>? mappings,
            int? totalCount)
        {
            this.Mappings = mappings;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetScimWorkspacesResponse" /> class.
        /// </summary>
        public GetScimWorkspacesResponse()
        {
        }
    }
}