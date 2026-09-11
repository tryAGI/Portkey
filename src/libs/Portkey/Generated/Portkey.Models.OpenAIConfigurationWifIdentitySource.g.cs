
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Source of the subject JWT for WIF exchange (only configuredIdp is supported today)<br/>
    /// Default Value: configuredIdp
    /// </summary>
    public enum OpenAIConfigurationWifIdentitySource
    {
        /// <summary>
        ///
        /// </summary>
        ConfiguredIdp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIConfigurationWifIdentitySourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIConfigurationWifIdentitySource value)
        {
            return value switch
            {
                OpenAIConfigurationWifIdentitySource.ConfiguredIdp => "configuredIdp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIConfigurationWifIdentitySource? ToEnum(string value)
        {
            return value switch
            {
                "configuredIdp" => OpenAIConfigurationWifIdentitySource.ConfiguredIdp,
                _ => null,
            };
        }
    }
}