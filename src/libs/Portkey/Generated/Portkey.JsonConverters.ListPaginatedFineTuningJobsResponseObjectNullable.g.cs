#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListPaginatedFineTuningJobsResponseObjectNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.ListPaginatedFineTuningJobsResponseObject?>
    {
        /// <inheritdoc />
        public override global::Portkey.ListPaginatedFineTuningJobsResponseObject? Read(
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
                        return global::Portkey.ListPaginatedFineTuningJobsResponseObjectExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.ListPaginatedFineTuningJobsResponseObject)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.ListPaginatedFineTuningJobsResponseObject?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.ListPaginatedFineTuningJobsResponseObject? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Portkey.ListPaginatedFineTuningJobsResponseObjectExtensions.ToValueString(value.Value));
            }
        }
    }
}
