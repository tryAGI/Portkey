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
        public global::Portkey.IntegrationList? List { get; init; }
#else
        public global::Portkey.IntegrationList? List { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(List))]
#endif
        public bool IsList => List != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickList(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.IntegrationList? value)
        {
            value = List;
            return IsList;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.IntegrationList PickList() => IsList
            ? List!
            : throw new global::System.InvalidOperationException($"Expected union variant 'List' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.IntegrationDetailResponseVariant2? IntegrationDetailResponseVariant2 { get; init; }
#else
        public global::Portkey.IntegrationDetailResponseVariant2? IntegrationDetailResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IntegrationDetailResponseVariant2))]
#endif
        public bool IsIntegrationDetailResponseVariant2 => IntegrationDetailResponseVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickIntegrationDetailResponseVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.IntegrationDetailResponseVariant2? value)
        {
            value = IntegrationDetailResponseVariant2;
            return IsIntegrationDetailResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.IntegrationDetailResponseVariant2 PickIntegrationDetailResponseVariant2() => IsIntegrationDetailResponseVariant2
            ? IntegrationDetailResponseVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'IntegrationDetailResponseVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IntegrationDetailResponse(global::Portkey.IntegrationList value) => new IntegrationDetailResponse((global::Portkey.IntegrationList?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.IntegrationList?(IntegrationDetailResponse @this) => @this.List;

        /// <summary>
        /// 
        /// </summary>
        public IntegrationDetailResponse(global::Portkey.IntegrationList? value)
        {
            List = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IntegrationDetailResponse FromList(global::Portkey.IntegrationList? value) => new IntegrationDetailResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IntegrationDetailResponse(global::Portkey.IntegrationDetailResponseVariant2 value) => new IntegrationDetailResponse((global::Portkey.IntegrationDetailResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.IntegrationDetailResponseVariant2?(IntegrationDetailResponse @this) => @this.IntegrationDetailResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public IntegrationDetailResponse(global::Portkey.IntegrationDetailResponseVariant2? value)
        {
            IntegrationDetailResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IntegrationDetailResponse FromIntegrationDetailResponseVariant2(global::Portkey.IntegrationDetailResponseVariant2? value) => new IntegrationDetailResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public IntegrationDetailResponse(
            global::Portkey.IntegrationList? list,
            global::Portkey.IntegrationDetailResponseVariant2? integrationDetailResponseVariant2
            )
        {
            List = list;
            IntegrationDetailResponseVariant2 = integrationDetailResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            IntegrationDetailResponseVariant2 as object ??
            List as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            List?.ToString() ??
            IntegrationDetailResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsList && IsIntegrationDetailResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Portkey.IntegrationList, TResult>? list = null,
            global::System.Func<global::Portkey.IntegrationDetailResponseVariant2, TResult>? integrationDetailResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsList && list != null)
            {
                return list(List!);
            }
            else if (IsIntegrationDetailResponseVariant2 && integrationDetailResponseVariant2 != null)
            {
                return integrationDetailResponseVariant2(IntegrationDetailResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Portkey.IntegrationList>? list = null,

            global::System.Action<global::Portkey.IntegrationDetailResponseVariant2>? integrationDetailResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsList)
            {
                list?.Invoke(List!);
            }
            else if (IsIntegrationDetailResponseVariant2)
            {
                integrationDetailResponseVariant2?.Invoke(IntegrationDetailResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Portkey.IntegrationList>? list = null,
            global::System.Action<global::Portkey.IntegrationDetailResponseVariant2>? integrationDetailResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsList)
            {
                list?.Invoke(List!);
            }
            else if (IsIntegrationDetailResponseVariant2)
            {
                integrationDetailResponseVariant2?.Invoke(IntegrationDetailResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                List,
                typeof(global::Portkey.IntegrationList),
                IntegrationDetailResponseVariant2,
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
                global::System.Collections.Generic.EqualityComparer<global::Portkey.IntegrationList?>.Default.Equals(List, other.List) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.IntegrationDetailResponseVariant2?>.Default.Equals(IntegrationDetailResponseVariant2, other.IntegrationDetailResponseVariant2) 
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
