
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnthropicSystemContentVariant2ItemCacheControl
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.AnthropicSystemContentVariant2ItemCacheControlTypeJsonConverter))]
        public global::Portkey.AnthropicSystemContentVariant2ItemCacheControlType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicSystemContentVariant2ItemCacheControl" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicSystemContentVariant2ItemCacheControl(
            global::Portkey.AnthropicSystemContentVariant2ItemCacheControlType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicSystemContentVariant2ItemCacheControl" /> class.
        /// </summary>
        public AnthropicSystemContentVariant2ItemCacheControl()
        {
        }

    }
}