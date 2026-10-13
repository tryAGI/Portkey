
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum AccessPolicyTargetDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        McpServer,
        /// <summary>
        ///
        /// </summary>
        Provider,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AccessPolicyTargetDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccessPolicyTargetDiscriminatorType value)
        {
            return value switch
            {
                AccessPolicyTargetDiscriminatorType.McpServer => "mcp_server",
                AccessPolicyTargetDiscriminatorType.Provider => "provider",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccessPolicyTargetDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_server" => AccessPolicyTargetDiscriminatorType.McpServer,
                "provider" => AccessPolicyTargetDiscriminatorType.Provider,
                _ => null,
            };
        }
    }
}