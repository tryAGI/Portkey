#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AccessPolicyTarget : global::System.IEquatable<AccessPolicyTarget>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicyTargetDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.AccessPolicyMcpServerTarget? McpServer { get; init; }
#else
        public global::Portkey.AccessPolicyMcpServerTarget? McpServer { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpServer))]
#endif
        public bool IsMcpServer => McpServer != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMcpServer(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.AccessPolicyMcpServerTarget? value)
        {
            value = McpServer;
            return IsMcpServer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicyMcpServerTarget PickMcpServer() => McpServer is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpServer' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.AccessPolicyProviderTarget? Provider { get; init; }
#else
        public global::Portkey.AccessPolicyProviderTarget? Provider { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Provider))]
#endif
        public bool IsProvider => Provider != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickProvider(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.AccessPolicyProviderTarget? value)
        {
            value = Provider;
            return IsProvider;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AccessPolicyProviderTarget PickProvider() => Provider is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Provider' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AccessPolicyTarget(global::Portkey.AccessPolicyMcpServerTarget value) => new AccessPolicyTarget((global::Portkey.AccessPolicyMcpServerTarget?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Portkey.AccessPolicyMcpServerTarget?(AccessPolicyTarget @this) => @this.McpServer;

        /// <summary>
        ///
        /// </summary>
        public AccessPolicyTarget(global::Portkey.AccessPolicyMcpServerTarget? value)
        {
            McpServer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AccessPolicyTarget FromMcpServer(global::Portkey.AccessPolicyMcpServerTarget? value) => new AccessPolicyTarget(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AccessPolicyTarget(global::Portkey.AccessPolicyProviderTarget value) => new AccessPolicyTarget((global::Portkey.AccessPolicyProviderTarget?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Portkey.AccessPolicyProviderTarget?(AccessPolicyTarget @this) => @this.Provider;

        /// <summary>
        ///
        /// </summary>
        public AccessPolicyTarget(global::Portkey.AccessPolicyProviderTarget? value)
        {
            Provider = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AccessPolicyTarget FromProvider(global::Portkey.AccessPolicyProviderTarget? value) => new AccessPolicyTarget(value);

        /// <summary>
        ///
        /// </summary>
        public AccessPolicyTarget(
            global::Portkey.AccessPolicyTargetDiscriminatorType? type,
            global::Portkey.AccessPolicyMcpServerTarget? mcpServer,
            global::Portkey.AccessPolicyProviderTarget? provider
            )
        {
            Type = type;

            McpServer = mcpServer;
            Provider = provider;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Provider as object ??
            McpServer as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            McpServer?.ToString() ??
            Provider?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsMcpServer && !IsProvider || !IsMcpServer && IsProvider;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Portkey.AccessPolicyMcpServerTarget, TResult>? mcpServer = null,
            global::System.Func<global::Portkey.AccessPolicyProviderTarget, TResult>? provider = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (McpServer is { } __value0 && mcpServer != null)
            {
                return mcpServer(__value0);
            }
            else if (Provider is { } __value1 && provider != null)
            {
                return provider(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Portkey.AccessPolicyMcpServerTarget>? mcpServer = null,

            global::System.Action<global::Portkey.AccessPolicyProviderTarget>? provider = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (McpServer is { } __value0)
            {
                mcpServer?.Invoke(__value0);
            }
            else if (Provider is { } __value1)
            {
                provider?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Portkey.AccessPolicyMcpServerTarget>? mcpServer = null,
            global::System.Action<global::Portkey.AccessPolicyProviderTarget>? provider = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (McpServer is { } __value0)
            {
                mcpServer?.Invoke(__value0);
            }
            else if (Provider is { } __value1)
            {
                provider?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                McpServer,
                typeof(global::Portkey.AccessPolicyMcpServerTarget),
                Provider,
                typeof(global::Portkey.AccessPolicyProviderTarget),
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
        public bool Equals(AccessPolicyTarget other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Portkey.AccessPolicyMcpServerTarget?>.Default.Equals(McpServer, other.McpServer) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.AccessPolicyProviderTarget?>.Default.Equals(Provider, other.Provider)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AccessPolicyTarget obj1, AccessPolicyTarget obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AccessPolicyTarget>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AccessPolicyTarget obj1, AccessPolicyTarget obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AccessPolicyTarget o && Equals(o);
        }
    }
}
