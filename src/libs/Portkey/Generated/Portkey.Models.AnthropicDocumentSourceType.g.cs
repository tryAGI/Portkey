
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum AnthropicDocumentSourceType
    {
        /// <summary>
        ///
        /// </summary>
        Base64,
        /// <summary>
        ///
        /// </summary>
        Content,
        /// <summary>
        ///
        /// </summary>
        Text,
        /// <summary>
        ///
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicDocumentSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicDocumentSourceType value)
        {
            return value switch
            {
                AnthropicDocumentSourceType.Base64 => "base64",
                AnthropicDocumentSourceType.Content => "content",
                AnthropicDocumentSourceType.Text => "text",
                AnthropicDocumentSourceType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicDocumentSourceType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => AnthropicDocumentSourceType.Base64,
                "content" => AnthropicDocumentSourceType.Content,
                "text" => AnthropicDocumentSourceType.Text,
                "url" => AnthropicDocumentSourceType.Url,
                _ => null,
            };
        }
    }
}