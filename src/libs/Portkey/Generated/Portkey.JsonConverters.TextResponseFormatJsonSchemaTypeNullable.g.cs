#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class TextResponseFormatJsonSchemaTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.TextResponseFormatJsonSchemaType?>
    {
        /// <inheritdoc />
        public override global::Portkey.TextResponseFormatJsonSchemaType? Read(
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
                        return global::Portkey.TextResponseFormatJsonSchemaTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.TextResponseFormatJsonSchemaType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.TextResponseFormatJsonSchemaType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.TextResponseFormatJsonSchemaType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Portkey.TextResponseFormatJsonSchemaTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
