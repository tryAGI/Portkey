#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListEgressAllowlistResponseObjectJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.ListEgressAllowlistResponseObject>
    {
        /// <inheritdoc />
        public override global::Portkey.ListEgressAllowlistResponseObject Read(
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
                        return global::Portkey.ListEgressAllowlistResponseObjectExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.ListEgressAllowlistResponseObject)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.ListEgressAllowlistResponseObject);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.ListEgressAllowlistResponseObject value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Portkey.ListEgressAllowlistResponseObjectExtensions.ToValueString(value));
        }
    }
}
