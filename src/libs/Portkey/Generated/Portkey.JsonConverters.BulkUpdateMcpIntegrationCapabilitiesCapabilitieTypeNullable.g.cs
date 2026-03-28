#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class BulkUpdateMcpIntegrationCapabilitiesCapabilitieTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitieType?>
    {
        /// <inheritdoc />
        public override global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitieType? Read(
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
                        return global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitieTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitieType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitieType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitieType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Portkey.BulkUpdateMcpIntegrationCapabilitiesCapabilitieTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
