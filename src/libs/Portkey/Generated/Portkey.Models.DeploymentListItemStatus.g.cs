
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeploymentListItemStatus
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
    public static class DeploymentListItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeploymentListItemStatus value)
        {
            return value switch
            {
                DeploymentListItemStatus.Active => "active",
                DeploymentListItemStatus.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeploymentListItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => DeploymentListItemStatus.Active,
                "archived" => DeploymentListItemStatus.Archived,
                _ => null,
            };
        }
    }
}