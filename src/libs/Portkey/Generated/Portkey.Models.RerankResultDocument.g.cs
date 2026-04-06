
#nullable enable

namespace Portkey
{
    /// <summary>
    /// The original document text. Only present if `return_documents` is true.
    /// </summary>
    public sealed partial class RerankResultDocument
    {
        /// <summary>
        /// The text content of the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankResultDocument" /> class.
        /// </summary>
        /// <param name="text">
        /// The text content of the document.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RerankResultDocument(
            string? text)
        {
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankResultDocument" /> class.
        /// </summary>
        public RerankResultDocument()
        {
        }
    }
}