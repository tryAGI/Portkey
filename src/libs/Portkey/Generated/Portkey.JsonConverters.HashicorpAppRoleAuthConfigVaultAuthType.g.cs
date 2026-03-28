#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class HashicorpAppRoleAuthConfigVaultAuthTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.HashicorpAppRoleAuthConfigVaultAuthType>
    {
        /// <inheritdoc />
        public override global::Portkey.HashicorpAppRoleAuthConfigVaultAuthType Read(
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
                        return global::Portkey.HashicorpAppRoleAuthConfigVaultAuthTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.HashicorpAppRoleAuthConfigVaultAuthType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.HashicorpAppRoleAuthConfigVaultAuthType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.HashicorpAppRoleAuthConfigVaultAuthType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Portkey.HashicorpAppRoleAuthConfigVaultAuthTypeExtensions.ToValueString(value));
        }
    }
}
