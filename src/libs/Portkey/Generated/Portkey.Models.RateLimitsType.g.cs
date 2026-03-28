
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public enum RateLimitsType
    {
        /// <summary>
        /// 
        /// </summary>
        Requests,
        /// <summary>
        /// 
        /// </summary>
        Tokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RateLimitsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RateLimitsType value)
        {
            return value switch
            {
                RateLimitsType.Requests => "requests",
                RateLimitsType.Tokens => "tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RateLimitsType? ToEnum(string value)
        {
            return value switch
            {
                "requests" => RateLimitsType.Requests,
                "tokens" => RateLimitsType.Tokens,
                _ => null,
            };
        }
    }
}