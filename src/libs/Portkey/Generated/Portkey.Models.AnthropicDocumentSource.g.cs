
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnthropicDocumentSource
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.AnthropicDocumentSourceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Portkey.AnthropicDocumentSourceType Type { get; set; }

        /// <summary>
        /// Required when type is base64.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.AnthropicDocumentSourceMediaTypeJsonConverter))]
        public global::Portkey.AnthropicDocumentSourceMediaType? MediaType { get; set; }

        /// <summary>
        /// Base64-encoded document data. Required when type is base64.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public string? Data { get; set; }

        /// <summary>
        /// URL of the document. Required when type is url.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Plain text content. Required when type is text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicDocumentSource" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="mediaType">
        /// Required when type is base64.
        /// </param>
        /// <param name="data">
        /// Base64-encoded document data. Required when type is base64.
        /// </param>
        /// <param name="url">
        /// URL of the document. Required when type is url.
        /// </param>
        /// <param name="text">
        /// Plain text content. Required when type is text.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicDocumentSource(
            global::Portkey.AnthropicDocumentSourceType type,
            global::Portkey.AnthropicDocumentSourceMediaType? mediaType,
            string? data,
            string? url,
            string? text)
        {
            this.Type = type;
            this.MediaType = mediaType;
            this.Data = data;
            this.Url = url;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicDocumentSource" /> class.
        /// </summary>
        public AnthropicDocumentSource()
        {
        }

    }
}