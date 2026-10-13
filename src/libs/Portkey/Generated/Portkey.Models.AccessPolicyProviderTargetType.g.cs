
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum AccessPolicyProviderTargetType
    {
        /// <summary>
        ///
        /// </summary>
        Provider,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AccessPolicyProviderTargetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccessPolicyProviderTargetType value)
        {
            return value switch
            {
                AccessPolicyProviderTargetType.Provider => "provider",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccessPolicyProviderTargetType? ToEnum(string value)
        {
            return value switch
            {
                "provider" => AccessPolicyProviderTargetType.Provider,
                _ => null,
            };
        }
    }
}