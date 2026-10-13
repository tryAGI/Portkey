
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum AccessPolicyEffect
    {
        /// <summary>
        ///
        /// </summary>
        Allow,
        /// <summary>
        ///
        /// </summary>
        Deny,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AccessPolicyEffectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccessPolicyEffect value)
        {
            return value switch
            {
                AccessPolicyEffect.Allow => "allow",
                AccessPolicyEffect.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccessPolicyEffect? ToEnum(string value)
        {
            return value switch
            {
                "allow" => AccessPolicyEffect.Allow,
                "deny" => AccessPolicyEffect.Deny,
                _ => null,
            };
        }
    }
}