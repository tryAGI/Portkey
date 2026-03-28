
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public enum CollectionStatus
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
    public static class CollectionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CollectionStatus value)
        {
            return value switch
            {
                CollectionStatus.Active => "active",
                CollectionStatus.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CollectionStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => CollectionStatus.Active,
                "archived" => CollectionStatus.Archived,
                _ => null,
            };
        }
    }
}