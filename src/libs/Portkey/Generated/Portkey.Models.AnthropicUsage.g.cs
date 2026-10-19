
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnthropicUsage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        public int? InputTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        public int? OutputTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation_input_tokens")]
        public int? CacheCreationInputTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_tokens")]
        public int? CacheReadInputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicUsage" /> class.
        /// </summary>
        /// <param name="inputTokens"></param>
        /// <param name="outputTokens"></param>
        /// <param name="cacheCreationInputTokens"></param>
        /// <param name="cacheReadInputTokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicUsage(
            int? inputTokens,
            int? outputTokens,
            int? cacheCreationInputTokens,
            int? cacheReadInputTokens)
        {
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.CacheCreationInputTokens = cacheCreationInputTokens;
            this.CacheReadInputTokens = cacheReadInputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicUsage" /> class.
        /// </summary>
        public AnthropicUsage()
        {
        }

    }
}