
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum UpsertMcpServerMappingRequestRunOnItem
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
    public static class UpsertMcpServerMappingRequestRunOnItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpsertMcpServerMappingRequestRunOnItem value)
        {
            return value switch
            {
                UpsertMcpServerMappingRequestRunOnItem.Input => "input",
                UpsertMcpServerMappingRequestRunOnItem.Output => "output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpsertMcpServerMappingRequestRunOnItem? ToEnum(string value)
        {
            return value switch
            {
                "input" => UpsertMcpServerMappingRequestRunOnItem.Input,
                "output" => UpsertMcpServerMappingRequestRunOnItem.Output,
                _ => null,
            };
        }
    }
}