
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnthropicDocumentContent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.AnthropicDocumentContentTypeJsonConverter))]
        public global::Portkey.AnthropicDocumentContentType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Portkey.AnthropicDocumentSource Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public string? Context { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        public global::Portkey.AnthropicDocumentContentCitations? Citations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicDocumentContent" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="type"></param>
        /// <param name="title"></param>
        /// <param name="context"></param>
        /// <param name="citations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicDocumentContent(
            global::Portkey.AnthropicDocumentSource source,
            global::Portkey.AnthropicDocumentContentType type,
            string? title,
            string? context,
            global::Portkey.AnthropicDocumentContentCitations? citations)
        {
            this.Type = type;
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Title = title;
            this.Context = context;
            this.Citations = citations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicDocumentContent" /> class.
        /// </summary>
        public AnthropicDocumentContent()
        {
        }

    }
}