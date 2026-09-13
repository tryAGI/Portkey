
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateTranscriptionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateTranscriptionRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateTranscriptionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateTranscriptionRequestModel), TypeInfoPropertyName = "CreateTranscriptionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateTranscriptionRequestResponseFormat), TypeInfoPropertyName = "CreateTranscriptionRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.CreateTranscriptionRequestTimestampGranularitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateTranscriptionRequestTimestampGranularitie), TypeInfoPropertyName = "CreateTranscriptionRequestTimestampGranularitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateTranscriptionResponseJson))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.TranscriptionSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.TranscriptionWord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateTranscriptionResponseVerboseJson))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.TranscriptionWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.TranscriptionSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateTranslationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateTranslationRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateTranslationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateTranslationRequestModel), TypeInfoPropertyName = "CreateTranslationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateTranslationResponseJson))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateTranslationResponseVerboseJson))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateSpeechRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateSpeechRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateSpeechRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateSpeechRequestModel), TypeInfoPropertyName = "CreateSpeechRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateSpeechRequestVoice), TypeInfoPropertyName = "CreateSpeechRequestVoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateSpeechRequestResponseFormat), TypeInfoPropertyName = "CreateSpeechRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateTranscriptionResponseJson, global::Portkey.CreateTranscriptionResponseVerboseJson>), TypeInfoPropertyName = "OneOfCreateTranscriptionResponseJsonCreateTranscriptionResponseVerboseJson2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateTranslationResponseJson, global::Portkey.CreateTranslationResponseVerboseJson>), TypeInfoPropertyName = "OneOfCreateTranslationResponseJsonCreateTranslationResponseVerboseJson2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateTranscriptionRequestModel?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateTranscriptionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateTranscriptionRequestModel?), TypeInfoPropertyName = "NullableCreateTranscriptionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateTranscriptionRequestResponseFormat?), TypeInfoPropertyName = "NullableCreateTranscriptionRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateTranscriptionRequestTimestampGranularitie?), TypeInfoPropertyName = "NullableCreateTranscriptionRequestTimestampGranularitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateTranslationRequestModel?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateTranslationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateTranslationRequestModel?), TypeInfoPropertyName = "NullableCreateTranslationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<string, global::Portkey.CreateSpeechRequestModel?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateSpeechRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateSpeechRequestModel?), TypeInfoPropertyName = "NullableCreateSpeechRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateSpeechRequestVoice?), TypeInfoPropertyName = "NullableCreateSpeechRequestVoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateSpeechRequestResponseFormat?), TypeInfoPropertyName = "NullableCreateSpeechRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateTranscriptionResponseJson, global::Portkey.CreateTranscriptionResponseVerboseJson>?), TypeInfoPropertyName = "NullableOneOfCreateTranscriptionResponseJsonCreateTranscriptionResponseVerboseJson2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.CreateTranslationResponseJson, global::Portkey.CreateTranslationResponseVerboseJson>?), TypeInfoPropertyName = "NullableOneOfCreateTranslationResponseJsonCreateTranslationResponseVerboseJson2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.CreateTranscriptionRequestTimestampGranularitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.TranscriptionWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.TranscriptionSegment>))]
    internal sealed partial class AudioSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AudioSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AudioSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AudioSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateTranscriptionRequestModel?>());
            options.Converters.Add(new global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateTranslationRequestModel?>());
            options.Converters.Add(new global::Portkey.JsonConverters.AnyOfJsonConverter<string, global::Portkey.CreateSpeechRequestModel?>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.Dictionary<string, string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateTranscriptionResponseJson, global::Portkey.CreateTranscriptionResponseVerboseJson>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.CreateTranslationResponseJson, global::Portkey.CreateTranslationResponseVerboseJson>());
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
                    typeToConvert == typeof(global::Portkey.CreateTranscriptionRequestModel)

                    || typeToConvert == typeof(global::Portkey.CreateTranscriptionRequestModel?)

                    || typeToConvert == typeof(global::Portkey.CreateTranscriptionRequestResponseFormat)

                    || typeToConvert == typeof(global::Portkey.CreateTranscriptionRequestResponseFormat?)

                    || typeToConvert == typeof(global::Portkey.CreateTranscriptionRequestTimestampGranularitie)

                    || typeToConvert == typeof(global::Portkey.CreateTranscriptionRequestTimestampGranularitie?)

                    || typeToConvert == typeof(global::Portkey.CreateTranslationRequestModel)

                    || typeToConvert == typeof(global::Portkey.CreateTranslationRequestModel?)

                    || typeToConvert == typeof(global::Portkey.CreateSpeechRequestModel)

                    || typeToConvert == typeof(global::Portkey.CreateSpeechRequestModel?)

                    || typeToConvert == typeof(global::Portkey.CreateSpeechRequestVoice)

                    || typeToConvert == typeof(global::Portkey.CreateSpeechRequestVoice?)

                    || typeToConvert == typeof(global::Portkey.CreateSpeechRequestResponseFormat)

                    || typeToConvert == typeof(global::Portkey.CreateSpeechRequestResponseFormat?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Portkey.CreateTranscriptionRequestModel))
                {
                    return new global::Portkey.JsonConverters.CreateTranscriptionRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateTranscriptionRequestModel?))
                {
                    return new global::Portkey.JsonConverters.CreateTranscriptionRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateTranscriptionRequestResponseFormat))
                {
                    return new global::Portkey.JsonConverters.CreateTranscriptionRequestResponseFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateTranscriptionRequestResponseFormat?))
                {
                    return new global::Portkey.JsonConverters.CreateTranscriptionRequestResponseFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateTranscriptionRequestTimestampGranularitie))
                {
                    return new global::Portkey.JsonConverters.CreateTranscriptionRequestTimestampGranularitieJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateTranscriptionRequestTimestampGranularitie?))
                {
                    return new global::Portkey.JsonConverters.CreateTranscriptionRequestTimestampGranularitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateTranslationRequestModel))
                {
                    return new global::Portkey.JsonConverters.CreateTranslationRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateTranslationRequestModel?))
                {
                    return new global::Portkey.JsonConverters.CreateTranslationRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateSpeechRequestModel))
                {
                    return new global::Portkey.JsonConverters.CreateSpeechRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateSpeechRequestModel?))
                {
                    return new global::Portkey.JsonConverters.CreateSpeechRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateSpeechRequestVoice))
                {
                    return new global::Portkey.JsonConverters.CreateSpeechRequestVoiceJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateSpeechRequestVoice?))
                {
                    return new global::Portkey.JsonConverters.CreateSpeechRequestVoiceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateSpeechRequestResponseFormat))
                {
                    return new global::Portkey.JsonConverters.CreateSpeechRequestResponseFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateSpeechRequestResponseFormat?))
                {
                    return new global::Portkey.JsonConverters.CreateSpeechRequestResponseFormatNullableJsonConverter();
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
                    0 => new AudioSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}