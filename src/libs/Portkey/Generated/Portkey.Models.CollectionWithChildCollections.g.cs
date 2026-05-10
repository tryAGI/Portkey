#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CollectionWithChildCollections : global::System.IEquatable<CollectionWithChildCollections>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.Collection? Collection { get; init; }
#else
        public global::Portkey.Collection? Collection { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Collection))]
#endif
        public bool IsCollection => Collection != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCollection(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.Collection? value)
        {
            value = Collection;
            return IsCollection;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.CollectionWithChildCollectionsVariant2? CollectionWithChildCollectionsVariant2 { get; init; }
#else
        public global::Portkey.CollectionWithChildCollectionsVariant2? CollectionWithChildCollectionsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CollectionWithChildCollectionsVariant2))]
#endif
        public bool IsCollectionWithChildCollectionsVariant2 => CollectionWithChildCollectionsVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCollectionWithChildCollectionsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.CollectionWithChildCollectionsVariant2? value)
        {
            value = CollectionWithChildCollectionsVariant2;
            return IsCollectionWithChildCollectionsVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CollectionWithChildCollections(global::Portkey.Collection value) => new CollectionWithChildCollections((global::Portkey.Collection?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.Collection?(CollectionWithChildCollections @this) => @this.Collection;

        /// <summary>
        /// 
        /// </summary>
        public CollectionWithChildCollections(global::Portkey.Collection? value)
        {
            Collection = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CollectionWithChildCollections FromCollection(global::Portkey.Collection? value) => new CollectionWithChildCollections(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CollectionWithChildCollections(global::Portkey.CollectionWithChildCollectionsVariant2 value) => new CollectionWithChildCollections((global::Portkey.CollectionWithChildCollectionsVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.CollectionWithChildCollectionsVariant2?(CollectionWithChildCollections @this) => @this.CollectionWithChildCollectionsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CollectionWithChildCollections(global::Portkey.CollectionWithChildCollectionsVariant2? value)
        {
            CollectionWithChildCollectionsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CollectionWithChildCollections FromCollectionWithChildCollectionsVariant2(global::Portkey.CollectionWithChildCollectionsVariant2? value) => new CollectionWithChildCollections(value);

        /// <summary>
        /// 
        /// </summary>
        public CollectionWithChildCollections(
            global::Portkey.Collection? collection,
            global::Portkey.CollectionWithChildCollectionsVariant2? collectionWithChildCollectionsVariant2
            )
        {
            Collection = collection;
            CollectionWithChildCollectionsVariant2 = collectionWithChildCollectionsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CollectionWithChildCollectionsVariant2 as object ??
            Collection as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Collection?.ToString() ??
            CollectionWithChildCollectionsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCollection && IsCollectionWithChildCollectionsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Portkey.Collection, TResult>? collection = null,
            global::System.Func<global::Portkey.CollectionWithChildCollectionsVariant2, TResult>? collectionWithChildCollectionsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCollection && collection != null)
            {
                return collection(Collection!);
            }
            else if (IsCollectionWithChildCollectionsVariant2 && collectionWithChildCollectionsVariant2 != null)
            {
                return collectionWithChildCollectionsVariant2(CollectionWithChildCollectionsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Portkey.Collection>? collection = null,

            global::System.Action<global::Portkey.CollectionWithChildCollectionsVariant2>? collectionWithChildCollectionsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCollection)
            {
                collection?.Invoke(Collection!);
            }
            else if (IsCollectionWithChildCollectionsVariant2)
            {
                collectionWithChildCollectionsVariant2?.Invoke(CollectionWithChildCollectionsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Portkey.Collection>? collection = null,
            global::System.Action<global::Portkey.CollectionWithChildCollectionsVariant2>? collectionWithChildCollectionsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCollection)
            {
                collection?.Invoke(Collection!);
            }
            else if (IsCollectionWithChildCollectionsVariant2)
            {
                collectionWithChildCollectionsVariant2?.Invoke(CollectionWithChildCollectionsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Collection,
                typeof(global::Portkey.Collection),
                CollectionWithChildCollectionsVariant2,
                typeof(global::Portkey.CollectionWithChildCollectionsVariant2),
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
        public bool Equals(CollectionWithChildCollections other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Portkey.Collection?>.Default.Equals(Collection, other.Collection) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.CollectionWithChildCollectionsVariant2?>.Default.Equals(CollectionWithChildCollectionsVariant2, other.CollectionWithChildCollectionsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CollectionWithChildCollections obj1, CollectionWithChildCollections obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CollectionWithChildCollections>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CollectionWithChildCollections obj1, CollectionWithChildCollections obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CollectionWithChildCollections o && Equals(o);
        }
    }
}
