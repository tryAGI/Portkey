
#nullable enable

namespace Portkey
{
    /// <summary>
    /// `partial` when exactly one of the two checks passes
    /// </summary>
    public enum DeploymentPingResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Healthy,
        /// <summary>
        /// 
        /// </summary>
        Partial,
        /// <summary>
        /// 
        /// </summary>
        Unhealthy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeploymentPingResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeploymentPingResponseStatus value)
        {
            return value switch
            {
                DeploymentPingResponseStatus.Healthy => "healthy",
                DeploymentPingResponseStatus.Partial => "partial",
                DeploymentPingResponseStatus.Unhealthy => "unhealthy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeploymentPingResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "healthy" => DeploymentPingResponseStatus.Healthy,
                "partial" => DeploymentPingResponseStatus.Partial,
                "unhealthy" => DeploymentPingResponseStatus.Unhealthy,
                _ => null,
            };
        }
    }
}