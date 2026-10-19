
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum AnthropicSystemContentVariant2ItemType
    {
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicSystemContentVariant2ItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicSystemContentVariant2ItemType value)
        {
            return value switch
            {
                AnthropicSystemContentVariant2ItemType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicSystemContentVariant2ItemType? ToEnum(string value)
        {
            return value switch
            {
                "text" => AnthropicSystemContentVariant2ItemType.Text,
                _ => null,
            };
        }
    }
}