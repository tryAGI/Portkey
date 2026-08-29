#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public class IntegrationDetailResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.IntegrationDetailResponse>
    {
        /// <inheritdoc />
        public override global::Portkey.IntegrationDetailResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::Portkey.IntegrationList? list = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.IntegrationList), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.IntegrationList> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.IntegrationList).Name}");
                list = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::Portkey.IntegrationDetailResponseVariant2? integrationDetailResponseVariant2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.IntegrationDetailResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.IntegrationDetailResponseVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.IntegrationDetailResponseVariant2).Name}");
                integrationDetailResponseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::Portkey.IntegrationDetailResponse(
                list,

                integrationDetailResponseVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.IntegrationDetailResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsList)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.IntegrationList), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.IntegrationList?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.IntegrationList).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.List!, typeInfo);
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
            if (value.IsIntegrationDetailResponseVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.IntegrationDetailResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.IntegrationDetailResponseVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.IntegrationDetailResponseVariant2).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.IntegrationDetailResponseVariant2!, typeInfo);
                if (__element1.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element1.EnumerateObject())
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