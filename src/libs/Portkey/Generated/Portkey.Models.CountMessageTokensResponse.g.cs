
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CountMessageTokensResponse
    {
        /// <summary>
        /// The number of input tokens that would be consumed by the corresponding Messages API call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        public int? InputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CountMessageTokensResponse" /> class.
        /// </summary>
        /// <param name="inputTokens">
        /// The number of input tokens that would be consumed by the corresponding Messages API call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CountMessageTokensResponse(
            int? inputTokens)
        {
            this.InputTokens = inputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CountMessageTokensResponse" /> class.
        /// </summary>
        public CountMessageTokensResponse()
        {
        }

    }
}