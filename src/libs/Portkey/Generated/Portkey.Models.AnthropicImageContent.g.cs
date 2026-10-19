
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnthropicImageContent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.AnthropicImageContentTypeJsonConverter))]
        public global::Portkey.AnthropicImageContentType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Portkey.AnthropicImageSource Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicImageContent" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicImageContent(
            global::Portkey.AnthropicImageSource source,
            global::Portkey.AnthropicImageContentType type)
        {
            this.Type = type;
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicImageContent" /> class.
        /// </summary>
        public AnthropicImageContent()
        {
        }

    }
}