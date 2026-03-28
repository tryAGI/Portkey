#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Portkey
{
    /// <summary>
    /// A block of content in a chat completion message.
    /// </summary>
    public readonly partial struct ChatCompletionMessageContentBlock : global::System.IEquatable<ChatCompletionMessageContentBlock>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ChatCompletionRequestMessageContentPartText? TextContentPart { get; init; }
#else
        public global::Portkey.ChatCompletionRequestMessageContentPartText? TextContentPart { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextContentPart))]
#endif
        public bool IsTextContentPart => TextContentPart != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ChatCompletionMessageContentPartThinking? ThinkingContentPart { get; init; }
#else
        public global::Portkey.ChatCompletionMessageContentPartThinking? ThinkingContentPart { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThinkingContentPart))]
#endif
        public bool IsThinkingContentPart => ThinkingContentPart != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ChatCompletionMessageContentPartRedactedThinking? RedactedThinkingContentPart { get; init; }
#else
        public global::Portkey.ChatCompletionMessageContentPartRedactedThinking? RedactedThinkingContentPart { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RedactedThinkingContentPart))]
#endif
        public bool IsRedactedThinkingContentPart => RedactedThinkingContentPart != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionMessageContentBlock(global::Portkey.ChatCompletionRequestMessageContentPartText value) => new ChatCompletionMessageContentBlock((global::Portkey.ChatCompletionRequestMessageContentPartText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ChatCompletionRequestMessageContentPartText?(ChatCompletionMessageContentBlock @this) => @this.TextContentPart;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageContentBlock(global::Portkey.ChatCompletionRequestMessageContentPartText? value)
        {
            TextContentPart = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionMessageContentBlock(global::Portkey.ChatCompletionMessageContentPartThinking value) => new ChatCompletionMessageContentBlock((global::Portkey.ChatCompletionMessageContentPartThinking?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ChatCompletionMessageContentPartThinking?(ChatCompletionMessageContentBlock @this) => @this.ThinkingContentPart;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageContentBlock(global::Portkey.ChatCompletionMessageContentPartThinking? value)
        {
            ThinkingContentPart = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionMessageContentBlock(global::Portkey.ChatCompletionMessageContentPartRedactedThinking value) => new ChatCompletionMessageContentBlock((global::Portkey.ChatCompletionMessageContentPartRedactedThinking?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ChatCompletionMessageContentPartRedactedThinking?(ChatCompletionMessageContentBlock @this) => @this.RedactedThinkingContentPart;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageContentBlock(global::Portkey.ChatCompletionMessageContentPartRedactedThinking? value)
        {
            RedactedThinkingContentPart = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageContentBlock(
            global::Portkey.ChatCompletionRequestMessageContentPartText? textContentPart,
            global::Portkey.ChatCompletionMessageContentPartThinking? thinkingContentPart,
            global::Portkey.ChatCompletionMessageContentPartRedactedThinking? redactedThinkingContentPart
            )
        {
            TextContentPart = textContentPart;
            ThinkingContentPart = thinkingContentPart;
            RedactedThinkingContentPart = redactedThinkingContentPart;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RedactedThinkingContentPart as object ??
            ThinkingContentPart as object ??
            TextContentPart as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TextContentPart?.ToString() ??
            ThinkingContentPart?.ToString() ??
            RedactedThinkingContentPart?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextContentPart && !IsThinkingContentPart && !IsRedactedThinkingContentPart || !IsTextContentPart && IsThinkingContentPart && !IsRedactedThinkingContentPart || !IsTextContentPart && !IsThinkingContentPart && IsRedactedThinkingContentPart;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Portkey.ChatCompletionRequestMessageContentPartText?, TResult>? textContentPart = null,
            global::System.Func<global::Portkey.ChatCompletionMessageContentPartThinking?, TResult>? thinkingContentPart = null,
            global::System.Func<global::Portkey.ChatCompletionMessageContentPartRedactedThinking?, TResult>? redactedThinkingContentPart = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextContentPart && textContentPart != null)
            {
                return textContentPart(TextContentPart!);
            }
            else if (IsThinkingContentPart && thinkingContentPart != null)
            {
                return thinkingContentPart(ThinkingContentPart!);
            }
            else if (IsRedactedThinkingContentPart && redactedThinkingContentPart != null)
            {
                return redactedThinkingContentPart(RedactedThinkingContentPart!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Portkey.ChatCompletionRequestMessageContentPartText?>? textContentPart = null,
            global::System.Action<global::Portkey.ChatCompletionMessageContentPartThinking?>? thinkingContentPart = null,
            global::System.Action<global::Portkey.ChatCompletionMessageContentPartRedactedThinking?>? redactedThinkingContentPart = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextContentPart)
            {
                textContentPart?.Invoke(TextContentPart!);
            }
            else if (IsThinkingContentPart)
            {
                thinkingContentPart?.Invoke(ThinkingContentPart!);
            }
            else if (IsRedactedThinkingContentPart)
            {
                redactedThinkingContentPart?.Invoke(RedactedThinkingContentPart!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TextContentPart,
                typeof(global::Portkey.ChatCompletionRequestMessageContentPartText),
                ThinkingContentPart,
                typeof(global::Portkey.ChatCompletionMessageContentPartThinking),
                RedactedThinkingContentPart,
                typeof(global::Portkey.ChatCompletionMessageContentPartRedactedThinking),
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
        public bool Equals(ChatCompletionMessageContentBlock other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ChatCompletionRequestMessageContentPartText?>.Default.Equals(TextContentPart, other.TextContentPart) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ChatCompletionMessageContentPartThinking?>.Default.Equals(ThinkingContentPart, other.ThinkingContentPart) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ChatCompletionMessageContentPartRedactedThinking?>.Default.Equals(RedactedThinkingContentPart, other.RedactedThinkingContentPart) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionMessageContentBlock obj1, ChatCompletionMessageContentBlock obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionMessageContentBlock>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionMessageContentBlock obj1, ChatCompletionMessageContentBlock obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionMessageContentBlock o && Equals(o);
        }
    }
}
