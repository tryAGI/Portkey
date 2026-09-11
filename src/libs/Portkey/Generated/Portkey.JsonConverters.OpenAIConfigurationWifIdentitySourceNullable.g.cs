#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class OpenAIConfigurationWifIdentitySourceNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.OpenAIConfigurationWifIdentitySource?>
    {
        /// <inheritdoc />
        public override global::Portkey.OpenAIConfigurationWifIdentitySource? Read(
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
                        return global::Portkey.OpenAIConfigurationWifIdentitySourceExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.OpenAIConfigurationWifIdentitySource)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.OpenAIConfigurationWifIdentitySource?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.OpenAIConfigurationWifIdentitySource? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Portkey.OpenAIConfigurationWifIdentitySourceExtensions.ToValueString(value.Value));
            }
        }
    }
}
