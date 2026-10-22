
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Controls which tool the model uses.
    /// </summary>
    public sealed partial class CreateAnthropicMessageRequestToolChoice
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Portkey.JsonConverters.CreateAnthropicMessageRequestToolChoiceTypeJsonConverter))]
        public global::Portkey.CreateAnthropicMessageRequestToolChoiceType? Type { get; set; }

        /// <summary>
        /// Required when type is tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAnthropicMessageRequestToolChoice" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name">
        /// Required when type is tool.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAnthropicMessageRequestToolChoice(
            global::Portkey.CreateAnthropicMessageRequestToolChoiceType? type,
            string? name)
        {
            this.Type = type;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAnthropicMessageRequestToolChoice" /> class.
        /// </summary>
        public CreateAnthropicMessageRequestToolChoice()
        {
        }

    }
}