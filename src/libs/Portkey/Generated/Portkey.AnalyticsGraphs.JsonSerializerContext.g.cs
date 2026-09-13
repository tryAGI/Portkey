
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsRequestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsRequestsResponseSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsRequestsResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsRequestsResponseDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsRequestsResponseObject), TypeInfoPropertyName = "GetAnalyticsGraphsRequestsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsCostResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsCostResponseSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsCostResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsCostResponseDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsCostResponseObject), TypeInfoPropertyName = "GetAnalyticsGraphsCostResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsLatencyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsLatencyResponseSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsLatencyResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsLatencyResponseDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsLatencyResponseObject), TypeInfoPropertyName = "GetAnalyticsGraphsLatencyResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsTokensResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsTokensResponseSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsTokensResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsTokensResponseDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsTokensResponseObject), TypeInfoPropertyName = "GetAnalyticsGraphsTokensResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsUsersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsUsersResponseSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsUsersResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsUsersResponseDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsUsersResponseObject), TypeInfoPropertyName = "GetAnalyticsGraphsUsersResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsUsersRequestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsUsersRequestsResponseSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsUsersRequestsResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsUsersRequestsResponseDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsUsersRequestsResponseObject), TypeInfoPropertyName = "GetAnalyticsGraphsUsersRequestsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsResponseSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsResponseDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsResponseObject), TypeInfoPropertyName = "GetAnalyticsGraphsErrorsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsRateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsRateResponseSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsRateResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsRateResponseDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsRateResponseObject), TypeInfoPropertyName = "GetAnalyticsGraphsErrorsRateResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsStacksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsStacksResponseSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPointStat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPointStat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsStacksResponseObject), TypeInfoPropertyName = "GetAnalyticsGraphsErrorsStacksResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseObject), TypeInfoPropertyName = "GetAnalyticsGraphsErrorsStatusCodesResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsRequestsRescuedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPointRetryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPointRetryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseObject), TypeInfoPropertyName = "GetAnalyticsGraphsRequestsRescuedResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsCacheHitRateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsCacheHitRateResponseSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsCacheHitRateResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsCacheHitRateResponseDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsCacheHitRateResponseObject), TypeInfoPropertyName = "GetAnalyticsGraphsCacheHitRateResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsCacheLatencyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsCacheLatencyResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsCacheLatencyResponseDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsCacheLatencyResponseObject), TypeInfoPropertyName = "GetAnalyticsGraphsCacheLatencyResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksResponseSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsFeedbacksResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksResponseDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksResponseObject), TypeInfoPropertyName = "GetAnalyticsGraphsFeedbacksResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseObject), TypeInfoPropertyName = "GetAnalyticsGraphsFeedbacksScoresResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseObject), TypeInfoPropertyName = "GetAnalyticsGraphsFeedbacksWeightedResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseObject), TypeInfoPropertyName = "GetAnalyticsGraphsFeedbacksAiModelsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsRequestsResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGraphsRequestsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsCostResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGraphsCostResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsLatencyResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGraphsLatencyResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsTokensResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGraphsTokensResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsUsersResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGraphsUsersResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsUsersRequestsResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGraphsUsersRequestsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGraphsErrorsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsRateResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGraphsErrorsRateResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsStacksResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGraphsErrorsStacksResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGraphsErrorsStatusCodesResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGraphsRequestsRescuedResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsCacheHitRateResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGraphsCacheHitRateResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsCacheLatencyResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGraphsCacheLatencyResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGraphsFeedbacksResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGraphsFeedbacksScoresResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGraphsFeedbacksWeightedResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseObject?), TypeInfoPropertyName = "NullableGetAnalyticsGraphsFeedbacksAiModelsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsRequestsResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsCostResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsLatencyResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsTokensResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsUsersResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsUsersRequestsResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsErrorsResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsErrorsRateResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsErrorsStacksResponseDataPointStat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseDataPointRetryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsCacheHitRateResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsCacheLatencyResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsFeedbacksResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseDataPoint>))]
    internal sealed partial class AnalyticsGraphsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnalyticsGraphsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AnalyticsGraphsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AnalyticsGraphsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsRequestsResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsRequestsResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsCostResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsCostResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsLatencyResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsLatencyResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsTokensResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsTokensResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsUsersResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsUsersResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsUsersRequestsResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsUsersRequestsResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsErrorsResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsErrorsResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsErrorsRateResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsErrorsRateResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsErrorsStacksResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsErrorsStacksResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsCacheHitRateResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsCacheHitRateResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsCacheLatencyResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsCacheLatencyResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsFeedbacksResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsFeedbacksResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseObject?)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseObject?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsRequestsResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsRequestsResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsRequestsResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsRequestsResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsCostResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsCostResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsCostResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsCostResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsLatencyResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsLatencyResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsLatencyResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsLatencyResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsTokensResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsTokensResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsTokensResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsTokensResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsUsersResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsUsersResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsUsersResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsUsersResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsUsersRequestsResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsUsersRequestsResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsUsersRequestsResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsUsersRequestsResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsErrorsResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsErrorsResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsErrorsRateResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsRateResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsErrorsRateResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsRateResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsErrorsStacksResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsStacksResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsErrorsStacksResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsStacksResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsStatusCodesResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsErrorsStatusCodesResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsErrorsStatusCodesResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsRequestsRescuedResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsRequestsRescuedResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsRequestsRescuedResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsCacheHitRateResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsCacheHitRateResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsCacheHitRateResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsCacheHitRateResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsCacheLatencyResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsCacheLatencyResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsCacheLatencyResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsCacheLatencyResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsFeedbacksResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsFeedbacksResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksScoresResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsFeedbacksScoresResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksScoresResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksWeightedResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsFeedbacksWeightedResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksWeightedResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksAiModelsResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAnalyticsGraphsFeedbacksAiModelsResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetAnalyticsGraphsFeedbacksAiModelsResponseObjectNullableJsonConverter();
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
                    0 => new AnalyticsGraphsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}