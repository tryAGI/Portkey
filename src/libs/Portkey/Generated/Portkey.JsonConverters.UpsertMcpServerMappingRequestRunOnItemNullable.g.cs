#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpsertMcpServerMappingRequestRunOnItemNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.UpsertMcpServerMappingRequestRunOnItem?>
    {
        /// <inheritdoc />
        public override global::Portkey.UpsertMcpServerMappingRequestRunOnItem? Read(
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
                        return global::Portkey.UpsertMcpServerMappingRequestRunOnItemExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.UpsertMcpServerMappingRequestRunOnItem)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.UpsertMcpServerMappingRequestRunOnItem?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.UpsertMcpServerMappingRequestRunOnItem? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Portkey.UpsertMcpServerMappingRequestRunOnItemExtensions.ToValueString(value.Value));
            }
        }
    }
}
