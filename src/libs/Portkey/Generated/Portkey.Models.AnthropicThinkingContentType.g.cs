
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum AnthropicThinkingContentType
    {
        /// <summary>
        ///
        /// </summary>
        Thinking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicThinkingContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicThinkingContentType value)
        {
            return value switch
            {
                AnthropicThinkingContentType.Thinking => "thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicThinkingContentType? ToEnum(string value)
        {
            return value switch
            {
                "thinking" => AnthropicThinkingContentType.Thinking,
                _ => null,
            };
        }
    }
}