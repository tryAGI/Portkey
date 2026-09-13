
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateImageRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateImageRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageRequestModel), TypeInfoPropertyName = "CreateImageRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageRequestQuality), TypeInfoPropertyName = "CreateImageRequestQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageRequestResponseFormat), TypeInfoPropertyName = "CreateImageRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageRequestSize), TypeInfoPropertyName = "CreateImageRequestSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageRequestStyle), TypeInfoPropertyName = "CreateImageRequestStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ImagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.Image>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Image))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageEditRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateImageEditRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateImageEditRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageEditRequestModel), TypeInfoPropertyName = "CreateImageEditRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageEditRequestSize), TypeInfoPropertyName = "CreateImageEditRequestSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageEditRequestResponseFormat), TypeInfoPropertyName = "CreateImageEditRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageVariationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateImageVariationRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateImageVariationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageVariationRequestModel), TypeInfoPropertyName = "CreateImageVariationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageVariationRequestResponseFormat), TypeInfoPropertyName = "CreateImageVariationRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageVariationRequestSize), TypeInfoPropertyName = "CreateImageVariationRequestSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateImageRequestModel?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateImageRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageRequestModel?), TypeInfoPropertyName = "NullableCreateImageRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageRequestQuality?), TypeInfoPropertyName = "NullableCreateImageRequestQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageRequestResponseFormat?), TypeInfoPropertyName = "NullableCreateImageRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageRequestSize?), TypeInfoPropertyName = "NullableCreateImageRequestSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageRequestStyle?), TypeInfoPropertyName = "NullableCreateImageRequestStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateImageEditRequestModel?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateImageEditRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageEditRequestModel?), TypeInfoPropertyName = "NullableCreateImageEditRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageEditRequestSize?), TypeInfoPropertyName = "NullableCreateImageEditRequestSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageEditRequestResponseFormat?), TypeInfoPropertyName = "NullableCreateImageEditRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateImageVariationRequestModel?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateImageVariationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageVariationRequestModel?), TypeInfoPropertyName = "NullableCreateImageVariationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageVariationRequestResponseFormat?), TypeInfoPropertyName = "NullableCreateImageVariationRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateImageVariationRequestSize?), TypeInfoPropertyName = "NullableCreateImageVariationRequestSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.Image>))]
    internal sealed partial class ImagesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImagesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ImagesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ImagesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateImageRequestModel?>());
            options.Converters.Add(new global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateImageEditRequestModel?>());
            options.Converters.Add(new global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateImageVariationRequestModel?>());
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
                    typeToConvert == typeof(global::Portkey.CreateImageRequestModel)

                    || typeToConvert == typeof(global::Portkey.CreateImageRequestModel?)

                    || typeToConvert == typeof(global::Portkey.CreateImageRequestQuality)

                    || typeToConvert == typeof(global::Portkey.CreateImageRequestQuality?)

                    || typeToConvert == typeof(global::Portkey.CreateImageRequestResponseFormat)

                    || typeToConvert == typeof(global::Portkey.CreateImageRequestResponseFormat?)

                    || typeToConvert == typeof(global::Portkey.CreateImageRequestSize)

                    || typeToConvert == typeof(global::Portkey.CreateImageRequestSize?)

                    || typeToConvert == typeof(global::Portkey.CreateImageRequestStyle)

                    || typeToConvert == typeof(global::Portkey.CreateImageRequestStyle?)

                    || typeToConvert == typeof(global::Portkey.CreateImageEditRequestModel)

                    || typeToConvert == typeof(global::Portkey.CreateImageEditRequestModel?)

                    || typeToConvert == typeof(global::Portkey.CreateImageEditRequestSize)

                    || typeToConvert == typeof(global::Portkey.CreateImageEditRequestSize?)

                    || typeToConvert == typeof(global::Portkey.CreateImageEditRequestResponseFormat)

                    || typeToConvert == typeof(global::Portkey.CreateImageEditRequestResponseFormat?)

                    || typeToConvert == typeof(global::Portkey.CreateImageVariationRequestModel)

                    || typeToConvert == typeof(global::Portkey.CreateImageVariationRequestModel?)

                    || typeToConvert == typeof(global::Portkey.CreateImageVariationRequestResponseFormat)

                    || typeToConvert == typeof(global::Portkey.CreateImageVariationRequestResponseFormat?)

                    || typeToConvert == typeof(global::Portkey.CreateImageVariationRequestSize)

                    || typeToConvert == typeof(global::Portkey.CreateImageVariationRequestSize?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Portkey.CreateImageRequestModel))
                {
                    return new global::Portkey.JsonConverters.CreateImageRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageRequestModel?))
                {
                    return new global::Portkey.JsonConverters.CreateImageRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageRequestQuality))
                {
                    return new global::Portkey.JsonConverters.CreateImageRequestQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageRequestQuality?))
                {
                    return new global::Portkey.JsonConverters.CreateImageRequestQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageRequestResponseFormat))
                {
                    return new global::Portkey.JsonConverters.CreateImageRequestResponseFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageRequestResponseFormat?))
                {
                    return new global::Portkey.JsonConverters.CreateImageRequestResponseFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageRequestSize))
                {
                    return new global::Portkey.JsonConverters.CreateImageRequestSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageRequestSize?))
                {
                    return new global::Portkey.JsonConverters.CreateImageRequestSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageRequestStyle))
                {
                    return new global::Portkey.JsonConverters.CreateImageRequestStyleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageRequestStyle?))
                {
                    return new global::Portkey.JsonConverters.CreateImageRequestStyleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageEditRequestModel))
                {
                    return new global::Portkey.JsonConverters.CreateImageEditRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageEditRequestModel?))
                {
                    return new global::Portkey.JsonConverters.CreateImageEditRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageEditRequestSize))
                {
                    return new global::Portkey.JsonConverters.CreateImageEditRequestSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageEditRequestSize?))
                {
                    return new global::Portkey.JsonConverters.CreateImageEditRequestSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageEditRequestResponseFormat))
                {
                    return new global::Portkey.JsonConverters.CreateImageEditRequestResponseFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageEditRequestResponseFormat?))
                {
                    return new global::Portkey.JsonConverters.CreateImageEditRequestResponseFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageVariationRequestModel))
                {
                    return new global::Portkey.JsonConverters.CreateImageVariationRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageVariationRequestModel?))
                {
                    return new global::Portkey.JsonConverters.CreateImageVariationRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageVariationRequestResponseFormat))
                {
                    return new global::Portkey.JsonConverters.CreateImageVariationRequestResponseFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageVariationRequestResponseFormat?))
                {
                    return new global::Portkey.JsonConverters.CreateImageVariationRequestResponseFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageVariationRequestSize))
                {
                    return new global::Portkey.JsonConverters.CreateImageVariationRequestSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateImageVariationRequestSize?))
                {
                    return new global::Portkey.JsonConverters.CreateImageVariationRequestSizeNullableJsonConverter();
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
                    0 => new ImagesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}