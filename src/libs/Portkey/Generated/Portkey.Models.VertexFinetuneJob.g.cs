#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct VertexFinetuneJob : global::System.IEquatable<VertexFinetuneJob>
    {
        /// <summary>
        /// Gateway supported body params for OpenAI, Azure OpenAI and VertexAI.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.OpenAIFinetuneJob? OpenAIParams { get; init; }
#else
        public global::Portkey.OpenAIFinetuneJob? OpenAIParams { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAIParams))]
#endif
        public bool IsOpenAIParams => OpenAIParams != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VertexFinetuneJob(global::Portkey.OpenAIFinetuneJob value) => new VertexFinetuneJob((global::Portkey.OpenAIFinetuneJob?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.OpenAIFinetuneJob?(VertexFinetuneJob @this) => @this.OpenAIParams;

        /// <summary>
        /// 
        /// </summary>
        public VertexFinetuneJob(global::Portkey.OpenAIFinetuneJob? value)
        {
            OpenAIParams = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OpenAIParams as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OpenAIParams?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOpenAIParams;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Portkey.OpenAIFinetuneJob?, TResult>? openAIParams = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenAIParams && openAIParams != null)
            {
                return openAIParams(OpenAIParams!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Portkey.OpenAIFinetuneJob?>? openAIParams = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenAIParams)
            {
                openAIParams?.Invoke(OpenAIParams!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OpenAIParams,
                typeof(global::Portkey.OpenAIFinetuneJob),
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
        public bool Equals(VertexFinetuneJob other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Portkey.OpenAIFinetuneJob?>.Default.Equals(OpenAIParams, other.OpenAIParams) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VertexFinetuneJob obj1, VertexFinetuneJob obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VertexFinetuneJob>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VertexFinetuneJob obj1, VertexFinetuneJob obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VertexFinetuneJob o && Equals(o);
        }
    }
}
