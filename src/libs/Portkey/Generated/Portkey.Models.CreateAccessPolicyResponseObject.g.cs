
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateAccessPolicyResponseObject
    {
        /// <summary>
        ///
        /// </summary>
        Access,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAccessPolicyResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAccessPolicyResponseObject value)
        {
            return value switch
            {
                CreateAccessPolicyResponseObject.Access => "access",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAccessPolicyResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "access" => CreateAccessPolicyResponseObject.Access,
                _ => null,
            };
        }
    }
}