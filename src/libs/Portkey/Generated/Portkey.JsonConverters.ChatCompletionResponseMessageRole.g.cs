#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatCompletionResponseMessageRoleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.ChatCompletionResponseMessageRole>
    {
        /// <inheritdoc />
        public override global::Portkey.ChatCompletionResponseMessageRole Read(
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
                        return global::Portkey.ChatCompletionResponseMessageRoleExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.ChatCompletionResponseMessageRole)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.ChatCompletionResponseMessageRole);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.ChatCompletionResponseMessageRole value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Portkey.ChatCompletionResponseMessageRoleExtensions.ToValueString(value));
        }
    }
}
