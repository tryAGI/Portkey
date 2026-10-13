#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class AccessPolicyMcpServerTargetTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.AccessPolicyMcpServerTargetType>
    {
        /// <inheritdoc />
        public override global::Portkey.AccessPolicyMcpServerTargetType Read(
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
                        return global::Portkey.AccessPolicyMcpServerTargetTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.AccessPolicyMcpServerTargetType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.AccessPolicyMcpServerTargetType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.AccessPolicyMcpServerTargetType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Portkey.AccessPolicyMcpServerTargetTypeExtensions.ToValueString(value));
        }
    }
}
