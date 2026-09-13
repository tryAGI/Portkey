
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Condition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GroupBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.Condition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GroupBy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateRateLimitsPolicyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateRateLimitsPolicyRequestType), TypeInfoPropertyName = "CreateRateLimitsPolicyRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateRateLimitsPolicyRequestUnit), TypeInfoPropertyName = "CreateRateLimitsPolicyRequestUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateRateLimitsPolicyRequestTarget), TypeInfoPropertyName = "CreateRateLimitsPolicyRequestTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateRateLimitsPolicyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateRateLimitsPolicyRequestUnit), TypeInfoPropertyName = "UpdateRateLimitsPolicyRequestUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsPolicy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsPolicyType), TypeInfoPropertyName = "RateLimitsPolicyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsPolicyUnit), TypeInfoPropertyName = "RateLimitsPolicyUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsPolicyStatus), TypeInfoPropertyName = "RateLimitsPolicyStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsPolicyTarget), TypeInfoPropertyName = "RateLimitsPolicyTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreatePolicyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsPolicyListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.RateLimitsPolicy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsPolicyResponse), TypeInfoPropertyName = "RateLimitsPolicyResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsPolicyResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListRateLimitsPoliciesStatus), TypeInfoPropertyName = "ListRateLimitsPoliciesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListRateLimitsPoliciesType), TypeInfoPropertyName = "ListRateLimitsPoliciesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListRateLimitsPoliciesUnit), TypeInfoPropertyName = "ListRateLimitsPoliciesUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListRateLimitsPoliciesTarget), TypeInfoPropertyName = "ListRateLimitsPoliciesTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetRateLimitsPolicyStatus), TypeInfoPropertyName = "GetRateLimitsPolicyStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableOneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateRateLimitsPolicyRequestType?), TypeInfoPropertyName = "NullableCreateRateLimitsPolicyRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateRateLimitsPolicyRequestUnit?), TypeInfoPropertyName = "NullableCreateRateLimitsPolicyRequestUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateRateLimitsPolicyRequestTarget?), TypeInfoPropertyName = "NullableCreateRateLimitsPolicyRequestTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateRateLimitsPolicyRequestUnit?), TypeInfoPropertyName = "NullableUpdateRateLimitsPolicyRequestUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsPolicyType?), TypeInfoPropertyName = "NullableRateLimitsPolicyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsPolicyUnit?), TypeInfoPropertyName = "NullableRateLimitsPolicyUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsPolicyStatus?), TypeInfoPropertyName = "NullableRateLimitsPolicyStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsPolicyTarget?), TypeInfoPropertyName = "NullableRateLimitsPolicyTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsPolicyResponse?), TypeInfoPropertyName = "NullableRateLimitsPolicyResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListRateLimitsPoliciesStatus?), TypeInfoPropertyName = "NullableListRateLimitsPoliciesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListRateLimitsPoliciesType?), TypeInfoPropertyName = "NullableListRateLimitsPoliciesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListRateLimitsPoliciesUnit?), TypeInfoPropertyName = "NullableListRateLimitsPoliciesUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListRateLimitsPoliciesTarget?), TypeInfoPropertyName = "NullableListRateLimitsPoliciesTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetRateLimitsPolicyStatus?), TypeInfoPropertyName = "NullableGetRateLimitsPolicyStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.Condition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GroupBy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.RateLimitsPolicy>))]
    internal sealed partial class RateLimitsPoliciesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RateLimitsPoliciesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static RateLimitsPoliciesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private RateLimitsPoliciesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Portkey.JsonConverters.RateLimitsPolicyResponseJsonConverter());
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
                    typeToConvert == typeof(global::Portkey.CreateRateLimitsPolicyRequestType)

                    || typeToConvert == typeof(global::Portkey.CreateRateLimitsPolicyRequestType?)

                    || typeToConvert == typeof(global::Portkey.CreateRateLimitsPolicyRequestUnit)

                    || typeToConvert == typeof(global::Portkey.CreateRateLimitsPolicyRequestUnit?)

                    || typeToConvert == typeof(global::Portkey.CreateRateLimitsPolicyRequestTarget)

                    || typeToConvert == typeof(global::Portkey.CreateRateLimitsPolicyRequestTarget?)

                    || typeToConvert == typeof(global::Portkey.UpdateRateLimitsPolicyRequestUnit)

                    || typeToConvert == typeof(global::Portkey.UpdateRateLimitsPolicyRequestUnit?)

                    || typeToConvert == typeof(global::Portkey.RateLimitsPolicyType)

                    || typeToConvert == typeof(global::Portkey.RateLimitsPolicyType?)

                    || typeToConvert == typeof(global::Portkey.RateLimitsPolicyUnit)

                    || typeToConvert == typeof(global::Portkey.RateLimitsPolicyUnit?)

                    || typeToConvert == typeof(global::Portkey.RateLimitsPolicyStatus)

                    || typeToConvert == typeof(global::Portkey.RateLimitsPolicyStatus?)

                    || typeToConvert == typeof(global::Portkey.RateLimitsPolicyTarget)

                    || typeToConvert == typeof(global::Portkey.RateLimitsPolicyTarget?)

                    || typeToConvert == typeof(global::Portkey.ListRateLimitsPoliciesStatus)

                    || typeToConvert == typeof(global::Portkey.ListRateLimitsPoliciesStatus?)

                    || typeToConvert == typeof(global::Portkey.ListRateLimitsPoliciesType)

                    || typeToConvert == typeof(global::Portkey.ListRateLimitsPoliciesType?)

                    || typeToConvert == typeof(global::Portkey.ListRateLimitsPoliciesUnit)

                    || typeToConvert == typeof(global::Portkey.ListRateLimitsPoliciesUnit?)

                    || typeToConvert == typeof(global::Portkey.ListRateLimitsPoliciesTarget)

                    || typeToConvert == typeof(global::Portkey.ListRateLimitsPoliciesTarget?)

                    || typeToConvert == typeof(global::Portkey.GetRateLimitsPolicyStatus)

                    || typeToConvert == typeof(global::Portkey.GetRateLimitsPolicyStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Portkey.CreateRateLimitsPolicyRequestType))
                {
                    return new global::Portkey.JsonConverters.CreateRateLimitsPolicyRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateRateLimitsPolicyRequestType?))
                {
                    return new global::Portkey.JsonConverters.CreateRateLimitsPolicyRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateRateLimitsPolicyRequestUnit))
                {
                    return new global::Portkey.JsonConverters.CreateRateLimitsPolicyRequestUnitJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateRateLimitsPolicyRequestUnit?))
                {
                    return new global::Portkey.JsonConverters.CreateRateLimitsPolicyRequestUnitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateRateLimitsPolicyRequestTarget))
                {
                    return new global::Portkey.JsonConverters.CreateRateLimitsPolicyRequestTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateRateLimitsPolicyRequestTarget?))
                {
                    return new global::Portkey.JsonConverters.CreateRateLimitsPolicyRequestTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UpdateRateLimitsPolicyRequestUnit))
                {
                    return new global::Portkey.JsonConverters.UpdateRateLimitsPolicyRequestUnitJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UpdateRateLimitsPolicyRequestUnit?))
                {
                    return new global::Portkey.JsonConverters.UpdateRateLimitsPolicyRequestUnitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RateLimitsPolicyType))
                {
                    return new global::Portkey.JsonConverters.RateLimitsPolicyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RateLimitsPolicyType?))
                {
                    return new global::Portkey.JsonConverters.RateLimitsPolicyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RateLimitsPolicyUnit))
                {
                    return new global::Portkey.JsonConverters.RateLimitsPolicyUnitJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RateLimitsPolicyUnit?))
                {
                    return new global::Portkey.JsonConverters.RateLimitsPolicyUnitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RateLimitsPolicyStatus))
                {
                    return new global::Portkey.JsonConverters.RateLimitsPolicyStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RateLimitsPolicyStatus?))
                {
                    return new global::Portkey.JsonConverters.RateLimitsPolicyStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RateLimitsPolicyTarget))
                {
                    return new global::Portkey.JsonConverters.RateLimitsPolicyTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RateLimitsPolicyTarget?))
                {
                    return new global::Portkey.JsonConverters.RateLimitsPolicyTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListRateLimitsPoliciesStatus))
                {
                    return new global::Portkey.JsonConverters.ListRateLimitsPoliciesStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListRateLimitsPoliciesStatus?))
                {
                    return new global::Portkey.JsonConverters.ListRateLimitsPoliciesStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListRateLimitsPoliciesType))
                {
                    return new global::Portkey.JsonConverters.ListRateLimitsPoliciesTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListRateLimitsPoliciesType?))
                {
                    return new global::Portkey.JsonConverters.ListRateLimitsPoliciesTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListRateLimitsPoliciesUnit))
                {
                    return new global::Portkey.JsonConverters.ListRateLimitsPoliciesUnitJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListRateLimitsPoliciesUnit?))
                {
                    return new global::Portkey.JsonConverters.ListRateLimitsPoliciesUnitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListRateLimitsPoliciesTarget))
                {
                    return new global::Portkey.JsonConverters.ListRateLimitsPoliciesTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListRateLimitsPoliciesTarget?))
                {
                    return new global::Portkey.JsonConverters.ListRateLimitsPoliciesTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetRateLimitsPolicyStatus))
                {
                    return new global::Portkey.JsonConverters.GetRateLimitsPolicyStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetRateLimitsPolicyStatus?))
                {
                    return new global::Portkey.JsonConverters.GetRateLimitsPolicyStatusNullableJsonConverter();
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
                    0 => new RateLimitsPoliciesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}