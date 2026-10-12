
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum ListEgressAllowlistResponseObject
    {
        /// <summary>
        ///
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListEgressAllowlistResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListEgressAllowlistResponseObject value)
        {
            return value switch
            {
                ListEgressAllowlistResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListEgressAllowlistResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => ListEgressAllowlistResponseObject.List,
                _ => null,
            };
        }
    }
}