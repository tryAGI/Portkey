#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class AutoChunkingStrategyRequestParamTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.AutoChunkingStrategyRequestParamType?>
    {
        /// <inheritdoc />
        public override global::Portkey.AutoChunkingStrategyRequestParamType? Read(
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
                        return global::Portkey.AutoChunkingStrategyRequestParamTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.AutoChunkingStrategyRequestParamType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.AutoChunkingStrategyRequestParamType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.AutoChunkingStrategyRequestParamType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Portkey.AutoChunkingStrategyRequestParamTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
