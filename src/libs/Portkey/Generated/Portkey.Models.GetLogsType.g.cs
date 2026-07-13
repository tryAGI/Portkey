
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetLogsType
    {
        /// <summary>
        /// 
        /// </summary>
        Hooks,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetLogsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetLogsType value)
        {
            return value switch
            {
                GetLogsType.Hooks => "hooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetLogsType? ToEnum(string value)
        {
            return value switch
            {
                "hooks" => GetLogsType.Hooks,
                _ => null,
            };
        }
    }
}