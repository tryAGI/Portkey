
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Format of the secret value.<br/>
    /// - `string`: The secret value is treated as a plain string.<br/>
    /// - `json`: The secret value is parsed as JSON before being applied to the target field. Use this when the target field expects a structured object (e.g. `configurations.oauth_metadata`).<br/>
    /// Example: json
    /// </summary>
    public enum SecretMappingValueFormat
    {
        /// <summary>
        /// The secret value is parsed as JSON before being applied to the target field. Use this when the target field expects a structured object (e.g. `configurations.oauth_metadata`).
        /// </summary>
        Json,
        /// <summary>
        /// The secret value is treated as a plain string.
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretMappingValueFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretMappingValueFormat value)
        {
            return value switch
            {
                SecretMappingValueFormat.Json => "json",
                SecretMappingValueFormat.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretMappingValueFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => SecretMappingValueFormat.Json,
                "string" => SecretMappingValueFormat.String,
                _ => null,
            };
        }
    }
}