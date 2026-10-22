
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Request body for the Anthropic-native Messages API (`POST /v1/messages`).<br/>
    /// For Azure AI Foundry (Anthropic models), set your provider's `azure_foundry_url` to<br/>
    /// `https://{resource}.services.ai.azure.com/anthropic` (strip the path to `/anthropic`).<br/>
    /// Use the deployment name as the `model` value (or `@provider/deployment` format with Portkey).
    /// </summary>
    public sealed partial class CreateAnthropicMessageRequest
    {
        /// <summary>
        /// The model identifier. When using Portkey's provider/virtual-key routing, use the<br/>
        /// `@provider-slug/deployment-name` format (e.g., `@my-azure-foundry-provider/my-claude-deployment`).<br/>
        /// Example: claude-sonnet-4-6-20251101
        /// </summary>
        /// <example>claude-sonnet-4-6-20251101</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// List of input messages forming the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Portkey.AnthropicMessage> Messages { get; set; }

        /// <summary>
        /// Maximum number of tokens to generate in the response.<br/>
        /// Example: 1024
        /// </summary>
        /// <example>1024</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.AnthropicSystemContentJsonConverter))]
        public global::Portkey.AnthropicSystemContent? System { get; set; }

        /// <summary>
        /// Set to true to stream the response using server-sent events.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Sampling temperature between 0 and 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Nucleus sampling probability.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// Top-K sampling value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// Custom stop sequences.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_sequences")]
        public global::System.Collections.Generic.IList<string>? StopSequences { get; set; }

        /// <summary>
        /// Tool definitions available to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Portkey.AnthropicTool>? Tools { get; set; }

        /// <summary>
        /// Controls which tool the model uses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        public global::Portkey.CreateAnthropicMessageRequestToolChoice? ToolChoice { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        public global::Portkey.AnthropicThinkingConfig? Thinking { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Portkey.CreateAnthropicMessageRequestMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAnthropicMessageRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The model identifier. When using Portkey's provider/virtual-key routing, use the<br/>
        /// `@provider-slug/deployment-name` format (e.g., `@my-azure-foundry-provider/my-claude-deployment`).<br/>
        /// Example: claude-sonnet-4-6-20251101
        /// </param>
        /// <param name="messages">
        /// List of input messages forming the conversation.
        /// </param>
        /// <param name="maxTokens">
        /// Maximum number of tokens to generate in the response.<br/>
        /// Example: 1024
        /// </param>
        /// <param name="system"></param>
        /// <param name="stream">
        /// Set to true to stream the response using server-sent events.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature between 0 and 1.
        /// </param>
        /// <param name="topP">
        /// Nucleus sampling probability.
        /// </param>
        /// <param name="topK">
        /// Top-K sampling value.
        /// </param>
        /// <param name="stopSequences">
        /// Custom stop sequences.
        /// </param>
        /// <param name="tools">
        /// Tool definitions available to the model.
        /// </param>
        /// <param name="toolChoice">
        /// Controls which tool the model uses.
        /// </param>
        /// <param name="thinking"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAnthropicMessageRequest(
            string model,
            global::System.Collections.Generic.IList<global::Portkey.AnthropicMessage> messages,
            int maxTokens,
            global::Portkey.AnthropicSystemContent? system,
            bool? stream,
            double? temperature,
            double? topP,
            int? topK,
            global::System.Collections.Generic.IList<string>? stopSequences,
            global::System.Collections.Generic.IList<global::Portkey.AnthropicTool>? tools,
            global::Portkey.CreateAnthropicMessageRequestToolChoice? toolChoice,
            global::Portkey.AnthropicThinkingConfig? thinking,
            global::Portkey.CreateAnthropicMessageRequestMetadata? metadata)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.MaxTokens = maxTokens;
            this.System = system;
            this.Stream = stream;
            this.Temperature = temperature;
            this.TopP = topP;
            this.TopK = topK;
            this.StopSequences = stopSequences;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.Thinking = thinking;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAnthropicMessageRequest" /> class.
        /// </summary>
        public CreateAnthropicMessageRequest()
        {
        }

    }
}