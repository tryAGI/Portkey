#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateResponse : global::System.IEquatable<CreateResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.CreateModelResponseProperties? ModelProperties { get; init; }
#else
        public global::Portkey.CreateModelResponseProperties? ModelProperties { get; }
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
            out global::Portkey.CreateModelResponseProperties? value)
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
        public global::Portkey.CreateResponseVariant3? CreateResponseVariant3 { get; init; }
#else
        public global::Portkey.CreateResponseVariant3? CreateResponseVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateResponseVariant3))]
#endif
        public bool IsCreateResponseVariant3 => CreateResponseVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCreateResponseVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.CreateResponseVariant3? value)
        {
            value = CreateResponseVariant3;
            return IsCreateResponseVariant3;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateResponse(global::Portkey.CreateModelResponseProperties value) => new CreateResponse((global::Portkey.CreateModelResponseProperties?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.CreateModelResponseProperties?(CreateResponse @this) => @this.ModelProperties;

        /// <summary>
        /// 
        /// </summary>
        public CreateResponse(global::Portkey.CreateModelResponseProperties? value)
        {
            ModelProperties = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateResponse FromModelProperties(global::Portkey.CreateModelResponseProperties? value) => new CreateResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateResponse(global::Portkey.ResponseProperties value) => new CreateResponse((global::Portkey.ResponseProperties?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ResponseProperties?(CreateResponse @this) => @this.Properties;

        /// <summary>
        /// 
        /// </summary>
        public CreateResponse(global::Portkey.ResponseProperties? value)
        {
            Properties = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateResponse FromProperties(global::Portkey.ResponseProperties? value) => new CreateResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateResponse(global::Portkey.CreateResponseVariant3 value) => new CreateResponse((global::Portkey.CreateResponseVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.CreateResponseVariant3?(CreateResponse @this) => @this.CreateResponseVariant3;

        /// <summary>
        /// 
        /// </summary>
        public CreateResponse(global::Portkey.CreateResponseVariant3? value)
        {
            CreateResponseVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateResponse FromCreateResponseVariant3(global::Portkey.CreateResponseVariant3? value) => new CreateResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public CreateResponse(
            global::Portkey.CreateModelResponseProperties? modelProperties,
            global::Portkey.ResponseProperties? properties,
            global::Portkey.CreateResponseVariant3? createResponseVariant3
            )
        {
            ModelProperties = modelProperties;
            Properties = properties;
            CreateResponseVariant3 = createResponseVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateResponseVariant3 as object ??
            Properties as object ??
            ModelProperties as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ModelProperties?.ToString() ??
            Properties?.ToString() ??
            CreateResponseVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsModelProperties && IsProperties && IsCreateResponseVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Portkey.CreateModelResponseProperties?, TResult>? modelProperties = null,
            global::System.Func<global::Portkey.ResponseProperties, TResult>? properties = null,
            global::System.Func<global::Portkey.CreateResponseVariant3, TResult>? createResponseVariant3 = null,
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
            else if (IsCreateResponseVariant3 && createResponseVariant3 != null)
            {
                return createResponseVariant3(CreateResponseVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Portkey.CreateModelResponseProperties?>? modelProperties = null,

            global::System.Action<global::Portkey.ResponseProperties>? properties = null,

            global::System.Action<global::Portkey.CreateResponseVariant3>? createResponseVariant3 = null,
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
            else if (IsCreateResponseVariant3)
            {
                createResponseVariant3?.Invoke(CreateResponseVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Portkey.CreateModelResponseProperties?>? modelProperties = null,
            global::System.Action<global::Portkey.ResponseProperties>? properties = null,
            global::System.Action<global::Portkey.CreateResponseVariant3>? createResponseVariant3 = null,
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
            else if (IsCreateResponseVariant3)
            {
                createResponseVariant3?.Invoke(CreateResponseVariant3!);
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
                typeof(global::Portkey.CreateModelResponseProperties),
                Properties,
                typeof(global::Portkey.ResponseProperties),
                CreateResponseVariant3,
                typeof(global::Portkey.CreateResponseVariant3),
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
        public bool Equals(CreateResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Portkey.CreateModelResponseProperties?>.Default.Equals(ModelProperties, other.ModelProperties) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ResponseProperties?>.Default.Equals(Properties, other.Properties) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.CreateResponseVariant3?>.Default.Equals(CreateResponseVariant3, other.CreateResponseVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateResponse obj1, CreateResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateResponse obj1, CreateResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateResponse o && Equals(o);
        }
    }
}
