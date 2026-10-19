#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AnthropicContentBlock : global::System.IEquatable<AnthropicContentBlock>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.AnthropicTextContent? Text { get; init; }
#else
        public global::Portkey.AnthropicTextContent? Text { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.AnthropicTextContent? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicTextContent PickText() => Text is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.AnthropicImageContent? Image { get; init; }
#else
        public global::Portkey.AnthropicImageContent? Image { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.AnthropicImageContent? value)
        {
            value = Image;
            return IsImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicImageContent PickImage() => Image is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Image' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.AnthropicDocumentContent? Document { get; init; }
#else
        public global::Portkey.AnthropicDocumentContent? Document { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Document))]
#endif
        public bool IsDocument => Document != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDocument(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.AnthropicDocumentContent? value)
        {
            value = Document;
            return IsDocument;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicDocumentContent PickDocument() => Document is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Document' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.AnthropicToolUseContent? ToolUse { get; init; }
#else
        public global::Portkey.AnthropicToolUseContent? ToolUse { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolUse))]
#endif
        public bool IsToolUse => ToolUse != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickToolUse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.AnthropicToolUseContent? value)
        {
            value = ToolUse;
            return IsToolUse;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicToolUseContent PickToolUse() => ToolUse is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolUse' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.AnthropicToolResultContent? ToolResult { get; init; }
#else
        public global::Portkey.AnthropicToolResultContent? ToolResult { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolResult))]
#endif
        public bool IsToolResult => ToolResult != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickToolResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.AnthropicToolResultContent? value)
        {
            value = ToolResult;
            return IsToolResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicToolResultContent PickToolResult() => ToolResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolResult' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.AnthropicThinkingContent? Thinking { get; init; }
#else
        public global::Portkey.AnthropicThinkingContent? Thinking { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Thinking))]
#endif
        public bool IsThinking => Thinking != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickThinking(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.AnthropicThinkingContent? value)
        {
            value = Thinking;
            return IsThinking;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicThinkingContent PickThinking() => Thinking is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Thinking' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Portkey.AnthropicRedactedThinkingContent? RedactedThinking { get; init; }
#else
        public global::Portkey.AnthropicRedactedThinkingContent? RedactedThinking { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RedactedThinking))]
