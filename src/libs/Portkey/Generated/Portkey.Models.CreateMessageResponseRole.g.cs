
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateMessageResponseRole
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateMessageResponseRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateMessageResponseRole value)
        {
            return value switch
            {
                CreateMessageResponseRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateMessageResponseRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => CreateMessageResponseRole.Assistant,
                _ => null,
            };
        }
    }
}