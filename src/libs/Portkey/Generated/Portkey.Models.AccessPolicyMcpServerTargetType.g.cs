
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum AccessPolicyMcpServerTargetType
    {
        /// <summary>
        ///
        /// </summary>
        McpServer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AccessPolicyMcpServerTargetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccessPolicyMcpServerTargetType value)
        {
            return value switch
            {
                AccessPolicyMcpServerTargetType.McpServer => "mcp_server",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccessPolicyMcpServerTargetType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_server" => AccessPolicyMcpServerTargetType.McpServer,
                _ => null,
            };
        }
    }
}