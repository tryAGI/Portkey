
#nullable enable

namespace Portkey
{
    /// <summary>
    /// How often to automatically rotate the key.<br/>
    /// Example: monthly
    /// </summary>
    public enum UpdateApiKeyObjectRotationPolicyRotationPeriod
    {
        /// <summary>
        /// 
        /// </summary>
        Monthly,
        /// <summary>
        /// 
        /// </summary>
        Weekly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateApiKeyObjectRotationPolicyRotationPeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateApiKeyObjectRotationPolicyRotationPeriod value)
        {
            return value switch
            {
                UpdateApiKeyObjectRotationPolicyRotationPeriod.Monthly => "monthly",
                UpdateApiKeyObjectRotationPolicyRotationPeriod.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateApiKeyObjectRotationPolicyRotationPeriod? ToEnum(string value)
        {
            return value switch
            {
                "monthly" => UpdateApiKeyObjectRotationPolicyRotationPeriod.Monthly,
                "weekly" => UpdateApiKeyObjectRotationPolicyRotationPeriod.Weekly,
                _ => null,
            };
        }
    }
}