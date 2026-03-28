#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class AzureOpenAIConfigurationAzureAuthModeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.AzureOpenAIConfigurationAzureAuthMode?>
    {
        /// <inheritdoc />
        public override global::Portkey.AzureOpenAIConfigurationAzureAuthMode? Read(
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
                        return global::Portkey.AzureOpenAIConfigurationAzureAuthModeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.AzureOpenAIConfigurationAzureAuthMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.AzureOpenAIConfigurationAzureAuthMode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.AzureOpenAIConfigurationAzureAuthMode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Portkey.AzureOpenAIConfigurationAzureAuthModeExtensions.ToValueString(value.Value));
            }
        }
    }
}
