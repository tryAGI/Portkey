
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAnalyticsGroupsUsersResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAnalyticsGroupsUsersResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsGroupsUsersResponseObject value)
        {
            return value switch
            {
                GetAnalyticsGroupsUsersResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsGroupsUsersResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => GetAnalyticsGroupsUsersResponseObject.List,
                _ => null,
            };
        }
    }
}