
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum DeploymentPingResponseObject
    {
        /// <summary>
        ///
        /// </summary>
        Deployment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeploymentPingResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeploymentPingResponseObject value)
        {
            return value switch
            {
                DeploymentPingResponseObject.Deployment => "deployment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeploymentPingResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "deployment" => DeploymentPingResponseObject.Deployment,
                _ => null,
            };
        }
    }
}