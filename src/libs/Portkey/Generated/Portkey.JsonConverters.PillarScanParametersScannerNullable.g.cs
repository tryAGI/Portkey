#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class PillarScanParametersScannerNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.PillarScanParametersScanner?>
    {
        /// <inheritdoc />
        public override global::Portkey.PillarScanParametersScanner? Read(
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
                        return global::Portkey.PillarScanParametersScannerExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.PillarScanParametersScanner)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.PillarScanParametersScanner?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.PillarScanParametersScanner? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Portkey.PillarScanParametersScannerExtensions.ToValueString(value.Value));
            }
        }
    }
}
