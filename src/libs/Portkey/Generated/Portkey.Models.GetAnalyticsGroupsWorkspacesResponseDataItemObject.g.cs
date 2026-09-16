
#nullable enable

namespace Portkey
{
    /// <summary>
    /// The type of object being returned
    /// </summary>
    public enum GetAnalyticsGroupsWorkspacesResponseDataItemObject
    {
        /// <summary>
        ///
        /// </summary>
        AnalyticsGroup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAnalyticsGroupsWorkspacesResponseDataItemObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsGroupsWorkspacesResponseDataItemObject value)
        {
            return value switch
            {
                GetAnalyticsGroupsWorkspacesResponseDataItemObject.AnalyticsGroup => "analytics-group",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsGroupsWorkspacesResponseDataItemObject? ToEnum(string value)
        {
            return value switch
            {
                "analytics-group" => GetAnalyticsGroupsWorkspacesResponseDataItemObject.AnalyticsGroup,
                _ => null,
            };
        }
    }
}