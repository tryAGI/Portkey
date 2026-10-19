
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum CountMessageTokensRequestToolChoiceType
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
    public static class CountMessageTokensRequestToolChoiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CountMessageTokensRequestToolChoiceType value)
        {
            return value switch
            {
                CountMessageTokensRequestToolChoiceType.Any => "any",
                CountMessageTokensRequestToolChoiceType.Auto => "auto",
                CountMessageTokensRequestToolChoiceType.None => "none",
                CountMessageTokensRequestToolChoiceType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CountMessageTokensRequestToolChoiceType? ToEnum(string value)
        {
            return value switch
            {
                "any" => CountMessageTokensRequestToolChoiceType.Any,
                "auto" => CountMessageTokensRequestToolChoiceType.Auto,
                "none" => CountMessageTokensRequestToolChoiceType.None,
                "tool" => CountMessageTokensRequestToolChoiceType.Tool,
                _ => null,
            };
        }
    }
}