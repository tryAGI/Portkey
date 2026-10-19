#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class AnthropicSystemContentVariant2ItemCacheControlTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.AnthropicSystemContentVariant2ItemCacheControlType>
    {
        /// <inheritdoc />
        public override global::Portkey.AnthropicSystemContentVariant2ItemCacheControlType Read(
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
                        return global::Portkey.AnthropicSystemContentVariant2ItemCacheControlTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.AnthropicSystemContentVariant2ItemCacheControlType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.AnthropicSystemContentVariant2ItemCacheControlType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.AnthropicSystemContentVariant2ItemCacheControlType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Portkey.AnthropicSystemContentVariant2ItemCacheControlTypeExtensions.ToValueString(value));
        }
    }
}
