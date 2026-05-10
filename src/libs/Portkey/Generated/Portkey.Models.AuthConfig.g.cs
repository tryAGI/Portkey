#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AuthConfig : global::System.IEquatable<AuthConfig>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.AwsAccessKeyAuthConfig? AccessKey { get; init; }
#else
        public global::Portkey.AwsAccessKeyAuthConfig? AccessKey { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AccessKey))]
#endif
        public bool IsAccessKey => AccessKey != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAccessKey(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.AwsAccessKeyAuthConfig? value)
        {
            value = AccessKey;
            return IsAccessKey;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.AwsAssumedRoleAuthConfig? AssumedRole { get; init; }
#else
        public global::Portkey.AwsAssumedRoleAuthConfig? AssumedRole { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AssumedRole))]
#endif
        public bool IsAssumedRole => AssumedRole != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAssumedRole(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.AwsAssumedRoleAuthConfig? value)
        {
            value = AssumedRole;
            return IsAssumedRole;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.AwsServiceRoleAuthConfig? ServiceRole { get; init; }
#else
        public global::Portkey.AwsServiceRoleAuthConfig? ServiceRole { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ServiceRole))]
#endif
        public bool IsServiceRole => ServiceRole != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickServiceRole(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.AwsServiceRoleAuthConfig? value)
        {
            value = ServiceRole;
            return IsServiceRole;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.AzureEntraAuthConfig? AzureEntra { get; init; }
#else
        public global::Portkey.AzureEntraAuthConfig? AzureEntra { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AzureEntra))]
#endif
        public bool IsAzureEntra => AzureEntra != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAzureEntra(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.AzureEntraAuthConfig? value)
        {
            value = AzureEntra;
            return IsAzureEntra;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.AzureManagedAuthConfig? AzureManaged { get; init; }
#else
        public global::Portkey.AzureManagedAuthConfig? AzureManaged { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AzureManaged))]
#endif
        public bool IsAzureManaged => AzureManaged != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAzureManaged(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.AzureManagedAuthConfig? value)
        {
            value = AzureManaged;
            return IsAzureManaged;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.AzureDefaultAuthConfig? AzureDefault { get; init; }
#else
        public global::Portkey.AzureDefaultAuthConfig? AzureDefault { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AzureDefault))]
#endif
        public bool IsAzureDefault => AzureDefault != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAzureDefault(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.AzureDefaultAuthConfig? value)
        {
            value = AzureDefault;
            return IsAzureDefault;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.HashicorpTokenAuthConfig? HashicorpToken { get; init; }
#else
        public global::Portkey.HashicorpTokenAuthConfig? HashicorpToken { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HashicorpToken))]
#endif
        public bool IsHashicorpToken => HashicorpToken != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickHashicorpToken(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.HashicorpTokenAuthConfig? value)
        {
            value = HashicorpToken;
            return IsHashicorpToken;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.HashicorpAppRoleAuthConfig? HashicorpAppRole { get; init; }
#else
        public global::Portkey.HashicorpAppRoleAuthConfig? HashicorpAppRole { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HashicorpAppRole))]
#endif
        public bool IsHashicorpAppRole => HashicorpAppRole != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickHashicorpAppRole(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.HashicorpAppRoleAuthConfig? value)
        {
            value = HashicorpAppRole;
            return IsHashicorpAppRole;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.HashicorpKubernetesAuthConfig? HashicorpKubernetes { get; init; }
#else
        public global::Portkey.HashicorpKubernetesAuthConfig? HashicorpKubernetes { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HashicorpKubernetes))]
