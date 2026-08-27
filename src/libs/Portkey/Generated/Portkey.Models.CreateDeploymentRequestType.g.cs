
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Default Value: production
    /// </summary>
    public enum CreateDeploymentRequestType
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
    public static class CreateDeploymentRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentRequestType value)
        {
            return value switch
            {
                CreateDeploymentRequestType.NonProduction => "non_production",
                CreateDeploymentRequestType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentRequestType? ToEnum(string value)
        {
            return value switch
            {
                "non_production" => CreateDeploymentRequestType.NonProduction,
                "production" => CreateDeploymentRequestType.Production,
                _ => null,
            };
        }
    }
}