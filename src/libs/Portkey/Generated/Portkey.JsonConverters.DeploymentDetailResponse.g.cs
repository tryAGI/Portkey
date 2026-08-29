#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public class DeploymentDetailResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.DeploymentDetailResponse>
    {
        /// <inheritdoc />
        public override global::Portkey.DeploymentDetailResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::Portkey.DeploymentListItem? listItem = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.DeploymentListItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.DeploymentListItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.DeploymentListItem).Name}");
                listItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::Portkey.DeploymentDetailResponseVariant2? deploymentDetailResponseVariant2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.DeploymentDetailResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.DeploymentDetailResponseVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.DeploymentDetailResponseVariant2).Name}");
                deploymentDetailResponseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::Portkey.DeploymentDetailResponse(
                listItem,

                deploymentDetailResponseVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.DeploymentDetailResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsListItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.DeploymentListItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.DeploymentListItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.DeploymentListItem).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.ListItem!, typeInfo);
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
            if (value.IsDeploymentDetailResponseVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.DeploymentDetailResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.DeploymentDetailResponseVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.DeploymentDetailResponseVariant2).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.DeploymentDetailResponseVariant2!, typeInfo);
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