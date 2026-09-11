
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Authentication mode for the OpenAI integration<br/>
    /// Default Value: apiKey
    /// </summary>
    public enum OpenAIConfigurationProviderAuthType
    {
        /// <summary>
        ///
        /// </summary>
        ApiKey,
        /// <summary>
        ///
        /// </summary>
        OauthClientCredentials,
        /// <summary>
        ///
        /// </summary>
        Wif,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIConfigurationProviderAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIConfigurationProviderAuthType value)
        {
            return value switch
            {
                OpenAIConfigurationProviderAuthType.ApiKey => "apiKey",
                OpenAIConfigurationProviderAuthType.OauthClientCredentials => "oauthClientCredentials",
                OpenAIConfigurationProviderAuthType.Wif => "wif",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIConfigurationProviderAuthType? ToEnum(string value)
        {
            return value switch
            {
                "apiKey" => OpenAIConfigurationProviderAuthType.ApiKey,
                "oauthClientCredentials" => OpenAIConfigurationProviderAuthType.OauthClientCredentials,
                "wif" => OpenAIConfigurationProviderAuthType.Wif,
                _ => null,
            };
        }
    }
}