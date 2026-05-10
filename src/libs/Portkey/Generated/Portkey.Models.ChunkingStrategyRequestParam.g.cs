#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Portkey
{
    /// <summary>
    /// The chunking strategy used to chunk the file(s). If not set, will use the `auto` strategy.
    /// </summary>
    public readonly partial struct ChunkingStrategyRequestParam : global::System.IEquatable<ChunkingStrategyRequestParam>
    {
        /// <summary>
        /// The default strategy. This strategy currently uses a `max_chunk_size_tokens` of `800` and `chunk_overlap_tokens` of `400`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.AutoChunkingStrategyRequestParam? AutoChunkingStrategy { get; init; }
#else
        public global::Portkey.AutoChunkingStrategyRequestParam? AutoChunkingStrategy { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AutoChunkingStrategy))]
#endif
        public bool IsAutoChunkingStrategy => AutoChunkingStrategy != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAutoChunkingStrategy(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.AutoChunkingStrategyRequestParam? value)
        {
            value = AutoChunkingStrategy;
            return IsAutoChunkingStrategy;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.StaticChunkingStrategyRequestParam? StaticChunkingStrategy { get; init; }
#else
        public global::Portkey.StaticChunkingStrategyRequestParam? StaticChunkingStrategy { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StaticChunkingStrategy))]
#endif
        public bool IsStaticChunkingStrategy => StaticChunkingStrategy != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStaticChunkingStrategy(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.StaticChunkingStrategyRequestParam? value)
        {
            value = StaticChunkingStrategy;
            return IsStaticChunkingStrategy;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChunkingStrategyRequestParam(global::Portkey.AutoChunkingStrategyRequestParam value) => new ChunkingStrategyRequestParam((global::Portkey.AutoChunkingStrategyRequestParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.AutoChunkingStrategyRequestParam?(ChunkingStrategyRequestParam @this) => @this.AutoChunkingStrategy;

        /// <summary>
        /// 
        /// </summary>
        public ChunkingStrategyRequestParam(global::Portkey.AutoChunkingStrategyRequestParam? value)
        {
            AutoChunkingStrategy = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChunkingStrategyRequestParam FromAutoChunkingStrategy(global::Portkey.AutoChunkingStrategyRequestParam? value) => new ChunkingStrategyRequestParam(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChunkingStrategyRequestParam(global::Portkey.StaticChunkingStrategyRequestParam value) => new ChunkingStrategyRequestParam((global::Portkey.StaticChunkingStrategyRequestParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.StaticChunkingStrategyRequestParam?(ChunkingStrategyRequestParam @this) => @this.StaticChunkingStrategy;

        /// <summary>
        /// 
        /// </summary>
        public ChunkingStrategyRequestParam(global::Portkey.StaticChunkingStrategyRequestParam? value)
        {
            StaticChunkingStrategy = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChunkingStrategyRequestParam FromStaticChunkingStrategy(global::Portkey.StaticChunkingStrategyRequestParam? value) => new ChunkingStrategyRequestParam(value);

        /// <summary>
        /// 
        /// </summary>
        public ChunkingStrategyRequestParam(
            global::Portkey.AutoChunkingStrategyRequestParam? autoChunkingStrategy,
            global::Portkey.StaticChunkingStrategyRequestParam? staticChunkingStrategy
            )
        {
            AutoChunkingStrategy = autoChunkingStrategy;
            StaticChunkingStrategy = staticChunkingStrategy;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StaticChunkingStrategy as object ??
            AutoChunkingStrategy as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AutoChunkingStrategy?.ToString() ??
            StaticChunkingStrategy?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAutoChunkingStrategy && !IsStaticChunkingStrategy || !IsAutoChunkingStrategy && IsStaticChunkingStrategy;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Portkey.AutoChunkingStrategyRequestParam, TResult>? autoChunkingStrategy = null,
            global::System.Func<global::Portkey.StaticChunkingStrategyRequestParam, TResult>? staticChunkingStrategy = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAutoChunkingStrategy && autoChunkingStrategy != null)
            {
                return autoChunkingStrategy(AutoChunkingStrategy!);
            }
            else if (IsStaticChunkingStrategy && staticChunkingStrategy != null)
            {
                return staticChunkingStrategy(StaticChunkingStrategy!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Portkey.AutoChunkingStrategyRequestParam>? autoChunkingStrategy = null,

            global::System.Action<global::Portkey.StaticChunkingStrategyRequestParam>? staticChunkingStrategy = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAutoChunkingStrategy)
            {
                autoChunkingStrategy?.Invoke(AutoChunkingStrategy!);
            }
            else if (IsStaticChunkingStrategy)
            {
                staticChunkingStrategy?.Invoke(StaticChunkingStrategy!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Portkey.AutoChunkingStrategyRequestParam>? autoChunkingStrategy = null,
            global::System.Action<global::Portkey.StaticChunkingStrategyRequestParam>? staticChunkingStrategy = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAutoChunkingStrategy)
            {
                autoChunkingStrategy?.Invoke(AutoChunkingStrategy!);
            }
            else if (IsStaticChunkingStrategy)
            {
                staticChunkingStrategy?.Invoke(StaticChunkingStrategy!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AutoChunkingStrategy,
                typeof(global::Portkey.AutoChunkingStrategyRequestParam),
                StaticChunkingStrategy,
                typeof(global::Portkey.StaticChunkingStrategyRequestParam),
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
        public bool Equals(ChunkingStrategyRequestParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Portkey.AutoChunkingStrategyRequestParam?>.Default.Equals(AutoChunkingStrategy, other.AutoChunkingStrategy) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.StaticChunkingStrategyRequestParam?>.Default.Equals(StaticChunkingStrategy, other.StaticChunkingStrategy) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChunkingStrategyRequestParam obj1, ChunkingStrategyRequestParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChunkingStrategyRequestParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChunkingStrategyRequestParam obj1, ChunkingStrategyRequestParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChunkingStrategyRequestParam o && Equals(o);
        }
    }
}
