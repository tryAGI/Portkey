#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateRateLimitsPolicyRequestTargetNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.CreateRateLimitsPolicyRequestTarget?>
    {
        /// <inheritdoc />
        public override global::Portkey.CreateRateLimitsPolicyRequestTarget? Read(
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
                        return global::Portkey.CreateRateLimitsPolicyRequestTargetExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.CreateRateLimitsPolicyRequestTarget)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.CreateRateLimitsPolicyRequestTarget?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.CreateRateLimitsPolicyRequestTarget? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Portkey.CreateRateLimitsPolicyRequestTargetExtensions.ToValueString(value.Value));
            }
        }
    }
}
