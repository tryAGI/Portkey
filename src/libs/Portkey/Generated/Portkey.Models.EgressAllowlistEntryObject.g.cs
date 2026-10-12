
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum EgressAllowlistEntryObject
    {
        /// <summary>
        ///
        /// </summary>
        EgressAllowlist,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EgressAllowlistEntryObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EgressAllowlistEntryObject value)
        {
            return value switch
            {
                EgressAllowlistEntryObject.EgressAllowlist => "egress-allowlist",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EgressAllowlistEntryObject? ToEnum(string value)
        {
            return value switch
            {
                "egress-allowlist" => EgressAllowlistEntryObject.EgressAllowlist,
                _ => null,
            };
        }
    }
}