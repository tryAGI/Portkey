#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class AcuvityScanParametersPiiCategorieJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.AcuvityScanParametersPiiCategorie>
    {
        /// <inheritdoc />
        public override global::Portkey.AcuvityScanParametersPiiCategorie Read(
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
                        return global::Portkey.AcuvityScanParametersPiiCategorieExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.AcuvityScanParametersPiiCategorie)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.AcuvityScanParametersPiiCategorie);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.AcuvityScanParametersPiiCategorie value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Portkey.AcuvityScanParametersPiiCategorieExtensions.ToValueString(value));
        }
    }
}
