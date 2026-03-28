#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatCompletionRequestToolMessageRoleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.ChatCompletionRequestToolMessageRole>
    {
        /// <inheritdoc />
        public override global::Portkey.ChatCompletionRequestToolMessageRole Read(
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
                        return global::Portkey.ChatCompletionRequestToolMessageRoleExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.ChatCompletionRequestToolMessageRole)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.ChatCompletionRequestToolMessageRole);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.ChatCompletionRequestToolMessageRole value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Portkey.ChatCompletionRequestToolMessageRoleExtensions.ToValueString(value));
        }
    }
}
