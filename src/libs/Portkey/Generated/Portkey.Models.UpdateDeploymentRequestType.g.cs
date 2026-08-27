
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateDeploymentRequestType
    {
        /// <summary>
        ///
        /// </summary>
        NonProduction,
        /// <summary>
        ///
        /// </summary>
        Production,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateDeploymentRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDeploymentRequestType value)
        {
            return value switch
            {
                UpdateDeploymentRequestType.NonProduction => "non_production",
                UpdateDeploymentRequestType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDeploymentRequestType? ToEnum(string value)
        {
            return value switch
            {
                "non_production" => UpdateDeploymentRequestType.NonProduction,
                "production" => UpdateDeploymentRequestType.Production,
                _ => null,
            };
        }
    }
}