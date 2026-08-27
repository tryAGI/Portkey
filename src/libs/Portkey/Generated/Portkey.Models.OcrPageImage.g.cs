
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OcrPageImage
    {
        /// <summary>
        /// Unique identifier for the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Base64-encoded image data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_base64")]
        public string? ImageBase64 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrPageImage" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the image.
        /// </param>
        /// <param name="imageBase64">
        /// Base64-encoded image data.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OcrPageImage(
            string? id,
            string? imageBase64)
        {
            this.Id = id;
            this.ImageBase64 = imageBase64;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrPageImage" /> class.
        /// </summary>
        public OcrPageImage()
        {
        }

    }
}