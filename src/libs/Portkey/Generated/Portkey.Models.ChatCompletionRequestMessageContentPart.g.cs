#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatCompletionRequestMessageContentPart : global::System.IEquatable<ChatCompletionRequestMessageContentPart>
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
        public bool TryPickTextContentPart(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ChatCompletionRequestMessageContentPartText? value)
        {
            value = TextContentPart;
            return IsTextContentPart;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.ChatCompletionRequestMessageContentPartImage? ImageContentPart { get; init; }
#else
        public global::Portkey.ChatCompletionRequestMessageContentPartImage? ImageContentPart { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageContentPart))]
#endif
        public bool IsImageContentPart => ImageContentPart != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickImageContentPart(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.ChatCompletionRequestMessageContentPartImage? value)
        {
            value = ImageContentPart;
            return IsImageContentPart;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestMessageContentPart(global::Portkey.ChatCompletionRequestMessageContentPartText value) => new ChatCompletionRequestMessageContentPart((global::Portkey.ChatCompletionRequestMessageContentPartText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ChatCompletionRequestMessageContentPartText?(ChatCompletionRequestMessageContentPart @this) => @this.TextContentPart;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessageContentPart(global::Portkey.ChatCompletionRequestMessageContentPartText? value)
        {
            TextContentPart = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestMessageContentPart(global::Portkey.ChatCompletionRequestMessageContentPartImage value) => new ChatCompletionRequestMessageContentPart((global::Portkey.ChatCompletionRequestMessageContentPartImage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Portkey.ChatCompletionRequestMessageContentPartImage?(ChatCompletionRequestMessageContentPart @this) => @this.ImageContentPart;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessageContentPart(global::Portkey.ChatCompletionRequestMessageContentPartImage? value)
        {
            ImageContentPart = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessageContentPart(
            global::Portkey.ChatCompletionRequestMessageContentPartText? textContentPart,
            global::Portkey.ChatCompletionRequestMessageContentPartImage? imageContentPart
            )
        {
            TextContentPart = textContentPart;
            ImageContentPart = imageContentPart;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ImageContentPart as object ??
            TextContentPart as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TextContentPart?.ToString() ??
            ImageContentPart?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextContentPart && !IsImageContentPart || !IsTextContentPart && IsImageContentPart;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Portkey.ChatCompletionRequestMessageContentPartText, TResult>? textContentPart = null,
            global::System.Func<global::Portkey.ChatCompletionRequestMessageContentPartImage, TResult>? imageContentPart = null,
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
            else if (IsImageContentPart && imageContentPart != null)
            {
                return imageContentPart(ImageContentPart!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Portkey.ChatCompletionRequestMessageContentPartText>? textContentPart = null,

            global::System.Action<global::Portkey.ChatCompletionRequestMessageContentPartImage>? imageContentPart = null,
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
            else if (IsImageContentPart)
            {
                imageContentPart?.Invoke(ImageContentPart!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Portkey.ChatCompletionRequestMessageContentPartText>? textContentPart = null,
            global::System.Action<global::Portkey.ChatCompletionRequestMessageContentPartImage>? imageContentPart = null,
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
            else if (IsImageContentPart)
            {
                imageContentPart?.Invoke(ImageContentPart!);
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
                ImageContentPart,
                typeof(global::Portkey.ChatCompletionRequestMessageContentPartImage),
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
        public bool Equals(ChatCompletionRequestMessageContentPart other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ChatCompletionRequestMessageContentPartText?>.Default.Equals(TextContentPart, other.TextContentPart) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.ChatCompletionRequestMessageContentPartImage?>.Default.Equals(ImageContentPart, other.ImageContentPart) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionRequestMessageContentPart obj1, ChatCompletionRequestMessageContentPart obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionRequestMessageContentPart>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionRequestMessageContentPart obj1, ChatCompletionRequestMessageContentPart obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionRequestMessageContentPart o && Equals(o);
        }
    }
}
