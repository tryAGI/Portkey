
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateSecretReferenceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateSecretReferenceRequestManagerType), TypeInfoPropertyName = "CreateSecretReferenceRequestManagerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AuthConfig), TypeInfoPropertyName = "AuthConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AwsAccessKeyAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AwsAssumedRoleAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AwsServiceRoleAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzureEntraAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzureManagedAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzureDefaultAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.HashicorpTokenAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.HashicorpAppRoleAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.HashicorpKubernetesAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateSecretReferenceRequestAuthConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthType), TypeInfoPropertyName = "CreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateSecretReferenceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretReferenceListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretReferenceListItemManagerType), TypeInfoPropertyName = "SecretReferenceListItemManagerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretReferenceListItemStatus), TypeInfoPropertyName = "SecretReferenceListItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretReferenceListItemObject), TypeInfoPropertyName = "SecretReferenceListItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretReferenceDetailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretReferenceDetailResponseManagerType), TypeInfoPropertyName = "SecretReferenceDetailResponseManagerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretReferenceDetailResponseStatus), TypeInfoPropertyName = "SecretReferenceDetailResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretReferenceDetailResponseObject), TypeInfoPropertyName = "SecretReferenceDetailResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AwsAccessKeyAuthConfigAwsAuthType), TypeInfoPropertyName = "AwsAccessKeyAuthConfigAwsAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AwsAssumedRoleAuthConfigAwsAuthType), TypeInfoPropertyName = "AwsAssumedRoleAuthConfigAwsAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AwsServiceRoleAuthConfigAwsAuthType), TypeInfoPropertyName = "AwsServiceRoleAuthConfigAwsAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzureEntraAuthConfigAzureAuthMode), TypeInfoPropertyName = "AzureEntraAuthConfigAzureAuthMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzureManagedAuthConfigAzureAuthMode), TypeInfoPropertyName = "AzureManagedAuthConfigAzureAuthMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzureDefaultAuthConfigAzureAuthMode), TypeInfoPropertyName = "AzureDefaultAuthConfigAzureAuthMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.HashicorpTokenAuthConfigVaultAuthType), TypeInfoPropertyName = "HashicorpTokenAuthConfigVaultAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.HashicorpAppRoleAuthConfigVaultAuthType), TypeInfoPropertyName = "HashicorpAppRoleAuthConfigVaultAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.HashicorpKubernetesAuthConfigVaultAuthType), TypeInfoPropertyName = "HashicorpKubernetesAuthConfigVaultAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListSecretReferencesManagerType), TypeInfoPropertyName = "ListSecretReferencesManagerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListSecretReferencesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListSecretReferencesResponseObject), TypeInfoPropertyName = "ListSecretReferencesResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.SecretReferenceListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateSecretReferenceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateSecretReferenceResponseObject), TypeInfoPropertyName = "CreateSecretReferenceResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateSecretReferenceRequestManagerType?), TypeInfoPropertyName = "NullableCreateSecretReferenceRequestManagerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AuthConfig?), TypeInfoPropertyName = "NullableAuthConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthType?), TypeInfoPropertyName = "NullableCreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretReferenceListItemManagerType?), TypeInfoPropertyName = "NullableSecretReferenceListItemManagerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretReferenceListItemStatus?), TypeInfoPropertyName = "NullableSecretReferenceListItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretReferenceListItemObject?), TypeInfoPropertyName = "NullableSecretReferenceListItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretReferenceDetailResponseManagerType?), TypeInfoPropertyName = "NullableSecretReferenceDetailResponseManagerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretReferenceDetailResponseStatus?), TypeInfoPropertyName = "NullableSecretReferenceDetailResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SecretReferenceDetailResponseObject?), TypeInfoPropertyName = "NullableSecretReferenceDetailResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AwsAccessKeyAuthConfigAwsAuthType?), TypeInfoPropertyName = "NullableAwsAccessKeyAuthConfigAwsAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AwsAssumedRoleAuthConfigAwsAuthType?), TypeInfoPropertyName = "NullableAwsAssumedRoleAuthConfigAwsAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AwsServiceRoleAuthConfigAwsAuthType?), TypeInfoPropertyName = "NullableAwsServiceRoleAuthConfigAwsAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzureEntraAuthConfigAzureAuthMode?), TypeInfoPropertyName = "NullableAzureEntraAuthConfigAzureAuthMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzureManagedAuthConfigAzureAuthMode?), TypeInfoPropertyName = "NullableAzureManagedAuthConfigAzureAuthMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AzureDefaultAuthConfigAzureAuthMode?), TypeInfoPropertyName = "NullableAzureDefaultAuthConfigAzureAuthMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.HashicorpTokenAuthConfigVaultAuthType?), TypeInfoPropertyName = "NullableHashicorpTokenAuthConfigVaultAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.HashicorpAppRoleAuthConfigVaultAuthType?), TypeInfoPropertyName = "NullableHashicorpAppRoleAuthConfigVaultAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.HashicorpKubernetesAuthConfigVaultAuthType?), TypeInfoPropertyName = "NullableHashicorpKubernetesAuthConfigVaultAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListSecretReferencesManagerType?), TypeInfoPropertyName = "NullableListSecretReferencesManagerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListSecretReferencesResponseObject?), TypeInfoPropertyName = "NullableListSecretReferencesResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateSecretReferenceResponseObject?), TypeInfoPropertyName = "NullableCreateSecretReferenceResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.SecretReferenceListItem>))]
    internal sealed partial class SecretReferencesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SecretReferencesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SecretReferencesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SecretReferencesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Portkey.JsonConverters.AuthConfigJsonConverter());
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
                    typeToConvert == typeof(global::Portkey.CreateSecretReferenceRequestManagerType)

                    || typeToConvert == typeof(global::Portkey.CreateSecretReferenceRequestManagerType?)

                    || typeToConvert == typeof(global::Portkey.CreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthType)

                    || typeToConvert == typeof(global::Portkey.CreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthType?)

                    || typeToConvert == typeof(global::Portkey.SecretReferenceListItemManagerType)

                    || typeToConvert == typeof(global::Portkey.SecretReferenceListItemManagerType?)

                    || typeToConvert == typeof(global::Portkey.SecretReferenceListItemStatus)

                    || typeToConvert == typeof(global::Portkey.SecretReferenceListItemStatus?)

                    || typeToConvert == typeof(global::Portkey.SecretReferenceListItemObject)

                    || typeToConvert == typeof(global::Portkey.SecretReferenceListItemObject?)

                    || typeToConvert == typeof(global::Portkey.SecretReferenceDetailResponseManagerType)

                    || typeToConvert == typeof(global::Portkey.SecretReferenceDetailResponseManagerType?)

                    || typeToConvert == typeof(global::Portkey.SecretReferenceDetailResponseStatus)

                    || typeToConvert == typeof(global::Portkey.SecretReferenceDetailResponseStatus?)

                    || typeToConvert == typeof(global::Portkey.SecretReferenceDetailResponseObject)

                    || typeToConvert == typeof(global::Portkey.SecretReferenceDetailResponseObject?)

                    || typeToConvert == typeof(global::Portkey.AwsAccessKeyAuthConfigAwsAuthType)

                    || typeToConvert == typeof(global::Portkey.AwsAccessKeyAuthConfigAwsAuthType?)

                    || typeToConvert == typeof(global::Portkey.AwsAssumedRoleAuthConfigAwsAuthType)

                    || typeToConvert == typeof(global::Portkey.AwsAssumedRoleAuthConfigAwsAuthType?)

                    || typeToConvert == typeof(global::Portkey.AwsServiceRoleAuthConfigAwsAuthType)

                    || typeToConvert == typeof(global::Portkey.AwsServiceRoleAuthConfigAwsAuthType?)

                    || typeToConvert == typeof(global::Portkey.AzureEntraAuthConfigAzureAuthMode)

                    || typeToConvert == typeof(global::Portkey.AzureEntraAuthConfigAzureAuthMode?)

                    || typeToConvert == typeof(global::Portkey.AzureManagedAuthConfigAzureAuthMode)

                    || typeToConvert == typeof(global::Portkey.AzureManagedAuthConfigAzureAuthMode?)

                    || typeToConvert == typeof(global::Portkey.AzureDefaultAuthConfigAzureAuthMode)

                    || typeToConvert == typeof(global::Portkey.AzureDefaultAuthConfigAzureAuthMode?)

                    || typeToConvert == typeof(global::Portkey.HashicorpTokenAuthConfigVaultAuthType)

                    || typeToConvert == typeof(global::Portkey.HashicorpTokenAuthConfigVaultAuthType?)

                    || typeToConvert == typeof(global::Portkey.HashicorpAppRoleAuthConfigVaultAuthType)

                    || typeToConvert == typeof(global::Portkey.HashicorpAppRoleAuthConfigVaultAuthType?)

                    || typeToConvert == typeof(global::Portkey.HashicorpKubernetesAuthConfigVaultAuthType)

                    || typeToConvert == typeof(global::Portkey.HashicorpKubernetesAuthConfigVaultAuthType?)

                    || typeToConvert == typeof(global::Portkey.ListSecretReferencesManagerType)

                    || typeToConvert == typeof(global::Portkey.ListSecretReferencesManagerType?)

                    || typeToConvert == typeof(global::Portkey.ListSecretReferencesResponseObject)

                    || typeToConvert == typeof(global::Portkey.ListSecretReferencesResponseObject?)

                    || typeToConvert == typeof(global::Portkey.CreateSecretReferenceResponseObject)

                    || typeToConvert == typeof(global::Portkey.CreateSecretReferenceResponseObject?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Portkey.CreateSecretReferenceRequestManagerType))
                {
                    return new global::Portkey.JsonConverters.CreateSecretReferenceRequestManagerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateSecretReferenceRequestManagerType?))
                {
                    return new global::Portkey.JsonConverters.CreateSecretReferenceRequestManagerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthType))
                {
                    return new global::Portkey.JsonConverters.CreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthType?))
                {
                    return new global::Portkey.JsonConverters.CreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.SecretReferenceListItemManagerType))
                {
                    return new global::Portkey.JsonConverters.SecretReferenceListItemManagerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.SecretReferenceListItemManagerType?))
                {
                    return new global::Portkey.JsonConverters.SecretReferenceListItemManagerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.SecretReferenceListItemStatus))
                {
                    return new global::Portkey.JsonConverters.SecretReferenceListItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.SecretReferenceListItemStatus?))
                {
                    return new global::Portkey.JsonConverters.SecretReferenceListItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.SecretReferenceListItemObject))
                {
                    return new global::Portkey.JsonConverters.SecretReferenceListItemObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.SecretReferenceListItemObject?))
                {
                    return new global::Portkey.JsonConverters.SecretReferenceListItemObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.SecretReferenceDetailResponseManagerType))
                {
                    return new global::Portkey.JsonConverters.SecretReferenceDetailResponseManagerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.SecretReferenceDetailResponseManagerType?))
                {
                    return new global::Portkey.JsonConverters.SecretReferenceDetailResponseManagerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.SecretReferenceDetailResponseStatus))
                {
                    return new global::Portkey.JsonConverters.SecretReferenceDetailResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.SecretReferenceDetailResponseStatus?))
                {
                    return new global::Portkey.JsonConverters.SecretReferenceDetailResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.SecretReferenceDetailResponseObject))
                {
                    return new global::Portkey.JsonConverters.SecretReferenceDetailResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.SecretReferenceDetailResponseObject?))
                {
                    return new global::Portkey.JsonConverters.SecretReferenceDetailResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AwsAccessKeyAuthConfigAwsAuthType))
                {
                    return new global::Portkey.JsonConverters.AwsAccessKeyAuthConfigAwsAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AwsAccessKeyAuthConfigAwsAuthType?))
                {
                    return new global::Portkey.JsonConverters.AwsAccessKeyAuthConfigAwsAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AwsAssumedRoleAuthConfigAwsAuthType))
                {
                    return new global::Portkey.JsonConverters.AwsAssumedRoleAuthConfigAwsAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AwsAssumedRoleAuthConfigAwsAuthType?))
                {
                    return new global::Portkey.JsonConverters.AwsAssumedRoleAuthConfigAwsAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AwsServiceRoleAuthConfigAwsAuthType))
                {
                    return new global::Portkey.JsonConverters.AwsServiceRoleAuthConfigAwsAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AwsServiceRoleAuthConfigAwsAuthType?))
                {
                    return new global::Portkey.JsonConverters.AwsServiceRoleAuthConfigAwsAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AzureEntraAuthConfigAzureAuthMode))
                {
                    return new global::Portkey.JsonConverters.AzureEntraAuthConfigAzureAuthModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AzureEntraAuthConfigAzureAuthMode?))
                {
                    return new global::Portkey.JsonConverters.AzureEntraAuthConfigAzureAuthModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AzureManagedAuthConfigAzureAuthMode))
                {
                    return new global::Portkey.JsonConverters.AzureManagedAuthConfigAzureAuthModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AzureManagedAuthConfigAzureAuthMode?))
                {
                    return new global::Portkey.JsonConverters.AzureManagedAuthConfigAzureAuthModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AzureDefaultAuthConfigAzureAuthMode))
                {
                    return new global::Portkey.JsonConverters.AzureDefaultAuthConfigAzureAuthModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.AzureDefaultAuthConfigAzureAuthMode?))
                {
                    return new global::Portkey.JsonConverters.AzureDefaultAuthConfigAzureAuthModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.HashicorpTokenAuthConfigVaultAuthType))
                {
                    return new global::Portkey.JsonConverters.HashicorpTokenAuthConfigVaultAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.HashicorpTokenAuthConfigVaultAuthType?))
                {
                    return new global::Portkey.JsonConverters.HashicorpTokenAuthConfigVaultAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.HashicorpAppRoleAuthConfigVaultAuthType))
                {
                    return new global::Portkey.JsonConverters.HashicorpAppRoleAuthConfigVaultAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.HashicorpAppRoleAuthConfigVaultAuthType?))
                {
                    return new global::Portkey.JsonConverters.HashicorpAppRoleAuthConfigVaultAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.HashicorpKubernetesAuthConfigVaultAuthType))
                {
                    return new global::Portkey.JsonConverters.HashicorpKubernetesAuthConfigVaultAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.HashicorpKubernetesAuthConfigVaultAuthType?))
                {
                    return new global::Portkey.JsonConverters.HashicorpKubernetesAuthConfigVaultAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListSecretReferencesManagerType))
                {
                    return new global::Portkey.JsonConverters.ListSecretReferencesManagerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListSecretReferencesManagerType?))
                {
                    return new global::Portkey.JsonConverters.ListSecretReferencesManagerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListSecretReferencesResponseObject))
                {
                    return new global::Portkey.JsonConverters.ListSecretReferencesResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListSecretReferencesResponseObject?))
                {
                    return new global::Portkey.JsonConverters.ListSecretReferencesResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateSecretReferenceResponseObject))
                {
                    return new global::Portkey.JsonConverters.CreateSecretReferenceResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateSecretReferenceResponseObject?))
                {
                    return new global::Portkey.JsonConverters.CreateSecretReferenceResponseObjectNullableJsonConverter();
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
                    0 => new SecretReferencesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}