
#nullable enable

namespace Portkey
{
    /// <summary>
    /// A single reranked document result.
    /// </summary>
    public sealed partial class RerankResult
    {
        /// <summary>
        /// The index of the document in the original input array.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// The relevance score of the document to the query. Higher scores indicate greater relevance.<br/>
        /// Score ranges vary by provider but are typically between 0 and 1.<br/>
        /// Example: 0.98
        /// </summary>
        /// <example>0.98</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("relevance_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float RelevanceScore { get; set; }

        /// <summary>
        /// The original document text. Only present if `return_documents` is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document")]
        public global::Portkey.RerankResultDocument? Document { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankResult" /> class.
        /// </summary>
        /// <param name="index">
        /// The index of the document in the original input array.<br/>
        /// Example: 0
        /// </param>
        /// <param name="relevanceScore">
        /// The relevance score of the document to the query. Higher scores indicate greater relevance.<br/>
        /// Score ranges vary by provider but are typically between 0 and 1.<br/>
        /// Example: 0.98
        /// </param>
        /// <param name="document">
        /// The original document text. Only present if `return_documents` is true.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RerankResult(
            int index,
            float relevanceScore,
            global::Portkey.RerankResultDocument? document)
        {
            this.Index = index;
            this.RelevanceScore = relevanceScore;
            this.Document = document;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankResult" /> class.
        /// </summary>
        public RerankResult()
        {
        }

    }
}