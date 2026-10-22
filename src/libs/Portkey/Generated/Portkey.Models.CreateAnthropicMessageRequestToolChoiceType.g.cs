
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateAnthropicMessageRequestToolChoiceType
    {
        /// <summary>
        ///
        /// </summary>
        Any,
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAnthropicMessageRequestToolChoiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAnthropicMessageRequestToolChoiceType value)
        {
            return value switch
            {
                CreateAnthropicMessageRequestToolChoiceType.Any => "any",
                CreateAnthropicMessageRequestToolChoiceType.Auto => "auto",
                CreateAnthropicMessageRequestToolChoiceType.None => "none",
                CreateAnthropicMessageRequestToolChoiceType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAnthropicMessageRequestToolChoiceType? ToEnum(string value)
        {
            return value switch
            {
                "any" => CreateAnthropicMessageRequestToolChoiceType.Any,
                "auto" => CreateAnthropicMessageRequestToolChoiceType.Auto,
                "none" => CreateAnthropicMessageRequestToolChoiceType.None,
                "tool" => CreateAnthropicMessageRequestToolChoiceType.Tool,
                _ => null,
            };
        }
    }
}