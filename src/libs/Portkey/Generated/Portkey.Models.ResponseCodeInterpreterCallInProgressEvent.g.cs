
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Emitted when a code interpreter call is in progress.
    /// </summary>
    public sealed partial class ResponseCodeInterpreterCallInProgressEvent
    {
        /// <summary>
        /// The type of the event. Always `response.code_interpreter_call.in_progress`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.ResponseCodeInterpreterCallInProgressEventTypeJsonConverter))]
        public global::Portkey.ResponseCodeInterpreterCallInProgressEventType Type { get; set; }

        /// <summary>
        /// The index of the output item that the code interpreter call is in progress.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// A tool call to run code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_interpreter_call")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Portkey.CodeInterpreterToolCall CodeInterpreterCall { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCodeInterpreterCallInProgressEvent" /> class.
        /// </summary>
        /// <param name="outputIndex">
        /// The index of the output item that the code interpreter call is in progress.
        /// </param>
        /// <param name="codeInterpreterCall">
        /// A tool call to run code.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `response.code_interpreter_call.in_progress`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseCodeInterpreterCallInProgressEvent(
            int outputIndex,
            global::Portkey.CodeInterpreterToolCall codeInterpreterCall,
            global::Portkey.ResponseCodeInterpreterCallInProgressEventType type)
        {
            this.Type = type;
            this.OutputIndex = outputIndex;
            this.CodeInterpreterCall = codeInterpreterCall ?? throw new global::System.ArgumentNullException(nameof(codeInterpreterCall));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCodeInterpreterCallInProgressEvent" /> class.
        /// </summary>
        public ResponseCodeInterpreterCallInProgressEvent()
        {
        }

    }
}