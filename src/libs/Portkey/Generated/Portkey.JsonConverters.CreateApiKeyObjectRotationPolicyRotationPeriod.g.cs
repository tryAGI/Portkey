#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateApiKeyObjectRotationPolicyRotationPeriodJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.CreateApiKeyObjectRotationPolicyRotationPeriod>
    {
        /// <inheritdoc />
        public override global::Portkey.CreateApiKeyObjectRotationPolicyRotationPeriod Read(
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
                        return global::Portkey.CreateApiKeyObjectRotationPolicyRotationPeriodExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.CreateApiKeyObjectRotationPolicyRotationPeriod)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.CreateApiKeyObjectRotationPolicyRotationPeriod);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.CreateApiKeyObjectRotationPolicyRotationPeriod value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Portkey.CreateApiKeyObjectRotationPolicyRotationPeriodExtensions.ToValueString(value));
        }
    }
}
