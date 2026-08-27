
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum DeploymentPingResponseInboundStatus
    {
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Healthy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeploymentPingResponseInboundStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeploymentPingResponseInboundStatus value)
        {
            return value switch
            {
                DeploymentPingResponseInboundStatus.Failed => "failed",
                DeploymentPingResponseInboundStatus.Healthy => "healthy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeploymentPingResponseInboundStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => DeploymentPingResponseInboundStatus.Failed,
                "healthy" => DeploymentPingResponseInboundStatus.Healthy,
                _ => null,
            };
        }
    }
}