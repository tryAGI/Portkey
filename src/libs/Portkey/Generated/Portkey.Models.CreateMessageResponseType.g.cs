
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateMessageResponseType
    {
        /// <summary>
        ///
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateMessageResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateMessageResponseType value)
        {
            return value switch
            {
                CreateMessageResponseType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateMessageResponseType? ToEnum(string value)
        {
            return value switch
            {
                "message" => CreateMessageResponseType.Message,
                _ => null,
            };
        }
    }
}