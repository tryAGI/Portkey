
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum AnthropicToolCacheControlType
    {
        /// <summary>
        ///
        /// </summary>
        Ephemeral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicToolCacheControlTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicToolCacheControlType value)
        {
            return value switch
            {
                AnthropicToolCacheControlType.Ephemeral => "ephemeral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicToolCacheControlType? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => AnthropicToolCacheControlType.Ephemeral,
                _ => null,
            };
        }
    }
}