
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Keeps the stored effect when omitted
    /// </summary>
    public enum UpdateAccessPolicyRequestEffect
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
    public static class UpdateAccessPolicyRequestEffectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAccessPolicyRequestEffect value)
        {
            return value switch
            {
                UpdateAccessPolicyRequestEffect.Allow => "allow",
                UpdateAccessPolicyRequestEffect.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAccessPolicyRequestEffect? ToEnum(string value)
        {
            return value switch
            {
                "allow" => UpdateAccessPolicyRequestEffect.Allow,
                "deny" => UpdateAccessPolicyRequestEffect.Deny,
                _ => null,
            };
        }
    }
}