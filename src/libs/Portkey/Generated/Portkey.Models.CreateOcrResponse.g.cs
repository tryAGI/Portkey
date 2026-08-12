
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Response from the OCR endpoint containing extracted content per page.
    /// </summary>
    public sealed partial class CreateOcrResponse
    {
        /// <summary>
        /// Array of processed pages with extracted content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Portkey.OcrPage> Pages { get; set; }

        /// <summary>
        /// The model used for OCR processing.<br/>
        /// Example: mistral-ocr-latest
        /// </summary>
        /// <example>mistral-ocr-latest</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Usage information for the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_info")]
        public global::Portkey.CreateOcrResponseUsageInfo? UsageInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOcrResponse" /> class.
        /// </summary>
        /// <param name="pages">
        /// Array of processed pages with extracted content.
        /// </param>
        /// <param name="model">
        /// The model used for OCR processing.<br/>
        /// Example: mistral-ocr-latest
        /// </param>
        /// <param name="usageInfo">
        /// Usage information for the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOcrResponse(
            global::System.Collections.Generic.IList<global::Portkey.OcrPage> pages,
            string model,
            global::Portkey.CreateOcrResponseUsageInfo? usageInfo)
        {
            this.Pages = pages ?? throw new global::System.ArgumentNullException(nameof(pages));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.UsageInfo = usageInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOcrResponse" /> class.
        /// </summary>
        public CreateOcrResponse()
        {
        }

    }
}