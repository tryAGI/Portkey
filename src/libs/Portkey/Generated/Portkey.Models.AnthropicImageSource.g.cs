
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnthropicImageSource
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.AnthropicImageSourceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Portkey.AnthropicImageSourceType Type { get; set; }

        /// <summary>
        /// Required when type is base64.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.AnthropicImageSourceMediaTypeJsonConverter))]
        public global::Portkey.AnthropicImageSourceMediaType? MediaType { get; set; }

        /// <summary>
        /// Base64-encoded image data. Required when type is base64.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public string? Data { get; set; }

        /// <summary>
        /// URL of the image. Required when type is url.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicImageSource" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="mediaType">
        /// Required when type is base64.
        /// </param>
        /// <param name="data">
        /// Base64-encoded image data. Required when type is base64.
        /// </param>
        /// <param name="url">
        /// URL of the image. Required when type is url.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicImageSource(
            global::Portkey.AnthropicImageSourceType type,
            global::Portkey.AnthropicImageSourceMediaType? mediaType,
            string? data,
            string? url)
        {
            this.Type = type;
            this.MediaType = mediaType;
            this.Data = data;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicImageSource" /> class.
        /// </summary>
        public AnthropicImageSource()
        {
        }

    }
}