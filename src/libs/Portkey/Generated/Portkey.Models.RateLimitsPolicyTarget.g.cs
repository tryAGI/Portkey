
#nullable enable

namespace Portkey
{
    /// <summary>
    /// The target resource for rate limiting:<br/>
    /// - `llm` - Apply rate limit to LLM requests (default)<br/>
    /// - `mcp_tools` - Apply rate limit to MCP tool calls<br/>
    /// Default Value: llm
    /// </summary>
    public enum RateLimitsPolicyTarget
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
    public static class RateLimitsPolicyTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RateLimitsPolicyTarget value)
        {
            return value switch
            {
                RateLimitsPolicyTarget.Llm => "llm",
                RateLimitsPolicyTarget.McpTools => "mcp_tools",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RateLimitsPolicyTarget? ToEnum(string value)
        {
            return value switch
            {
                "llm" => RateLimitsPolicyTarget.Llm,
                "mcp_tools" => RateLimitsPolicyTarget.McpTools,
                _ => null,
            };
        }
    }
}