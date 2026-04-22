
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Rate limit unit: requests/tokens per day, hour, minute, second, or week.<br/>
    /// Example: rpm
    /// </summary>
    public enum CreateApiKeyObjectRateLimitUnit
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
    public static class CreateApiKeyObjectRateLimitUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateApiKeyObjectRateLimitUnit value)
        {
            return value switch
            {
                CreateApiKeyObjectRateLimitUnit.Rpd => "rpd",
                CreateApiKeyObjectRateLimitUnit.Rph => "rph",
                CreateApiKeyObjectRateLimitUnit.Rpm => "rpm",
                CreateApiKeyObjectRateLimitUnit.Rps => "rps",
                CreateApiKeyObjectRateLimitUnit.Rpw => "rpw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateApiKeyObjectRateLimitUnit? ToEnum(string value)
        {
            return value switch
            {
                "rpd" => CreateApiKeyObjectRateLimitUnit.Rpd,
                "rph" => CreateApiKeyObjectRateLimitUnit.Rph,
                "rpm" => CreateApiKeyObjectRateLimitUnit.Rpm,
                "rps" => CreateApiKeyObjectRateLimitUnit.Rps,
                "rpw" => CreateApiKeyObjectRateLimitUnit.Rpw,
                _ => null,
            };
        }
    }
}