
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreExpirationAfter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreExpirationAfterAnchor), TypeInfoPropertyName = "VectorStoreExpirationAfterAnchor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreObjectObject), TypeInfoPropertyName = "VectorStoreObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreObjectFileCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreObjectStatus), TypeInfoPropertyName = "VectorStoreObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateVectorStoreRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.AutoChunkingStrategyRequestParam, global::Portkey.StaticChunkingStrategyRequestParam>), TypeInfoPropertyName = "OneOfAutoChunkingStrategyRequestParamStaticChunkingStrategyRequestParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AutoChunkingStrategyRequestParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.StaticChunkingStrategyRequestParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateVectorStoreRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListVectorStoresResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.VectorStoreObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeleteVectorStoreResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeleteVectorStoreResponseObject), TypeInfoPropertyName = "DeleteVectorStoreResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreFileObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreFileObjectObject), TypeInfoPropertyName = "VectorStoreFileObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreFileObjectStatus), TypeInfoPropertyName = "VectorStoreFileObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreFileObjectLastError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreFileObjectLastErrorCode), TypeInfoPropertyName = "VectorStoreFileObjectLastErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.StaticChunkingStrategyResponseParam, global::Portkey.OtherChunkingStrategyResponseParam>), TypeInfoPropertyName = "OneOfStaticChunkingStrategyResponseParamOtherChunkingStrategyResponseParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.StaticChunkingStrategyResponseParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OtherChunkingStrategyResponseParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OtherChunkingStrategyResponseParamType), TypeInfoPropertyName = "OtherChunkingStrategyResponseParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.StaticChunkingStrategyResponseParamType), TypeInfoPropertyName = "StaticChunkingStrategyResponseParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.StaticChunkingStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AutoChunkingStrategyRequestParamType), TypeInfoPropertyName = "AutoChunkingStrategyRequestParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.StaticChunkingStrategyRequestParamType), TypeInfoPropertyName = "StaticChunkingStrategyRequestParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChunkingStrategyRequestParam), TypeInfoPropertyName = "ChunkingStrategyRequestParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateVectorStoreFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListVectorStoreFilesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.VectorStoreFileObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeleteVectorStoreFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeleteVectorStoreFileResponseObject), TypeInfoPropertyName = "DeleteVectorStoreFileResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreFileBatchObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreFileBatchObjectObject), TypeInfoPropertyName = "VectorStoreFileBatchObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreFileBatchObjectStatus), TypeInfoPropertyName = "VectorStoreFileBatchObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreFileBatchObjectFileCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateVectorStoreFileBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListVectorStoresOrder), TypeInfoPropertyName = "ListVectorStoresOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListVectorStoreFilesOrder), TypeInfoPropertyName = "ListVectorStoreFilesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListVectorStoreFilesFilter), TypeInfoPropertyName = "ListVectorStoreFilesFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListFilesInVectorStoreBatchOrder), TypeInfoPropertyName = "ListFilesInVectorStoreBatchOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListFilesInVectorStoreBatchFilter), TypeInfoPropertyName = "ListFilesInVectorStoreBatchFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreExpirationAfterAnchor?), TypeInfoPropertyName = "NullableVectorStoreExpirationAfterAnchor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreObjectObject?), TypeInfoPropertyName = "NullableVectorStoreObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreObjectStatus?), TypeInfoPropertyName = "NullableVectorStoreObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.AutoChunkingStrategyRequestParam, global::Portkey.StaticChunkingStrategyRequestParam>?), TypeInfoPropertyName = "NullableOneOfAutoChunkingStrategyRequestParamStaticChunkingStrategyRequestParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeleteVectorStoreResponseObject?), TypeInfoPropertyName = "NullableDeleteVectorStoreResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreFileObjectObject?), TypeInfoPropertyName = "NullableVectorStoreFileObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreFileObjectStatus?), TypeInfoPropertyName = "NullableVectorStoreFileObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreFileObjectLastErrorCode?), TypeInfoPropertyName = "NullableVectorStoreFileObjectLastErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.StaticChunkingStrategyResponseParam, global::Portkey.OtherChunkingStrategyResponseParam>?), TypeInfoPropertyName = "NullableOneOfStaticChunkingStrategyResponseParamOtherChunkingStrategyResponseParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OtherChunkingStrategyResponseParamType?), TypeInfoPropertyName = "NullableOtherChunkingStrategyResponseParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.StaticChunkingStrategyResponseParamType?), TypeInfoPropertyName = "NullableStaticChunkingStrategyResponseParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AutoChunkingStrategyRequestParamType?), TypeInfoPropertyName = "NullableAutoChunkingStrategyRequestParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.StaticChunkingStrategyRequestParamType?), TypeInfoPropertyName = "NullableStaticChunkingStrategyRequestParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ChunkingStrategyRequestParam?), TypeInfoPropertyName = "NullableChunkingStrategyRequestParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeleteVectorStoreFileResponseObject?), TypeInfoPropertyName = "NullableDeleteVectorStoreFileResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreFileBatchObjectObject?), TypeInfoPropertyName = "NullableVectorStoreFileBatchObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VectorStoreFileBatchObjectStatus?), TypeInfoPropertyName = "NullableVectorStoreFileBatchObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListVectorStoresOrder?), TypeInfoPropertyName = "NullableListVectorStoresOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListVectorStoreFilesOrder?), TypeInfoPropertyName = "NullableListVectorStoreFilesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListVectorStoreFilesFilter?), TypeInfoPropertyName = "NullableListVectorStoreFilesFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListFilesInVectorStoreBatchOrder?), TypeInfoPropertyName = "NullableListFilesInVectorStoreBatchOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListFilesInVectorStoreBatchFilter?), TypeInfoPropertyName = "NullableListFilesInVectorStoreBatchFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.VectorStoreObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.VectorStoreFileObject>))]
    internal sealed partial class VectorStoresSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VectorStoresSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static VectorStoresSourceGenerationContext Default { get; } = new(DefaultOptions);

        private VectorStoresSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Portkey.JsonConverters.ChunkingStrategyRequestParamJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.AutoChunkingStrategyRequestParam, global::Portkey.StaticChunkingStrategyRequestParam>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.StaticChunkingStrategyResponseParam, global::Portkey.OtherChunkingStrategyResponseParam>());
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
                    typeToConvert == typeof(global::Portkey.VectorStoreExpirationAfterAnchor)

                    || typeToConvert == typeof(global::Portkey.VectorStoreExpirationAfterAnchor?)

                    || typeToConvert == typeof(global::Portkey.VectorStoreObjectObject)

                    || typeToConvert == typeof(global::Portkey.VectorStoreObjectObject?)

                    || typeToConvert == typeof(global::Portkey.VectorStoreObjectStatus)

                    || typeToConvert == typeof(global::Portkey.VectorStoreObjectStatus?)

                    || typeToConvert == typeof(global::Portkey.DeleteVectorStoreResponseObject)

                    || typeToConvert == typeof(global::Portkey.DeleteVectorStoreResponseObject?)

                    || typeToConvert == typeof(global::Portkey.VectorStoreFileObjectObject)

                    || typeToConvert == typeof(global::Portkey.VectorStoreFileObjectObject?)

                    || typeToConvert == typeof(global::Portkey.VectorStoreFileObjectStatus)

                    || typeToConvert == typeof(global::Portkey.VectorStoreFileObjectStatus?)

                    || typeToConvert == typeof(global::Portkey.VectorStoreFileObjectLastErrorCode)

                    || typeToConvert == typeof(global::Portkey.VectorStoreFileObjectLastErrorCode?)

                    || typeToConvert == typeof(global::Portkey.OtherChunkingStrategyResponseParamType)

                    || typeToConvert == typeof(global::Portkey.OtherChunkingStrategyResponseParamType?)

                    || typeToConvert == typeof(global::Portkey.StaticChunkingStrategyResponseParamType)

                    || typeToConvert == typeof(global::Portkey.StaticChunkingStrategyResponseParamType?)

                    || typeToConvert == typeof(global::Portkey.AutoChunkingStrategyRequestParamType)

                    || typeToConvert == typeof(global::Portkey.AutoChunkingStrategyRequestParamType?)

                    || typeToConvert == typeof(global::Portkey.StaticChunkingStrategyRequestParamType)

                    || typeToConvert == typeof(global::Portkey.StaticChunkingStrategyRequestParamType?)

                    || typeToConvert == typeof(global::Portkey.DeleteVectorStoreFileResponseObject)

                    || typeToConvert == typeof(global::Portkey.DeleteVectorStoreFileResponseObject?)

                    || typeToConvert == typeof(global::Portkey.VectorStoreFileBatchObjectObject)

                    || typeToConvert == typeof(global::Portkey.VectorStoreFileBatchObjectObject?)

                    || typeToConvert == typeof(global::Portkey.VectorStoreFileBatchObjectStatus)

                    || typeToConvert == typeof(global::Portkey.VectorStoreFileBatchObjectStatus?)

                    || typeToConvert == typeof(global::Portkey.ListVectorStoresOrder)

                    || typeToConvert == typeof(global::Portkey.ListVectorStoresOrder?)

                    || typeToConvert == typeof(global::Portkey.ListVectorStoreFilesOrder)

                    || typeToConvert == typeof(global::Portkey.ListVectorStoreFilesOrder?)

                    || typeToConvert == typeof(global::Portkey.ListVectorStoreFilesFilter)

                    || typeToConvert == typeof(global::Portkey.ListVectorStoreFilesFilter?)

                    || typeToConvert == typeof(global::Portkey.ListFilesInVectorStoreBatchOrder)

                    || typeToConvert == typeof(global::Portkey.ListFilesInVectorStoreBatchOrder?)

                    || typeToConvert == typeof(global::Portkey.ListFilesInVectorStoreBatchFilter)

                    || typeToConvert == typeof(global::Portkey.ListFilesInVectorStoreBatchFilter?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Portkey.VectorStoreExpirationAfterAnchor))
                {
                    return new global::Portkey.JsonConverters.VectorStoreExpirationAfterAnchorJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VectorStoreExpirationAfterAnchor?))
                {
                    return new global::Portkey.JsonConverters.VectorStoreExpirationAfterAnchorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VectorStoreObjectObject))
                {
                    return new global::Portkey.JsonConverters.VectorStoreObjectObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VectorStoreObjectObject?))
                {
                    return new global::Portkey.JsonConverters.VectorStoreObjectObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VectorStoreObjectStatus))
                {
                    return new global::Portkey.JsonConverters.VectorStoreObjectStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VectorStoreObjectStatus?))
                {
                    return new global::Portkey.JsonConverters.VectorStoreObjectStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeleteVectorStoreResponseObject))
                {
                    return new global::Portkey.JsonConverters.DeleteVectorStoreResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeleteVectorStoreResponseObject?))
                {
                    return new global::Portkey.JsonConverters.DeleteVectorStoreResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VectorStoreFileObjectObject))
                {
                    return new global::Portkey.JsonConverters.VectorStoreFileObjectObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VectorStoreFileObjectObject?))
                {
                    return new global::Portkey.JsonConverters.VectorStoreFileObjectObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VectorStoreFileObjectStatus))
                {
                    return new global::Portkey.JsonConverters.VectorStoreFileObjectStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VectorStoreFileObjectStatus?))
                {
                    return new global::Portkey.JsonConverters.VectorStoreFileObjectStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VectorStoreFileObjectLastErrorCode))
                {
                    return new global::Portkey.JsonConverters.VectorStoreFileObjectLastErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VectorStoreFileObjectLastErrorCode?))
                {
                    return new global::Portkey.JsonConverters.VectorStoreFileObjectLastErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OtherChunkingStrategyResponseParamType))
                {
                    return new global::Portkey.JsonConverters.OtherChunkingStrategyResponseParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OtherChunkingStrategyResponseParamType?))
                {
                    return new global::Portkey.JsonConverters.OtherChunkingStrategyResponseParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.StaticChunkingStrategyResponseParamType))
                {
                    return new global::Portkey.JsonConverters.StaticChunkingStrategyResponseParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.StaticChunkingStrategyResponseParamType?))
                {
                    return new global::Portkey.JsonConverters.StaticChunkingStrategyResponseParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AutoChunkingStrategyRequestParamType))
                {
                    return new global::Portkey.JsonConverters.AutoChunkingStrategyRequestParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AutoChunkingStrategyRequestParamType?))
                {
                    return new global::Portkey.JsonConverters.AutoChunkingStrategyRequestParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.StaticChunkingStrategyRequestParamType))
                {
                    return new global::Portkey.JsonConverters.StaticChunkingStrategyRequestParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.StaticChunkingStrategyRequestParamType?))
                {
                    return new global::Portkey.JsonConverters.StaticChunkingStrategyRequestParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeleteVectorStoreFileResponseObject))
                {
                    return new global::Portkey.JsonConverters.DeleteVectorStoreFileResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeleteVectorStoreFileResponseObject?))
                {
                    return new global::Portkey.JsonConverters.DeleteVectorStoreFileResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VectorStoreFileBatchObjectObject))
                {
                    return new global::Portkey.JsonConverters.VectorStoreFileBatchObjectObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VectorStoreFileBatchObjectObject?))
                {
                    return new global::Portkey.JsonConverters.VectorStoreFileBatchObjectObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VectorStoreFileBatchObjectStatus))
                {
                    return new global::Portkey.JsonConverters.VectorStoreFileBatchObjectStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VectorStoreFileBatchObjectStatus?))
                {
                    return new global::Portkey.JsonConverters.VectorStoreFileBatchObjectStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListVectorStoresOrder))
                {
                    return new global::Portkey.JsonConverters.ListVectorStoresOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListVectorStoresOrder?))
                {
                    return new global::Portkey.JsonConverters.ListVectorStoresOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListVectorStoreFilesOrder))
                {
                    return new global::Portkey.JsonConverters.ListVectorStoreFilesOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListVectorStoreFilesOrder?))
                {
                    return new global::Portkey.JsonConverters.ListVectorStoreFilesOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListVectorStoreFilesFilter))
                {
                    return new global::Portkey.JsonConverters.ListVectorStoreFilesFilterJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListVectorStoreFilesFilter?))
                {
                    return new global::Portkey.JsonConverters.ListVectorStoreFilesFilterNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListFilesInVectorStoreBatchOrder))
                {
                    return new global::Portkey.JsonConverters.ListFilesInVectorStoreBatchOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListFilesInVectorStoreBatchOrder?))
                {
                    return new global::Portkey.JsonConverters.ListFilesInVectorStoreBatchOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListFilesInVectorStoreBatchFilter))
                {
                    return new global::Portkey.JsonConverters.ListFilesInVectorStoreBatchFilterJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListFilesInVectorStoreBatchFilter?))
                {
                    return new global::Portkey.JsonConverters.ListFilesInVectorStoreBatchFilterNullableJsonConverter();
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
                    0 => new VectorStoresSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}