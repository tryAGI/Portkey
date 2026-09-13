
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ExportListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ExportListResponseObject), TypeInfoPropertyName = "ExportListResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.ExportItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ExportItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GenerationsFilterSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.LogExportsRequestedDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ExportItemStatus), TypeInfoPropertyName = "ExportItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ExportItemObject), TypeInfoPropertyName = "ExportItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateExportResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateExportResponseObject), TypeInfoPropertyName = "UpdateExportResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ExportTaskResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ExportTaskResponseObject), TypeInfoPropertyName = "ExportTaskResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DownloadLogsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.LogExportsRequestedDataItem), TypeInfoPropertyName = "LogExportsRequestedDataItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PutLogsExportsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateLogsExportsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ExportListResponseObject?), TypeInfoPropertyName = "NullableExportListResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ExportItemStatus?), TypeInfoPropertyName = "NullableExportItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ExportItemObject?), TypeInfoPropertyName = "NullableExportItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateExportResponseObject?), TypeInfoPropertyName = "NullableUpdateExportResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ExportTaskResponseObject?), TypeInfoPropertyName = "NullableExportTaskResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.LogExportsRequestedDataItem?), TypeInfoPropertyName = "NullableLogExportsRequestedDataItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.ExportItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.LogExportsRequestedDataItem>))]
    internal sealed partial class LogsExportSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LogsExportSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static LogsExportSourceGenerationContext Default { get; } = new(DefaultOptions);

        private LogsExportSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Portkey.ExportListResponseObject)

                    || typeToConvert == typeof(global::Portkey.ExportListResponseObject?)

                    || typeToConvert == typeof(global::Portkey.ExportItemStatus)

                    || typeToConvert == typeof(global::Portkey.ExportItemStatus?)

                    || typeToConvert == typeof(global::Portkey.ExportItemObject)

                    || typeToConvert == typeof(global::Portkey.ExportItemObject?)

                    || typeToConvert == typeof(global::Portkey.UpdateExportResponseObject)

                    || typeToConvert == typeof(global::Portkey.UpdateExportResponseObject?)

                    || typeToConvert == typeof(global::Portkey.ExportTaskResponseObject)

                    || typeToConvert == typeof(global::Portkey.ExportTaskResponseObject?)

                    || typeToConvert == typeof(global::Portkey.LogExportsRequestedDataItem)

                    || typeToConvert == typeof(global::Portkey.LogExportsRequestedDataItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Portkey.ExportListResponseObject))
                {
                    return new global::Portkey.JsonConverters.ExportListResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ExportListResponseObject?))
                {
                    return new global::Portkey.JsonConverters.ExportListResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ExportItemStatus))
                {
                    return new global::Portkey.JsonConverters.ExportItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ExportItemStatus?))
                {
                    return new global::Portkey.JsonConverters.ExportItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ExportItemObject))
                {
                    return new global::Portkey.JsonConverters.ExportItemObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ExportItemObject?))
                {
                    return new global::Portkey.JsonConverters.ExportItemObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UpdateExportResponseObject))
                {
                    return new global::Portkey.JsonConverters.UpdateExportResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UpdateExportResponseObject?))
                {
                    return new global::Portkey.JsonConverters.UpdateExportResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ExportTaskResponseObject))
                {
                    return new global::Portkey.JsonConverters.ExportTaskResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ExportTaskResponseObject?))
                {
                    return new global::Portkey.JsonConverters.ExportTaskResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.LogExportsRequestedDataItem))
                {
                    return new global::Portkey.JsonConverters.LogExportsRequestedDataItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.LogExportsRequestedDataItem?))
                {
                    return new global::Portkey.JsonConverters.LogExportsRequestedDataItemNullableJsonConverter();
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
                    0 => new LogsExportSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}