#endif
        public bool IsHashicorpKubernetes => HashicorpKubernetes != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickHashicorpKubernetes(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.HashicorpKubernetesAuthConfig? value)
        {
            value = HashicorpKubernetes;
            return IsHashicorpKubernetes;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthConfig(global::Portkey.AwsAccessKeyAuthConfig value) => new AuthConfig((global::Portkey.AwsAccessKeyAuthConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.AwsAccessKeyAuthConfig?(AuthConfig @this) => @this.AccessKey;

        /// <summary>
        /// 
        /// </summary>
        public AuthConfig(global::Portkey.AwsAccessKeyAuthConfig? value)
        {
            AccessKey = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AuthConfig FromAccessKey(global::Portkey.AwsAccessKeyAuthConfig? value) => new AuthConfig(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthConfig(global::Portkey.AwsAssumedRoleAuthConfig value) => new AuthConfig((global::Portkey.AwsAssumedRoleAuthConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.AwsAssumedRoleAuthConfig?(AuthConfig @this) => @this.AssumedRole;

        /// <summary>
        /// 
        /// </summary>
        public AuthConfig(global::Portkey.AwsAssumedRoleAuthConfig? value)
        {
            AssumedRole = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AuthConfig FromAssumedRole(global::Portkey.AwsAssumedRoleAuthConfig? value) => new AuthConfig(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthConfig(global::Portkey.AwsServiceRoleAuthConfig value) => new AuthConfig((global::Portkey.AwsServiceRoleAuthConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.AwsServiceRoleAuthConfig?(AuthConfig @this) => @this.ServiceRole;

        /// <summary>
        /// 
        /// </summary>
        public AuthConfig(global::Portkey.AwsServiceRoleAuthConfig? value)
        {
            ServiceRole = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AuthConfig FromServiceRole(global::Portkey.AwsServiceRoleAuthConfig? value) => new AuthConfig(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthConfig(global::Portkey.AzureEntraAuthConfig value) => new AuthConfig((global::Portkey.AzureEntraAuthConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.AzureEntraAuthConfig?(AuthConfig @this) => @this.AzureEntra;

        /// <summary>
        /// 
        /// </summary>
        public AuthConfig(global::Portkey.AzureEntraAuthConfig? value)
        {
            AzureEntra = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AuthConfig FromAzureEntra(global::Portkey.AzureEntraAuthConfig? value) => new AuthConfig(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthConfig(global::Portkey.AzureManagedAuthConfig value) => new AuthConfig((global::Portkey.AzureManagedAuthConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.AzureManagedAuthConfig?(AuthConfig @this) => @this.AzureManaged;

        /// <summary>
        /// 
        /// </summary>
        public AuthConfig(global::Portkey.AzureManagedAuthConfig? value)
        {
            AzureManaged = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AuthConfig FromAzureManaged(global::Portkey.AzureManagedAuthConfig? value) => new AuthConfig(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthConfig(global::Portkey.AzureDefaultAuthConfig value) => new AuthConfig((global::Portkey.AzureDefaultAuthConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.AzureDefaultAuthConfig?(AuthConfig @this) => @this.AzureDefault;

        /// <summary>
        /// 
        /// </summary>
        public AuthConfig(global::Portkey.AzureDefaultAuthConfig? value)
        {
            AzureDefault = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AuthConfig FromAzureDefault(global::Portkey.AzureDefaultAuthConfig? value) => new AuthConfig(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthConfig(global::Portkey.HashicorpTokenAuthConfig value) => new AuthConfig((global::Portkey.HashicorpTokenAuthConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.HashicorpTokenAuthConfig?(AuthConfig @this) => @this.HashicorpToken;

        /// <summary>
        /// 
        /// </summary>
        public AuthConfig(global::Portkey.HashicorpTokenAuthConfig? value)
        {
            HashicorpToken = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AuthConfig FromHashicorpToken(global::Portkey.HashicorpTokenAuthConfig? value) => new AuthConfig(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthConfig(global::Portkey.HashicorpAppRoleAuthConfig value) => new AuthConfig((global::Portkey.HashicorpAppRoleAuthConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.HashicorpAppRoleAuthConfig?(AuthConfig @this) => @this.HashicorpAppRole;

        /// <summary>
        /// 
        /// </summary>
        public AuthConfig(global::Portkey.HashicorpAppRoleAuthConfig? value)
        {
            HashicorpAppRole = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AuthConfig FromHashicorpAppRole(global::Portkey.HashicorpAppRoleAuthConfig? value) => new AuthConfig(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthConfig(global::Portkey.HashicorpKubernetesAuthConfig value) => new AuthConfig((global::Portkey.HashicorpKubernetesAuthConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.HashicorpKubernetesAuthConfig?(AuthConfig @this) => @this.HashicorpKubernetes;

        /// <summary>
        /// 
        /// </summary>
        public AuthConfig(global::Portkey.HashicorpKubernetesAuthConfig? value)
        {
            HashicorpKubernetes = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AuthConfig FromHashicorpKubernetes(global::Portkey.HashicorpKubernetesAuthConfig? value) => new AuthConfig(value);

        /// <summary>
        /// 
        /// </summary>
        public AuthConfig(
            global::Portkey.AwsAccessKeyAuthConfig? accessKey,
            global::Portkey.AwsAssumedRoleAuthConfig? assumedRole,
            global::Portkey.AwsServiceRoleAuthConfig? serviceRole,
            global::Portkey.AzureEntraAuthConfig? azureEntra,
            global::Portkey.AzureManagedAuthConfig? azureManaged,
            global::Portkey.AzureDefaultAuthConfig? azureDefault,
            global::Portkey.HashicorpTokenAuthConfig? hashicorpToken,
            global::Portkey.HashicorpAppRoleAuthConfig? hashicorpAppRole,
            global::Portkey.HashicorpKubernetesAuthConfig? hashicorpKubernetes
            )
        {
            AccessKey = accessKey;
            AssumedRole = assumedRole;
            ServiceRole = serviceRole;
            AzureEntra = azureEntra;
            AzureManaged = azureManaged;
            AzureDefault = azureDefault;
            HashicorpToken = hashicorpToken;
            HashicorpAppRole = hashicorpAppRole;
            HashicorpKubernetes = hashicorpKubernetes;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            HashicorpKubernetes as object ??
            HashicorpAppRole as object ??
            HashicorpToken as object ??
            AzureDefault as object ??
            AzureManaged as object ??
            AzureEntra as object ??
            ServiceRole as object ??
            AssumedRole as object ??
            AccessKey as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AccessKey?.ToString() ??
            AssumedRole?.ToString() ??
            ServiceRole?.ToString() ??
            AzureEntra?.ToString() ??
            AzureManaged?.ToString() ??
            AzureDefault?.ToString() ??
            HashicorpToken?.ToString() ??
            HashicorpAppRole?.ToString() ??
            HashicorpKubernetes?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAccessKey && !IsAssumedRole && !IsServiceRole && !IsAzureEntra && !IsAzureManaged && !IsAzureDefault && !IsHashicorpToken && !IsHashicorpAppRole && !IsHashicorpKubernetes || !IsAccessKey && IsAssumedRole && !IsServiceRole && !IsAzureEntra && !IsAzureManaged && !IsAzureDefault && !IsHashicorpToken && !IsHashicorpAppRole && !IsHashicorpKubernetes || !IsAccessKey && !IsAssumedRole && IsServiceRole && !IsAzureEntra && !IsAzureManaged && !IsAzureDefault && !IsHashicorpToken && !IsHashicorpAppRole && !IsHashicorpKubernetes || !IsAccessKey && !IsAssumedRole && !IsServiceRole && IsAzureEntra && !IsAzureManaged && !IsAzureDefault && !IsHashicorpToken && !IsHashicorpAppRole && !IsHashicorpKubernetes || !IsAccessKey && !IsAssumedRole && !IsServiceRole && !IsAzureEntra && IsAzureManaged && !IsAzureDefault && !IsHashicorpToken && !IsHashicorpAppRole && !IsHashicorpKubernetes || !IsAccessKey && !IsAssumedRole && !IsServiceRole && !IsAzureEntra && !IsAzureManaged && IsAzureDefault && !IsHashicorpToken && !IsHashicorpAppRole && !IsHashicorpKubernetes || !IsAccessKey && !IsAssumedRole && !IsServiceRole && !IsAzureEntra && !IsAzureManaged && !IsAzureDefault && IsHashicorpToken && !IsHashicorpAppRole && !IsHashicorpKubernetes || !IsAccessKey && !IsAssumedRole && !IsServiceRole && !IsAzureEntra && !IsAzureManaged && !IsAzureDefault && !IsHashicorpToken && IsHashicorpAppRole && !IsHashicorpKubernetes || !IsAccessKey && !IsAssumedRole && !IsServiceRole && !IsAzureEntra && !IsAzureManaged && !IsAzureDefault && !IsHashicorpToken && !IsHashicorpAppRole && IsHashicorpKubernetes;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Portkey.AwsAccessKeyAuthConfig, TResult>? accessKey = null,
            global::System.Func<global::Portkey.AwsAssumedRoleAuthConfig, TResult>? assumedRole = null,
            global::System.Func<global::Portkey.AwsServiceRoleAuthConfig, TResult>? serviceRole = null,
            global::System.Func<global::Portkey.AzureEntraAuthConfig, TResult>? azureEntra = null,
            global::System.Func<global::Portkey.AzureManagedAuthConfig, TResult>? azureManaged = null,
            global::System.Func<global::Portkey.AzureDefaultAuthConfig, TResult>? azureDefault = null,
            global::System.Func<global::Portkey.HashicorpTokenAuthConfig, TResult>? hashicorpToken = null,
            global::System.Func<global::Portkey.HashicorpAppRoleAuthConfig, TResult>? hashicorpAppRole = null,
            global::System.Func<global::Portkey.HashicorpKubernetesAuthConfig, TResult>? hashicorpKubernetes = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAccessKey && accessKey != null)
            {
                return accessKey(AccessKey!);
            }
            else if (IsAssumedRole && assumedRole != null)
            {
                return assumedRole(AssumedRole!);
            }
            else if (IsServiceRole && serviceRole != null)
            {
                return serviceRole(ServiceRole!);
            }
            else if (IsAzureEntra && azureEntra != null)
            {
                return azureEntra(AzureEntra!);
            }
            else if (IsAzureManaged && azureManaged != null)
            {
                return azureManaged(AzureManaged!);
            }
            else if (IsAzureDefault && azureDefault != null)
            {
                return azureDefault(AzureDefault!);
            }
            else if (IsHashicorpToken && hashicorpToken != null)
            {
                return hashicorpToken(HashicorpToken!);
            }
            else if (IsHashicorpAppRole && hashicorpAppRole != null)
            {
                return hashicorpAppRole(HashicorpAppRole!);
            }
            else if (IsHashicorpKubernetes && hashicorpKubernetes != null)
            {
                return hashicorpKubernetes(HashicorpKubernetes!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Portkey.AwsAccessKeyAuthConfig>? accessKey = null,

            global::System.Action<global::Portkey.AwsAssumedRoleAuthConfig>? assumedRole = null,

            global::System.Action<global::Portkey.AwsServiceRoleAuthConfig>? serviceRole = null,

            global::System.Action<global::Portkey.AzureEntraAuthConfig>? azureEntra = null,

            global::System.Action<global::Portkey.AzureManagedAuthConfig>? azureManaged = null,

            global::System.Action<global::Portkey.AzureDefaultAuthConfig>? azureDefault = null,

            global::System.Action<global::Portkey.HashicorpTokenAuthConfig>? hashicorpToken = null,

            global::System.Action<global::Portkey.HashicorpAppRoleAuthConfig>? hashicorpAppRole = null,

            global::System.Action<global::Portkey.HashicorpKubernetesAuthConfig>? hashicorpKubernetes = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAccessKey)
            {
                accessKey?.Invoke(AccessKey!);
            }
            else if (IsAssumedRole)
            {
                assumedRole?.Invoke(AssumedRole!);
            }
            else if (IsServiceRole)
            {
                serviceRole?.Invoke(ServiceRole!);
            }
            else if (IsAzureEntra)
            {
                azureEntra?.Invoke(AzureEntra!);
            }
            else if (IsAzureManaged)
            {
                azureManaged?.Invoke(AzureManaged!);
            }
            else if (IsAzureDefault)
            {
                azureDefault?.Invoke(AzureDefault!);
            }
            else if (IsHashicorpToken)
            {
                hashicorpToken?.Invoke(HashicorpToken!);
            }
            else if (IsHashicorpAppRole)
            {
                hashicorpAppRole?.Invoke(HashicorpAppRole!);
            }
            else if (IsHashicorpKubernetes)
            {
                hashicorpKubernetes?.Invoke(HashicorpKubernetes!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Portkey.AwsAccessKeyAuthConfig>? accessKey = null,
            global::System.Action<global::Portkey.AwsAssumedRoleAuthConfig>? assumedRole = null,
            global::System.Action<global::Portkey.AwsServiceRoleAuthConfig>? serviceRole = null,
            global::System.Action<global::Portkey.AzureEntraAuthConfig>? azureEntra = null,
            global::System.Action<global::Portkey.AzureManagedAuthConfig>? azureManaged = null,
            global::System.Action<global::Portkey.AzureDefaultAuthConfig>? azureDefault = null,
            global::System.Action<global::Portkey.HashicorpTokenAuthConfig>? hashicorpToken = null,
            global::System.Action<global::Portkey.HashicorpAppRoleAuthConfig>? hashicorpAppRole = null,
            global::System.Action<global::Portkey.HashicorpKubernetesAuthConfig>? hashicorpKubernetes = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAccessKey)
            {
                accessKey?.Invoke(AccessKey!);
            }
            else if (IsAssumedRole)
            {
                assumedRole?.Invoke(AssumedRole!);
            }
            else if (IsServiceRole)
            {
                serviceRole?.Invoke(ServiceRole!);
            }
            else if (IsAzureEntra)
            {
                azureEntra?.Invoke(AzureEntra!);
            }
            else if (IsAzureManaged)
            {
                azureManaged?.Invoke(AzureManaged!);
            }
            else if (IsAzureDefault)
            {
                azureDefault?.Invoke(AzureDefault!);
            }
            else if (IsHashicorpToken)
            {
                hashicorpToken?.Invoke(HashicorpToken!);
            }
            else if (IsHashicorpAppRole)
            {
                hashicorpAppRole?.Invoke(HashicorpAppRole!);
            }
            else if (IsHashicorpKubernetes)
            {
                hashicorpKubernetes?.Invoke(HashicorpKubernetes!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AccessKey,
                typeof(global::Portkey.AwsAccessKeyAuthConfig),
                AssumedRole,
                typeof(global::Portkey.AwsAssumedRoleAuthConfig),
                ServiceRole,
                typeof(global::Portkey.AwsServiceRoleAuthConfig),
                AzureEntra,
                typeof(global::Portkey.AzureEntraAuthConfig),
                AzureManaged,
                typeof(global::Portkey.AzureManagedAuthConfig),
                AzureDefault,
                typeof(global::Portkey.AzureDefaultAuthConfig),
                HashicorpToken,
                typeof(global::Portkey.HashicorpTokenAuthConfig),
                HashicorpAppRole,
                typeof(global::Portkey.HashicorpAppRoleAuthConfig),
                HashicorpKubernetes,
                typeof(global::Portkey.HashicorpKubernetesAuthConfig),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(AuthConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Portkey.AwsAccessKeyAuthConfig?>.Default.Equals(AccessKey, other.AccessKey) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.AwsAssumedRoleAuthConfig?>.Default.Equals(AssumedRole, other.AssumedRole) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.AwsServiceRoleAuthConfig?>.Default.Equals(ServiceRole, other.ServiceRole) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.AzureEntraAuthConfig?>.Default.Equals(AzureEntra, other.AzureEntra) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.AzureManagedAuthConfig?>.Default.Equals(AzureManaged, other.AzureManaged) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.AzureDefaultAuthConfig?>.Default.Equals(AzureDefault, other.AzureDefault) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.HashicorpTokenAuthConfig?>.Default.Equals(HashicorpToken, other.HashicorpToken) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.HashicorpAppRoleAuthConfig?>.Default.Equals(HashicorpAppRole, other.HashicorpAppRole) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.HashicorpKubernetesAuthConfig?>.Default.Equals(HashicorpKubernetes, other.HashicorpKubernetes) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AuthConfig obj1, AuthConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AuthConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AuthConfig obj1, AuthConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AuthConfig o && Equals(o);
        }
    }
}
