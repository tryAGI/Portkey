#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetAnalyticsSummaryCacheResponseObjectJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.GetAnalyticsSummaryCacheResponseObject>
    {
        /// <inheritdoc />
        public override global::Portkey.GetAnalyticsSummaryCacheResponseObject Read(
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
                        return global::Portkey.GetAnalyticsSummaryCacheResponseObjectExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.GetAnalyticsSummaryCacheResponseObject)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.GetAnalyticsSummaryCacheResponseObject);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.GetAnalyticsSummaryCacheResponseObject value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Portkey.GetAnalyticsSummaryCacheResponseObjectExtensions.ToValueString(value));
        }
    }
}