#endif
        public bool IsRedactedThinking => RedactedThinking != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRedactedThinking(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Portkey.AnthropicRedactedThinkingContent? value)
        {
            value = RedactedThinking;
            return IsRedactedThinking;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Portkey.AnthropicRedactedThinkingContent PickRedactedThinking() => RedactedThinking is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RedactedThinking' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicContentBlock(global::Portkey.AnthropicTextContent value) => new AnthropicContentBlock((global::Portkey.AnthropicTextContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Portkey.AnthropicTextContent?(AnthropicContentBlock @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public AnthropicContentBlock(global::Portkey.AnthropicTextContent? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicContentBlock FromText(global::Portkey.AnthropicTextContent? value) => new AnthropicContentBlock(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicContentBlock(global::Portkey.AnthropicImageContent value) => new AnthropicContentBlock((global::Portkey.AnthropicImageContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Portkey.AnthropicImageContent?(AnthropicContentBlock @this) => @this.Image;

        /// <summary>
        ///
        /// </summary>
        public AnthropicContentBlock(global::Portkey.AnthropicImageContent? value)
        {
            Image = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicContentBlock FromImage(global::Portkey.AnthropicImageContent? value) => new AnthropicContentBlock(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicContentBlock(global::Portkey.AnthropicDocumentContent value) => new AnthropicContentBlock((global::Portkey.AnthropicDocumentContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Portkey.AnthropicDocumentContent?(AnthropicContentBlock @this) => @this.Document;

        /// <summary>
        ///
        /// </summary>
        public AnthropicContentBlock(global::Portkey.AnthropicDocumentContent? value)
        {
            Document = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicContentBlock FromDocument(global::Portkey.AnthropicDocumentContent? value) => new AnthropicContentBlock(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicContentBlock(global::Portkey.AnthropicToolUseContent value) => new AnthropicContentBlock((global::Portkey.AnthropicToolUseContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Portkey.AnthropicToolUseContent?(AnthropicContentBlock @this) => @this.ToolUse;

        /// <summary>
        ///
        /// </summary>
        public AnthropicContentBlock(global::Portkey.AnthropicToolUseContent? value)
        {
            ToolUse = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicContentBlock FromToolUse(global::Portkey.AnthropicToolUseContent? value) => new AnthropicContentBlock(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicContentBlock(global::Portkey.AnthropicToolResultContent value) => new AnthropicContentBlock((global::Portkey.AnthropicToolResultContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Portkey.AnthropicToolResultContent?(AnthropicContentBlock @this) => @this.ToolResult;

        /// <summary>
        ///
        /// </summary>
        public AnthropicContentBlock(global::Portkey.AnthropicToolResultContent? value)
        {
            ToolResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicContentBlock FromToolResult(global::Portkey.AnthropicToolResultContent? value) => new AnthropicContentBlock(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicContentBlock(global::Portkey.AnthropicThinkingContent value) => new AnthropicContentBlock((global::Portkey.AnthropicThinkingContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Portkey.AnthropicThinkingContent?(AnthropicContentBlock @this) => @this.Thinking;

        /// <summary>
        ///
        /// </summary>
        public AnthropicContentBlock(global::Portkey.AnthropicThinkingContent? value)
        {
            Thinking = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicContentBlock FromThinking(global::Portkey.AnthropicThinkingContent? value) => new AnthropicContentBlock(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicContentBlock(global::Portkey.AnthropicRedactedThinkingContent value) => new AnthropicContentBlock((global::Portkey.AnthropicRedactedThinkingContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Portkey.AnthropicRedactedThinkingContent?(AnthropicContentBlock @this) => @this.RedactedThinking;

        /// <summary>
        ///
        /// </summary>
        public AnthropicContentBlock(global::Portkey.AnthropicRedactedThinkingContent? value)
        {
            RedactedThinking = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicContentBlock FromRedactedThinking(global::Portkey.AnthropicRedactedThinkingContent? value) => new AnthropicContentBlock(value);

        /// <summary>
        ///
        /// </summary>
        public AnthropicContentBlock(
            global::Portkey.AnthropicTextContent? text,
            global::Portkey.AnthropicImageContent? image,
            global::Portkey.AnthropicDocumentContent? document,
            global::Portkey.AnthropicToolUseContent? toolUse,
            global::Portkey.AnthropicToolResultContent? toolResult,
            global::Portkey.AnthropicThinkingContent? thinking,
            global::Portkey.AnthropicRedactedThinkingContent? redactedThinking
            )
        {
            Text = text;
            Image = image;
            Document = document;
            ToolUse = toolUse;
            ToolResult = toolResult;
            Thinking = thinking;
            RedactedThinking = redactedThinking;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            RedactedThinking as object ??
            Thinking as object ??
            ToolResult as object ??
            ToolUse as object ??
            Document as object ??
            Image as object ??
            Text as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Image?.ToString() ??
            Document?.ToString() ??
            ToolUse?.ToString() ??
            ToolResult?.ToString() ??
            Thinking?.ToString() ??
            RedactedThinking?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImage && !IsDocument && !IsToolUse && !IsToolResult && !IsThinking && !IsRedactedThinking || !IsText && IsImage && !IsDocument && !IsToolUse && !IsToolResult && !IsThinking && !IsRedactedThinking || !IsText && !IsImage && IsDocument && !IsToolUse && !IsToolResult && !IsThinking && !IsRedactedThinking || !IsText && !IsImage && !IsDocument && IsToolUse && !IsToolResult && !IsThinking && !IsRedactedThinking || !IsText && !IsImage && !IsDocument && !IsToolUse && IsToolResult && !IsThinking && !IsRedactedThinking || !IsText && !IsImage && !IsDocument && !IsToolUse && !IsToolResult && IsThinking && !IsRedactedThinking || !IsText && !IsImage && !IsDocument && !IsToolUse && !IsToolResult && !IsThinking && IsRedactedThinking;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Portkey.AnthropicTextContent, TResult>? text = null,
            global::System.Func<global::Portkey.AnthropicImageContent, TResult>? image = null,
            global::System.Func<global::Portkey.AnthropicDocumentContent, TResult>? document = null,
            global::System.Func<global::Portkey.AnthropicToolUseContent, TResult>? toolUse = null,
            global::System.Func<global::Portkey.AnthropicToolResultContent, TResult>? toolResult = null,
            global::System.Func<global::Portkey.AnthropicThinkingContent, TResult>? thinking = null,
            global::System.Func<global::Portkey.AnthropicRedactedThinkingContent, TResult>? redactedThinking = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0 && text != null)
            {
                return text(__value0);
            }
            else if (Image is { } __value1 && image != null)
            {
                return image(__value1);
            }
            else if (Document is { } __value2 && document != null)
            {
                return document(__value2);
            }
            else if (ToolUse is { } __value3 && toolUse != null)
            {
                return toolUse(__value3);
            }
            else if (ToolResult is { } __value4 && toolResult != null)
            {
                return toolResult(__value4);
            }
            else if (Thinking is { } __value5 && thinking != null)
            {
                return thinking(__value5);
            }
            else if (RedactedThinking is { } __value6 && redactedThinking != null)
            {
                return redactedThinking(__value6);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Portkey.AnthropicTextContent>? text = null,

            global::System.Action<global::Portkey.AnthropicImageContent>? image = null,

            global::System.Action<global::Portkey.AnthropicDocumentContent>? document = null,

            global::System.Action<global::Portkey.AnthropicToolUseContent>? toolUse = null,

            global::System.Action<global::Portkey.AnthropicToolResultContent>? toolResult = null,

            global::System.Action<global::Portkey.AnthropicThinkingContent>? thinking = null,

            global::System.Action<global::Portkey.AnthropicRedactedThinkingContent>? redactedThinking = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (Image is { } __value1)
            {
                image?.Invoke(__value1);
            }
            else if (Document is { } __value2)
            {
                document?.Invoke(__value2);
            }
            else if (ToolUse is { } __value3)
            {
                toolUse?.Invoke(__value3);
            }
            else if (ToolResult is { } __value4)
            {
                toolResult?.Invoke(__value4);
            }
            else if (Thinking is { } __value5)
            {
                thinking?.Invoke(__value5);
            }
            else if (RedactedThinking is { } __value6)
            {
                redactedThinking?.Invoke(__value6);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Portkey.AnthropicTextContent>? text = null,
            global::System.Action<global::Portkey.AnthropicImageContent>? image = null,
            global::System.Action<global::Portkey.AnthropicDocumentContent>? document = null,
            global::System.Action<global::Portkey.AnthropicToolUseContent>? toolUse = null,
            global::System.Action<global::Portkey.AnthropicToolResultContent>? toolResult = null,
            global::System.Action<global::Portkey.AnthropicThinkingContent>? thinking = null,
            global::System.Action<global::Portkey.AnthropicRedactedThinkingContent>? redactedThinking = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (Image is { } __value1)
            {
                image?.Invoke(__value1);
            }
            else if (Document is { } __value2)
            {
                document?.Invoke(__value2);
            }
            else if (ToolUse is { } __value3)
            {
                toolUse?.Invoke(__value3);
            }
            else if (ToolResult is { } __value4)
            {
                toolResult?.Invoke(__value4);
            }
            else if (Thinking is { } __value5)
            {
                thinking?.Invoke(__value5);
            }
            else if (RedactedThinking is { } __value6)
            {
                redactedThinking?.Invoke(__value6);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::Portkey.AnthropicTextContent),
                Image,
                typeof(global::Portkey.AnthropicImageContent),
                Document,
                typeof(global::Portkey.AnthropicDocumentContent),
                ToolUse,
                typeof(global::Portkey.AnthropicToolUseContent),
                ToolResult,
                typeof(global::Portkey.AnthropicToolResultContent),
                Thinking,
                typeof(global::Portkey.AnthropicThinkingContent),
                RedactedThinking,
                typeof(global::Portkey.AnthropicRedactedThinkingContent),
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
        public bool Equals(AnthropicContentBlock other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Portkey.AnthropicTextContent?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.AnthropicImageContent?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.AnthropicDocumentContent?>.Default.Equals(Document, other.Document) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.AnthropicToolUseContent?>.Default.Equals(ToolUse, other.ToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.AnthropicToolResultContent?>.Default.Equals(ToolResult, other.ToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.AnthropicThinkingContent?>.Default.Equals(Thinking, other.Thinking) &&
                global::System.Collections.Generic.EqualityComparer<global::Portkey.AnthropicRedactedThinkingContent?>.Default.Equals(RedactedThinking, other.RedactedThinking)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AnthropicContentBlock obj1, AnthropicContentBlock obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnthropicContentBlock>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AnthropicContentBlock obj1, AnthropicContentBlock obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicContentBlock o && Equals(o);
        }
    }
}
