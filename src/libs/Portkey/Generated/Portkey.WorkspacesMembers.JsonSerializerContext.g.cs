
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceMemberObject), TypeInfoPropertyName = "WorkspaceMemberObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceMemberOrgRole), TypeInfoPropertyName = "WorkspaceMemberOrgRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceMemberRole), TypeInfoPropertyName = "WorkspaceMemberRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceMemberStatus), TypeInfoPropertyName = "WorkspaceMemberStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceMemberList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceMemberListObject), TypeInfoPropertyName = "WorkspaceMemberListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.WorkspaceMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateAdminWorkspacesUsersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.CreateAdminWorkspacesUsersRequestUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateAdminWorkspacesUsersRequestUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateAdminWorkspacesUsersRequestUserRole), TypeInfoPropertyName = "CreateAdminWorkspacesUsersRequestUserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PutAdminWorkspacesUsersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PutAdminWorkspacesUsersRequestRole), TypeInfoPropertyName = "PutAdminWorkspacesUsersRequestRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAdminWorkspacesUsersRole), TypeInfoPropertyName = "GetAdminWorkspacesUsersRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceMemberObject?), TypeInfoPropertyName = "NullableWorkspaceMemberObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceMemberOrgRole?), TypeInfoPropertyName = "NullableWorkspaceMemberOrgRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceMemberRole?), TypeInfoPropertyName = "NullableWorkspaceMemberRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceMemberStatus?), TypeInfoPropertyName = "NullableWorkspaceMemberStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceMemberListObject?), TypeInfoPropertyName = "NullableWorkspaceMemberListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateAdminWorkspacesUsersRequestUserRole?), TypeInfoPropertyName = "NullableCreateAdminWorkspacesUsersRequestUserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.PutAdminWorkspacesUsersRequestRole?), TypeInfoPropertyName = "NullablePutAdminWorkspacesUsersRequestRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAdminWorkspacesUsersRole?), TypeInfoPropertyName = "NullableGetAdminWorkspacesUsersRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.WorkspaceMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.CreateAdminWorkspacesUsersRequestUser>))]
    internal sealed partial class WorkspacesMembersSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WorkspacesMembersSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static WorkspacesMembersSourceGenerationContext Default { get; } = new(DefaultOptions);

        private WorkspacesMembersSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Portkey.WorkspaceMemberObject)

                    || typeToConvert == typeof(global::Portkey.WorkspaceMemberObject?)

                    || typeToConvert == typeof(global::Portkey.WorkspaceMemberOrgRole)

                    || typeToConvert == typeof(global::Portkey.WorkspaceMemberOrgRole?)

                    || typeToConvert == typeof(global::Portkey.WorkspaceMemberRole)

                    || typeToConvert == typeof(global::Portkey.WorkspaceMemberRole?)

                    || typeToConvert == typeof(global::Portkey.WorkspaceMemberStatus)

                    || typeToConvert == typeof(global::Portkey.WorkspaceMemberStatus?)

                    || typeToConvert == typeof(global::Portkey.WorkspaceMemberListObject)

                    || typeToConvert == typeof(global::Portkey.WorkspaceMemberListObject?)

                    || typeToConvert == typeof(global::Portkey.CreateAdminWorkspacesUsersRequestUserRole)

                    || typeToConvert == typeof(global::Portkey.CreateAdminWorkspacesUsersRequestUserRole?)

                    || typeToConvert == typeof(global::Portkey.PutAdminWorkspacesUsersRequestRole)

                    || typeToConvert == typeof(global::Portkey.PutAdminWorkspacesUsersRequestRole?)

                    || typeToConvert == typeof(global::Portkey.GetAdminWorkspacesUsersRole)

                    || typeToConvert == typeof(global::Portkey.GetAdminWorkspacesUsersRole?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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

                if (typeToConvert == typeof(global::Portkey.WorkspaceMemberListObject))
                {
                    return new global::Portkey.JsonConverters.WorkspaceMemberListObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WorkspaceMemberListObject?))
                {
                    return new global::Portkey.JsonConverters.WorkspaceMemberListObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateAdminWorkspacesUsersRequestUserRole))
                {
                    return new global::Portkey.JsonConverters.CreateAdminWorkspacesUsersRequestUserRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.CreateAdminWorkspacesUsersRequestUserRole?))
                {
                    return new global::Portkey.JsonConverters.CreateAdminWorkspacesUsersRequestUserRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PutAdminWorkspacesUsersRequestRole))
                {
                    return new global::Portkey.JsonConverters.PutAdminWorkspacesUsersRequestRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.PutAdminWorkspacesUsersRequestRole?))
                {
                    return new global::Portkey.JsonConverters.PutAdminWorkspacesUsersRequestRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAdminWorkspacesUsersRole))
                {
                    return new global::Portkey.JsonConverters.GetAdminWorkspacesUsersRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAdminWorkspacesUsersRole?))
                {
                    return new global::Portkey.JsonConverters.GetAdminWorkspacesUsersRoleNullableJsonConverter();
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
                    0 => new WorkspacesMembersSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}