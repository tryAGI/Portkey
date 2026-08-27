
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Derived from `last_synced_at` — `healthy` within the last 5 minutes, `unknown` if never synced.
    /// </summary>
    public enum DeploymentListItemConnectionStatus
    {
        /// <summary>
        ///
        /// </summary>
        Healthy,
        /// <summary>
        ///
        /// </summary>
        Unhealthy,
        /// <summary>
        ///
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeploymentListItemConnectionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeploymentListItemConnectionStatus value)
        {
            return value switch
            {
                DeploymentListItemConnectionStatus.Healthy => "healthy",
                DeploymentListItemConnectionStatus.Unhealthy => "unhealthy",
                DeploymentListItemConnectionStatus.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeploymentListItemConnectionStatus? ToEnum(string value)
        {
            return value switch
            {
                "healthy" => DeploymentListItemConnectionStatus.Healthy,
                "unhealthy" => DeploymentListItemConnectionStatus.Unhealthy,
                "unknown" => DeploymentListItemConnectionStatus.Unknown,
                _ => null,
            };
        }
    }
}