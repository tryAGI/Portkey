
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Condition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GroupBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateUsageLimitsPolicyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.Condition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GroupBy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateUsageLimitsPolicyRequestType), TypeInfoPropertyName = "CreateUsageLimitsPolicyRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateUsageLimitsPolicyRequestPeriodicReset), TypeInfoPropertyName = "CreateUsageLimitsPolicyRequestPeriodicReset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateUsageLimitsPolicyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateUsageLimitsPolicyRequestPeriodicReset), TypeInfoPropertyName = "UpdateUsageLimitsPolicyRequestPeriodicReset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsPolicy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsPolicyType), TypeInfoPropertyName = "UsageLimitsPolicyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsPolicyPeriodicReset), TypeInfoPropertyName = "UsageLimitsPolicyPeriodicReset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsPolicyStatus), TypeInfoPropertyName = "UsageLimitsPolicyStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Portkey.ValueKeyUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ValueKeyUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ValueKeyUsageStatus), TypeInfoPropertyName = "ValueKeyUsageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreatePolicyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsPolicyListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.UsageLimitsPolicy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsPolicyResponse), TypeInfoPropertyName = "UsageLimitsPolicyResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsPolicyResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsPolicyEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsPolicyEntityListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.UsageLimitsPolicyEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListUsageLimitsPoliciesStatus), TypeInfoPropertyName = "ListUsageLimitsPoliciesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListUsageLimitsPoliciesType), TypeInfoPropertyName = "ListUsageLimitsPoliciesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetUsageLimitsPolicyStatus), TypeInfoPropertyName = "GetUsageLimitsPolicyStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListUsageLimitsPolicyEntitiesStatus), TypeInfoPropertyName = "ListUsageLimitsPolicyEntitiesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableOneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateUsageLimitsPolicyRequestType?), TypeInfoPropertyName = "NullableCreateUsageLimitsPolicyRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateUsageLimitsPolicyRequestPeriodicReset?), TypeInfoPropertyName = "NullableCreateUsageLimitsPolicyRequestPeriodicReset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateUsageLimitsPolicyRequestPeriodicReset?), TypeInfoPropertyName = "NullableUpdateUsageLimitsPolicyRequestPeriodicReset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsPolicyType?), TypeInfoPropertyName = "NullableUsageLimitsPolicyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsPolicyPeriodicReset?), TypeInfoPropertyName = "NullableUsageLimitsPolicyPeriodicReset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsPolicyStatus?), TypeInfoPropertyName = "NullableUsageLimitsPolicyStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ValueKeyUsageStatus?), TypeInfoPropertyName = "NullableValueKeyUsageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsPolicyResponse?), TypeInfoPropertyName = "NullableUsageLimitsPolicyResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListUsageLimitsPoliciesStatus?), TypeInfoPropertyName = "NullableListUsageLimitsPoliciesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListUsageLimitsPoliciesType?), TypeInfoPropertyName = "NullableListUsageLimitsPoliciesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetUsageLimitsPolicyStatus?), TypeInfoPropertyName = "NullableGetUsageLimitsPolicyStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListUsageLimitsPolicyEntitiesStatus?), TypeInfoPropertyName = "NullableListUsageLimitsPolicyEntitiesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.Condition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GroupBy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.UsageLimitsPolicy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.UsageLimitsPolicyEntity>))]
    internal sealed partial class UsageLimitsPoliciesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UsageLimitsPoliciesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static UsageLimitsPoliciesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private UsageLimitsPoliciesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Portkey.JsonConverters.UsageLimitsPolicyResponseJsonConverter());
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
                    typeToConvert == typeof(global::Portkey.CreateUsageLimitsPolicyRequestType)

                    || typeToConvert == typeof(global::Portkey.CreateUsageLimitsPolicyRequestType?)

                    || typeToConvert == typeof(global::Portkey.CreateUsageLimitsPolicyRequestPeriodicReset)

                    || typeToConvert == typeof(global::Portkey.CreateUsageLimitsPolicyRequestPeriodicReset?)

                    || typeToConvert == typeof(global::Portkey.UpdateUsageLimitsPolicyRequestPeriodicReset)

                    || typeToConvert == typeof(global::Portkey.UpdateUsageLimitsPolicyRequestPeriodicReset?)

                    || typeToConvert == typeof(global::Portkey.UsageLimitsPolicyType)

                    || typeToConvert == typeof(global::Portkey.UsageLimitsPolicyType?)

                    || typeToConvert == typeof(global::Portkey.UsageLimitsPolicyPeriodicReset)

                    || typeToConvert == typeof(global::Portkey.UsageLimitsPolicyPeriodicReset?)

                    || typeToConvert == typeof(global::Portkey.UsageLimitsPolicyStatus)

                    || typeToConvert == typeof(global::Portkey.UsageLimitsPolicyStatus?)

                    || typeToConvert == typeof(global::Portkey.ValueKeyUsageStatus)

                    || typeToConvert == typeof(global::Portkey.ValueKeyUsageStatus?)

                    || typeToConvert == typeof(global::Portkey.ListUsageLimitsPoliciesStatus)

                    || typeToConvert == typeof(global::Portkey.ListUsageLimitsPoliciesStatus?)

                    || typeToConvert == typeof(global::Portkey.ListUsageLimitsPoliciesType)

                    || typeToConvert == typeof(global::Portkey.ListUsageLimitsPoliciesType?)

                    || typeToConvert == typeof(global::Portkey.GetUsageLimitsPolicyStatus)

                    || typeToConvert == typeof(global::Portkey.GetUsageLimitsPolicyStatus?)

                    || typeToConvert == typeof(global::Portkey.ListUsageLimitsPolicyEntitiesStatus)

                    || typeToConvert == typeof(global::Portkey.ListUsageLimitsPolicyEntitiesStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Portkey.CreateUsageLimitsPolicyRequestType))
                {
                    return new global::Portkey.JsonConverters.CreateUsageLimitsPolicyRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateUsageLimitsPolicyRequestType?))
                {
                    return new global::Portkey.JsonConverters.CreateUsageLimitsPolicyRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateUsageLimitsPolicyRequestPeriodicReset))
                {
                    return new global::Portkey.JsonConverters.CreateUsageLimitsPolicyRequestPeriodicResetJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateUsageLimitsPolicyRequestPeriodicReset?))
                {
                    return new global::Portkey.JsonConverters.CreateUsageLimitsPolicyRequestPeriodicResetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UpdateUsageLimitsPolicyRequestPeriodicReset))
                {
                    return new global::Portkey.JsonConverters.UpdateUsageLimitsPolicyRequestPeriodicResetJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UpdateUsageLimitsPolicyRequestPeriodicReset?))
                {
                    return new global::Portkey.JsonConverters.UpdateUsageLimitsPolicyRequestPeriodicResetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UsageLimitsPolicyType))
                {
                    return new global::Portkey.JsonConverters.UsageLimitsPolicyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UsageLimitsPolicyType?))
                {
                    return new global::Portkey.JsonConverters.UsageLimitsPolicyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UsageLimitsPolicyPeriodicReset))
                {
                    return new global::Portkey.JsonConverters.UsageLimitsPolicyPeriodicResetJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UsageLimitsPolicyPeriodicReset?))
                {
                    return new global::Portkey.JsonConverters.UsageLimitsPolicyPeriodicResetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UsageLimitsPolicyStatus))
                {
                    return new global::Portkey.JsonConverters.UsageLimitsPolicyStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UsageLimitsPolicyStatus?))
                {
                    return new global::Portkey.JsonConverters.UsageLimitsPolicyStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ValueKeyUsageStatus))
                {
                    return new global::Portkey.JsonConverters.ValueKeyUsageStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ValueKeyUsageStatus?))
                {
                    return new global::Portkey.JsonConverters.ValueKeyUsageStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListUsageLimitsPoliciesStatus))
                {
                    return new global::Portkey.JsonConverters.ListUsageLimitsPoliciesStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListUsageLimitsPoliciesStatus?))
                {
                    return new global::Portkey.JsonConverters.ListUsageLimitsPoliciesStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListUsageLimitsPoliciesType))
                {
                    return new global::Portkey.JsonConverters.ListUsageLimitsPoliciesTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListUsageLimitsPoliciesType?))
                {
                    return new global::Portkey.JsonConverters.ListUsageLimitsPoliciesTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetUsageLimitsPolicyStatus))
                {
                    return new global::Portkey.JsonConverters.GetUsageLimitsPolicyStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetUsageLimitsPolicyStatus?))
                {
                    return new global::Portkey.JsonConverters.GetUsageLimitsPolicyStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListUsageLimitsPolicyEntitiesStatus))
                {
                    return new global::Portkey.JsonConverters.ListUsageLimitsPolicyEntitiesStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListUsageLimitsPolicyEntitiesStatus?))
                {
                    return new global::Portkey.JsonConverters.ListUsageLimitsPolicyEntitiesStatusNullableJsonConverter();
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
                    0 => new UsageLimitsPoliciesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}