
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum AccessPolicyStatus
    {
        /// <summary>
        ///
        /// </summary>
        Active,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AccessPolicyStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccessPolicyStatus value)
        {
            return value switch
            {
                AccessPolicyStatus.Active => "active",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccessPolicyStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => AccessPolicyStatus.Active,
                _ => null,
            };
        }
    }
}