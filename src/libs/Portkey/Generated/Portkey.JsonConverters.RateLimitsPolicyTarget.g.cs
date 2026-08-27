#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class RateLimitsPolicyTargetJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.RateLimitsPolicyTarget>
    {
        /// <inheritdoc />
        public override global::Portkey.RateLimitsPolicyTarget Read(
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
                        return global::Portkey.RateLimitsPolicyTargetExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.RateLimitsPolicyTarget)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.RateLimitsPolicyTarget);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.RateLimitsPolicyTarget value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Portkey.RateLimitsPolicyTargetExtensions.ToValueString(value));
        }
    }
}
