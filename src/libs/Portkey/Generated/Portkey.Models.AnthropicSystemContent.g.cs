#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AnthropicSystemContent : global::System.IEquatable<AnthropicSystemContent>
    {
        /// <summary>
        /// Plain text system prompt.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? AnthropicSystemContentVariant1 { get; init; }
#else
        public string? AnthropicSystemContentVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicSystemContentVariant1))]
#endif
        public bool IsAnthropicSystemContentVariant1 => AnthropicSystemContentVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAnthropicSystemContentVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = AnthropicSystemContentVariant1;
            return IsAnthropicSystemContentVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickAnthropicSystemContentVariant1() => AnthropicSystemContentVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnthropicSystemContentVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Portkey.AnthropicSystemContentVariant2Item>? AnthropicSystemContentVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Portkey.AnthropicSystemContentVariant2Item>? AnthropicSystemContentVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicSystemContentVariant2))]
#endif
        public bool IsAnthropicSystemContentVariant2 => AnthropicSystemContentVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAnthropicSystemContentVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Portkey.AnthropicSystemContentVariant2Item>? value)
        {
            value = AnthropicSystemContentVariant2;
            return IsAnthropicSystemContentVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Portkey.AnthropicSystemContentVariant2Item> PickAnthropicSystemContentVariant2() => AnthropicSystemContentVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnthropicSystemContentVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicSystemContent(string value) => new AnthropicSystemContent((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(AnthropicSystemContent @this) => @this.AnthropicSystemContentVariant1;

        /// <summary>
        ///
        /// </summary>
        public AnthropicSystemContent(string? value)
        {
            AnthropicSystemContentVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicSystemContent FromAnthropicSystemContentVariant1(string? value) => new AnthropicSystemContent(value);

        /// <summary>
        ///
        /// </summary>
        public AnthropicSystemContent(
            string? anthropicSystemContentVariant1,
            global::System.Collections.Generic.IList<global::Portkey.AnthropicSystemContentVariant2Item>? anthropicSystemContentVariant2
            )
        {
            AnthropicSystemContentVariant1 = anthropicSystemContentVariant1;
            AnthropicSystemContentVariant2 = anthropicSystemContentVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AnthropicSystemContentVariant2 as object ??
            AnthropicSystemContentVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AnthropicSystemContentVariant1?.ToString() ??
            AnthropicSystemContentVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAnthropicSystemContentVariant1 && !IsAnthropicSystemContentVariant2 || !IsAnthropicSystemContentVariant1 && IsAnthropicSystemContentVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? anthropicSystemContentVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Portkey.AnthropicSystemContentVariant2Item>, TResult>? anthropicSystemContentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AnthropicSystemContentVariant1 is { } __value0 && anthropicSystemContentVariant1 != null)
            {
                return anthropicSystemContentVariant1(__value0);
            }
            else if (AnthropicSystemContentVariant2 is { } __value1 && anthropicSystemContentVariant2 != null)
            {
                return anthropicSystemContentVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? anthropicSystemContentVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::Portkey.AnthropicSystemContentVariant2Item>>? anthropicSystemContentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AnthropicSystemContentVariant1 is { } __value0)
            {
                anthropicSystemContentVariant1?.Invoke(__value0);
            }
            else if (AnthropicSystemContentVariant2 is { } __value1)
            {
                anthropicSystemContentVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? anthropicSystemContentVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Portkey.AnthropicSystemContentVariant2Item>>? anthropicSystemContentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AnthropicSystemContentVariant1 is { } __value0)
            {
                anthropicSystemContentVariant1?.Invoke(__value0);
            }
            else if (AnthropicSystemContentVariant2 is { } __value1)
            {
                anthropicSystemContentVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AnthropicSystemContentVariant1,
                typeof(string),
                AnthropicSystemContentVariant2,
                typeof(global::System.Collections.Generic.IList<global::Portkey.AnthropicSystemContentVariant2Item>),
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
        public bool Equals(AnthropicSystemContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(AnthropicSystemContentVariant1, other.AnthropicSystemContentVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Portkey.AnthropicSystemContentVariant2Item>?>.Default.Equals(AnthropicSystemContentVariant2, other.AnthropicSystemContentVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AnthropicSystemContent obj1, AnthropicSystemContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnthropicSystemContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AnthropicSystemContent obj1, AnthropicSystemContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicSystemContent o && Equals(o);
        }
    }
}
