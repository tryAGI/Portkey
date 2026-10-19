
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum AnthropicImageContentType
    {
        /// <summary>
        ///
        /// </summary>
        Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicImageContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicImageContentType value)
        {
            return value switch
            {
                AnthropicImageContentType.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicImageContentType? ToEnum(string value)
        {
            return value switch
            {
                "image" => AnthropicImageContentType.Image,
                _ => null,
            };
        }
    }
}