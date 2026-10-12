#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateEgressAllowlistEntryResponseObjectJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.CreateEgressAllowlistEntryResponseObject>
    {
        /// <inheritdoc />
        public override global::Portkey.CreateEgressAllowlistEntryResponseObject Read(
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
                        return global::Portkey.CreateEgressAllowlistEntryResponseObjectExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.CreateEgressAllowlistEntryResponseObject)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.CreateEgressAllowlistEntryResponseObject);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.CreateEgressAllowlistEntryResponseObject value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Portkey.CreateEgressAllowlistEntryResponseObjectExtensions.ToValueString(value));
        }
    }
}
