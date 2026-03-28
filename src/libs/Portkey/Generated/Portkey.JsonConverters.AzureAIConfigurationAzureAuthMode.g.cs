#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class AzureAIConfigurationAzureAuthModeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.AzureAIConfigurationAzureAuthMode>
    {
        /// <inheritdoc />
        public override global::Portkey.AzureAIConfigurationAzureAuthMode Read(
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
                        return global::Portkey.AzureAIConfigurationAzureAuthModeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.AzureAIConfigurationAzureAuthMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.AzureAIConfigurationAzureAuthMode);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.AzureAIConfigurationAzureAuthMode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Portkey.AzureAIConfigurationAzureAuthModeExtensions.ToValueString(value));
        }
    }
}
