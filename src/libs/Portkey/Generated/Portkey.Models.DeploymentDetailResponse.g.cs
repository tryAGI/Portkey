#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DeploymentDetailResponse : global::System.IEquatable<DeploymentDetailResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.DeploymentListItem? ListItem { get; init; }
#else
        public global::Portkey.DeploymentListItem? ListItem { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListItem))]
#endif
        public bool IsListItem => ListItem != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickListItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.DeploymentListItem? value)
        {
            value = ListItem;
            return IsListItem;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeploymentListItem PickListItem() => IsListItem
            ? ListItem!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ListItem' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.DeploymentDetailResponseVariant2? DeploymentDetailResponseVariant2 { get; init; }
#else
        public global::Portkey.DeploymentDetailResponseVariant2? DeploymentDetailResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeploymentDetailResponseVariant2))]
#endif
        public bool IsDeploymentDetailResponseVariant2 => DeploymentDetailResponseVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDeploymentDetailResponseVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.DeploymentDetailResponseVariant2? value)
        {
            value = DeploymentDetailResponseVariant2;
            return IsDeploymentDetailResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.DeploymentDetailResponseVariant2 PickDeploymentDetailResponseVariant2() => IsDeploymentDetailResponseVariant2
            ? DeploymentDetailResponseVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DeploymentDetailResponseVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DeploymentDetailResponse(global::Portkey.DeploymentListItem value) => new DeploymentDetailResponse((global::Portkey.DeploymentListItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.DeploymentListItem?(DeploymentDetailResponse @this) => @this.ListItem;

        /// <summary>
        /// 
        /// </summary>
        public DeploymentDetailResponse(global::Portkey.DeploymentListItem? value)
        {
            ListItem = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DeploymentDetailResponse FromListItem(global::Portkey.DeploymentListItem? value) => new DeploymentDetailResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DeploymentDetailResponse(global::Portkey.DeploymentDetailResponseVariant2 value) => new DeploymentDetailResponse((global::Portkey.DeploymentDetailResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.DeploymentDetailResponseVariant2?(DeploymentDetailResponse @this) => @this.DeploymentDetailResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public DeploymentDetailResponse(global::Portkey.DeploymentDetailResponseVariant2? value)
        {
            DeploymentDetailResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DeploymentDetailResponse FromDeploymentDetailResponseVariant2(global::Portkey.DeploymentDetailResponseVariant2? value) => new DeploymentDetailResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public DeploymentDetailResponse(
            global::Portkey.DeploymentListItem? listItem,
            global::Portkey.DeploymentDetailResponseVariant2? deploymentDetailResponseVariant2
            )
        {
            ListItem = listItem;
            DeploymentDetailResponseVariant2 = deploymentDetailResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DeploymentDetailResponseVariant2 as object ??
            ListItem as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ListItem?.ToString() ??
            DeploymentDetailResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsListItem && IsDeploymentDetailResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Portkey.DeploymentListItem, TResult>? listItem = null,
            global::System.Func<global::Portkey.DeploymentDetailResponseVariant2, TResult>? deploymentDetailResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsListItem && listItem != null)
            {
                return listItem(ListItem!);
            }
            else if (IsDeploymentDetailResponseVariant2 && deploymentDetailResponseVariant2 != null)
            {
                return deploymentDetailResponseVariant2(DeploymentDetailResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Portkey.DeploymentListItem>? listItem = null,

            global::System.Action<global::Portkey.DeploymentDetailResponseVariant2>? deploymentDetailResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsListItem)
            {
                listItem?.Invoke(ListItem!);
            }
            else if (IsDeploymentDetailResponseVariant2)
            {
                deploymentDetailResponseVariant2?.Invoke(DeploymentDetailResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Portkey.DeploymentListItem>? listItem = null,
            global::System.Action<global::Portkey.DeploymentDetailResponseVariant2>? deploymentDetailResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsListItem)
            {
                listItem?.Invoke(ListItem!);
            }
            else if (IsDeploymentDetailResponseVariant2)
            {
                deploymentDetailResponseVariant2?.Invoke(DeploymentDetailResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ListItem,
                typeof(global::Portkey.DeploymentListItem),
                DeploymentDetailResponseVariant2,
                typeof(global::Portkey.DeploymentDetailResponseVariant2),
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
        public bool Equals(DeploymentDetailResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Portkey.DeploymentListItem?>.Default.Equals(ListItem, other.ListItem) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.DeploymentDetailResponseVariant2?>.Default.Equals(DeploymentDetailResponseVariant2, other.DeploymentDetailResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DeploymentDetailResponse obj1, DeploymentDetailResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DeploymentDetailResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DeploymentDetailResponse obj1, DeploymentDetailResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DeploymentDetailResponse o && Equals(o);
        }
    }
}
