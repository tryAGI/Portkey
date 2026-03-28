#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class AuditLogObjectListRecordUserTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.AuditLogObjectListRecordUserType>
    {
        /// <inheritdoc />
        public override global::Portkey.AuditLogObjectListRecordUserType Read(
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
                        return global::Portkey.AuditLogObjectListRecordUserTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.AuditLogObjectListRecordUserType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.AuditLogObjectListRecordUserType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.AuditLogObjectListRecordUserType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Portkey.AuditLogObjectListRecordUserTypeExtensions.ToValueString(value));
        }
    }
}
