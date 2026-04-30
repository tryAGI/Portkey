
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Role assigned to group members in the workspace.
    /// </summary>
    public enum GetScimWorkspacesResponseMappingRole
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
    public static class GetScimWorkspacesResponseMappingRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetScimWorkspacesResponseMappingRole value)
        {
            return value switch
            {
                GetScimWorkspacesResponseMappingRole.Admin => "admin",
                GetScimWorkspacesResponseMappingRole.Manager => "manager",
                GetScimWorkspacesResponseMappingRole.Member => "member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetScimWorkspacesResponseMappingRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetScimWorkspacesResponseMappingRole.Admin,
                "manager" => GetScimWorkspacesResponseMappingRole.Manager,
                "member" => GetScimWorkspacesResponseMappingRole.Member,
                _ => null,
            };
        }
    }
}