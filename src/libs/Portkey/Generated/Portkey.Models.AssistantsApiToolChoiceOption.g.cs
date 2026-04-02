#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Portkey
{
    /// <summary>
    /// Controls which (if any) tool is called by the model.<br/>
    /// `none` means the model will not call any tools and instead generates a message.<br/>
    /// `auto` is the default value and means the model can pick between generating a message or calling one or more tools.<br/>
    /// `required` means the model must call one or more tools before responding to the user.<br/>
    /// Specifying a particular tool like `{"type": "file_search"}` or `{"type": "function", "function": {"name": "my_function"}}` forces the model to call that tool.
    /// </summary>
    public readonly partial struct AssistantsApiToolChoiceOption : global::System.IEquatable<AssistantsApiToolChoiceOption>
    {
        /// <summary>
        /// `none` means the model will not call any tools and instead generates a message. `auto` means the model can pick between generating a message or calling one or more tools. `required` means the model must call one or more tools before responding to the user.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.AssistantsApiToolChoiceOptionEnum? Enum { get; init; }
#else
        public global::Portkey.AssistantsApiToolChoiceOptionEnum? Enum { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enum))]
#endif
        public bool IsEnum => Enum != null;

        /// <summary>
        /// Specifies a tool the model should use. Use to force the model to call a specific tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.AssistantsNamedToolChoice? Named { get; init; }
#else
        public global::Portkey.AssistantsNamedToolChoice? Named { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Named))]
#endif
        public bool IsNamed => Named != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantsApiToolChoiceOption(global::Portkey.AssistantsApiToolChoiceOptionEnum value) => new AssistantsApiToolChoiceOption((global::Portkey.AssistantsApiToolChoiceOptionEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.AssistantsApiToolChoiceOptionEnum?(AssistantsApiToolChoiceOption @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public AssistantsApiToolChoiceOption(global::Portkey.AssistantsApiToolChoiceOptionEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantsApiToolChoiceOption(global::Portkey.AssistantsNamedToolChoice value) => new AssistantsApiToolChoiceOption((global::Portkey.AssistantsNamedToolChoice?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.AssistantsNamedToolChoice?(AssistantsApiToolChoiceOption @this) => @this.Named;

        /// <summary>
        /// 
        /// </summary>
        public AssistantsApiToolChoiceOption(global::Portkey.AssistantsNamedToolChoice? value)
        {
            Named = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AssistantsApiToolChoiceOption(
            global::Portkey.AssistantsApiToolChoiceOptionEnum? @enum,
            global::Portkey.AssistantsNamedToolChoice? named
            )
        {
            Enum = @enum;
            Named = named;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Named as object ??
            Enum as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Enum?.ToValueString() ??
            Named?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEnum && !IsNamed || !IsEnum && IsNamed;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Portkey.AssistantsApiToolChoiceOptionEnum?, TResult>? @enum = null,
            global::System.Func<global::Portkey.AssistantsNamedToolChoice?, TResult>? named = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnum && @enum != null)
            {
                return @enum(Enum!);
            }
            else if (IsNamed && named != null)
            {
                return named(Named!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Portkey.AssistantsApiToolChoiceOptionEnum?>? @enum = null,
            global::System.Action<global::Portkey.AssistantsNamedToolChoice?>? named = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
            else if (IsNamed)
            {
                named?.Invoke(Named!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Enum,
                typeof(global::Portkey.AssistantsApiToolChoiceOptionEnum),
                Named,
                typeof(global::Portkey.AssistantsNamedToolChoice),
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
        public bool Equals(AssistantsApiToolChoiceOption other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Portkey.AssistantsApiToolChoiceOptionEnum?>.Default.Equals(Enum, other.Enum) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.AssistantsNamedToolChoice?>.Default.Equals(Named, other.Named) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AssistantsApiToolChoiceOption obj1, AssistantsApiToolChoiceOption obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AssistantsApiToolChoiceOption>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AssistantsApiToolChoiceOption obj1, AssistantsApiToolChoiceOption obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AssistantsApiToolChoiceOption o && Equals(o);
        }
    }
}
