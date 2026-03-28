#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class RunStreamEventVariant8EventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.RunStreamEventVariant8Event>
    {
        /// <inheritdoc />
        public override global::Portkey.RunStreamEventVariant8Event Read(
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
                        return global::Portkey.RunStreamEventVariant8EventExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.RunStreamEventVariant8Event)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.RunStreamEventVariant8Event);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.RunStreamEventVariant8Event value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Portkey.RunStreamEventVariant8EventExtensions.ToValueString(value));
        }
    }
}
