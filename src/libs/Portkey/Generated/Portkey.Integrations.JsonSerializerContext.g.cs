
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.OpenAIConfiguration, global::Portkey.AnthropicConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>), TypeInfoPropertyName = "CustomHostConfiguration_8eaf0277af18c94c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<global::Portkey.OpenAIConfiguration, global::Portkey.AnthropicConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>?), TypeInfoPropertyName = "CustomHostConfiguration_772f8ae33ef6038c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsType), TypeInfoPropertyName = "RateLimitsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsUnit), TypeInfoPropertyName = "RateLimitsUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsType), TypeInfoPropertyName = "UsageLimitsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsPeriodicReset), TypeInfoPropertyName = "UsageLimitsPeriodicReset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateIntegrationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OpenAIConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnthropicConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzureOpenAIConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BedrockConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VertexAIConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzureAIConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkersAIConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SageMakerConfiguration), TypeInfoPropertyName = "SageMakerConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.HuggingFaceConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CortexConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CustomHostConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.SecretMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretMapping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PricingAdjustments))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateIntegrationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.IntegrationDetailResponse), TypeInfoPropertyName = "IntegrationDetailResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.IntegrationList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.IntegrationDetailResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GlobalWorkspaceAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PricingMultiplier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PricingMultiplierImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.UsageLimits>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.RateLimits>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OpenAIConfigurationProviderAuthType), TypeInfoPropertyName = "OpenAIConfigurationProviderAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OpenAIConfigurationWifIdentitySource), TypeInfoPropertyName = "OpenAIConfigurationWifIdentitySource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnthropicConfigurationProviderAuthType), TypeInfoPropertyName = "AnthropicConfigurationProviderAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnthropicConfigurationWifIdentitySource), TypeInfoPropertyName = "AnthropicConfigurationWifIdentitySource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzureOpenAIConfigurationAzureAuthMode), TypeInfoPropertyName = "AzureOpenAIConfigurationAzureAuthMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.AzureDeploymentConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzureDeploymentConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BedrockConfigurationAwsAuthType), TypeInfoPropertyName = "BedrockConfigurationAwsAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SageMakerConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VertexAIConfigurationVertexAuthType), TypeInfoPropertyName = "VertexAIConfigurationVertexAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzureAIConfigurationAzureAuthMode), TypeInfoPropertyName = "AzureAIConfigurationAzureAuthMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretMappingValueFormat), TypeInfoPropertyName = "SecretMappingValueFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.IntegrationListStatus), TypeInfoPropertyName = "IntegrationListStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.IntegrationListObject), TypeInfoPropertyName = "IntegrationListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetIntegrationsType), TypeInfoPropertyName = "GetIntegrationsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetIntegrationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetIntegrationsResponseObject), TypeInfoPropertyName = "GetIntegrationsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.IntegrationList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateIntegrationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsType?), TypeInfoPropertyName = "NullableRateLimitsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsUnit?), TypeInfoPropertyName = "NullableRateLimitsUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsType?), TypeInfoPropertyName = "NullableUsageLimitsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsPeriodicReset?), TypeInfoPropertyName = "NullableUsageLimitsPeriodicReset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SageMakerConfiguration?), TypeInfoPropertyName = "NullableSageMakerConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.IntegrationDetailResponse?), TypeInfoPropertyName = "NullableIntegrationDetailResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OpenAIConfigurationProviderAuthType?), TypeInfoPropertyName = "NullableOpenAIConfigurationProviderAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OpenAIConfigurationWifIdentitySource?), TypeInfoPropertyName = "NullableOpenAIConfigurationWifIdentitySource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnthropicConfigurationProviderAuthType?), TypeInfoPropertyName = "NullableAnthropicConfigurationProviderAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AnthropicConfigurationWifIdentitySource?), TypeInfoPropertyName = "NullableAnthropicConfigurationWifIdentitySource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzureOpenAIConfigurationAzureAuthMode?), TypeInfoPropertyName = "NullableAzureOpenAIConfigurationAzureAuthMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.BedrockConfigurationAwsAuthType?), TypeInfoPropertyName = "NullableBedrockConfigurationAwsAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.VertexAIConfigurationVertexAuthType?), TypeInfoPropertyName = "NullableVertexAIConfigurationVertexAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzureAIConfigurationAzureAuthMode?), TypeInfoPropertyName = "NullableAzureAIConfigurationAzureAuthMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretMappingValueFormat?), TypeInfoPropertyName = "NullableSecretMappingValueFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.IntegrationListStatus?), TypeInfoPropertyName = "NullableIntegrationListStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.IntegrationListObject?), TypeInfoPropertyName = "NullableIntegrationListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetIntegrationsType?), TypeInfoPropertyName = "NullableGetIntegrationsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetIntegrationsResponseObject?), TypeInfoPropertyName = "NullableGetIntegrationsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.SecretMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.UsageLimits>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.RateLimits>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.AzureDeploymentConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.IntegrationList>))]
    internal sealed partial class IntegrationsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IntegrationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static IntegrationsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private IntegrationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Portkey.JsonConverters.IntegrationDetailResponseJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.SageMakerConfigurationJsonConverter());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.OpenAIConfiguration, global::Portkey.AnthropicConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.OpenAIConfiguration, global::Portkey.AnthropicConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>());
            options.Converters.Add(new global::Portkey.JsonConverters.OneOfJsonConverter<global::Portkey.OpenAIConfiguration, global::Portkey.AnthropicConfiguration, global::Portkey.AzureOpenAIConfiguration, global::Portkey.BedrockConfiguration, global::Portkey.VertexAIConfiguration, global::Portkey.AzureAIConfiguration, global::Portkey.WorkersAIConfiguration, global::Portkey.SageMakerConfiguration?, global::Portkey.HuggingFaceConfiguration, global::Portkey.CortexConfiguration, global::Portkey.CustomHostConfiguration>());
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
                    typeToConvert == typeof(global::Portkey.RateLimitsType)

                    || typeToConvert == typeof(global::Portkey.RateLimitsType?)

                    || typeToConvert == typeof(global::Portkey.RateLimitsUnit)

                    || typeToConvert == typeof(global::Portkey.RateLimitsUnit?)

                    || typeToConvert == typeof(global::Portkey.UsageLimitsType)

                    || typeToConvert == typeof(global::Portkey.UsageLimitsType?)

                    || typeToConvert == typeof(global::Portkey.UsageLimitsPeriodicReset)

                    || typeToConvert == typeof(global::Portkey.UsageLimitsPeriodicReset?)

                    || typeToConvert == typeof(global::Portkey.OpenAIConfigurationProviderAuthType)

                    || typeToConvert == typeof(global::Portkey.OpenAIConfigurationProviderAuthType?)

                    || typeToConvert == typeof(global::Portkey.OpenAIConfigurationWifIdentitySource)

                    || typeToConvert == typeof(global::Portkey.OpenAIConfigurationWifIdentitySource?)

                    || typeToConvert == typeof(global::Portkey.AnthropicConfigurationProviderAuthType)

                    || typeToConvert == typeof(global::Portkey.AnthropicConfigurationProviderAuthType?)

                    || typeToConvert == typeof(global::Portkey.AnthropicConfigurationWifIdentitySource)

                    || typeToConvert == typeof(global::Portkey.AnthropicConfigurationWifIdentitySource?)

                    || typeToConvert == typeof(global::Portkey.AzureOpenAIConfigurationAzureAuthMode)

                    || typeToConvert == typeof(global::Portkey.AzureOpenAIConfigurationAzureAuthMode?)

                    || typeToConvert == typeof(global::Portkey.BedrockConfigurationAwsAuthType)

                    || typeToConvert == typeof(global::Portkey.BedrockConfigurationAwsAuthType?)

                    || typeToConvert == typeof(global::Portkey.VertexAIConfigurationVertexAuthType)

                    || typeToConvert == typeof(global::Portkey.VertexAIConfigurationVertexAuthType?)

                    || typeToConvert == typeof(global::Portkey.AzureAIConfigurationAzureAuthMode)

                    || typeToConvert == typeof(global::Portkey.AzureAIConfigurationAzureAuthMode?)

                    || typeToConvert == typeof(global::Portkey.SecretMappingValueFormat)

                    || typeToConvert == typeof(global::Portkey.SecretMappingValueFormat?)

                    || typeToConvert == typeof(global::Portkey.IntegrationListStatus)

                    || typeToConvert == typeof(global::Portkey.IntegrationListStatus?)

                    || typeToConvert == typeof(global::Portkey.IntegrationListObject)

                    || typeToConvert == typeof(global::Portkey.IntegrationListObject?)

                    || typeToConvert == typeof(global::Portkey.GetIntegrationsType)

                    || typeToConvert == typeof(global::Portkey.GetIntegrationsType?)

                    || typeToConvert == typeof(global::Portkey.GetIntegrationsResponseObject)

                    || typeToConvert == typeof(global::Portkey.GetIntegrationsResponseObject?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Portkey.RateLimitsType))
                {
                    return new global::Portkey.JsonConverters.RateLimitsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RateLimitsType?))
                {
                    return new global::Portkey.JsonConverters.RateLimitsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RateLimitsUnit))
                {
                    return new global::Portkey.JsonConverters.RateLimitsUnitJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.RateLimitsUnit?))
                {
                    return new global::Portkey.JsonConverters.RateLimitsUnitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UsageLimitsType))
                {
                    return new global::Portkey.JsonConverters.UsageLimitsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UsageLimitsType?))
                {
                    return new global::Portkey.JsonConverters.UsageLimitsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UsageLimitsPeriodicReset))
                {
                    return new global::Portkey.JsonConverters.UsageLimitsPeriodicResetJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UsageLimitsPeriodicReset?))
                {
                    return new global::Portkey.JsonConverters.UsageLimitsPeriodicResetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OpenAIConfigurationProviderAuthType))
                {
                    return new global::Portkey.JsonConverters.OpenAIConfigurationProviderAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OpenAIConfigurationProviderAuthType?))
                {
                    return new global::Portkey.JsonConverters.OpenAIConfigurationProviderAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OpenAIConfigurationWifIdentitySource))
                {
                    return new global::Portkey.JsonConverters.OpenAIConfigurationWifIdentitySourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.OpenAIConfigurationWifIdentitySource?))
                {
                    return new global::Portkey.JsonConverters.OpenAIConfigurationWifIdentitySourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AnthropicConfigurationProviderAuthType))
                {
                    return new global::Portkey.JsonConverters.AnthropicConfigurationProviderAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AnthropicConfigurationProviderAuthType?))
                {
                    return new global::Portkey.JsonConverters.AnthropicConfigurationProviderAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AnthropicConfigurationWifIdentitySource))
                {
                    return new global::Portkey.JsonConverters.AnthropicConfigurationWifIdentitySourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AnthropicConfigurationWifIdentitySource?))
                {
                    return new global::Portkey.JsonConverters.AnthropicConfigurationWifIdentitySourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AzureOpenAIConfigurationAzureAuthMode))
                {
                    return new global::Portkey.JsonConverters.AzureOpenAIConfigurationAzureAuthModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AzureOpenAIConfigurationAzureAuthMode?))
                {
                    return new global::Portkey.JsonConverters.AzureOpenAIConfigurationAzureAuthModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.BedrockConfigurationAwsAuthType))
                {
                    return new global::Portkey.JsonConverters.BedrockConfigurationAwsAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.BedrockConfigurationAwsAuthType?))
                {
                    return new global::Portkey.JsonConverters.BedrockConfigurationAwsAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VertexAIConfigurationVertexAuthType))
                {
                    return new global::Portkey.JsonConverters.VertexAIConfigurationVertexAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.VertexAIConfigurationVertexAuthType?))
                {
                    return new global::Portkey.JsonConverters.VertexAIConfigurationVertexAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AzureAIConfigurationAzureAuthMode))
                {
                    return new global::Portkey.JsonConverters.AzureAIConfigurationAzureAuthModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AzureAIConfigurationAzureAuthMode?))
                {
                    return new global::Portkey.JsonConverters.AzureAIConfigurationAzureAuthModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.SecretMappingValueFormat))
                {
                    return new global::Portkey.JsonConverters.SecretMappingValueFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.SecretMappingValueFormat?))
                {
                    return new global::Portkey.JsonConverters.SecretMappingValueFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.IntegrationListStatus))
                {
                    return new global::Portkey.JsonConverters.IntegrationListStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.IntegrationListStatus?))
                {
                    return new global::Portkey.JsonConverters.IntegrationListStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.IntegrationListObject))
                {
                    return new global::Portkey.JsonConverters.IntegrationListObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.IntegrationListObject?))
                {
                    return new global::Portkey.JsonConverters.IntegrationListObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetIntegrationsType))
                {
                    return new global::Portkey.JsonConverters.GetIntegrationsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetIntegrationsType?))
                {
                    return new global::Portkey.JsonConverters.GetIntegrationsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetIntegrationsResponseObject))
                {
                    return new global::Portkey.JsonConverters.GetIntegrationsResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetIntegrationsResponseObject?))
                {
                    return new global::Portkey.JsonConverters.GetIntegrationsResponseObjectNullableJsonConverter();
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
                    0 => new IntegrationsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}