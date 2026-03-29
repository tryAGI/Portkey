
#nullable enable

namespace Portkey
{
    /// <summary>
    /// The text content that is part of a message.
    /// </summary>
    public sealed partial class MessageContentTextObject
    {
        /// <summary>
        /// Always `text`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.MessageContentTextObjectTypeJsonConverter))]
        public global::Portkey.MessageContentTextObjectType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Portkey.MessageContentTextObjectText Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentTextObject" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="type">
        /// Always `text`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageContentTextObject(
            global::Portkey.MessageContentTextObjectText text,
            global::Portkey.MessageContentTextObjectType type)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentTextObject" /> class.
        /// </summary>
        public MessageContentTextObject()
        {
        }
    }
}