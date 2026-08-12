
#nullable enable

namespace Portkey
{
    /// <summary>
    /// The document to process. Specify either a URL or base64-encoded content.
    /// </summary>
    public sealed partial class CreateOcrRequestDocument
    {
        /// <summary>
        /// The type of document source.<br/>
        /// Example: document_url
        /// </summary>
        /// <example>document_url</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.CreateOcrRequestDocumentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Portkey.CreateOcrRequestDocumentType Type { get; set; }

        /// <summary>
        /// URL of the document to process. Can be an HTTPS URL or a base64 data URI (e.g. `data:application/pdf;base64,...`).<br/>
        /// Example: https://example.com/document.pdf
        /// </summary>
        /// <example>https://example.com/document.pdf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_url")]
        public string? DocumentUrl { get; set; }

        /// <summary>
        /// URL of an image to process.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOcrRequestDocument" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of document source.<br/>
        /// Example: document_url
        /// </param>
        /// <param name="documentUrl">
        /// URL of the document to process. Can be an HTTPS URL or a base64 data URI (e.g. `data:application/pdf;base64,...`).<br/>
        /// Example: https://example.com/document.pdf
        /// </param>
        /// <param name="imageUrl">
        /// URL of an image to process.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOcrRequestDocument(
            global::Portkey.CreateOcrRequestDocumentType type,
            string? documentUrl,
            string? imageUrl)
        {
            this.Type = type;
            this.DocumentUrl = documentUrl;
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOcrRequestDocument" /> class.
        /// </summary>
        public CreateOcrRequestDocument()
        {
        }

    }
}