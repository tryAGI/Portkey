
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDeploymentRequestStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Archived,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateDeploymentRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDeploymentRequestStatus value)
        {
            return value switch
            {
                UpdateDeploymentRequestStatus.Active => "active",
                UpdateDeploymentRequestStatus.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDeploymentRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => UpdateDeploymentRequestStatus.Active,
                "archived" => UpdateDeploymentRequestStatus.Archived,
                _ => null,
            };
        }
    }
}