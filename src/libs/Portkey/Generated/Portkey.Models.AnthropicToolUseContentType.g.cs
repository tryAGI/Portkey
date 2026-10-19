
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum AnthropicToolUseContentType
    {
        /// <summary>
        ///
        /// </summary>
        ToolUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicToolUseContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicToolUseContentType value)
        {
            return value switch
            {
                AnthropicToolUseContentType.ToolUse => "tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicToolUseContentType? ToEnum(string value)
        {
            return value switch
            {
                "tool_use" => AnthropicToolUseContentType.ToolUse,
                _ => null,
            };
        }
    }
}