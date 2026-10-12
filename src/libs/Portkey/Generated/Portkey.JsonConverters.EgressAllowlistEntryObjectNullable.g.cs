#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class EgressAllowlistEntryObjectNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.EgressAllowlistEntryObject?>
    {
        /// <inheritdoc />
        public override global::Portkey.EgressAllowlistEntryObject? Read(
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
                        return global::Portkey.EgressAllowlistEntryObjectExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.EgressAllowlistEntryObject)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.EgressAllowlistEntryObject?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.EgressAllowlistEntryObject? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Portkey.EgressAllowlistEntryObjectExtensions.ToValueString(value.Value));
            }
        }
    }
}
