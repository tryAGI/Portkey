
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>), TypeInfoPropertyName = "OneOfStringIListStringIListInt32IListIListInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateEmbeddingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateEmbeddingRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateEmbeddingRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateEmbeddingRequestModel), TypeInfoPropertyName = "CreateEmbeddingRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateEmbeddingRequestEncodingFormat), TypeInfoPropertyName = "CreateEmbeddingRequestEncodingFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateEmbeddingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.Embedding>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Embedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateEmbeddingResponseObject), TypeInfoPropertyName = "CreateEmbeddingResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateEmbeddingResponseUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.EmbeddingObject), TypeInfoPropertyName = "EmbeddingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>?), TypeInfoPropertyName = "NullableOneOfStringIListStringIListInt32IListIListInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateEmbeddingRequestModel?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateEmbeddingRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateEmbeddingRequestModel?), TypeInfoPropertyName = "NullableCreateEmbeddingRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateEmbeddingRequestEncodingFormat?), TypeInfoPropertyName = "NullableCreateEmbeddingRequestEncodingFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateEmbeddingResponseObject?), TypeInfoPropertyName = "NullableCreateEmbeddingResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.EmbeddingObject?), TypeInfoPropertyName = "NullableEmbeddingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.List<string>, global::System.Collections.Generic.List<int>, global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.Embedding>))]
    internal sealed partial class EmbeddingsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EmbeddingsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static EmbeddingsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private EmbeddingsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateEmbeddingRequestModel?>());
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
                    typeToConvert == typeof(global::Portkey.CreateEmbeddingRequestModel)

                    || typeToConvert == typeof(global::Portkey.CreateEmbeddingRequestModel?)

                    || typeToConvert == typeof(global::Portkey.CreateEmbeddingRequestEncodingFormat)

                    || typeToConvert == typeof(global::Portkey.CreateEmbeddingRequestEncodingFormat?)

                    || typeToConvert == typeof(global::Portkey.CreateEmbeddingResponseObject)

                    || typeToConvert == typeof(global::Portkey.CreateEmbeddingResponseObject?)

                    || typeToConvert == typeof(global::Portkey.EmbeddingObject)

                    || typeToConvert == typeof(global::Portkey.EmbeddingObject?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Portkey.CreateEmbeddingRequestModel))
                {
                    return new global::Portkey.JsonConverters.CreateEmbeddingRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateEmbeddingRequestModel?))
                {
                    return new global::Portkey.JsonConverters.CreateEmbeddingRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateEmbeddingRequestEncodingFormat))
                {
                    return new global::Portkey.JsonConverters.CreateEmbeddingRequestEncodingFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateEmbeddingRequestEncodingFormat?))
                {
                    return new global::Portkey.JsonConverters.CreateEmbeddingRequestEncodingFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateEmbeddingResponseObject))
                {
                    return new global::Portkey.JsonConverters.CreateEmbeddingResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateEmbeddingResponseObject?))
                {
                    return new global::Portkey.JsonConverters.CreateEmbeddingResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.EmbeddingObject))
                {
                    return new global::Portkey.JsonConverters.EmbeddingObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.EmbeddingObject?))
                {
                    return new global::Portkey.JsonConverters.EmbeddingObjectNullableJsonConverter();
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
                    0 => new EmbeddingsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}