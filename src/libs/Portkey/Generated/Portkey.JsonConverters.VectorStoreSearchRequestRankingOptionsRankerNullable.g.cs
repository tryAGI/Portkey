#nullable enable

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public sealed class VectorStoreSearchRequestRankingOptionsRankerNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.VectorStoreSearchRequestRankingOptionsRanker?>
    {
        /// <inheritdoc />
        public override global::Portkey.VectorStoreSearchRequestRankingOptionsRanker? Read(
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
                        return global::Portkey.VectorStoreSearchRequestRankingOptionsRankerExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Portkey.VectorStoreSearchRequestRankingOptionsRanker)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Portkey.VectorStoreSearchRequestRankingOptionsRanker?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.VectorStoreSearchRequestRankingOptionsRanker? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Portkey.VectorStoreSearchRequestRankingOptionsRankerExtensions.ToValueString(value.Value));
            }
        }
    }
}
