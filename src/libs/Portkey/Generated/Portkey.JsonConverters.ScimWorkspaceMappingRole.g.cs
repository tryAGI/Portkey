#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class ScimWorkspaceMappingRoleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.ScimWorkspaceMappingRole>
    {
        /// <inheritdoc />
        public override global::Portkey.ScimWorkspaceMappingRole Read(
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
                        return global::Portkey.ScimWorkspaceMappingRoleExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.ScimWorkspaceMappingRole)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.ScimWorkspaceMappingRole);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.ScimWorkspaceMappingRole value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Portkey.ScimWorkspaceMappingRoleExtensions.ToValueString(value));
        }
    }
}
