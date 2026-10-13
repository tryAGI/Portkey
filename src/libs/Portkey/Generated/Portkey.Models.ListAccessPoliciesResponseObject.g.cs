
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum ListAccessPoliciesResponseObject
    {
        /// <summary>
        ///
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListAccessPoliciesResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAccessPoliciesResponseObject value)
        {
            return value switch
            {
                ListAccessPoliciesResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAccessPoliciesResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => ListAccessPoliciesResponseObject.List,
                _ => null,
            };
        }
    }
}