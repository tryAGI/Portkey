
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsType), TypeInfoPropertyName = "RateLimitsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsUnit), TypeInfoPropertyName = "RateLimitsUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsType), TypeInfoPropertyName = "UsageLimitsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsPeriodicReset), TypeInfoPropertyName = "UsageLimitsPeriodicReset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.SecretMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretMapping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.RateLimits>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretMappingValueFormat), TypeInfoPropertyName = "SecretMappingValueFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VirtualKeys))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VirtualKeysStatus), TypeInfoPropertyName = "VirtualKeysStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VirtualKeysObject), TypeInfoPropertyName = "VirtualKeysObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateVirtualKeysRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateVirtualKeysRequestProvider), TypeInfoPropertyName = "CreateVirtualKeysRequestProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.CreateVirtualKeysRequestDeploymentConfigItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateVirtualKeysRequestDeploymentConfigItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PutVirtualKeysRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.PutVirtualKeysRequestDeploymentConfigItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PutVirtualKeysRequestDeploymentConfigItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetVirtualKeysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetVirtualKeysResponseObject), TypeInfoPropertyName = "GetVirtualKeysResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.VirtualKeys>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetVirtualKeysResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetVirtualKeysResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateVirtualKeysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateVirtualKeysResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateVirtualKeysResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateVirtualKeysResponseData2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetVirtualKeysResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetVirtualKeysResponseData2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PutVirtualKeysResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PutVirtualKeysResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeleteVirtualKeysResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeleteVirtualKeysResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsType?), TypeInfoPropertyName = "NullableRateLimitsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsUnit?), TypeInfoPropertyName = "NullableRateLimitsUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsType?), TypeInfoPropertyName = "NullableUsageLimitsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsPeriodicReset?), TypeInfoPropertyName = "NullableUsageLimitsPeriodicReset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretMappingValueFormat?), TypeInfoPropertyName = "NullableSecretMappingValueFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VirtualKeysStatus?), TypeInfoPropertyName = "NullableVirtualKeysStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VirtualKeysObject?), TypeInfoPropertyName = "NullableVirtualKeysObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateVirtualKeysRequestProvider?), TypeInfoPropertyName = "NullableCreateVirtualKeysRequestProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetVirtualKeysResponseObject?), TypeInfoPropertyName = "NullableGetVirtualKeysResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.SecretMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.RateLimits>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.CreateVirtualKeysRequestDeploymentConfigItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.PutVirtualKeysRequestDeploymentConfigItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.VirtualKeys>))]
    internal sealed partial class VirtualKeysSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VirtualKeysSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static VirtualKeysSourceGenerationContext Default { get; } = new(DefaultOptions);

        private VirtualKeysSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Portkey.RateLimitsType)

                    || typeToConvert == typeof(global::Portkey.RateLimitsType?)

                    || typeToConvert == typeof(global::Portkey.RateLimitsUnit)

                    || typeToConvert == typeof(global::Portkey.RateLimitsUnit?)

                    || typeToConvert == typeof(global::Portkey.UsageLimitsType)

                    || typeToConvert == typeof(global::Portkey.UsageLimitsType?)

                    || typeToConvert == typeof(global::Portkey.UsageLimitsPeriodicReset)

                    || typeToConvert == typeof(global::Portkey.UsageLimitsPeriodicReset?)

                    || typeToConvert == typeof(global::Portkey.SecretMappingValueFormat)

                    || typeToConvert == typeof(global::Portkey.SecretMappingValueFormat?)

                    || typeToConvert == typeof(global::Portkey.VirtualKeysStatus)

                    || typeToConvert == typeof(global::Portkey.VirtualKeysStatus?)

                    || typeToConvert == typeof(global::Portkey.VirtualKeysObject)

                    || typeToConvert == typeof(global::Portkey.VirtualKeysObject?)

                    || typeToConvert == typeof(global::Portkey.CreateVirtualKeysRequestProvider)

                    || typeToConvert == typeof(global::Portkey.CreateVirtualKeysRequestProvider?)

                    || typeToConvert == typeof(global::Portkey.GetVirtualKeysResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetVirtualKeysResponseObject?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Portkey.RateLimitsType))
                {
                    return new global::Portkey.JsonConverters.RateLimitsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RateLimitsType?))
                {
                    return new global::Portkey.JsonConverters.RateLimitsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RateLimitsUnit))
                {
                    return new global::Portkey.JsonConverters.RateLimitsUnitJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RateLimitsUnit?))
                {
                    return new global::Portkey.JsonConverters.RateLimitsUnitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UsageLimitsType))
                {
                    return new global::Portkey.JsonConverters.UsageLimitsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UsageLimitsType?))
                {
                    return new global::Portkey.JsonConverters.UsageLimitsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UsageLimitsPeriodicReset))
                {
                    return new global::Portkey.JsonConverters.UsageLimitsPeriodicResetJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UsageLimitsPeriodicReset?))
                {
                    return new global::Portkey.JsonConverters.UsageLimitsPeriodicResetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.SecretMappingValueFormat))
                {
                    return new global::Portkey.JsonConverters.SecretMappingValueFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.SecretMappingValueFormat?))
                {
                    return new global::Portkey.JsonConverters.SecretMappingValueFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VirtualKeysStatus))
                {
                    return new global::Portkey.JsonConverters.VirtualKeysStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VirtualKeysStatus?))
                {
                    return new global::Portkey.JsonConverters.VirtualKeysStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VirtualKeysObject))
                {
                    return new global::Portkey.JsonConverters.VirtualKeysObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VirtualKeysObject?))
                {
                    return new global::Portkey.JsonConverters.VirtualKeysObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateVirtualKeysRequestProvider))
                {
                    return new global::Portkey.JsonConverters.CreateVirtualKeysRequestProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateVirtualKeysRequestProvider?))
                {
                    return new global::Portkey.JsonConverters.CreateVirtualKeysRequestProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetVirtualKeysResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetVirtualKeysResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetVirtualKeysResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetVirtualKeysResponseObjectNullableJsonConverter();
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
                    0 => new VirtualKeysSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}