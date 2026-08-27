
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum ListDeploymentsType
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
    public static class ListDeploymentsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDeploymentsType value)
        {
            return value switch
            {
                ListDeploymentsType.NonProduction => "non_production",
                ListDeploymentsType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDeploymentsType? ToEnum(string value)
        {
            return value switch
            {
                "non_production" => ListDeploymentsType.NonProduction,
                "production" => ListDeploymentsType.Production,
                _ => null,
            };
        }
    }
}