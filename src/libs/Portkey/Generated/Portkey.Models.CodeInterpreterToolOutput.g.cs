#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CodeInterpreterToolOutput : global::System.IEquatable<CodeInterpreterToolOutput>
    {
        /// <summary>
        /// The output of a code interpreter tool call that is text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.CodeInterpreterTextOutput? CodeInterpreterTextOutput { get; init; }
#else
        public global::Portkey.CodeInterpreterTextOutput? CodeInterpreterTextOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreterTextOutput))]
#endif
        public bool IsCodeInterpreterTextOutput => CodeInterpreterTextOutput != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCodeInterpreterTextOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.CodeInterpreterTextOutput? value)
        {
            value = CodeInterpreterTextOutput;
            return IsCodeInterpreterTextOutput;
        }

        /// <summary>
        /// The output of a code interpreter tool call that is a file.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.CodeInterpreterFileOutput? CodeInterpreterFileOutput { get; init; }
#else
        public global::Portkey.CodeInterpreterFileOutput? CodeInterpreterFileOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreterFileOutput))]
#endif
        public bool IsCodeInterpreterFileOutput => CodeInterpreterFileOutput != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCodeInterpreterFileOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.CodeInterpreterFileOutput? value)
        {
            value = CodeInterpreterFileOutput;
            return IsCodeInterpreterFileOutput;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CodeInterpreterToolOutput(global::Portkey.CodeInterpreterTextOutput value) => new CodeInterpreterToolOutput((global::Portkey.CodeInterpreterTextOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.CodeInterpreterTextOutput?(CodeInterpreterToolOutput @this) => @this.CodeInterpreterTextOutput;

        /// <summary>
        /// 
        /// </summary>
        public CodeInterpreterToolOutput(global::Portkey.CodeInterpreterTextOutput? value)
        {
            CodeInterpreterTextOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CodeInterpreterToolOutput(global::Portkey.CodeInterpreterFileOutput value) => new CodeInterpreterToolOutput((global::Portkey.CodeInterpreterFileOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.CodeInterpreterFileOutput?(CodeInterpreterToolOutput @this) => @this.CodeInterpreterFileOutput;

        /// <summary>
        /// 
        /// </summary>
        public CodeInterpreterToolOutput(global::Portkey.CodeInterpreterFileOutput? value)
        {
            CodeInterpreterFileOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CodeInterpreterToolOutput(
            global::Portkey.CodeInterpreterTextOutput? codeInterpreterTextOutput,
            global::Portkey.CodeInterpreterFileOutput? codeInterpreterFileOutput
            )
        {
            CodeInterpreterTextOutput = codeInterpreterTextOutput;
            CodeInterpreterFileOutput = codeInterpreterFileOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CodeInterpreterFileOutput as object ??
            CodeInterpreterTextOutput as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CodeInterpreterTextOutput?.ToString() ??
            CodeInterpreterFileOutput?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCodeInterpreterTextOutput && !IsCodeInterpreterFileOutput || !IsCodeInterpreterTextOutput && IsCodeInterpreterFileOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Portkey.CodeInterpreterTextOutput, TResult>? codeInterpreterTextOutput = null,
            global::System.Func<global::Portkey.CodeInterpreterFileOutput, TResult>? codeInterpreterFileOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCodeInterpreterTextOutput && codeInterpreterTextOutput != null)
            {
                return codeInterpreterTextOutput(CodeInterpreterTextOutput!);
            }
            else if (IsCodeInterpreterFileOutput && codeInterpreterFileOutput != null)
            {
                return codeInterpreterFileOutput(CodeInterpreterFileOutput!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Portkey.CodeInterpreterTextOutput>? codeInterpreterTextOutput = null,

            global::System.Action<global::Portkey.CodeInterpreterFileOutput>? codeInterpreterFileOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCodeInterpreterTextOutput)
            {
                codeInterpreterTextOutput?.Invoke(CodeInterpreterTextOutput!);
            }
            else if (IsCodeInterpreterFileOutput)
            {
                codeInterpreterFileOutput?.Invoke(CodeInterpreterFileOutput!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Portkey.CodeInterpreterTextOutput>? codeInterpreterTextOutput = null,
            global::System.Action<global::Portkey.CodeInterpreterFileOutput>? codeInterpreterFileOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCodeInterpreterTextOutput)
            {
                codeInterpreterTextOutput?.Invoke(CodeInterpreterTextOutput!);
            }
            else if (IsCodeInterpreterFileOutput)
            {
                codeInterpreterFileOutput?.Invoke(CodeInterpreterFileOutput!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CodeInterpreterTextOutput,
                typeof(global::Portkey.CodeInterpreterTextOutput),
                CodeInterpreterFileOutput,
                typeof(global::Portkey.CodeInterpreterFileOutput),
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
        public bool Equals(CodeInterpreterToolOutput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Portkey.CodeInterpreterTextOutput?>.Default.Equals(CodeInterpreterTextOutput, other.CodeInterpreterTextOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.CodeInterpreterFileOutput?>.Default.Equals(CodeInterpreterFileOutput, other.CodeInterpreterFileOutput) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CodeInterpreterToolOutput obj1, CodeInterpreterToolOutput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CodeInterpreterToolOutput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CodeInterpreterToolOutput obj1, CodeInterpreterToolOutput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CodeInterpreterToolOutput o && Equals(o);
        }
    }
}
