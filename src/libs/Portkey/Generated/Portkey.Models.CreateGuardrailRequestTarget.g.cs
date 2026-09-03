
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Target type for the guardrail. Use "llm" for LLM API requests (default) or "mcp_tools" for MCP tool calls.<br/>
    /// Default Value: llm
    /// </summary>
    public enum CreateGuardrailRequestTarget
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
    public static class CreateGuardrailRequestTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGuardrailRequestTarget value)
        {
            return value switch
            {
                CreateGuardrailRequestTarget.Llm => "llm",
                CreateGuardrailRequestTarget.McpTools => "mcp_tools",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGuardrailRequestTarget? ToEnum(string value)
        {
            return value switch
            {
                "llm" => CreateGuardrailRequestTarget.Llm,
                "mcp_tools" => CreateGuardrailRequestTarget.McpTools,
                _ => null,
            };
        }
    }
}