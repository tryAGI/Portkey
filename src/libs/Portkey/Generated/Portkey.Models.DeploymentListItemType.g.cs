
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeploymentListItemType
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
    public static class DeploymentListItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeploymentListItemType value)
        {
            return value switch
            {
                DeploymentListItemType.NonProduction => "non_production",
                DeploymentListItemType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeploymentListItemType? ToEnum(string value)
        {
            return value switch
            {
                "non_production" => DeploymentListItemType.NonProduction,
                "production" => DeploymentListItemType.Production,
                _ => null,
            };
        }
    }
}