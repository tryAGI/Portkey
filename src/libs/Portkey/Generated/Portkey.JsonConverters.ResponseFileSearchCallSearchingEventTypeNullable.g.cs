#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class ResponseFileSearchCallSearchingEventTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.ResponseFileSearchCallSearchingEventType?>
    {
        /// <inheritdoc />
        public override global::Portkey.ResponseFileSearchCallSearchingEventType? Read(
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
                        return global::Portkey.ResponseFileSearchCallSearchingEventTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.ResponseFileSearchCallSearchingEventType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.ResponseFileSearchCallSearchingEventType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.ResponseFileSearchCallSearchingEventType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Portkey.ResponseFileSearchCallSearchingEventTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
