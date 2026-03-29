
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Occurs when a [message](https://platform.openai.com/docs/api-reference/messages/object) moves to an `in_progress` state.
    /// </summary>
    public sealed partial class MessageStreamEventVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.MessageStreamEventVariant2EventJsonConverter))]
        public global::Portkey.MessageStreamEventVariant2Event Event { get; set; }

        /// <summary>
        /// Represents a message within a [thread](https://platform.openai.com/docs/api-reference/threads).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Portkey.MessageObject Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageStreamEventVariant2" /> class.
        /// </summary>
        /// <param name="data">
        /// Represents a message within a [thread](https://platform.openai.com/docs/api-reference/threads).
        /// </param>
        /// <param name="event"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageStreamEventVariant2(
            global::Portkey.MessageObject data,
            global::Portkey.MessageStreamEventVariant2Event @event)
        {
            this.Event = @event;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageStreamEventVariant2" /> class.
        /// </summary>
        public MessageStreamEventVariant2()
        {
        }
    }
}