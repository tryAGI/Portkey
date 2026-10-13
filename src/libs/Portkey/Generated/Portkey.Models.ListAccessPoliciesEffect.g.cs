
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum ListAccessPoliciesEffect
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
    public static class ListAccessPoliciesEffectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAccessPoliciesEffect value)
        {
            return value switch
            {
                ListAccessPoliciesEffect.Allow => "allow",
                ListAccessPoliciesEffect.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAccessPoliciesEffect? ToEnum(string value)
        {
            return value switch
            {
                "allow" => ListAccessPoliciesEffect.Allow,
                "deny" => ListAccessPoliciesEffect.Deny,
                _ => null,
            };
        }
    }
}