#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Portkey
{
    /// <summary>
    /// A document to be reranked. Can be a simple string or an object with a text field and optional metadata.
    /// </summary>
    public readonly partial struct RerankDocument : global::System.IEquatable<RerankDocument>
    {
        /// <summary>
        /// A simple text string to be reranked.<br/>
        /// Example: Paris is the capital of France.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? String { get; init; }
#else
        public string? String { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(String))]
#endif
        public bool IsString => String != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickString(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = String;
            return IsString;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickString() => IsString
            ? String!
            : throw new global::System.InvalidOperationException($"Expected union variant 'String' but the value was {ToString()}.");

        /// <summary>
        /// An object containing the document text and optional metadata.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.RerankDocumentObject? ObjectValue { get; init; }
#else
        public global::Portkey.RerankDocumentObject? ObjectValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ObjectValue))]
#endif
        public bool IsObjectValue => ObjectValue != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickObjectValue(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.RerankDocumentObject? value)
        {
            value = ObjectValue;
            return IsObjectValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Portkey.RerankDocumentObject PickObjectValue() => IsObjectValue
            ? ObjectValue!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ObjectValue' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RerankDocument(string value) => new RerankDocument((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(RerankDocument @this) => @this.String;

        /// <summary>
        /// 
        /// </summary>
        public RerankDocument(string? value)
        {
            String = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RerankDocument FromString(string? value) => new RerankDocument(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RerankDocument(global::Portkey.RerankDocumentObject value) => new RerankDocument((global::Portkey.RerankDocumentObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.RerankDocumentObject?(RerankDocument @this) => @this.ObjectValue;

        /// <summary>
        /// 
        /// </summary>
        public RerankDocument(global::Portkey.RerankDocumentObject? value)
        {
            ObjectValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RerankDocument FromObjectValue(global::Portkey.RerankDocumentObject? value) => new RerankDocument(value);

        /// <summary>
        /// 
        /// </summary>
        public RerankDocument(
            string? @string,
            global::Portkey.RerankDocumentObject? objectValue
            )
        {
            String = @string;
            ObjectValue = objectValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ObjectValue as object ??
            String as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            String?.ToString() ??
            ObjectValue?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsString && !IsObjectValue || !IsString && IsObjectValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? @string = null,
            global::System.Func<global::Portkey.RerankDocumentObject, TResult>? objectValue = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsString && @string != null)
            {
                return @string(String!);
            }
            else if (IsObjectValue && objectValue != null)
            {
                return objectValue(ObjectValue!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? @string = null,

            global::System.Action<global::Portkey.RerankDocumentObject>? objectValue = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsString)
            {
                @string?.Invoke(String!);
            }
            else if (IsObjectValue)
            {
                objectValue?.Invoke(ObjectValue!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? @string = null,
            global::System.Action<global::Portkey.RerankDocumentObject>? objectValue = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsString)
            {
                @string?.Invoke(String!);
            }
            else if (IsObjectValue)
            {
                objectValue?.Invoke(ObjectValue!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                String,
                typeof(string),
                ObjectValue,
                typeof(global::Portkey.RerankDocumentObject),
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
        public bool Equals(RerankDocument other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(String, other.String) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.RerankDocumentObject?>.Default.Equals(ObjectValue, other.ObjectValue) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RerankDocument obj1, RerankDocument obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RerankDocument>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RerankDocument obj1, RerankDocument obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RerankDocument o && Equals(o);
        }
    }
}
