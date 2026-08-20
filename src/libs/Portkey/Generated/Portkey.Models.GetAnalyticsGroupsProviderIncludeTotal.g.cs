
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Default Value: true
    /// </summary>
    public enum GetAnalyticsGroupsProviderIncludeTotal
    {
        /// <summary>
        /// 
        /// </summary>
        False,
        /// <summary>
        /// 
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAnalyticsGroupsProviderIncludeTotalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsGroupsProviderIncludeTotal value)
        {
            return value switch
            {
                GetAnalyticsGroupsProviderIncludeTotal.False => "false",
                GetAnalyticsGroupsProviderIncludeTotal.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsGroupsProviderIncludeTotal? ToEnum(string value)
        {
            return value switch
            {
                "false" => GetAnalyticsGroupsProviderIncludeTotal.False,
                "true" => GetAnalyticsGroupsProviderIncludeTotal.True,
                _ => null,
            };
        }
    }
}