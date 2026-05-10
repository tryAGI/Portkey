#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateModelResponseProperties : global::System.IEquatable<CreateModelResponseProperties>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ModelResponseProperties? ModelResponseProperties { get; init; }
#else
        public global::Portkey.ModelResponseProperties? ModelResponseProperties { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelResponseProperties))]
#endif
        public bool IsModelResponseProperties => ModelResponseProperties != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickModelResponseProperties(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ModelResponseProperties? value)
        {
            value = ModelResponseProperties;
            return IsModelResponseProperties;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateModelResponseProperties(global::Portkey.ModelResponseProperties value) => new CreateModelResponseProperties((global::Portkey.ModelResponseProperties?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ModelResponseProperties?(CreateModelResponseProperties @this) => @this.ModelResponseProperties;

        /// <summary>
        /// 
        /// </summary>
        public CreateModelResponseProperties(global::Portkey.ModelResponseProperties? value)
        {
            ModelResponseProperties = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateModelResponseProperties FromModelResponseProperties(global::Portkey.ModelResponseProperties? value) => new CreateModelResponseProperties(value);

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ModelResponseProperties as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ModelResponseProperties?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsModelResponseProperties;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Portkey.ModelResponseProperties, TResult>? modelResponseProperties = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModelResponseProperties && modelResponseProperties != null)
            {
                return modelResponseProperties(ModelResponseProperties!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Portkey.ModelResponseProperties>? modelResponseProperties = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModelResponseProperties)
            {
                modelResponseProperties?.Invoke(ModelResponseProperties!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Portkey.ModelResponseProperties>? modelResponseProperties = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModelResponseProperties)
            {
                modelResponseProperties?.Invoke(ModelResponseProperties!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ModelResponseProperties,
                typeof(global::Portkey.ModelResponseProperties),
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
        public bool Equals(CreateModelResponseProperties other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ModelResponseProperties?>.Default.Equals(ModelResponseProperties, other.ModelResponseProperties) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateModelResponseProperties obj1, CreateModelResponseProperties obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateModelResponseProperties>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateModelResponseProperties obj1, CreateModelResponseProperties obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateModelResponseProperties o && Equals(o);
        }
    }
}
