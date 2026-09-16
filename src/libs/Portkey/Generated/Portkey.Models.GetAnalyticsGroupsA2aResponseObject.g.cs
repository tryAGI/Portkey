
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum GetAnalyticsGroupsA2aResponseObject
    {
        /// <summary>
        ///
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAnalyticsGroupsA2aResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsGroupsA2aResponseObject value)
        {
            return value switch
            {
                GetAnalyticsGroupsA2aResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsGroupsA2aResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => GetAnalyticsGroupsA2aResponseObject.List,
                _ => null,
            };
        }
    }
}