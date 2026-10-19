
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum AnthropicImageSourceType
    {
        /// <summary>
        ///
        /// </summary>
        Base64,
        /// <summary>
        ///
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicImageSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicImageSourceType value)
        {
            return value switch
            {
                AnthropicImageSourceType.Base64 => "base64",
                AnthropicImageSourceType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicImageSourceType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => AnthropicImageSourceType.Base64,
                "url" => AnthropicImageSourceType.Url,
                _ => null,
            };
        }
    }
}