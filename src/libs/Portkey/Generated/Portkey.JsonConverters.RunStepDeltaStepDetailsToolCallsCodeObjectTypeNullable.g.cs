#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class RunStepDeltaStepDetailsToolCallsCodeObjectTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObjectType?>
    {
        /// <inheritdoc />
        public override global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObjectType? Read(
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
                        return global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObjectTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObjectType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObjectType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObjectType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Portkey.RunStepDeltaStepDetailsToolCallsCodeObjectTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
