
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateMessageResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.CreateMessageResponseTypeJsonConverter))]
        public global::Portkey.CreateMessageResponseType? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.CreateMessageResponseRoleJsonConverter))]
        public global::Portkey.CreateMessageResponseRole? Role { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::Portkey.AnthropicContentBlock>? Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.CreateMessageResponseStopReasonJsonConverter))]
        public global::Portkey.CreateMessageResponseStopReason? StopReason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_sequence")]
        public string? StopSequence { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Portkey.AnthropicUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMessageResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="role"></param>
        /// <param name="model"></param>
        /// <param name="content"></param>
        /// <param name="stopReason"></param>
        /// <param name="stopSequence"></param>
        /// <param name="usage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateMessageResponse(
            string? id,
            global::Portkey.CreateMessageResponseType? type,
            global::Portkey.CreateMessageResponseRole? role,
            string? model,
            global::System.Collections.Generic.IList<global::Portkey.AnthropicContentBlock>? content,
            global::Portkey.CreateMessageResponseStopReason? stopReason,
            string? stopSequence,
            global::Portkey.AnthropicUsage? usage)
        {
            this.Id = id;
            this.Type = type;
            this.Role = role;
            this.Model = model;
            this.Content = content;
            this.StopReason = stopReason;
            this.StopSequence = stopSequence;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMessageResponse" /> class.
        /// </summary>
        public CreateMessageResponse()
        {
        }

    }
}