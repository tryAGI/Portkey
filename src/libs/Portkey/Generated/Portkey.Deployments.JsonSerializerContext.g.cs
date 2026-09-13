
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentAuthSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentAuthSettingsInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentCredentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateDeploymentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateDeploymentRequestType), TypeInfoPropertyName = "CreateDeploymentRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateDeploymentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateDeploymentRequestType), TypeInfoPropertyName = "UpdateDeploymentRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateDeploymentRequestStatus), TypeInfoPropertyName = "UpdateDeploymentRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AllOf<global::Portkey.DeploymentAuthSettingsInput, global::Portkey.UpdateDeploymentRequestAuthSettings>), TypeInfoPropertyName = "AllOfDeploymentAuthSettingsInputUpdateDeploymentRequestAuthSettings2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateDeploymentRequestAuthSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentCreateResponseObject), TypeInfoPropertyName = "DeploymentCreateResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentListItemType), TypeInfoPropertyName = "DeploymentListItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentListItemStatus), TypeInfoPropertyName = "DeploymentListItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentListItemConnectionStatus), TypeInfoPropertyName = "DeploymentListItemConnectionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentListItemObject), TypeInfoPropertyName = "DeploymentListItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentDetailResponse), TypeInfoPropertyName = "DeploymentDetailResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentDetailResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AllOf<global::Portkey.DeploymentAuthSettings, global::Portkey.DeploymentDetailResponseVariant2AuthSettings>), TypeInfoPropertyName = "AllOfDeploymentAuthSettingsDeploymentDetailResponseVariant2AuthSettings2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentDetailResponseVariant2AuthSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.DeploymentDetailResponseVariant2Workspace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentDetailResponseVariant2Workspace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentPingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentPingResponseStatus), TypeInfoPropertyName = "DeploymentPingResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentPingResponseOutbound))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentPingResponseOutboundStatus), TypeInfoPropertyName = "DeploymentPingResponseOutboundStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentPingResponseInbound))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentPingResponseInboundStatus), TypeInfoPropertyName = "DeploymentPingResponseInboundStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentPingResponseObject), TypeInfoPropertyName = "DeploymentPingResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListDeploymentsStatus), TypeInfoPropertyName = "ListDeploymentsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListDeploymentsType), TypeInfoPropertyName = "ListDeploymentsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.Dictionary<string, string>>), TypeInfoPropertyName = "OneOfStringDictionaryStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListDeploymentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListDeploymentsResponseObject), TypeInfoPropertyName = "ListDeploymentsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.DeploymentListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateDeploymentRequestType?), TypeInfoPropertyName = "NullableCreateDeploymentRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateDeploymentRequestType?), TypeInfoPropertyName = "NullableUpdateDeploymentRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UpdateDeploymentRequestStatus?), TypeInfoPropertyName = "NullableUpdateDeploymentRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AllOf<global::Portkey.DeploymentAuthSettingsInput, global::Portkey.UpdateDeploymentRequestAuthSettings>?), TypeInfoPropertyName = "NullableAllOfDeploymentAuthSettingsInputUpdateDeploymentRequestAuthSettings2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentCreateResponseObject?), TypeInfoPropertyName = "NullableDeploymentCreateResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentListItemType?), TypeInfoPropertyName = "NullableDeploymentListItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentListItemStatus?), TypeInfoPropertyName = "NullableDeploymentListItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentListItemConnectionStatus?), TypeInfoPropertyName = "NullableDeploymentListItemConnectionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentListItemObject?), TypeInfoPropertyName = "NullableDeploymentListItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentDetailResponse?), TypeInfoPropertyName = "NullableDeploymentDetailResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.AllOf<global::Portkey.DeploymentAuthSettings, global::Portkey.DeploymentDetailResponseVariant2AuthSettings>?), TypeInfoPropertyName = "NullableAllOfDeploymentAuthSettingsDeploymentDetailResponseVariant2AuthSettings2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentPingResponseStatus?), TypeInfoPropertyName = "NullableDeploymentPingResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentPingResponseOutboundStatus?), TypeInfoPropertyName = "NullableDeploymentPingResponseOutboundStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentPingResponseInboundStatus?), TypeInfoPropertyName = "NullableDeploymentPingResponseInboundStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeploymentPingResponseObject?), TypeInfoPropertyName = "NullableDeploymentPingResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListDeploymentsStatus?), TypeInfoPropertyName = "NullableListDeploymentsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListDeploymentsType?), TypeInfoPropertyName = "NullableListDeploymentsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.OneOf<string, global::System.Collections.Generic.Dictionary<string, string>>?), TypeInfoPropertyName = "NullableOneOfStringDictionaryStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ListDeploymentsResponseObject?), TypeInfoPropertyName = "NullableListDeploymentsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.DeploymentDetailResponseVariant2Workspace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.DeploymentListItem>))]
    internal sealed partial class DeploymentsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeploymentsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static DeploymentsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private DeploymentsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Portkey.JsonConverters.DeploymentDetailResponseJsonConverter());
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
            options.Converters.Add(new global::Portkey.JsonConverters.AllOfJsonConverter<global::Portkey.DeploymentAuthSettingsInput, global::Portkey.UpdateDeploymentRequestAuthSettings>());
            options.Converters.Add(new global::Portkey.JsonConverters.AllOfJsonConverter<global::Portkey.DeploymentAuthSettings, global::Portkey.DeploymentDetailResponseVariant2AuthSettings>());
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
                    typeToConvert == typeof(global::Portkey.CreateDeploymentRequestType)

                    || typeToConvert == typeof(global::Portkey.CreateDeploymentRequestType?)

                    || typeToConvert == typeof(global::Portkey.UpdateDeploymentRequestType)

                    || typeToConvert == typeof(global::Portkey.UpdateDeploymentRequestType?)

                    || typeToConvert == typeof(global::Portkey.UpdateDeploymentRequestStatus)

                    || typeToConvert == typeof(global::Portkey.UpdateDeploymentRequestStatus?)

                    || typeToConvert == typeof(global::Portkey.DeploymentCreateResponseObject)

                    || typeToConvert == typeof(global::Portkey.DeploymentCreateResponseObject?)

                    || typeToConvert == typeof(global::Portkey.DeploymentListItemType)

                    || typeToConvert == typeof(global::Portkey.DeploymentListItemType?)

                    || typeToConvert == typeof(global::Portkey.DeploymentListItemStatus)

                    || typeToConvert == typeof(global::Portkey.DeploymentListItemStatus?)

                    || typeToConvert == typeof(global::Portkey.DeploymentListItemConnectionStatus)

                    || typeToConvert == typeof(global::Portkey.DeploymentListItemConnectionStatus?)

                    || typeToConvert == typeof(global::Portkey.DeploymentListItemObject)

                    || typeToConvert == typeof(global::Portkey.DeploymentListItemObject?)

                    || typeToConvert == typeof(global::Portkey.DeploymentPingResponseStatus)

                    || typeToConvert == typeof(global::Portkey.DeploymentPingResponseStatus?)

                    || typeToConvert == typeof(global::Portkey.DeploymentPingResponseOutboundStatus)

                    || typeToConvert == typeof(global::Portkey.DeploymentPingResponseOutboundStatus?)

                    || typeToConvert == typeof(global::Portkey.DeploymentPingResponseInboundStatus)

                    || typeToConvert == typeof(global::Portkey.DeploymentPingResponseInboundStatus?)

                    || typeToConvert == typeof(global::Portkey.DeploymentPingResponseObject)

                    || typeToConvert == typeof(global::Portkey.DeploymentPingResponseObject?)

                    || typeToConvert == typeof(global::Portkey.ListDeploymentsStatus)

                    || typeToConvert == typeof(global::Portkey.ListDeploymentsStatus?)

                    || typeToConvert == typeof(global::Portkey.ListDeploymentsType)

                    || typeToConvert == typeof(global::Portkey.ListDeploymentsType?)

                    || typeToConvert == typeof(global::Portkey.ListDeploymentsResponseObject)

                    || typeToConvert == typeof(global::Portkey.ListDeploymentsResponseObject?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Portkey.CreateDeploymentRequestType))
                {
                    return new global::Portkey.JsonConverters.CreateDeploymentRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateDeploymentRequestType?))
                {
                    return new global::Portkey.JsonConverters.CreateDeploymentRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UpdateDeploymentRequestType))
                {
                    return new global::Portkey.JsonConverters.UpdateDeploymentRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UpdateDeploymentRequestType?))
                {
                    return new global::Portkey.JsonConverters.UpdateDeploymentRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UpdateDeploymentRequestStatus))
                {
                    return new global::Portkey.JsonConverters.UpdateDeploymentRequestStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.UpdateDeploymentRequestStatus?))
                {
                    return new global::Portkey.JsonConverters.UpdateDeploymentRequestStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeploymentCreateResponseObject))
                {
                    return new global::Portkey.JsonConverters.DeploymentCreateResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeploymentCreateResponseObject?))
                {
                    return new global::Portkey.JsonConverters.DeploymentCreateResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeploymentListItemType))
                {
                    return new global::Portkey.JsonConverters.DeploymentListItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeploymentListItemType?))
                {
                    return new global::Portkey.JsonConverters.DeploymentListItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeploymentListItemStatus))
                {
                    return new global::Portkey.JsonConverters.DeploymentListItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeploymentListItemStatus?))
                {
                    return new global::Portkey.JsonConverters.DeploymentListItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeploymentListItemConnectionStatus))
                {
                    return new global::Portkey.JsonConverters.DeploymentListItemConnectionStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeploymentListItemConnectionStatus?))
                {
                    return new global::Portkey.JsonConverters.DeploymentListItemConnectionStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeploymentListItemObject))
                {
                    return new global::Portkey.JsonConverters.DeploymentListItemObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeploymentListItemObject?))
                {
                    return new global::Portkey.JsonConverters.DeploymentListItemObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeploymentPingResponseStatus))
                {
                    return new global::Portkey.JsonConverters.DeploymentPingResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeploymentPingResponseStatus?))
                {
                    return new global::Portkey.JsonConverters.DeploymentPingResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeploymentPingResponseOutboundStatus))
                {
                    return new global::Portkey.JsonConverters.DeploymentPingResponseOutboundStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeploymentPingResponseOutboundStatus?))
                {
                    return new global::Portkey.JsonConverters.DeploymentPingResponseOutboundStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeploymentPingResponseInboundStatus))
                {
                    return new global::Portkey.JsonConverters.DeploymentPingResponseInboundStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeploymentPingResponseInboundStatus?))
                {
                    return new global::Portkey.JsonConverters.DeploymentPingResponseInboundStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeploymentPingResponseObject))
                {
                    return new global::Portkey.JsonConverters.DeploymentPingResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.DeploymentPingResponseObject?))
                {
                    return new global::Portkey.JsonConverters.DeploymentPingResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListDeploymentsStatus))
                {
                    return new global::Portkey.JsonConverters.ListDeploymentsStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListDeploymentsStatus?))
                {
                    return new global::Portkey.JsonConverters.ListDeploymentsStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListDeploymentsType))
                {
                    return new global::Portkey.JsonConverters.ListDeploymentsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListDeploymentsType?))
                {
                    return new global::Portkey.JsonConverters.ListDeploymentsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListDeploymentsResponseObject))
                {
                    return new global::Portkey.JsonConverters.ListDeploymentsResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ListDeploymentsResponseObject?))
                {
                    return new global::Portkey.JsonConverters.ListDeploymentsResponseObjectNullableJsonConverter();
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
                    0 => new DeploymentsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}