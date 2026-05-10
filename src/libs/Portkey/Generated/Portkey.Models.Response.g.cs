#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Response : global::System.IEquatable<Response>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ModelResponseProperties? ModelProperties { get; init; }
#else
        public global::Portkey.ModelResponseProperties? ModelProperties { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelProperties))]
#endif
        public bool IsModelProperties => ModelProperties != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickModelProperties(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ModelResponseProperties? value)
        {
            value = ModelProperties;
            return IsModelProperties;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ResponseProperties? Properties { get; init; }
#else
        public global::Portkey.ResponseProperties? Properties { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Properties))]
#endif
        public bool IsProperties => Properties != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickProperties(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ResponseProperties? value)
        {
            value = Properties;
            return IsProperties;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ResponseVariant3? ResponseVariant3 { get; init; }
#else
        public global::Portkey.ResponseVariant3? ResponseVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseVariant3))]
#endif
        public bool IsResponseVariant3 => ResponseVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ResponseVariant3? value)
        {
            value = ResponseVariant3;
            return IsResponseVariant3;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Response(global::Portkey.ModelResponseProperties value) => new Response((global::Portkey.ModelResponseProperties?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ModelResponseProperties?(Response @this) => @this.ModelProperties;

        /// <summary>
        /// 
        /// </summary>
        public Response(global::Portkey.ModelResponseProperties? value)
        {
            ModelProperties = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Response FromModelProperties(global::Portkey.ModelResponseProperties? value) => new Response(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Response(global::Portkey.ResponseProperties value) => new Response((global::Portkey.ResponseProperties?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ResponseProperties?(Response @this) => @this.Properties;

        /// <summary>
        /// 
        /// </summary>
        public Response(global::Portkey.ResponseProperties? value)
        {
            Properties = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Response FromProperties(global::Portkey.ResponseProperties? value) => new Response(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Response(global::Portkey.ResponseVariant3 value) => new Response((global::Portkey.ResponseVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ResponseVariant3?(Response @this) => @this.ResponseVariant3;

        /// <summary>
        /// 
        /// </summary>
        public Response(global::Portkey.ResponseVariant3? value)
        {
            ResponseVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Response FromResponseVariant3(global::Portkey.ResponseVariant3? value) => new Response(value);

        /// <summary>
        /// 
        /// </summary>
        public Response(
            global::Portkey.ModelResponseProperties? modelProperties,
            global::Portkey.ResponseProperties? properties,
            global::Portkey.ResponseVariant3? responseVariant3
            )
        {
            ModelProperties = modelProperties;
            Properties = properties;
            ResponseVariant3 = responseVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ResponseVariant3 as object ??
            Properties as object ??
            ModelProperties as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ModelProperties?.ToString() ??
            Properties?.ToString() ??
            ResponseVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsModelProperties && IsProperties && IsResponseVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Portkey.ModelResponseProperties, TResult>? modelProperties = null,
            global::System.Func<global::Portkey.ResponseProperties, TResult>? properties = null,
            global::System.Func<global::Portkey.ResponseVariant3, TResult>? responseVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModelProperties && modelProperties != null)
            {
                return modelProperties(ModelProperties!);
            }
            else if (IsProperties && properties != null)
            {
                return properties(Properties!);
            }
            else if (IsResponseVariant3 && responseVariant3 != null)
            {
                return responseVariant3(ResponseVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Portkey.ModelResponseProperties>? modelProperties = null,

            global::System.Action<global::Portkey.ResponseProperties>? properties = null,

            global::System.Action<global::Portkey.ResponseVariant3>? responseVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModelProperties)
            {
                modelProperties?.Invoke(ModelProperties!);
            }
            else if (IsProperties)
            {
                properties?.Invoke(Properties!);
            }
            else if (IsResponseVariant3)
            {
                responseVariant3?.Invoke(ResponseVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Portkey.ModelResponseProperties>? modelProperties = null,
            global::System.Action<global::Portkey.ResponseProperties>? properties = null,
            global::System.Action<global::Portkey.ResponseVariant3>? responseVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModelProperties)
            {
                modelProperties?.Invoke(ModelProperties!);
            }
            else if (IsProperties)
            {
                properties?.Invoke(Properties!);
            }
            else if (IsResponseVariant3)
            {
                responseVariant3?.Invoke(ResponseVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ModelProperties,
                typeof(global::Portkey.ModelResponseProperties),
                Properties,
                typeof(global::Portkey.ResponseProperties),
                ResponseVariant3,
                typeof(global::Portkey.ResponseVariant3),
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
        public bool Equals(Response other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ModelResponseProperties?>.Default.Equals(ModelProperties, other.ModelProperties) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ResponseProperties?>.Default.Equals(Properties, other.Properties) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ResponseVariant3?>.Default.Equals(ResponseVariant3, other.ResponseVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Response obj1, Response obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Response>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Response obj1, Response obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Response o && Equals(o);
        }
    }
}
