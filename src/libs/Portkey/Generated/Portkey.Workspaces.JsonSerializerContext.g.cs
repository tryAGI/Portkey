
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsType), TypeInfoPropertyName = "RateLimitsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsUnit), TypeInfoPropertyName = "RateLimitsUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsType), TypeInfoPropertyName = "UsageLimitsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsPeriodicReset), TypeInfoPropertyName = "UsageLimitsPeriodicReset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.UsageLimits>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.RateLimits>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceMemberObject), TypeInfoPropertyName = "WorkspaceMemberObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceMemberOrgRole), TypeInfoPropertyName = "WorkspaceMemberOrgRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceMemberRole), TypeInfoPropertyName = "WorkspaceMemberRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceMemberStatus), TypeInfoPropertyName = "WorkspaceMemberStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.WorkspaceMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Workspace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceDefaults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceDefaultsObject), TypeInfoPropertyName = "WorkspaceDefaultsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceListObject), TypeInfoPropertyName = "WorkspaceListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.Workspace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceWithUsers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceWithUsersDefaults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceWithUsersDefaultsObject), TypeInfoPropertyName = "WorkspaceWithUsersDefaultsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ScimWorkspaceMapping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ScimWorkspaceMappingRole), TypeInfoPropertyName = "ScimWorkspaceMappingRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateAdminWorkspacesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateAdminWorkspacesRequestDefaults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PutAdminWorkspacesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PutAdminWorkspacesRequestDefaults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateScimWorkspacesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateScimWorkspacesRequestRole), TypeInfoPropertyName = "CreateScimWorkspacesRequestRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAdminWorkspacesStatus), TypeInfoPropertyName = "GetAdminWorkspacesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetScimWorkspacesRole), TypeInfoPropertyName = "GetScimWorkspacesRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetScimWorkspacesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.GetScimWorkspacesResponseMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetScimWorkspacesResponseMapping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetScimWorkspacesResponseMappingRole), TypeInfoPropertyName = "GetScimWorkspacesResponseMappingRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.DeleteScimWorkspacesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsType?), TypeInfoPropertyName = "NullableRateLimitsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.RateLimitsUnit?), TypeInfoPropertyName = "NullableRateLimitsUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsType?), TypeInfoPropertyName = "NullableUsageLimitsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.UsageLimitsPeriodicReset?), TypeInfoPropertyName = "NullableUsageLimitsPeriodicReset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceMemberObject?), TypeInfoPropertyName = "NullableWorkspaceMemberObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceMemberOrgRole?), TypeInfoPropertyName = "NullableWorkspaceMemberOrgRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceMemberRole?), TypeInfoPropertyName = "NullableWorkspaceMemberRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceMemberStatus?), TypeInfoPropertyName = "NullableWorkspaceMemberStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceDefaultsObject?), TypeInfoPropertyName = "NullableWorkspaceDefaultsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceListObject?), TypeInfoPropertyName = "NullableWorkspaceListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceWithUsersDefaultsObject?), TypeInfoPropertyName = "NullableWorkspaceWithUsersDefaultsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.ScimWorkspaceMappingRole?), TypeInfoPropertyName = "NullableScimWorkspaceMappingRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateScimWorkspacesRequestRole?), TypeInfoPropertyName = "NullableCreateScimWorkspacesRequestRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAdminWorkspacesStatus?), TypeInfoPropertyName = "NullableGetAdminWorkspacesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetScimWorkspacesRole?), TypeInfoPropertyName = "NullableGetScimWorkspacesRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetScimWorkspacesResponseMappingRole?), TypeInfoPropertyName = "NullableGetScimWorkspacesResponseMappingRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.UsageLimits>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.RateLimits>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.WorkspaceMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.Workspace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.GetScimWorkspacesResponseMapping>))]
    internal sealed partial class WorkspacesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WorkspacesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static WorkspacesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private WorkspacesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Portkey.RateLimitsType)

                    || typeToConvert == typeof(global::Portkey.RateLimitsType?)

                    || typeToConvert == typeof(global::Portkey.RateLimitsUnit)

                    || typeToConvert == typeof(global::Portkey.RateLimitsUnit?)

                    || typeToConvert == typeof(global::Portkey.UsageLimitsType)

                    || typeToConvert == typeof(global::Portkey.UsageLimitsType?)

                    || typeToConvert == typeof(global::Portkey.UsageLimitsPeriodicReset)

                    || typeToConvert == typeof(global::Portkey.UsageLimitsPeriodicReset?)

                    || typeToConvert == typeof(global::Portkey.WorkspaceMemberObject)

                    || typeToConvert == typeof(global::Portkey.WorkspaceMemberObject?)

                    || typeToConvert == typeof(global::Portkey.WorkspaceMemberOrgRole)

                    || typeToConvert == typeof(global::Portkey.WorkspaceMemberOrgRole?)

                    || typeToConvert == typeof(global::Portkey.WorkspaceMemberRole)

                    || typeToConvert == typeof(global::Portkey.WorkspaceMemberRole?)

                    || typeToConvert == typeof(global::Portkey.WorkspaceMemberStatus)

                    || typeToConvert == typeof(global::Portkey.WorkspaceMemberStatus?)

                    || typeToConvert == typeof(global::Portkey.WorkspaceDefaultsObject)

                    || typeToConvert == typeof(global::Portkey.WorkspaceDefaultsObject?)

                    || typeToConvert == typeof(global::Portkey.WorkspaceListObject)

                    || typeToConvert == typeof(global::Portkey.WorkspaceListObject?)

                    || typeToConvert == typeof(global::Portkey.WorkspaceWithUsersDefaultsObject)

                    || typeToConvert == typeof(global::Portkey.WorkspaceWithUsersDefaultsObject?)

                    || typeToConvert == typeof(global::Portkey.ScimWorkspaceMappingRole)

                    || typeToConvert == typeof(global::Portkey.ScimWorkspaceMappingRole?)

                    || typeToConvert == typeof(global::Portkey.CreateScimWorkspacesRequestRole)

                    || typeToConvert == typeof(global::Portkey.CreateScimWorkspacesRequestRole?)

                    || typeToConvert == typeof(global::Portkey.GetAdminWorkspacesStatus)

                    || typeToConvert == typeof(global::Portkey.GetAdminWorkspacesStatus?)

                    || typeToConvert == typeof(global::Portkey.GetScimWorkspacesRole)

                    || typeToConvert == typeof(global::Portkey.GetScimWorkspacesRole?)

                    || typeToConvert == typeof(global::Portkey.GetScimWorkspacesResponseMappingRole)

                    || typeToConvert == typeof(global::Portkey.GetScimWorkspacesResponseMappingRole?);
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

                if (typeToConvert == typeof(global::Portkey.WorkspaceMemberObject))
                {
                    return new global::Portkey.JsonConverters.WorkspaceMemberObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WorkspaceMemberObject?))
                {
                    return new global::Portkey.JsonConverters.WorkspaceMemberObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WorkspaceMemberOrgRole))
                {
                    return new global::Portkey.JsonConverters.WorkspaceMemberOrgRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WorkspaceMemberOrgRole?))
                {
                    return new global::Portkey.JsonConverters.WorkspaceMemberOrgRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WorkspaceMemberRole))
                {
                    return new global::Portkey.JsonConverters.WorkspaceMemberRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WorkspaceMemberRole?))
                {
                    return new global::Portkey.JsonConverters.WorkspaceMemberRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WorkspaceMemberStatus))
                {
                    return new global::Portkey.JsonConverters.WorkspaceMemberStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WorkspaceMemberStatus?))
                {
                    return new global::Portkey.JsonConverters.WorkspaceMemberStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WorkspaceDefaultsObject))
                {
                    return new global::Portkey.JsonConverters.WorkspaceDefaultsObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WorkspaceDefaultsObject?))
                {
                    return new global::Portkey.JsonConverters.WorkspaceDefaultsObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WorkspaceListObject))
                {
                    return new global::Portkey.JsonConverters.WorkspaceListObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WorkspaceListObject?))
                {
                    return new global::Portkey.JsonConverters.WorkspaceListObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WorkspaceWithUsersDefaultsObject))
                {
                    return new global::Portkey.JsonConverters.WorkspaceWithUsersDefaultsObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WorkspaceWithUsersDefaultsObject?))
                {
                    return new global::Portkey.JsonConverters.WorkspaceWithUsersDefaultsObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ScimWorkspaceMappingRole))
                {
                    return new global::Portkey.JsonConverters.ScimWorkspaceMappingRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.ScimWorkspaceMappingRole?))
                {
                    return new global::Portkey.JsonConverters.ScimWorkspaceMappingRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateScimWorkspacesRequestRole))
                {
                    return new global::Portkey.JsonConverters.CreateScimWorkspacesRequestRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateScimWorkspacesRequestRole?))
                {
                    return new global::Portkey.JsonConverters.CreateScimWorkspacesRequestRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAdminWorkspacesStatus))
                {
                    return new global::Portkey.JsonConverters.GetAdminWorkspacesStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAdminWorkspacesStatus?))
                {
                    return new global::Portkey.JsonConverters.GetAdminWorkspacesStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetScimWorkspacesRole))
                {
                    return new global::Portkey.JsonConverters.GetScimWorkspacesRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetScimWorkspacesRole?))
                {
                    return new global::Portkey.JsonConverters.GetScimWorkspacesRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetScimWorkspacesResponseMappingRole))
                {
                    return new global::Portkey.JsonConverters.GetScimWorkspacesResponseMappingRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetScimWorkspacesResponseMappingRole?))
                {
                    return new global::Portkey.JsonConverters.GetScimWorkspacesResponseMappingRoleNullableJsonConverter();
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
                    0 => new WorkspacesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}