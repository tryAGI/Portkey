
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum AnthropicRedactedThinkingContentType
    {
        /// <summary>
        ///
        /// </summary>
        RedactedThinking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicRedactedThinkingContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicRedactedThinkingContentType value)
        {
            return value switch
            {
                AnthropicRedactedThinkingContentType.RedactedThinking => "redacted_thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicRedactedThinkingContentType? ToEnum(string value)
        {
            return value switch
            {
                "redacted_thinking" => AnthropicRedactedThinkingContentType.RedactedThinking,
                _ => null,
            };
        }
    }
}