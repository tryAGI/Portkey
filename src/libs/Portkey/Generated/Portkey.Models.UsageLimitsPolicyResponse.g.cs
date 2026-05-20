#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct UsageLimitsPolicyResponse : global::System.IEquatable<UsageLimitsPolicyResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.UsageLimitsPolicy? UsageLimitsPolicy { get; init; }
#else
        public global::Portkey.UsageLimitsPolicy? UsageLimitsPolicy { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UsageLimitsPolicy))]
#endif
        public bool IsUsageLimitsPolicy => UsageLimitsPolicy != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUsageLimitsPolicy(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.UsageLimitsPolicy? value)
        {
            value = UsageLimitsPolicy;
            return IsUsageLimitsPolicy;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicy PickUsageLimitsPolicy() => IsUsageLimitsPolicy
            ? UsageLimitsPolicy!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UsageLimitsPolicy' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.UsageLimitsPolicyResponseVariant2? UsageLimitsPolicyResponseVariant2 { get; init; }
#else
        public global::Portkey.UsageLimitsPolicyResponseVariant2? UsageLimitsPolicyResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UsageLimitsPolicyResponseVariant2))]
#endif
        public bool IsUsageLimitsPolicyResponseVariant2 => UsageLimitsPolicyResponseVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUsageLimitsPolicyResponseVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.UsageLimitsPolicyResponseVariant2? value)
        {
            value = UsageLimitsPolicyResponseVariant2;
            return IsUsageLimitsPolicyResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.UsageLimitsPolicyResponseVariant2 PickUsageLimitsPolicyResponseVariant2() => IsUsageLimitsPolicyResponseVariant2
            ? UsageLimitsPolicyResponseVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UsageLimitsPolicyResponseVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UsageLimitsPolicyResponse(global::Portkey.UsageLimitsPolicy value) => new UsageLimitsPolicyResponse((global::Portkey.UsageLimitsPolicy?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.UsageLimitsPolicy?(UsageLimitsPolicyResponse @this) => @this.UsageLimitsPolicy;

        /// <summary>
        /// 
        /// </summary>
        public UsageLimitsPolicyResponse(global::Portkey.UsageLimitsPolicy? value)
        {
            UsageLimitsPolicy = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UsageLimitsPolicyResponse FromUsageLimitsPolicy(global::Portkey.UsageLimitsPolicy? value) => new UsageLimitsPolicyResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UsageLimitsPolicyResponse(global::Portkey.UsageLimitsPolicyResponseVariant2 value) => new UsageLimitsPolicyResponse((global::Portkey.UsageLimitsPolicyResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.UsageLimitsPolicyResponseVariant2?(UsageLimitsPolicyResponse @this) => @this.UsageLimitsPolicyResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public UsageLimitsPolicyResponse(global::Portkey.UsageLimitsPolicyResponseVariant2? value)
        {
            UsageLimitsPolicyResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UsageLimitsPolicyResponse FromUsageLimitsPolicyResponseVariant2(global::Portkey.UsageLimitsPolicyResponseVariant2? value) => new UsageLimitsPolicyResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public UsageLimitsPolicyResponse(
            global::Portkey.UsageLimitsPolicy? usageLimitsPolicy,
            global::Portkey.UsageLimitsPolicyResponseVariant2? usageLimitsPolicyResponseVariant2
            )
        {
            UsageLimitsPolicy = usageLimitsPolicy;
            UsageLimitsPolicyResponseVariant2 = usageLimitsPolicyResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UsageLimitsPolicyResponseVariant2 as object ??
            UsageLimitsPolicy as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            UsageLimitsPolicy?.ToString() ??
            UsageLimitsPolicyResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUsageLimitsPolicy && IsUsageLimitsPolicyResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Portkey.UsageLimitsPolicy, TResult>? usageLimitsPolicy = null,
            global::System.Func<global::Portkey.UsageLimitsPolicyResponseVariant2, TResult>? usageLimitsPolicyResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUsageLimitsPolicy && usageLimitsPolicy != null)
            {
                return usageLimitsPolicy(UsageLimitsPolicy!);
            }
            else if (IsUsageLimitsPolicyResponseVariant2 && usageLimitsPolicyResponseVariant2 != null)
            {
                return usageLimitsPolicyResponseVariant2(UsageLimitsPolicyResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Portkey.UsageLimitsPolicy>? usageLimitsPolicy = null,

            global::System.Action<global::Portkey.UsageLimitsPolicyResponseVariant2>? usageLimitsPolicyResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUsageLimitsPolicy)
            {
                usageLimitsPolicy?.Invoke(UsageLimitsPolicy!);
            }
            else if (IsUsageLimitsPolicyResponseVariant2)
            {
                usageLimitsPolicyResponseVariant2?.Invoke(UsageLimitsPolicyResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Portkey.UsageLimitsPolicy>? usageLimitsPolicy = null,
            global::System.Action<global::Portkey.UsageLimitsPolicyResponseVariant2>? usageLimitsPolicyResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUsageLimitsPolicy)
            {
                usageLimitsPolicy?.Invoke(UsageLimitsPolicy!);
            }
            else if (IsUsageLimitsPolicyResponseVariant2)
            {
                usageLimitsPolicyResponseVariant2?.Invoke(UsageLimitsPolicyResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UsageLimitsPolicy,
                typeof(global::Portkey.UsageLimitsPolicy),
                UsageLimitsPolicyResponseVariant2,
                typeof(global::Portkey.UsageLimitsPolicyResponseVariant2),
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
        public bool Equals(UsageLimitsPolicyResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Portkey.UsageLimitsPolicy?>.Default.Equals(UsageLimitsPolicy, other.UsageLimitsPolicy) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.UsageLimitsPolicyResponseVariant2?>.Default.Equals(UsageLimitsPolicyResponseVariant2, other.UsageLimitsPolicyResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UsageLimitsPolicyResponse obj1, UsageLimitsPolicyResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UsageLimitsPolicyResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UsageLimitsPolicyResponse obj1, UsageLimitsPolicyResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UsageLimitsPolicyResponse o && Equals(o);
        }
    }
}
