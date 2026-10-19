
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Required when type is base64.
    /// </summary>
    public enum AnthropicImageSourceMediaType
    {
        /// <summary>
        ///
        /// </summary>
        ImageGif,
        /// <summary>
        ///
        /// </summary>
        ImageJpeg,
        /// <summary>
        ///
        /// </summary>
        ImagePng,
        /// <summary>
        ///
        /// </summary>
        ImageWebp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicImageSourceMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicImageSourceMediaType value)
        {
            return value switch
            {
                AnthropicImageSourceMediaType.ImageGif => "image/gif",
                AnthropicImageSourceMediaType.ImageJpeg => "image/jpeg",
                AnthropicImageSourceMediaType.ImagePng => "image/png",
                AnthropicImageSourceMediaType.ImageWebp => "image/webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicImageSourceMediaType? ToEnum(string value)
        {
            return value switch
            {
                "image/gif" => AnthropicImageSourceMediaType.ImageGif,
                "image/jpeg" => AnthropicImageSourceMediaType.ImageJpeg,
                "image/png" => AnthropicImageSourceMediaType.ImagePng,
                "image/webp" => AnthropicImageSourceMediaType.ImageWebp,
                _ => null,
            };
        }
    }
}