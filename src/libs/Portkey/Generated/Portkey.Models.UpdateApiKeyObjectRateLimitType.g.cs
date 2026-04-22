
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Example: requests
    /// </summary>
    public enum UpdateApiKeyObjectRateLimitType
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
    public static class UpdateApiKeyObjectRateLimitTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateApiKeyObjectRateLimitType value)
        {
            return value switch
            {
                UpdateApiKeyObjectRateLimitType.Requests => "requests",
                UpdateApiKeyObjectRateLimitType.Tokens => "tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateApiKeyObjectRateLimitType? ToEnum(string value)
        {
            return value switch
            {
                "requests" => UpdateApiKeyObjectRateLimitType.Requests,
                "tokens" => UpdateApiKeyObjectRateLimitType.Tokens,
                _ => null,
            };
        }
    }
}