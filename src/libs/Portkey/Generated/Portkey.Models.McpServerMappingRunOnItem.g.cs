
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum McpServerMappingRunOnItem
    {
        /// <summary>
        ///
        /// </summary>
        Input,
        /// <summary>
        ///
        /// </summary>
        Output,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpServerMappingRunOnItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpServerMappingRunOnItem value)
        {
            return value switch
            {
                McpServerMappingRunOnItem.Input => "input",
                McpServerMappingRunOnItem.Output => "output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpServerMappingRunOnItem? ToEnum(string value)
        {
            return value switch
            {
                "input" => McpServerMappingRunOnItem.Input,
                "output" => McpServerMappingRunOnItem.Output,
                _ => null,
            };
        }
    }
}