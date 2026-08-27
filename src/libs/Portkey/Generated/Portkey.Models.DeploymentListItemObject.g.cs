
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum DeploymentListItemObject
    {
        /// <summary>
        ///
        /// </summary>
        Deployment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeploymentListItemObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeploymentListItemObject value)
        {
            return value switch
            {
                DeploymentListItemObject.Deployment => "deployment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeploymentListItemObject? ToEnum(string value)
        {
            return value switch
            {
                "deployment" => DeploymentListItemObject.Deployment,
                _ => null,
            };
        }
    }
}