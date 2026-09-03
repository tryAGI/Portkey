
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Target type for the guardrail. "llm" for LLM API requests, "mcp_tools" for MCP tool calls.<br/>
    /// Default Value: llm
    /// </summary>
    public enum GuardrailSummaryTarget
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
    public static class GuardrailSummaryTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailSummaryTarget value)
        {
            return value switch
            {
                GuardrailSummaryTarget.Llm => "llm",
                GuardrailSummaryTarget.McpTools => "mcp_tools",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailSummaryTarget? ToEnum(string value)
        {
            return value switch
            {
                "llm" => GuardrailSummaryTarget.Llm,
                "mcp_tools" => GuardrailSummaryTarget.McpTools,
                _ => null,
            };
        }
    }
}