
#nullable enable

namespace Portkey
{
    /// <summary>
    /// An object containing the document text and optional metadata.
    /// </summary>
    public sealed partial class RerankDocumentObject
    {
        /// <summary>
        /// The text content of the document.<br/>
        /// Example: Paris is the capital of France.
        /// </summary>
        /// <example>Paris is the capital of France.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankDocumentObject" /> class.
        /// </summary>
        /// <param name="text">
        /// The text content of the document.<br/>
        /// Example: Paris is the capital of France.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RerankDocumentObject(
            string text)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankDocumentObject" /> class.
        /// </summary>
        public RerankDocumentObject()
        {
        }
    }
}