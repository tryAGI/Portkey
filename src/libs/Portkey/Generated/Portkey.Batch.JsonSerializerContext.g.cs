
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Batch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BatchObject), TypeInfoPropertyName = "BatchObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BatchErrors))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.BatchErrorsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BatchErrorsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BatchStatus), TypeInfoPropertyName = "BatchStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BatchRequestCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListBatchesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.Batch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListBatchesResponseObject), TypeInfoPropertyName = "ListBatchesResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BedrockBatchJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OpenAIBatchJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OpenAIBatchJobCompletionWindow), TypeInfoPropertyName = "OpenAIBatchJobCompletionWindow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OpenAIBatchJobEndpoint), TypeInfoPropertyName = "OpenAIBatchJobEndpoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PortkeyBatchJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PortkeyBatchOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<global::Portkey.PortkeyBatchJobProviderOptionsBedrockOptions, global::Portkey.PortkeyBatchJobProviderOptionsVertexOptions>), TypeInfoPropertyName = "AnyOfPortkeyBatchJobProviderOptionsBedrockOptionsPortkeyBatchJobProviderOptionsVertexOptions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PortkeyBatchJobProviderOptionsBedrockOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PortkeyBatchJobProviderOptionsVertexOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VertexBatchJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<global::Portkey.OpenAIBatchJob, global::Portkey.BedrockBatchJob, global::Portkey.VertexBatchJob, global::Portkey.PortkeyBatchJob>), TypeInfoPropertyName = "AnyOfOpenAIBatchJobBedrockBatchJobVertexBatchJobPortkeyBatchJob2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BatchObject?), TypeInfoPropertyName = "NullableBatchObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BatchStatus?), TypeInfoPropertyName = "NullableBatchStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListBatchesResponseObject?), TypeInfoPropertyName = "NullableListBatchesResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OpenAIBatchJobCompletionWindow?), TypeInfoPropertyName = "NullableOpenAIBatchJobCompletionWindow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OpenAIBatchJobEndpoint?), TypeInfoPropertyName = "NullableOpenAIBatchJobEndpoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<global::Portkey.PortkeyBatchJobProviderOptionsBedrockOptions, global::Portkey.PortkeyBatchJobProviderOptionsVertexOptions>?), TypeInfoPropertyName = "NullableAnyOfPortkeyBatchJobProviderOptionsBedrockOptionsPortkeyBatchJobProviderOptionsVertexOptions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnyOf<global::Portkey.OpenAIBatchJob, global::Portkey.BedrockBatchJob, global::Portkey.VertexBatchJob, global::Portkey.PortkeyBatchJob>?), TypeInfoPropertyName = "NullableAnyOfOpenAIBatchJobBedrockBatchJobVertexBatchJobPortkeyBatchJob2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.BatchErrorsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.Batch>))]
    internal sealed partial class BatchSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BatchSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static BatchSourceGenerationContext Default { get; } = new(DefaultOptions);

        private BatchSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Portkey.JsonConverters.AnyOfJsonConverter<global::Portkey.PortkeyBatchJobProviderOptionsBedrockOptions, global::Portkey.PortkeyBatchJobProviderOptionsVertexOptions>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.AnyOfJsonConverter<global::Portkey.OpenAIBatchJob, global::Portkey.BedrockBatchJob, global::Portkey.VertexBatchJob, global::Portkey.PortkeyBatchJob>());
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
                    typeToConvert == typeof(global::Portkey.BatchObject)

                    || typeToConvert == typeof(global::Portkey.BatchObject?)

                    || typeToConvert == typeof(global::Portkey.BatchStatus)

                    || typeToConvert == typeof(global::Portkey.BatchStatus?)

                    || typeToConvert == typeof(global::Portkey.ListBatchesResponseObject)

                    || typeToConvert == typeof(global::Portkey.ListBatchesResponseObject?)

                    || typeToConvert == typeof(global::Portkey.OpenAIBatchJobCompletionWindow)

                    || typeToConvert == typeof(global::Portkey.OpenAIBatchJobCompletionWindow?)

                    || typeToConvert == typeof(global::Portkey.OpenAIBatchJobEndpoint)

                    || typeToConvert == typeof(global::Portkey.OpenAIBatchJobEndpoint?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Portkey.BatchObject))
                {
                    return new global::Portkey.JsonConverters.BatchObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.BatchObject?))
                {
                    return new global::Portkey.JsonConverters.BatchObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.BatchStatus))
                {
                    return new global::Portkey.JsonConverters.BatchStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.BatchStatus?))
                {
                    return new global::Portkey.JsonConverters.BatchStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListBatchesResponseObject))
                {
                    return new global::Portkey.JsonConverters.ListBatchesResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListBatchesResponseObject?))
                {
                    return new global::Portkey.JsonConverters.ListBatchesResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OpenAIBatchJobCompletionWindow))
                {
                    return new global::Portkey.JsonConverters.OpenAIBatchJobCompletionWindowJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OpenAIBatchJobCompletionWindow?))
                {
                    return new global::Portkey.JsonConverters.OpenAIBatchJobCompletionWindowNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OpenAIBatchJobEndpoint))
                {
                    return new global::Portkey.JsonConverters.OpenAIBatchJobEndpointJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OpenAIBatchJobEndpoint?))
                {
                    return new global::Portkey.JsonConverters.OpenAIBatchJobEndpointNullableJsonConverter();
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
                    0 => new BatchSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}