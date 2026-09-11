
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Source of the subject JWT for WIF exchange<br/>
    /// Default Value: configuredIdp
    /// </summary>
    public enum AnthropicConfigurationWifIdentitySource
    {
        /// <summary>
        ///
        /// </summary>
        ConfiguredIdp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicConfigurationWifIdentitySourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicConfigurationWifIdentitySource value)
        {
            return value switch
            {
                AnthropicConfigurationWifIdentitySource.ConfiguredIdp => "configuredIdp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicConfigurationWifIdentitySource? ToEnum(string value)
        {
            return value switch
            {
                "configuredIdp" => AnthropicConfigurationWifIdentitySource.ConfiguredIdp,
                _ => null,
            };
        }
    }
}