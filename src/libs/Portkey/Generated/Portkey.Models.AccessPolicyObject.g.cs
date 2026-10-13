
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum AccessPolicyObject
    {
        /// <summary>
        ///
        /// </summary>
        Access,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AccessPolicyObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccessPolicyObject value)
        {
            return value switch
            {
                AccessPolicyObject.Access => "access",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccessPolicyObject? ToEnum(string value)
        {
            return value switch
            {
                "access" => AccessPolicyObject.Access,
                _ => null,
            };
        }
    }
}