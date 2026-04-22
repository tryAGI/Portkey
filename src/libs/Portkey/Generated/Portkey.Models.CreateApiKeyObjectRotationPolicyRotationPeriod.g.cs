
#nullable enable

namespace Portkey
{
    /// <summary>
    /// How often to automatically rotate the key.<br/>
    /// Example: monthly
    /// </summary>
    public enum CreateApiKeyObjectRotationPolicyRotationPeriod
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
    public static class CreateApiKeyObjectRotationPolicyRotationPeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateApiKeyObjectRotationPolicyRotationPeriod value)
        {
            return value switch
            {
                CreateApiKeyObjectRotationPolicyRotationPeriod.Monthly => "monthly",
                CreateApiKeyObjectRotationPolicyRotationPeriod.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateApiKeyObjectRotationPolicyRotationPeriod? ToEnum(string value)
        {
            return value switch
            {
                "monthly" => CreateApiKeyObjectRotationPolicyRotationPeriod.Monthly,
                "weekly" => CreateApiKeyObjectRotationPolicyRotationPeriod.Weekly,
                _ => null,
            };
        }
    }
}