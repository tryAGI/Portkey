
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Request body for the Anthropic token counting endpoint (`POST /v1/messages/count_tokens`).<br/>
    /// Returns the number of input tokens that a Messages API call would consume, without actually<br/>
    /// calling the model.
    /// </summary>
    public sealed partial class CountMessageTokensRequest
    {
        /// <summary>
        /// The model identifier (same format as CreateAnthropicMessageRequest).<br/>
        /// Example: claude-sonnet-4-6-20251101
        /// </summary>
        /// <example>claude-sonnet-4-6-20251101</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Portkey.AnthropicMessage> Messages { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.AnthropicSystemContentJsonConverter))]
        public global::Portkey.AnthropicSystemContent? System { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Portkey.AnthropicTool>? Tools { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        public global::Portkey.CountMessageTokensRequestToolChoice? ToolChoice { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        public global::Portkey.AnthropicThinkingConfig? Thinking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CountMessageTokensRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The model identifier (same format as CreateAnthropicMessageRequest).<br/>
        /// Example: claude-sonnet-4-6-20251101
        /// </param>
        /// <param name="messages"></param>
        /// <param name="system"></param>
        /// <param name="tools"></param>
        /// <param name="toolChoice"></param>
        /// <param name="thinking"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CountMessageTokensRequest(
            string model,
            global::System.Collections.Generic.IList<global::Portkey.AnthropicMessage> messages,
            global::Portkey.AnthropicSystemContent? system,
            global::System.Collections.Generic.IList<global::Portkey.AnthropicTool>? tools,
            global::Portkey.CountMessageTokensRequestToolChoice? toolChoice,
            global::Portkey.AnthropicThinkingConfig? thinking)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.System = system;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.Thinking = thinking;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CountMessageTokensRequest" /> class.
        /// </summary>
        public CountMessageTokensRequest()
        {
        }

    }
}