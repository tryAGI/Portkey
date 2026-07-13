
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Default Value: v1
    /// </summary>
    public enum GetLogsPathFormat
    {
        /// <summary>
        /// 
        /// </summary>
        V1,
        /// <summary>
        /// 
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetLogsPathFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetLogsPathFormat value)
        {
            return value switch
            {
                GetLogsPathFormat.V1 => "v1",
                GetLogsPathFormat.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetLogsPathFormat? ToEnum(string value)
        {
            return value switch
            {
                "v1" => GetLogsPathFormat.V1,
                "v2" => GetLogsPathFormat.V2,
                _ => null,
            };
        }
    }
}