#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateDeploymentRequestTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.UpdateDeploymentRequestType>
    {
        /// <inheritdoc />
        public override global::Portkey.UpdateDeploymentRequestType Read(
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
                        return global::Portkey.UpdateDeploymentRequestTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.UpdateDeploymentRequestType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.UpdateDeploymentRequestType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.UpdateDeploymentRequestType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Portkey.UpdateDeploymentRequestTypeExtensions.ToValueString(value));
        }
    }
}
