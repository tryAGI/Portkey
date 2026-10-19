#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class AnthropicThinkingConfigTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.AnthropicThinkingConfigType?>
    {
        /// <inheritdoc />
        public override global::Portkey.AnthropicThinkingConfigType? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Portkey.AnthropicThinkingConfigTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.AnthropicThinkingConfigType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.AnthropicThinkingConfigType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.AnthropicThinkingConfigType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Portkey.AnthropicThinkingConfigTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
