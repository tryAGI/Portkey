
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Usage information for the rerank request.
    /// </summary>
    public sealed partial class RerankUsage
    {
        /// <summary>
        /// The number of search units consumed by the request. Billing varies by provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_units")]
        public int? SearchUnits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankUsage" /> class.
        /// </summary>
        /// <param name="searchUnits">
        /// The number of search units consumed by the request. Billing varies by provider.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RerankUsage(
            int? searchUnits)
        {
            this.SearchUnits = searchUnits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankUsage" /> class.
        /// </summary>
        public RerankUsage()
        {
        }
    }
}