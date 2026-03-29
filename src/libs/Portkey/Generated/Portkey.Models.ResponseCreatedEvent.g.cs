
#nullable enable

namespace Portkey
{
    /// <summary>
    /// An event that is emitted when a response is created.
    /// </summary>
    public sealed partial class ResponseCreatedEvent
    {
        /// <summary>
        /// The type of the event. Always `response.created`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.ResponseCreatedEventTypeJsonConverter))]
        public global::Portkey.ResponseCreatedEventType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="ResponseCreatedEvent" /> class.
        /// </summary>
        /// <param name="response"></param>
        /// <param name="type">
        /// The type of the event. Always `response.created`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseCreatedEvent(
            global::Portkey.Response response,
            global::Portkey.ResponseCreatedEventType type)
        {
            this.Type = type;
            this.Response = response;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCreatedEvent" /> class.
        /// </summary>
        public ResponseCreatedEvent()
        {
        }
    }
}