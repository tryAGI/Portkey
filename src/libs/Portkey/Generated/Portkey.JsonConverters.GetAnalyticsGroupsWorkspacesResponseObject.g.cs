#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetAnalyticsGroupsWorkspacesResponseObjectJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.GetAnalyticsGroupsWorkspacesResponseObject>
    {
        /// <inheritdoc />
        public override global::Portkey.GetAnalyticsGroupsWorkspacesResponseObject Read(
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
                        return global::Portkey.GetAnalyticsGroupsWorkspacesResponseObjectExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.GetAnalyticsGroupsWorkspacesResponseObject)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.GetAnalyticsGroupsWorkspacesResponseObject);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.GetAnalyticsGroupsWorkspacesResponseObject value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Portkey.GetAnalyticsGroupsWorkspacesResponseObjectExtensions.ToValueString(value));
        }
    }
}
