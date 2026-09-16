
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsProviderIncludeTotal), TypeInfoPropertyName = "GetAnalyticsGroupsProviderIncludeTotal2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsUsersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsUsersResponseObject), TypeInfoPropertyName = "GetAnalyticsGroupsUsersResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsUsersResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsUsersResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsUsersResponseDataItemObject), TypeInfoPropertyName = "GetAnalyticsGroupsUsersResponseDataItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsAiModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsAiModelsResponseObject), TypeInfoPropertyName = "GetAnalyticsGroupsAiModelsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItemObject), TypeInfoPropertyName = "GetAnalyticsGroupsAiModelsResponseDataItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsProviderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsProviderResponseObject), TypeInfoPropertyName = "GetAnalyticsGroupsProviderResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsProviderResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsProviderResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsMetadataResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsMetadataResponseObject), TypeInfoPropertyName = "GetAnalyticsGroupsMetadataResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsMetadataResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsMetadataResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsMetadataResponseDataItemObject), TypeInfoPropertyName = "GetAnalyticsGroupsMetadataResponseDataItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsMcpResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsMcpResponseObject), TypeInfoPropertyName = "GetAnalyticsGroupsMcpResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsMcpResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsMcpResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsMcpResponseDataItemObject), TypeInfoPropertyName = "GetAnalyticsGroupsMcpResponseDataItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsA2aResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsA2aResponseObject), TypeInfoPropertyName = "GetAnalyticsGroupsA2aResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsA2aResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsA2aResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsA2aResponseDataItemObject), TypeInfoPropertyName = "GetAnalyticsGroupsA2aResponseDataItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsWorkspacesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsWorkspacesResponseObject), TypeInfoPropertyName = "GetAnalyticsGroupsWorkspacesResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGroupsWorkspacesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsWorkspacesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsWorkspacesResponseDataItemObject), TypeInfoPropertyName = "GetAnalyticsGroupsWorkspacesResponseDataItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsProviderIncludeTotal?), TypeInfoPropertyName = "NullableGetAnalyticsGroupsProviderIncludeTotal2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsUsersResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGroupsUsersResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsUsersResponseDataItemObject?), TypeInfoPropertyName = "NullableGetAnalyticsGroupsUsersResponseDataItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsAiModelsResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGroupsAiModelsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItemObject?), TypeInfoPropertyName = "NullableGetAnalyticsGroupsAiModelsResponseDataItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsProviderResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGroupsProviderResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsMetadataResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGroupsMetadataResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsMetadataResponseDataItemObject?), TypeInfoPropertyName = "NullableGetAnalyticsGroupsMetadataResponseDataItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsMcpResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGroupsMcpResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsMcpResponseDataItemObject?), TypeInfoPropertyName = "NullableGetAnalyticsGroupsMcpResponseDataItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsA2aResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGroupsA2aResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsA2aResponseDataItemObject?), TypeInfoPropertyName = "NullableGetAnalyticsGroupsA2aResponseDataItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsWorkspacesResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGroupsWorkspacesResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGroupsWorkspacesResponseDataItemObject?), TypeInfoPropertyName = "NullableGetAnalyticsGroupsWorkspacesResponseDataItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGroupsUsersResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGroupsProviderResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGroupsMetadataResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGroupsMcpResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGroupsA2aResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGroupsWorkspacesResponseDataItem>))]
    internal sealed partial class AnalyticsGroupsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnalyticsGroupsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AnalyticsGroupsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AnalyticsGroupsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsProviderIncludeTotal)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsProviderIncludeTotal?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsUsersResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsUsersResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsUsersResponseDataItemObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsUsersResponseDataItemObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsAiModelsResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsAiModelsResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItemObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItemObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsProviderResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsProviderResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsMetadataResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsMetadataResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsMetadataResponseDataItemObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsMetadataResponseDataItemObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsMcpResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsMcpResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsMcpResponseDataItemObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsMcpResponseDataItemObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsA2aResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsA2aResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsA2aResponseDataItemObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsA2aResponseDataItemObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsWorkspacesResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsWorkspacesResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsWorkspacesResponseDataItemObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsWorkspacesResponseDataItemObject?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsProviderIncludeTotal))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsProviderIncludeTotalJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsProviderIncludeTotal?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsProviderIncludeTotalNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsUsersResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsUsersResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsUsersResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsUsersResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsUsersResponseDataItemObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsUsersResponseDataItemObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsUsersResponseDataItemObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsUsersResponseDataItemObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsAiModelsResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsAiModelsResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsAiModelsResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsAiModelsResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItemObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsAiModelsResponseDataItemObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsAiModelsResponseDataItemObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsAiModelsResponseDataItemObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsProviderResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsProviderResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsProviderResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsProviderResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsMetadataResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsMetadataResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsMetadataResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsMetadataResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsMetadataResponseDataItemObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsMetadataResponseDataItemObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsMetadataResponseDataItemObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsMetadataResponseDataItemObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsMcpResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsMcpResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsMcpResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsMcpResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsMcpResponseDataItemObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsMcpResponseDataItemObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsMcpResponseDataItemObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsMcpResponseDataItemObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsA2aResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsA2aResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsA2aResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsA2aResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsA2aResponseDataItemObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsA2aResponseDataItemObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsA2aResponseDataItemObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsA2aResponseDataItemObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsWorkspacesResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsWorkspacesResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsWorkspacesResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsWorkspacesResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsWorkspacesResponseDataItemObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsWorkspacesResponseDataItemObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGroupsWorkspacesResponseDataItemObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGroupsWorkspacesResponseDataItemObjectNullableJsonConverter();
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
                    0 => new AnalyticsGroupsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}