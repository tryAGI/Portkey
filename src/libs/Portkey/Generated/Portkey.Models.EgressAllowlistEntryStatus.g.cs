
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum EgressAllowlistEntryStatus
    {
        /// <summary>
        ///
        /// </summary>
        Active,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EgressAllowlistEntryStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EgressAllowlistEntryStatus value)
        {
            return value switch
            {
                EgressAllowlistEntryStatus.Active => "active",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EgressAllowlistEntryStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => EgressAllowlistEntryStatus.Active,
                _ => null,
            };
        }
    }
}