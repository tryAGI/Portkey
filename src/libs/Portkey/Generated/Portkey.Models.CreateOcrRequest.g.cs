
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Request body for extracting text from documents using OCR. Supported providers include Mistral AI and Azure AI Foundry.
    /// </summary>
    public sealed partial class CreateOcrRequest
    {
        /// <summary>
        /// ID of the model to use for OCR processing. Model availability depends on the provider:<br/>
        /// - **Mistral AI**: `mistral-ocr-latest`, `mistral-ocr-4-0`<br/>
        /// - **Azure AI Foundry**: `mistral-ocr-4-0`, `mistral-document-ai-2505`, `mistral-document-ai-2512`<br/>
        /// Example: mistral-ocr-latest
        /// </summary>
        /// <example>mistral-ocr-latest</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The document to process. Specify either a URL or base64-encoded content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Portkey.CreateOcrRequestDocument Document { get; set; }

        /// <summary>
        /// Whether to include base64-encoded images of each page in the response.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_image_base64")]
        public bool? IncludeImageBase64 { get; set; }

        /// <summary>
        /// Maximum number of pages to process. If not specified, all pages are processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_limit")]
        public int? ImageLimit { get; set; }

        /// <summary>
        /// Minimum size (in pixels) for images to be included in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_min_size")]
        public int? ImageMinSize { get; set; }

        /// <summary>
        /// Specific page numbers to process (0-indexed). If not specified, all pages are processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        public global::System.Collections.Generic.IList<int>? Pages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOcrRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// ID of the model to use for OCR processing. Model availability depends on the provider:<br/>
        /// - **Mistral AI**: `mistral-ocr-latest`, `mistral-ocr-4-0`<br/>
        /// - **Azure AI Foundry**: `mistral-ocr-4-0`, `mistral-document-ai-2505`, `mistral-document-ai-2512`<br/>
        /// Example: mistral-ocr-latest
        /// </param>
        /// <param name="document">
        /// The document to process. Specify either a URL or base64-encoded content.
        /// </param>
        /// <param name="includeImageBase64">
        /// Whether to include base64-encoded images of each page in the response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="imageLimit">
        /// Maximum number of pages to process. If not specified, all pages are processed.
        /// </param>
        /// <param name="imageMinSize">
        /// Minimum size (in pixels) for images to be included in the response.
        /// </param>
        /// <param name="pages">
        /// Specific page numbers to process (0-indexed). If not specified, all pages are processed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOcrRequest(
            string model,
            global::Portkey.CreateOcrRequestDocument document,
            bool? includeImageBase64,
            int? imageLimit,
            int? imageMinSize,
            global::System.Collections.Generic.IList<int>? pages)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Document = document ?? throw new global::System.ArgumentNullException(nameof(document));
            this.IncludeImageBase64 = includeImageBase64;
            this.ImageLimit = imageLimit;
            this.ImageMinSize = imageMinSize;
            this.Pages = pages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOcrRequest" /> class.
        /// </summary>
        public CreateOcrRequest()
        {
        }

    }
}