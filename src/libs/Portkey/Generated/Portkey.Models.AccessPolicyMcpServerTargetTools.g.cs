
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum AccessPolicyMcpServerTargetTools
    {
        /// <summary>
        ///
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AccessPolicyMcpServerTargetToolsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccessPolicyMcpServerTargetTools value)
        {
            return value switch
            {
                AccessPolicyMcpServerTargetTools.All => "ALL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccessPolicyMcpServerTargetTools? ToEnum(string value)
        {
            return value switch
            {
                "ALL" => AccessPolicyMcpServerTargetTools.All,
                _ => null,
            };
        }
    }
}