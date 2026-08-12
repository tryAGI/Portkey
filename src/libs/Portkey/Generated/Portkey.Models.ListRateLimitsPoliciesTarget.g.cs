
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListRateLimitsPoliciesTarget
    {
        /// <summary>
        /// 
        /// </summary>
        Llm,
        /// <summary>
        /// 
        /// </summary>
        McpTools,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListRateLimitsPoliciesTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRateLimitsPoliciesTarget value)
        {
            return value switch
            {
                ListRateLimitsPoliciesTarget.Llm => "llm",
                ListRateLimitsPoliciesTarget.McpTools => "mcp_tools",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRateLimitsPoliciesTarget? ToEnum(string value)
        {
            return value switch
            {
                "llm" => ListRateLimitsPoliciesTarget.Llm,
                "mcp_tools" => ListRateLimitsPoliciesTarget.McpTools,
                _ => null,
            };
        }
    }
}