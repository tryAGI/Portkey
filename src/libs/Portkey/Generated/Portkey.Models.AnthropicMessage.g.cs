
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnthropicMessage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.AnthropicMessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Portkey.AnthropicMessageRole Role { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Portkey.AnthropicContentBlock>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.AnthropicContentBlock>> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicMessage" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="content"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicMessage(
            global::Portkey.AnthropicMessageRole role,
            global::Portkey.OneOf<string, global::System.Collections.Generic.IList<global::Portkey.AnthropicContentBlock>> content)
        {
            this.Role = role;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicMessage" /> class.
        /// </summary>
        public AnthropicMessage()
        {
        }

    }
}