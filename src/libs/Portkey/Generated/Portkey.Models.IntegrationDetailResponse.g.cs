#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IntegrationDetailResponse : global::System.IEquatable<IntegrationDetailResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.IntegrationList? Value1 { get; init; }
#else
        public global::Portkey.IntegrationList? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.IntegrationDetailResponseVariant2? Value2 { get; init; }
#else
        public global::Portkey.IntegrationDetailResponseVariant2? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IntegrationDetailResponse(global::Portkey.IntegrationList value) => new IntegrationDetailResponse((global::Portkey.IntegrationList?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.IntegrationList?(IntegrationDetailResponse @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public IntegrationDetailResponse(global::Portkey.IntegrationList? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IntegrationDetailResponse(global::Portkey.IntegrationDetailResponseVariant2 value) => new IntegrationDetailResponse((global::Portkey.IntegrationDetailResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.IntegrationDetailResponseVariant2?(IntegrationDetailResponse @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public IntegrationDetailResponse(global::Portkey.IntegrationDetailResponseVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public IntegrationDetailResponse(
            global::Portkey.IntegrationList? value1,
            global::Portkey.IntegrationDetailResponseVariant2? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Portkey.IntegrationList?, TResult>? value1 = null,
            global::System.Func<global::Portkey.IntegrationDetailResponseVariant2?, TResult>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Portkey.IntegrationList?>? value1 = null,
            global::System.Action<global::Portkey.IntegrationDetailResponseVariant2?>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::Portkey.IntegrationList),
                Value2,
                typeof(global::Portkey.IntegrationDetailResponseVariant2),
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
        public bool Equals(IntegrationDetailResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Portkey.IntegrationList?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.IntegrationDetailResponseVariant2?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IntegrationDetailResponse obj1, IntegrationDetailResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IntegrationDetailResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IntegrationDetailResponse obj1, IntegrationDetailResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IntegrationDetailResponse o && Equals(o);
        }
    }
}
