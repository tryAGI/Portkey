#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class AcuvityScanParametersLanguageValuesNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.AcuvityScanParametersLanguageValues?>
    {
        /// <inheritdoc />
        public override global::Portkey.AcuvityScanParametersLanguageValues? Read(
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
                        return global::Portkey.AcuvityScanParametersLanguageValuesExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.AcuvityScanParametersLanguageValues)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.AcuvityScanParametersLanguageValues?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.AcuvityScanParametersLanguageValues? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Portkey.AcuvityScanParametersLanguageValuesExtensions.ToValueString(value.Value));
            }
        }
    }
}
