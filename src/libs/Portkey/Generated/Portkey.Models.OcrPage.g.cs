
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Extracted content from a single page.
    /// </summary>
    public sealed partial class OcrPage
    {
        /// <summary>
        /// Zero-based page index.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Extracted content in markdown format.<br/>
        /// Example: # Document Title<br/>
        /// This is the extracted text content...
        /// </summary>
        /// <example>
        /// # Document Title<br/>
        /// This is the extracted text content...
        /// </example>
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Markdown { get; set; }

        /// <summary>
        /// Base64-encoded images found on this page (only present when `include_image_base64` is true).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<global::Portkey.OcrPageImage>? Images { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrPage" /> class.
        /// </summary>
        /// <param name="index">
        /// Zero-based page index.<br/>
        /// Example: 0
        /// </param>
        /// <param name="markdown">
        /// Extracted content in markdown format.<br/>
        /// Example: # Document Title<br/>
        /// This is the extracted text content...
        /// </param>
        /// <param name="images">
        /// Base64-encoded images found on this page (only present when `include_image_base64` is true).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OcrPage(
            int index,
            string markdown,
            global::System.Collections.Generic.IList<global::Portkey.OcrPageImage>? images)
        {
            this.Index = index;
            this.Markdown = markdown ?? throw new global::System.ArgumentNullException(nameof(markdown));
            this.Images = images;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrPage" /> class.
        /// </summary>
        public OcrPage()
        {
        }

    }
}