
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateEgressAllowlistEntryResponseObject
    {
        /// <summary>
        ///
        /// </summary>
        EgressAllowlist,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEgressAllowlistEntryResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEgressAllowlistEntryResponseObject value)
        {
            return value switch
            {
                CreateEgressAllowlistEntryResponseObject.EgressAllowlist => "egress-allowlist",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEgressAllowlistEntryResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "egress-allowlist" => CreateEgressAllowlistEntryResponseObject.EgressAllowlist,
                _ => null,
            };
        }
    }
}