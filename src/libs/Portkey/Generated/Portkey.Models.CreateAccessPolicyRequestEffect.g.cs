
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Inferred when omitted (see endpoint description)
    /// </summary>
    public enum CreateAccessPolicyRequestEffect
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
    public static class CreateAccessPolicyRequestEffectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAccessPolicyRequestEffect value)
        {
            return value switch
            {
                CreateAccessPolicyRequestEffect.Allow => "allow",
                CreateAccessPolicyRequestEffect.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAccessPolicyRequestEffect? ToEnum(string value)
        {
            return value switch
            {
                "allow" => CreateAccessPolicyRequestEffect.Allow,
                "deny" => CreateAccessPolicyRequestEffect.Deny,
                _ => null,
            };
        }
    }
}