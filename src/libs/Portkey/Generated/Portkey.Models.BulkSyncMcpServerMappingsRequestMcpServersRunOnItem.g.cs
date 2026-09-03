
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum BulkSyncMcpServerMappingsRequestMcpServersRunOnItem
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
    public static class BulkSyncMcpServerMappingsRequestMcpServersRunOnItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BulkSyncMcpServerMappingsRequestMcpServersRunOnItem value)
        {
            return value switch
            {
                BulkSyncMcpServerMappingsRequestMcpServersRunOnItem.Input => "input",
                BulkSyncMcpServerMappingsRequestMcpServersRunOnItem.Output => "output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BulkSyncMcpServerMappingsRequestMcpServersRunOnItem? ToEnum(string value)
        {
            return value switch
            {
                "input" => BulkSyncMcpServerMappingsRequestMcpServersRunOnItem.Input,
                "output" => BulkSyncMcpServerMappingsRequestMcpServersRunOnItem.Output,
                _ => null,
            };
        }
    }
}