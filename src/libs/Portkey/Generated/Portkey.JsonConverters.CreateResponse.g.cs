#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public class CreateResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.CreateResponse>
    {
        /// <inheritdoc />
        public override global::Portkey.CreateResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::Portkey.CreateModelResponseProperties? modelProperties = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.CreateModelResponseProperties), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.CreateModelResponseProperties> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.CreateModelResponseProperties).Name}");
                modelProperties = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::Portkey.ResponseProperties? properties = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseProperties), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseProperties> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ResponseProperties).Name}");
                properties = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::Portkey.CreateResponseVariant3? createResponseVariant3 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.CreateResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.CreateResponseVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.CreateResponseVariant3).Name}");
                createResponseVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::Portkey.CreateResponse(
                modelProperties,

                properties,

                createResponseVariant3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.CreateResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsModelProperties)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.CreateModelResponseProperties), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.CreateModelResponseProperties> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.CreateModelResponseProperties).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.ModelProperties!.Value, typeInfo);
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
            if (value.IsProperties)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.ResponseProperties), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.ResponseProperties?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.ResponseProperties).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.Properties!, typeInfo);
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
            if (value.IsCreateResponseVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.CreateResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.CreateResponseVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.CreateResponseVariant3).Name}");
                var __element2 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.CreateResponseVariant3!, typeInfo);
                if (__element2.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element2.EnumerateObject())
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