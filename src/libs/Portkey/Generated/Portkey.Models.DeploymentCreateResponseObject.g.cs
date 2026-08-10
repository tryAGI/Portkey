
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeploymentCreateResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        Deployment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeploymentCreateResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeploymentCreateResponseObject value)
        {
            return value switch
            {
                DeploymentCreateResponseObject.Deployment => "deployment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeploymentCreateResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "deployment" => DeploymentCreateResponseObject.Deployment,
                _ => null,
            };
        }
    }
}