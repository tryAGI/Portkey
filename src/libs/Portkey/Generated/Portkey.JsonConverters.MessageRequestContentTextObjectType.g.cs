#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class MessageRequestContentTextObjectTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.MessageRequestContentTextObjectType>
    {
        /// <inheritdoc />
        public override global::Portkey.MessageRequestContentTextObjectType Read(
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
                        return global::Portkey.MessageRequestContentTextObjectTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.MessageRequestContentTextObjectType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.MessageRequestContentTextObjectType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.MessageRequestContentTextObjectType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Portkey.MessageRequestContentTextObjectTypeExtensions.ToValueString(value));
        }
    }
}
