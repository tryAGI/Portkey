
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateInvite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.WorkspaceInvite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceInvite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InviteRole), TypeInfoPropertyName = "InviteRole2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateInviteWorkspaceApiKeyDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceInviteRole), TypeInfoPropertyName = "WorkspaceInviteRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.SuccessInvite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.Invite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InviteRole2), TypeInfoPropertyName = "InviteRole22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InviteStatus), TypeInfoPropertyName = "InviteStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InviteList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InviteListObject), TypeInfoPropertyName = "InviteListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Portkey.Invite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAdminUsersInvitesRole), TypeInfoPropertyName = "GetAdminUsersInvitesRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAdminUsersInvitesStatus), TypeInfoPropertyName = "GetAdminUsersInvitesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.CreateAdminUsersInvitesResendResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InviteRole?), TypeInfoPropertyName = "NullableInviteRole2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.WorkspaceInviteRole?), TypeInfoPropertyName = "NullableWorkspaceInviteRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InviteRole2?), TypeInfoPropertyName = "NullableInviteRole22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InviteStatus?), TypeInfoPropertyName = "NullableInviteStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.InviteListObject?), TypeInfoPropertyName = "NullableInviteListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAdminUsersInvitesRole?), TypeInfoPropertyName = "NullableGetAdminUsersInvitesRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Portkey.GetAdminUsersInvitesStatus?), TypeInfoPropertyName = "NullableGetAdminUsersInvitesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.WorkspaceInvite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Portkey.Invite>))]
    internal sealed partial class UserInvitesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserInvitesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static UserInvitesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private UserInvitesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Portkey.InviteRole)

                    || typeToConvert == typeof(global::Portkey.InviteRole?)

                    || typeToConvert == typeof(global::Portkey.WorkspaceInviteRole)

                    || typeToConvert == typeof(global::Portkey.WorkspaceInviteRole?)

                    || typeToConvert == typeof(global::Portkey.InviteRole2)

                    || typeToConvert == typeof(global::Portkey.InviteRole2?)

                    || typeToConvert == typeof(global::Portkey.InviteStatus)

                    || typeToConvert == typeof(global::Portkey.InviteStatus?)

                    || typeToConvert == typeof(global::Portkey.InviteListObject)

                    || typeToConvert == typeof(global::Portkey.InviteListObject?)

                    || typeToConvert == typeof(global::Portkey.GetAdminUsersInvitesRole)

                    || typeToConvert == typeof(global::Portkey.GetAdminUsersInvitesRole?)

                    || typeToConvert == typeof(global::Portkey.GetAdminUsersInvitesStatus)

                    || typeToConvert == typeof(global::Portkey.GetAdminUsersInvitesStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Portkey.InviteRole))
                {
                    return new global::Portkey.JsonConverters.InviteRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InviteRole?))
                {
                    return new global::Portkey.JsonConverters.InviteRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WorkspaceInviteRole))
                {
                    return new global::Portkey.JsonConverters.WorkspaceInviteRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.WorkspaceInviteRole?))
                {
                    return new global::Portkey.JsonConverters.WorkspaceInviteRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InviteRole2))
                {
                    return new global::Portkey.JsonConverters.InviteRole2JsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InviteRole2?))
                {
                    return new global::Portkey.JsonConverters.InviteRole2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InviteStatus))
                {
                    return new global::Portkey.JsonConverters.InviteStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InviteStatus?))
                {
                    return new global::Portkey.JsonConverters.InviteStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InviteListObject))
                {
                    return new global::Portkey.JsonConverters.InviteListObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.InviteListObject?))
                {
                    return new global::Portkey.JsonConverters.InviteListObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAdminUsersInvitesRole))
                {
                    return new global::Portkey.JsonConverters.GetAdminUsersInvitesRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAdminUsersInvitesRole?))
                {
                    return new global::Portkey.JsonConverters.GetAdminUsersInvitesRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAdminUsersInvitesStatus))
                {
                    return new global::Portkey.JsonConverters.GetAdminUsersInvitesStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Portkey.GetAdminUsersInvitesStatus?))
                {
                    return new global::Portkey.JsonConverters.GetAdminUsersInvitesStatusNullableJsonConverter();
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
                    0 => new UserInvitesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}