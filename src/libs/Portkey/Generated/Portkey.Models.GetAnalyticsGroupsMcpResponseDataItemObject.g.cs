
#nullable enable

namespace Portkey
{
    /// <summary>
    /// The type of object being returned
    /// </summary>
    public enum GetAnalyticsGroupsMcpResponseDataItemObject
    {
        /// <summary>
        ///
        /// </summary>
        AnalyticsGroup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAnalyticsGroupsMcpResponseDataItemObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsGroupsMcpResponseDataItemObject value)
        {
            return value switch
            {
                GetAnalyticsGroupsMcpResponseDataItemObject.AnalyticsGroup => "analytics-group",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsGroupsMcpResponseDataItemObject? ToEnum(string value)
        {
            return value switch
            {
                "analytics-group" => GetAnalyticsGroupsMcpResponseDataItemObject.AnalyticsGroup,
                _ => null,
            };
        }
    }
}