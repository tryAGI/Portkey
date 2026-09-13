
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListPaginatedFineTuningJobsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.FineTuningJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListPaginatedFineTuningJobsResponseObject), TypeInfoPropertyName = "ListPaginatedFineTuningJobsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListFineTuningJobEventsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.FineTuningJobEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningJobEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListFineTuningJobEventsResponseObject), TypeInfoPropertyName = "ListFineTuningJobEventsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListFineTuningJobCheckpointsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.FineTuningJobCheckpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningJobCheckpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListFineTuningJobCheckpointsResponseObject), TypeInfoPropertyName = "ListFineTuningJobCheckpointsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningJobError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningJobHyperparameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.FineTuningJobHyperparametersNEpochs?, int?>), TypeInfoPropertyName = "OneOfFineTuningJobHyperparametersNEpochsInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningJobHyperparametersNEpochs), TypeInfoPropertyName = "FineTuningJobHyperparametersNEpochs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningJobObject), TypeInfoPropertyName = "FineTuningJobObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningJobStatus), TypeInfoPropertyName = "FineTuningJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.FineTuningIntegration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningIntegrationType), TypeInfoPropertyName = "FineTuningIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningIntegrationWandb))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningJobEventLevel), TypeInfoPropertyName = "FineTuningJobEventLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningJobEventObject), TypeInfoPropertyName = "FineTuningJobEventObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningJobCheckpointMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningJobCheckpointObject), TypeInfoPropertyName = "FineTuningJobCheckpointObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListPaginatedFineTuningJobsResponseObject?), TypeInfoPropertyName = "NullableListPaginatedFineTuningJobsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListFineTuningJobEventsResponseObject?), TypeInfoPropertyName = "NullableListFineTuningJobEventsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListFineTuningJobCheckpointsResponseObject?), TypeInfoPropertyName = "NullableListFineTuningJobCheckpointsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.FineTuningJobHyperparametersNEpochs?, int?>?), TypeInfoPropertyName = "NullableOneOfFineTuningJobHyperparametersNEpochsInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningJobHyperparametersNEpochs?), TypeInfoPropertyName = "NullableFineTuningJobHyperparametersNEpochs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningJobObject?), TypeInfoPropertyName = "NullableFineTuningJobObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningJobStatus?), TypeInfoPropertyName = "NullableFineTuningJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningIntegrationType?), TypeInfoPropertyName = "NullableFineTuningIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningJobEventLevel?), TypeInfoPropertyName = "NullableFineTuningJobEventLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningJobEventObject?), TypeInfoPropertyName = "NullableFineTuningJobEventObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.FineTuningJobCheckpointObject?), TypeInfoPropertyName = "NullableFineTuningJobCheckpointObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.FineTuningJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.FineTuningJobEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.FineTuningJobCheckpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.FineTuningIntegration>))]
    internal sealed partial class FineTuningSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FineTuningSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static FineTuningSourceGenerationContext Default { get; } = new(DefaultOptions);

        private FineTuningSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.FineTuningJobHyperparametersNEpochs?, int?>());
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
                    typeToConvert == typeof(global::Portkey.ListPaginatedFineTuningJobsResponseObject)

                    || typeToConvert == typeof(global::Portkey.ListPaginatedFineTuningJobsResponseObject?)

                    || typeToConvert == typeof(global::Portkey.ListFineTuningJobEventsResponseObject)

                    || typeToConvert == typeof(global::Portkey.ListFineTuningJobEventsResponseObject?)

                    || typeToConvert == typeof(global::Portkey.ListFineTuningJobCheckpointsResponseObject)

                    || typeToConvert == typeof(global::Portkey.ListFineTuningJobCheckpointsResponseObject?)

                    || typeToConvert == typeof(global::Portkey.FineTuningJobHyperparametersNEpochs)

                    || typeToConvert == typeof(global::Portkey.FineTuningJobHyperparametersNEpochs?)

                    || typeToConvert == typeof(global::Portkey.FineTuningJobObject)

                    || typeToConvert == typeof(global::Portkey.FineTuningJobObject?)

                    || typeToConvert == typeof(global::Portkey.FineTuningJobStatus)

                    || typeToConvert == typeof(global::Portkey.FineTuningJobStatus?)

                    || typeToConvert == typeof(global::Portkey.FineTuningIntegrationType)

                    || typeToConvert == typeof(global::Portkey.FineTuningIntegrationType?)

                    || typeToConvert == typeof(global::Portkey.FineTuningJobEventLevel)

                    || typeToConvert == typeof(global::Portkey.FineTuningJobEventLevel?)

                    || typeToConvert == typeof(global::Portkey.FineTuningJobEventObject)

                    || typeToConvert == typeof(global::Portkey.FineTuningJobEventObject?)

                    || typeToConvert == typeof(global::Portkey.FineTuningJobCheckpointObject)

                    || typeToConvert == typeof(global::Portkey.FineTuningJobCheckpointObject?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Portkey.ListPaginatedFineTuningJobsResponseObject))
                {
                    return new global::Portkey.JsonConverters.ListPaginatedFineTuningJobsResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListPaginatedFineTuningJobsResponseObject?))
                {
                    return new global::Portkey.JsonConverters.ListPaginatedFineTuningJobsResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListFineTuningJobEventsResponseObject))
                {
                    return new global::Portkey.JsonConverters.ListFineTuningJobEventsResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListFineTuningJobEventsResponseObject?))
                {
                    return new global::Portkey.JsonConverters.ListFineTuningJobEventsResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListFineTuningJobCheckpointsResponseObject))
                {
                    return new global::Portkey.JsonConverters.ListFineTuningJobCheckpointsResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListFineTuningJobCheckpointsResponseObject?))
                {
                    return new global::Portkey.JsonConverters.ListFineTuningJobCheckpointsResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FineTuningJobHyperparametersNEpochs))
                {
                    return new global::Portkey.JsonConverters.FineTuningJobHyperparametersNEpochsJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FineTuningJobHyperparametersNEpochs?))
                {
                    return new global::Portkey.JsonConverters.FineTuningJobHyperparametersNEpochsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FineTuningJobObject))
                {
                    return new global::Portkey.JsonConverters.FineTuningJobObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FineTuningJobObject?))
                {
                    return new global::Portkey.JsonConverters.FineTuningJobObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FineTuningJobStatus))
                {
                    return new global::Portkey.JsonConverters.FineTuningJobStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FineTuningJobStatus?))
                {
                    return new global::Portkey.JsonConverters.FineTuningJobStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FineTuningIntegrationType))
                {
                    return new global::Portkey.JsonConverters.FineTuningIntegrationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FineTuningIntegrationType?))
                {
                    return new global::Portkey.JsonConverters.FineTuningIntegrationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FineTuningJobEventLevel))
                {
                    return new global::Portkey.JsonConverters.FineTuningJobEventLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FineTuningJobEventLevel?))
                {
                    return new global::Portkey.JsonConverters.FineTuningJobEventLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FineTuningJobEventObject))
                {
                    return new global::Portkey.JsonConverters.FineTuningJobEventObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FineTuningJobEventObject?))
                {
                    return new global::Portkey.JsonConverters.FineTuningJobEventObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FineTuningJobCheckpointObject))
                {
                    return new global::Portkey.JsonConverters.FineTuningJobCheckpointObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.FineTuningJobCheckpointObject?))
                {
                    return new global::Portkey.JsonConverters.FineTuningJobCheckpointObjectNullableJsonConverter();
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
                    0 => new FineTuningSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}