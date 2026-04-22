
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Rate limit unit: requests/tokens per day, hour, minute, second, or week.<br/>
    /// Example: rpm
    /// </summary>
    public enum UpdateApiKeyObjectRateLimitUnit
    {
        /// <summary>
        /// 
        /// </summary>
        Rpd,
        /// <summary>
        /// 
        /// </summary>
        Rph,
        /// <summary>
        /// 
        /// </summary>
        Rpm,
        /// <summary>
        /// 
        /// </summary>
        Rps,
        /// <summary>
        /// 
        /// </summary>
        Rpw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateApiKeyObjectRateLimitUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateApiKeyObjectRateLimitUnit value)
        {
            return value switch
            {
                UpdateApiKeyObjectRateLimitUnit.Rpd => "rpd",
                UpdateApiKeyObjectRateLimitUnit.Rph => "rph",
                UpdateApiKeyObjectRateLimitUnit.Rpm => "rpm",
                UpdateApiKeyObjectRateLimitUnit.Rps => "rps",
                UpdateApiKeyObjectRateLimitUnit.Rpw => "rpw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateApiKeyObjectRateLimitUnit? ToEnum(string value)
        {
            return value switch
            {
                "rpd" => UpdateApiKeyObjectRateLimitUnit.Rpd,
                "rph" => UpdateApiKeyObjectRateLimitUnit.Rph,
                "rpm" => UpdateApiKeyObjectRateLimitUnit.Rpm,
                "rps" => UpdateApiKeyObjectRateLimitUnit.Rps,
                "rpw" => UpdateApiKeyObjectRateLimitUnit.Rpw,
                _ => null,
            };
        }
    }
}