
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListDeploymentsResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListDeploymentsResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDeploymentsResponseObject value)
        {
            return value switch
            {
                ListDeploymentsResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDeploymentsResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => ListDeploymentsResponseObject.List,
                _ => null,
            };
        }
    }
}