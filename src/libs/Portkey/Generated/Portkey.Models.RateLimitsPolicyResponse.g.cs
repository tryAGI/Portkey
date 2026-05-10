#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RateLimitsPolicyResponse : global::System.IEquatable<RateLimitsPolicyResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.RateLimitsPolicy? RateLimitsPolicy { get; init; }
#else
        public global::Portkey.RateLimitsPolicy? RateLimitsPolicy { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RateLimitsPolicy))]
#endif
        public bool IsRateLimitsPolicy => RateLimitsPolicy != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRateLimitsPolicy(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.RateLimitsPolicy? value)
        {
            value = RateLimitsPolicy;
            return IsRateLimitsPolicy;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimitsPolicy PickRateLimitsPolicy() => IsRateLimitsPolicy
            ? RateLimitsPolicy!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RateLimitsPolicy' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.RateLimitsPolicyResponseVariant2? RateLimitsPolicyResponseVariant2 { get; init; }
#else
        public global::Portkey.RateLimitsPolicyResponseVariant2? RateLimitsPolicyResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RateLimitsPolicyResponseVariant2))]
#endif
        public bool IsRateLimitsPolicyResponseVariant2 => RateLimitsPolicyResponseVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRateLimitsPolicyResponseVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.RateLimitsPolicyResponseVariant2? value)
        {
            value = RateLimitsPolicyResponseVariant2;
            return IsRateLimitsPolicyResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RateLimitsPolicyResponseVariant2 PickRateLimitsPolicyResponseVariant2() => IsRateLimitsPolicyResponseVariant2
            ? RateLimitsPolicyResponseVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RateLimitsPolicyResponseVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RateLimitsPolicyResponse(global::Portkey.RateLimitsPolicy value) => new RateLimitsPolicyResponse((global::Portkey.RateLimitsPolicy?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.RateLimitsPolicy?(RateLimitsPolicyResponse @this) => @this.RateLimitsPolicy;

        /// <summary>
        /// 
        /// </summary>
        public RateLimitsPolicyResponse(global::Portkey.RateLimitsPolicy? value)
        {
            RateLimitsPolicy = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RateLimitsPolicyResponse FromRateLimitsPolicy(global::Portkey.RateLimitsPolicy? value) => new RateLimitsPolicyResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RateLimitsPolicyResponse(global::Portkey.RateLimitsPolicyResponseVariant2 value) => new RateLimitsPolicyResponse((global::Portkey.RateLimitsPolicyResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.RateLimitsPolicyResponseVariant2?(RateLimitsPolicyResponse @this) => @this.RateLimitsPolicyResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public RateLimitsPolicyResponse(global::Portkey.RateLimitsPolicyResponseVariant2? value)
        {
            RateLimitsPolicyResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RateLimitsPolicyResponse FromRateLimitsPolicyResponseVariant2(global::Portkey.RateLimitsPolicyResponseVariant2? value) => new RateLimitsPolicyResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public RateLimitsPolicyResponse(
            global::Portkey.RateLimitsPolicy? rateLimitsPolicy,
            global::Portkey.RateLimitsPolicyResponseVariant2? rateLimitsPolicyResponseVariant2
            )
        {
            RateLimitsPolicy = rateLimitsPolicy;
            RateLimitsPolicyResponseVariant2 = rateLimitsPolicyResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RateLimitsPolicyResponseVariant2 as object ??
            RateLimitsPolicy as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            RateLimitsPolicy?.ToString() ??
            RateLimitsPolicyResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRateLimitsPolicy && IsRateLimitsPolicyResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Portkey.RateLimitsPolicy, TResult>? rateLimitsPolicy = null,
            global::System.Func<global::Portkey.RateLimitsPolicyResponseVariant2, TResult>? rateLimitsPolicyResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRateLimitsPolicy && rateLimitsPolicy != null)
            {
                return rateLimitsPolicy(RateLimitsPolicy!);
            }
            else if (IsRateLimitsPolicyResponseVariant2 && rateLimitsPolicyResponseVariant2 != null)
            {
                return rateLimitsPolicyResponseVariant2(RateLimitsPolicyResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Portkey.RateLimitsPolicy>? rateLimitsPolicy = null,

            global::System.Action<global::Portkey.RateLimitsPolicyResponseVariant2>? rateLimitsPolicyResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRateLimitsPolicy)
            {
                rateLimitsPolicy?.Invoke(RateLimitsPolicy!);
            }
            else if (IsRateLimitsPolicyResponseVariant2)
            {
                rateLimitsPolicyResponseVariant2?.Invoke(RateLimitsPolicyResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Portkey.RateLimitsPolicy>? rateLimitsPolicy = null,
            global::System.Action<global::Portkey.RateLimitsPolicyResponseVariant2>? rateLimitsPolicyResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRateLimitsPolicy)
            {
                rateLimitsPolicy?.Invoke(RateLimitsPolicy!);
            }
            else if (IsRateLimitsPolicyResponseVariant2)
            {
                rateLimitsPolicyResponseVariant2?.Invoke(RateLimitsPolicyResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RateLimitsPolicy,
                typeof(global::Portkey.RateLimitsPolicy),
                RateLimitsPolicyResponseVariant2,
                typeof(global::Portkey.RateLimitsPolicyResponseVariant2),
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
        public bool Equals(RateLimitsPolicyResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Portkey.RateLimitsPolicy?>.Default.Equals(RateLimitsPolicy, other.RateLimitsPolicy) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.RateLimitsPolicyResponseVariant2?>.Default.Equals(RateLimitsPolicyResponseVariant2, other.RateLimitsPolicyResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RateLimitsPolicyResponse obj1, RateLimitsPolicyResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RateLimitsPolicyResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RateLimitsPolicyResponse obj1, RateLimitsPolicyResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RateLimitsPolicyResponse o && Equals(o);
        }
    }
}
