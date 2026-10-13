
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum AccessPolicySubjectDetailsType
    {
        /// <summary>
        ///
        /// </summary>
        Agent,
        /// <summary>
        ///
        /// </summary>
        Group,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AccessPolicySubjectDetailsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccessPolicySubjectDetailsType value)
        {
            return value switch
            {
                AccessPolicySubjectDetailsType.Agent => "agent",
                AccessPolicySubjectDetailsType.Group => "group",
                AccessPolicySubjectDetailsType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccessPolicySubjectDetailsType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => AccessPolicySubjectDetailsType.Agent,
                "group" => AccessPolicySubjectDetailsType.Group,
                "user" => AccessPolicySubjectDetailsType.User,
                _ => null,
            };
        }
    }
}