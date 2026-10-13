
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum AccessPolicyListItemEffect
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
    public static class AccessPolicyListItemEffectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccessPolicyListItemEffect value)
        {
            return value switch
            {
                AccessPolicyListItemEffect.Allow => "allow",
                AccessPolicyListItemEffect.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccessPolicyListItemEffect? ToEnum(string value)
        {
            return value switch
            {
                "allow" => AccessPolicyListItemEffect.Allow,
                "deny" => AccessPolicyListItemEffect.Deny,
                _ => null,
            };
        }
    }
}