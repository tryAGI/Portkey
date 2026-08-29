#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public class CreateModelResponsePropertiesJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.CreateModelResponseProperties>
    {
        /// <inheritdoc />
        public override global::Portkey.CreateModelResponseProperties Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::Portkey.ModelResponseProperties? modelResponseProperties = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ModelResponseProperties), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ModelResponseProperties> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ModelResponseProperties).Name}");
                modelResponseProperties = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::Portkey.CreateModelResponseProperties(
                modelResponseProperties
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.CreateModelResponseProperties value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsModelResponseProperties)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ModelResponseProperties), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ModelResponseProperties?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ModelResponseProperties).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.ModelResponseProperties!, typeInfo);
                if (__element0.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element0.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            writer.WriteEndObject();
        }
    }
}