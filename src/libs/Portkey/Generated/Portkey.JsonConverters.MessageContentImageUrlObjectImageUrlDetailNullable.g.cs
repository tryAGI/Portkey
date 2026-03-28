#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class MessageContentImageUrlObjectImageUrlDetailNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.MessageContentImageUrlObjectImageUrlDetail?>
    {
        /// <inheritdoc />
        public override global::Portkey.MessageContentImageUrlObjectImageUrlDetail? Read(
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
                        return global::Portkey.MessageContentImageUrlObjectImageUrlDetailExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.MessageContentImageUrlObjectImageUrlDetail)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.MessageContentImageUrlObjectImageUrlDetail?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.MessageContentImageUrlObjectImageUrlDetail? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Portkey.MessageContentImageUrlObjectImageUrlDetailExtensions.ToValueString(value.Value));
            }
        }
    }
}
