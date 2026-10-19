
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateMessageResponseStopReason
    {
        /// <summary>
        ///
        /// </summary>
        EndTurn,
        /// <summary>
        ///
        /// </summary>
        MaxTokens,
        /// <summary>
        ///
        /// </summary>
        PauseTurn,
        /// <summary>
        ///
        /// </summary>
        StopSequence,
        /// <summary>
        ///
        /// </summary>
        ToolUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateMessageResponseStopReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateMessageResponseStopReason value)
        {
            return value switch
            {
                CreateMessageResponseStopReason.EndTurn => "end_turn",
                CreateMessageResponseStopReason.MaxTokens => "max_tokens",
                CreateMessageResponseStopReason.PauseTurn => "pause_turn",
                CreateMessageResponseStopReason.StopSequence => "stop_sequence",
                CreateMessageResponseStopReason.ToolUse => "tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateMessageResponseStopReason? ToEnum(string value)
        {
            return value switch
            {
                "end_turn" => CreateMessageResponseStopReason.EndTurn,
                "max_tokens" => CreateMessageResponseStopReason.MaxTokens,
                "pause_turn" => CreateMessageResponseStopReason.PauseTurn,
                "stop_sequence" => CreateMessageResponseStopReason.StopSequence,
                "tool_use" => CreateMessageResponseStopReason.ToolUse,
                _ => null,
            };
        }
    }
}