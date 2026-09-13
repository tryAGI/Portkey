
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.SecretMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretMapping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretMappingValueFormat), TypeInfoPropertyName = "SecretMappingValueFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateMcpIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateMcpIntegrationConfigurations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateMcpIntegrationAuthType), TypeInfoPropertyName = "CreateMcpIntegrationAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateMcpIntegrationTransport), TypeInfoPropertyName = "CreateMcpIntegrationTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationAuthType), TypeInfoPropertyName = "McpIntegrationAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationTransport), TypeInfoPropertyName = "McpIntegrationTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationType), TypeInfoPropertyName = "McpIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationListItemType), TypeInfoPropertyName = "McpIntegrationListItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationListItemAuthType), TypeInfoPropertyName = "McpIntegrationListItemAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationListItemTransport), TypeInfoPropertyName = "McpIntegrationListItemTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.McpIntegrationListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateMcpIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateMcpIntegrationConfigurations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateMcpIntegrationAuthType), TypeInfoPropertyName = "UpdateMcpIntegrationAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateMcpIntegrationTransport), TypeInfoPropertyName = "UpdateMcpIntegrationTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationsListType), TypeInfoPropertyName = "McpIntegrationsListType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretMappingValueFormat?), TypeInfoPropertyName = "NullableSecretMappingValueFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateMcpIntegrationAuthType?), TypeInfoPropertyName = "NullableCreateMcpIntegrationAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateMcpIntegrationTransport?), TypeInfoPropertyName = "NullableCreateMcpIntegrationTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationAuthType?), TypeInfoPropertyName = "NullableMcpIntegrationAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationTransport?), TypeInfoPropertyName = "NullableMcpIntegrationTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationType?), TypeInfoPropertyName = "NullableMcpIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationListItemType?), TypeInfoPropertyName = "NullableMcpIntegrationListItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationListItemAuthType?), TypeInfoPropertyName = "NullableMcpIntegrationListItemAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationListItemTransport?), TypeInfoPropertyName = "NullableMcpIntegrationListItemTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateMcpIntegrationAuthType?), TypeInfoPropertyName = "NullableUpdateMcpIntegrationAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateMcpIntegrationTransport?), TypeInfoPropertyName = "NullableUpdateMcpIntegrationTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.McpIntegrationsListType?), TypeInfoPropertyName = "NullableMcpIntegrationsListType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.SecretMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.McpIntegrationListItem>))]
    internal sealed partial class McpIntegrationsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class McpIntegrationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static McpIntegrationsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private McpIntegrationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.Dictionary<string, string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Portkey.SecretMappingValueFormat)

                    || typeToConvert == typeof(global::Portkey.SecretMappingValueFormat?)

                    || typeToConvert == typeof(global::Portkey.CreateMcpIntegrationAuthType)

                    || typeToConvert == typeof(global::Portkey.CreateMcpIntegrationAuthType?)

                    || typeToConvert == typeof(global::Portkey.CreateMcpIntegrationTransport)

                    || typeToConvert == typeof(global::Portkey.CreateMcpIntegrationTransport?)

                    || typeToConvert == typeof(global::Portkey.McpIntegrationAuthType)

                    || typeToConvert == typeof(global::Portkey.McpIntegrationAuthType?)

                    || typeToConvert == typeof(global::Portkey.McpIntegrationTransport)

                    || typeToConvert == typeof(global::Portkey.McpIntegrationTransport?)

                    || typeToConvert == typeof(global::Portkey.McpIntegrationType)

                    || typeToConvert == typeof(global::Portkey.McpIntegrationType?)

                    || typeToConvert == typeof(global::Portkey.McpIntegrationListItemType)

                    || typeToConvert == typeof(global::Portkey.McpIntegrationListItemType?)

                    || typeToConvert == typeof(global::Portkey.McpIntegrationListItemAuthType)

                    || typeToConvert == typeof(global::Portkey.McpIntegrationListItemAuthType?)

                    || typeToConvert == typeof(global::Portkey.McpIntegrationListItemTransport)

                    || typeToConvert == typeof(global::Portkey.McpIntegrationListItemTransport?)

                    || typeToConvert == typeof(global::Portkey.UpdateMcpIntegrationAuthType)

                    || typeToConvert == typeof(global::Portkey.UpdateMcpIntegrationAuthType?)

                    || typeToConvert == typeof(global::Portkey.UpdateMcpIntegrationTransport)

                    || typeToConvert == typeof(global::Portkey.UpdateMcpIntegrationTransport?)

                    || typeToConvert == typeof(global::Portkey.McpIntegrationsListType)

                    || typeToConvert == typeof(global::Portkey.McpIntegrationsListType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Portkey.SecretMappingValueFormat))
                {
                    return new global::Portkey.JsonConverters.SecretMappingValueFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.SecretMappingValueFormat?))
                {
                    return new global::Portkey.JsonConverters.SecretMappingValueFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateMcpIntegrationAuthType))
                {
                    return new global::Portkey.JsonConverters.CreateMcpIntegrationAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateMcpIntegrationAuthType?))
                {
                    return new global::Portkey.JsonConverters.CreateMcpIntegrationAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateMcpIntegrationTransport))
                {
                    return new global::Portkey.JsonConverters.CreateMcpIntegrationTransportJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateMcpIntegrationTransport?))
                {
                    return new global::Portkey.JsonConverters.CreateMcpIntegrationTransportNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpIntegrationAuthType))
                {
                    return new global::Portkey.JsonConverters.McpIntegrationAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpIntegrationAuthType?))
                {
                    return new global::Portkey.JsonConverters.McpIntegrationAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpIntegrationTransport))
                {
                    return new global::Portkey.JsonConverters.McpIntegrationTransportJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpIntegrationTransport?))
                {
                    return new global::Portkey.JsonConverters.McpIntegrationTransportNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpIntegrationType))
                {
                    return new global::Portkey.JsonConverters.McpIntegrationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpIntegrationType?))
                {
                    return new global::Portkey.JsonConverters.McpIntegrationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpIntegrationListItemType))
                {
                    return new global::Portkey.JsonConverters.McpIntegrationListItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpIntegrationListItemType?))
                {
                    return new global::Portkey.JsonConverters.McpIntegrationListItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpIntegrationListItemAuthType))
                {
                    return new global::Portkey.JsonConverters.McpIntegrationListItemAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpIntegrationListItemAuthType?))
                {
                    return new global::Portkey.JsonConverters.McpIntegrationListItemAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpIntegrationListItemTransport))
                {
                    return new global::Portkey.JsonConverters.McpIntegrationListItemTransportJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpIntegrationListItemTransport?))
                {
                    return new global::Portkey.JsonConverters.McpIntegrationListItemTransportNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UpdateMcpIntegrationAuthType))
                {
                    return new global::Portkey.JsonConverters.UpdateMcpIntegrationAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UpdateMcpIntegrationAuthType?))
                {
                    return new global::Portkey.JsonConverters.UpdateMcpIntegrationAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UpdateMcpIntegrationTransport))
                {
                    return new global::Portkey.JsonConverters.UpdateMcpIntegrationTransportJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UpdateMcpIntegrationTransport?))
                {
                    return new global::Portkey.JsonConverters.UpdateMcpIntegrationTransportNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpIntegrationsListType))
                {
                    return new global::Portkey.JsonConverters.McpIntegrationsListTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.McpIntegrationsListType?))
                {
                    return new global::Portkey.JsonConverters.McpIntegrationsListTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new McpIntegrationsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}