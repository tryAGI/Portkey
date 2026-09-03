#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateGuardrailRequestTargetJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.CreateGuardrailRequestTarget>
    {
        /// <inheritdoc />
        public override global::Portkey.CreateGuardrailRequestTarget Read(
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
                        return global::Portkey.CreateGuardrailRequestTargetExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.CreateGuardrailRequestTarget)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.CreateGuardrailRequestTarget);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.CreateGuardrailRequestTarget value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Portkey.CreateGuardrailRequestTargetExtensions.ToValueString(value));
        }
    }
}
