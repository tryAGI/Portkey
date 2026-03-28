#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class PromptVersionSummaryObjectNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.PromptVersionSummaryObject?>
    {
        /// <inheritdoc />
        public override global::Portkey.PromptVersionSummaryObject? Read(
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
                        return global::Portkey.PromptVersionSummaryObjectExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.PromptVersionSummaryObject)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.PromptVersionSummaryObject?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.PromptVersionSummaryObject? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Portkey.PromptVersionSummaryObjectExtensions.ToValueString(value.Value));
            }
        }
    }
}
