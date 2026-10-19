
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum AnthropicTextContentType
    {
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicTextContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicTextContentType value)
        {
            return value switch
            {
                AnthropicTextContentType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicTextContentType? ToEnum(string value)
        {
            return value switch
            {
                "text" => AnthropicTextContentType.Text,
                _ => null,
            };
        }
    }
}