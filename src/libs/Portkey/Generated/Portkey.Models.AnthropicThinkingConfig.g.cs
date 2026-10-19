
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnthropicThinkingConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.AnthropicThinkingConfigTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Portkey.AnthropicThinkingConfigType Type { get; set; }

        /// <summary>
        /// Max tokens for thinking. Required when type is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_tokens")]
        public int? BudgetTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicThinkingConfig" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="budgetTokens">
        /// Max tokens for thinking. Required when type is enabled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicThinkingConfig(
            global::Portkey.AnthropicThinkingConfigType type,
            int? budgetTokens)
        {
            this.Type = type;
            this.BudgetTokens = budgetTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicThinkingConfig" /> class.
        /// </summary>
        public AnthropicThinkingConfig()
        {
        }

    }
}