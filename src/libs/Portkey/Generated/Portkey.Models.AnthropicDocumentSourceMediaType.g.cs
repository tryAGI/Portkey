
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Required when type is base64.
    /// </summary>
    public enum AnthropicDocumentSourceMediaType
    {
        /// <summary>
        ///
        /// </summary>
        ApplicationPdf,
        /// <summary>
        ///
        /// </summary>
        TextPlain,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicDocumentSourceMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicDocumentSourceMediaType value)
        {
            return value switch
            {
                AnthropicDocumentSourceMediaType.ApplicationPdf => "application/pdf",
                AnthropicDocumentSourceMediaType.TextPlain => "text/plain",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicDocumentSourceMediaType? ToEnum(string value)
        {
            return value switch
            {
                "application/pdf" => AnthropicDocumentSourceMediaType.ApplicationPdf,
                "text/plain" => AnthropicDocumentSourceMediaType.TextPlain,
                _ => null,
            };
        }
    }
}