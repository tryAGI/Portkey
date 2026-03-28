#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class AuditLogObjectListRecordMethodNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.AuditLogObjectListRecordMethod?>
    {
        /// <inheritdoc />
        public override global::Portkey.AuditLogObjectListRecordMethod? Read(
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
                        return global::Portkey.AuditLogObjectListRecordMethodExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.AuditLogObjectListRecordMethod)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.AuditLogObjectListRecordMethod?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.AuditLogObjectListRecordMethod? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Portkey.AuditLogObjectListRecordMethodExtensions.ToValueString(value.Value));
            }
        }
    }
}
