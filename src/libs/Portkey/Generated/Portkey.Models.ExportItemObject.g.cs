
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExportItemObject
    {
        /// <summary>
        /// 
        /// </summary>
        Export,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExportItemObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExportItemObject value)
        {
            return value switch
            {
                ExportItemObject.Export => "export",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExportItemObject? ToEnum(string value)
        {
            return value switch
            {
                "export" => ExportItemObject.Export,
                _ => null,
            };
        }
    }
}