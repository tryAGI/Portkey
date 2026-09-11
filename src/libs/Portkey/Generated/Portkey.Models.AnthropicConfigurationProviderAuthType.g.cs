
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Authentication mode for the Anthropic integration<br/>
    /// Default Value: apiKey
    /// </summary>
    public enum AnthropicConfigurationProviderAuthType
    {
        /// <summary>
        ///
        /// </summary>
        ApiKey,
        /// <summary>
        ///
        /// </summary>
        Wif,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicConfigurationProviderAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicConfigurationProviderAuthType value)
        {
            return value switch
            {
                AnthropicConfigurationProviderAuthType.ApiKey => "apiKey",
                AnthropicConfigurationProviderAuthType.Wif => "wif",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicConfigurationProviderAuthType? ToEnum(string value)
        {
            return value switch
            {
                "apiKey" => AnthropicConfigurationProviderAuthType.ApiKey,
                "wif" => AnthropicConfigurationProviderAuthType.Wif,
                _ => null,
            };
        }
    }
}