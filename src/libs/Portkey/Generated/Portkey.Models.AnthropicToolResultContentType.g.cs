
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum AnthropicToolResultContentType
    {
        /// <summary>
        ///
        /// </summary>
        ToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicToolResultContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicToolResultContentType value)
        {
            return value switch
            {
                AnthropicToolResultContentType.ToolResult => "tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicToolResultContentType? ToEnum(string value)
        {
            return value switch
            {
                "tool_result" => AnthropicToolResultContentType.ToolResult,
                _ => null,
            };
        }
    }
}