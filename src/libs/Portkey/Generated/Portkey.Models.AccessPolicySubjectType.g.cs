
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum AccessPolicySubjectType
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
    public static class AccessPolicySubjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccessPolicySubjectType value)
        {
            return value switch
            {
                AccessPolicySubjectType.Agent => "agent",
                AccessPolicySubjectType.Group => "group",
                AccessPolicySubjectType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccessPolicySubjectType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => AccessPolicySubjectType.Agent,
                "group" => AccessPolicySubjectType.Group,
                "user" => AccessPolicySubjectType.User,
                _ => null,
            };
        }
    }
}