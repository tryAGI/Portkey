
#nullable enable

namespace Portkey
{
    /// <summary>
    /// An event that is emitted when a response fails.
    /// </summary>
    public sealed partial class ResponseFailedEvent
    {
        /// <summary>
        /// The type of the event. Always `response.failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.ResponseFailedEventTypeJsonConverter))]
        public global::Portkey.ResponseFailedEventType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.ResponseJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Portkey.Response Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFailedEvent" /> class.
        /// </summary>
        /// <param name="response"></param>
        /// <param name="type">
        /// The type of the event. Always `response.failed`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseFailedEvent(
            global::Portkey.Response response,
            global::Portkey.ResponseFailedEventType type)
        {
            this.Type = type;
            this.Response = response;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFailedEvent" /> class.
        /// </summary>
        public ResponseFailedEvent()
        {
        }
    }
}