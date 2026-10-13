
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum AccessPolicyListItemObject
    {
        /// <summary>
        ///
        /// </summary>
        Access,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AccessPolicyListItemObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccessPolicyListItemObject value)
        {
            return value switch
            {
                AccessPolicyListItemObject.Access => "access",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccessPolicyListItemObject? ToEnum(string value)
        {
            return value switch
            {
                "access" => AccessPolicyListItemObject.Access,
                _ => null,
            };
        }
    }
}