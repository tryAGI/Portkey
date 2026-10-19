#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class AnthropicDocumentSourceTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.AnthropicDocumentSourceType?>
    {
        /// <inheritdoc />
        public override global::Portkey.AnthropicDocumentSourceType? Read(
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
                        return global::Portkey.AnthropicDocumentSourceTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.AnthropicDocumentSourceType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.AnthropicDocumentSourceType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.AnthropicDocumentSourceType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Portkey.AnthropicDocumentSourceTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
