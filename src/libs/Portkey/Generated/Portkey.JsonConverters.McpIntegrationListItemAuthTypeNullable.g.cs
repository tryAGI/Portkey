#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class McpIntegrationListItemAuthTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.McpIntegrationListItemAuthType?>
    {
        /// <inheritdoc />
        public override global::Portkey.McpIntegrationListItemAuthType? Read(
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
                        return global::Portkey.McpIntegrationListItemAuthTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.McpIntegrationListItemAuthType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.McpIntegrationListItemAuthType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.McpIntegrationListItemAuthType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Portkey.McpIntegrationListItemAuthTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
