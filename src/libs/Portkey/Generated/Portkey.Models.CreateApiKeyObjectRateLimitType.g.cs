
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Example: requests
    /// </summary>
    public enum CreateApiKeyObjectRateLimitType
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
    public static class CreateApiKeyObjectRateLimitTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateApiKeyObjectRateLimitType value)
        {
            return value switch
            {
                CreateApiKeyObjectRateLimitType.Requests => "requests",
                CreateApiKeyObjectRateLimitType.Tokens => "tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateApiKeyObjectRateLimitType? ToEnum(string value)
        {
            return value switch
            {
                "requests" => CreateApiKeyObjectRateLimitType.Requests,
                "tokens" => CreateApiKeyObjectRateLimitType.Tokens,
                _ => null,
            };
        }
    }
}