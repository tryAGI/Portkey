
#nullable enable

namespace Portkey
{
    /// <summary>
    /// The type of document source.<br/>
    /// Example: document_url
    /// </summary>
    public enum CreateOcrRequestDocumentType
    {
        /// <summary>
        ///
        /// </summary>
        DocumentUrl,
        /// <summary>
        ///
        /// </summary>
        ImageUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateOcrRequestDocumentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOcrRequestDocumentType value)
        {
            return value switch
            {
                CreateOcrRequestDocumentType.DocumentUrl => "document_url",
                CreateOcrRequestDocumentType.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOcrRequestDocumentType? ToEnum(string value)
        {
            return value switch
            {
                "document_url" => CreateOcrRequestDocumentType.DocumentUrl,
                "image_url" => CreateOcrRequestDocumentType.ImageUrl,
                _ => null,
            };
        }
    }
}