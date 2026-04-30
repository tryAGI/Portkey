
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Role assigned to group members
    /// </summary>
    public enum ScimWorkspaceMappingRole
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        Manager,
        /// <summary>
        /// 
        /// </summary>
        Member,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScimWorkspaceMappingRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScimWorkspaceMappingRole value)
        {
            return value switch
            {
                ScimWorkspaceMappingRole.Admin => "admin",
                ScimWorkspaceMappingRole.Manager => "manager",
                ScimWorkspaceMappingRole.Member => "member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScimWorkspaceMappingRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ScimWorkspaceMappingRole.Admin,
                "manager" => ScimWorkspaceMappingRole.Manager,
                "member" => ScimWorkspaceMappingRole.Member,
                _ => null,
            };
        }
    }
}