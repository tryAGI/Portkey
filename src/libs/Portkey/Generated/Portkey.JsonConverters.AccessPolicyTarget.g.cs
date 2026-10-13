#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Portkey.JsonConverters
{
    /// <inheritdoc />
    public class AccessPolicyTargetJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Portkey.AccessPolicyTarget>
    {
        /// <inheritdoc />
        public override global::Portkey.AccessPolicyTarget Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.AccessPolicyTargetDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.AccessPolicyTargetDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.AccessPolicyTargetDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Portkey.AccessPolicyMcpServerTarget? mcpServer = default;
            if (discriminator?.Type == global::Portkey.AccessPolicyTargetDiscriminatorType.McpServer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.AccessPolicyMcpServerTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.AccessPolicyMcpServerTarget> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.AccessPolicyMcpServerTarget)}");
                mcpServer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Portkey.AccessPolicyProviderTarget? provider = default;
            if (discriminator?.Type == global::Portkey.AccessPolicyTargetDiscriminatorType.Provider)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.AccessPolicyProviderTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.AccessPolicyProviderTarget> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Portkey.AccessPolicyProviderTarget)}");
                provider = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Portkey.AccessPolicyTarget(
                discriminator?.Type,
                mcpServer,

                provider
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Portkey.AccessPolicyTarget value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMcpServer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.AccessPolicyMcpServerTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.AccessPolicyMcpServerTarget?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.AccessPolicyMcpServerTarget).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickMcpServer(), typeInfo);
            }
            else if (value.IsProvider)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Portkey.AccessPolicyProviderTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Portkey.AccessPolicyProviderTarget?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Portkey.AccessPolicyProviderTarget).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickProvider(), typeInfo);
            }
        }
    }
}