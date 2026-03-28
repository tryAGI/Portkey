#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatCompletionStreamResponseDeltaRoleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.ChatCompletionStreamResponseDeltaRole>
    {
        /// <inheritdoc />
        public override global::Portkey.ChatCompletionStreamResponseDeltaRole Read(
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
                        return global::Portkey.ChatCompletionStreamResponseDeltaRoleExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.ChatCompletionStreamResponseDeltaRole)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.ChatCompletionStreamResponseDeltaRole);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.ChatCompletionStreamResponseDeltaRole value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Portkey.ChatCompletionStreamResponseDeltaRoleExtensions.ToValueString(value));
        }
    }
}
