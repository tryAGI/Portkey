#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class UsageLimitsPeriodicResetNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.UsageLimitsPeriodicReset?>
    {
        /// <inheritdoc />
        public override global::Portkey.UsageLimitsPeriodicReset? Read(
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
                        return global::Portkey.UsageLimitsPeriodicResetExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.UsageLimitsPeriodicReset)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.UsageLimitsPeriodicReset?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.UsageLimitsPeriodicReset? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Portkey.UsageLimitsPeriodicResetExtensions.ToValueString(value.Value));
            }
        }
    }
}
