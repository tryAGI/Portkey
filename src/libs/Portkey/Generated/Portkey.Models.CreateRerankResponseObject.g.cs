
#nullable enable

namespace Portkey
{
    /// <summary>
    /// The object type, which is always "list".<br/>
    /// Example: list
    /// </summary>
    public enum CreateRerankResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRerankResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRerankResponseObject value)
        {
            return value switch
            {
                CreateRerankResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRerankResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => CreateRerankResponseObject.List,
                _ => null,
            };
        }
    }
}