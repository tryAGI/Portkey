
#nullable enable

namespace Portkey
{
    /// <summary>
    ///
    /// </summary>
    public enum AccessPolicyProviderTargetModels
    {
        /// <summary>
        ///
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AccessPolicyProviderTargetModelsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccessPolicyProviderTargetModels value)
        {
            return value switch
            {
                AccessPolicyProviderTargetModels.All => "ALL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccessPolicyProviderTargetModels? ToEnum(string value)
        {
            return value switch
            {
                "ALL" => AccessPolicyProviderTargetModels.All,
                _ => null,
            };
        }
    }
}