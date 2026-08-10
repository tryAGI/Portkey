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
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("connection_status")) __score0++;
            if (__jsonProps.Contains("created_at")) __score0++;
            if (__jsonProps.Contains("created_by")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("is_default")) __score0++;
            if (__jsonProps.Contains("last_resynced_at")) __score0++;
            if (__jsonProps.Contains("last_synced_at")) __score0++;
            if (__jsonProps.Contains("last_updated_at")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("object")) __score0++;
            if (__jsonProps.Contains("slug")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("auth_settings")) __score1++;
            if (__jsonProps.Contains("client_auth")) __score1++;
            if (__jsonProps.Contains("credentials")) __score1++;
            if (__jsonProps.Contains("deployment_config")) __score1++;
            if (__jsonProps.Contains("workspaces")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Portkey.DeploymentListItem? listItem = default;
            global::Portkey.DeploymentDetailResponseVariant2? deploymentDetailResponseVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
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
                }
                else if (__bestIndex == 1)
                {
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
                }
            }

            if (listItem == null && deploymentDetailResponseVariant2 == null)
            {
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
            }

            if (listItem == null && deploymentDetailResponseVariant2 == null)
            {
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

            if (value.IsListItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.DeploymentListItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.DeploymentListItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.DeploymentListItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListItem!, typeInfo);
            }
            else if (value.IsDeploymentDetailResponseVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.DeploymentDetailResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.DeploymentDetailResponseVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.DeploymentDetailResponseVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeploymentDetailResponseVariant2!, typeInfo);
            }
        }
    }
}