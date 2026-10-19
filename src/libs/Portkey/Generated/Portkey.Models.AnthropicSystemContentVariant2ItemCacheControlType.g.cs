
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum AnthropicSystemContentVariant2ItemCacheControlType
    {
        /// <summary>
        ///
        /// </summary>
        Ephemeral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicSystemContentVariant2ItemCacheControlTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicSystemContentVariant2ItemCacheControlType value)
        {
            return value switch
            {
                AnthropicSystemContentVariant2ItemCacheControlType.Ephemeral => "ephemeral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicSystemContentVariant2ItemCacheControlType? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => AnthropicSystemContentVariant2ItemCacheControlType.Ephemeral,
                _ => null,
            };
        }
    }
}