#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class AssistantsApiToolChoiceOptionEnumNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.AssistantsApiToolChoiceOptionEnum?>
    {
        /// <inheritdoc />
        public override global::Portkey.AssistantsApiToolChoiceOptionEnum? Read(
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
                        return global::Portkey.AssistantsApiToolChoiceOptionEnumExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.AssistantsApiToolChoiceOptionEnum)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.AssistantsApiToolChoiceOptionEnum?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.AssistantsApiToolChoiceOptionEnum? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Portkey.AssistantsApiToolChoiceOptionEnumExtensions.ToValueString(value.Value));
            }
        }
    }
}
