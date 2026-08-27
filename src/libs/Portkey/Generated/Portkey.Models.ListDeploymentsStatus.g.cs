
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum ListDeploymentsStatus
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
    public static class ListDeploymentsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDeploymentsStatus value)
        {
            return value switch
            {
                ListDeploymentsStatus.Active => "active",
                ListDeploymentsStatus.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDeploymentsStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => ListDeploymentsStatus.Active,
                "archived" => ListDeploymentsStatus.Archived,
                _ => null,
            };
        }
    }
}