#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class VectorStoreFileObjectLastErrorCodeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.VectorStoreFileObjectLastErrorCode?>
    {
        /// <inheritdoc />
        public override global::Portkey.VectorStoreFileObjectLastErrorCode? Read(
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
                        return global::Portkey.VectorStoreFileObjectLastErrorCodeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.VectorStoreFileObjectLastErrorCode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.VectorStoreFileObjectLastErrorCode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.VectorStoreFileObjectLastErrorCode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Portkey.VectorStoreFileObjectLastErrorCodeExtensions.ToValueString(value.Value));
            }
        }
    }
}
