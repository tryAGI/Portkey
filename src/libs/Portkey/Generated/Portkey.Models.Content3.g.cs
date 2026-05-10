#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Portkey
{
    /// <summary>
    /// Multi-modal input and output contents.
    /// </summary>
    public readonly partial struct Content3 : global::System.IEquatable<Content3>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.InputContent? InputContent { get; init; }
#else
        public global::Portkey.InputContent? InputContent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputContent))]
#endif
        public bool IsInputContent => InputContent != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInputContent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.InputContent? value)
        {
            value = InputContent;
            return IsInputContent;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.OutputContent? OutputContent { get; init; }
#else
        public global::Portkey.OutputContent? OutputContent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputContent))]
#endif
        public bool IsOutputContent => OutputContent != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOutputContent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.OutputContent? value)
        {
            value = OutputContent;
            return IsOutputContent;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Content3(global::Portkey.InputContent value) => new Content3((global::Portkey.InputContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.InputContent?(Content3 @this) => @this.InputContent;

        /// <summary>
        /// 
        /// </summary>
        public Content3(global::Portkey.InputContent? value)
        {
            InputContent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Content3 FromInputContent(global::Portkey.InputContent? value) => new Content3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Content3(global::Portkey.OutputContent value) => new Content3((global::Portkey.OutputContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.OutputContent?(Content3 @this) => @this.OutputContent;

        /// <summary>
        /// 
        /// </summary>
        public Content3(global::Portkey.OutputContent? value)
        {
            OutputContent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Content3 FromOutputContent(global::Portkey.OutputContent? value) => new Content3(value);

        /// <summary>
        /// 
        /// </summary>
        public Content3(
            global::Portkey.InputContent? inputContent,
            global::Portkey.OutputContent? outputContent
            )
        {
            InputContent = inputContent;
            OutputContent = outputContent;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OutputContent as object ??
            InputContent as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputContent?.ToString() ??
            OutputContent?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputContent && !IsOutputContent || !IsInputContent && IsOutputContent;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Portkey.InputContent?, TResult>? inputContent = null,
            global::System.Func<global::Portkey.OutputContent?, TResult>? outputContent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputContent && inputContent != null)
            {
                return inputContent(InputContent!);
            }
            else if (IsOutputContent && outputContent != null)
            {
                return outputContent(OutputContent!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Portkey.InputContent?>? inputContent = null,

            global::System.Action<global::Portkey.OutputContent?>? outputContent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputContent)
            {
                inputContent?.Invoke(InputContent!);
            }
            else if (IsOutputContent)
            {
                outputContent?.Invoke(OutputContent!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Portkey.InputContent?>? inputContent = null,
            global::System.Action<global::Portkey.OutputContent?>? outputContent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputContent)
            {
                inputContent?.Invoke(InputContent!);
            }
            else if (IsOutputContent)
            {
                outputContent?.Invoke(OutputContent!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputContent,
                typeof(global::Portkey.InputContent),
                OutputContent,
                typeof(global::Portkey.OutputContent),
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
        public bool Equals(Content3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Portkey.InputContent?>.Default.Equals(InputContent, other.InputContent) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.OutputContent?>.Default.Equals(OutputContent, other.OutputContent) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Content3 obj1, Content3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Content3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Content3 obj1, Content3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Content3 o && Equals(o);
        }
    }
}
