
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum GetAnalyticsGroupsWorkspacesResponseObject
    {
        /// <summary>
        ///
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAnalyticsGroupsWorkspacesResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsGroupsWorkspacesResponseObject value)
        {
            return value switch
            {
                GetAnalyticsGroupsWorkspacesResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsGroupsWorkspacesResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => GetAnalyticsGroupsWorkspacesResponseObject.List,
                _ => null,
            };
        }
    }
}