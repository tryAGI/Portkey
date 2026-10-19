
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnthropicToolResultContent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.AnthropicToolResultContentTypeJsonConverter))]
        public global::Portkey.AnthropicToolResultContentType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_use_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolUseId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.AnthropicTextContent, global::Portkey.AnthropicImageContent>>>))]
        public global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.AnthropicTextContent, global::Portkey.AnthropicImageContent>>>? Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_error")]
        public bool? IsError { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicToolResultContent" /> class.
        /// </summary>
        /// <param name="toolUseId"></param>
        /// <param name="type"></param>
        /// <param name="content"></param>
        /// <param name="isError"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicToolResultContent(
            string toolUseId,
            global::Portkey.AnthropicToolResultContentType type,
            global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.OneOf<global::Portkey.AnthropicTextContent, global::Portkey.AnthropicImageContent>>>? content,
            bool? isError)
        {
            this.Type = type;
            this.ToolUseId = toolUseId ?? throw new global::System.ArgumentNullException(nameof(toolUseId));
            this.Content = content;
            this.IsError = isError;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicToolResultContent" /> class.
        /// </summary>
        public AnthropicToolResultContent()
        {
        }

    }
}