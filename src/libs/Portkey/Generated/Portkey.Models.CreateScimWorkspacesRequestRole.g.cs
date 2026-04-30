
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Role assigned to group members in the workspace.
    /// </summary>
    public enum CreateScimWorkspacesRequestRole
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
    public static class CreateScimWorkspacesRequestRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateScimWorkspacesRequestRole value)
        {
            return value switch
            {
                CreateScimWorkspacesRequestRole.Admin => "admin",
                CreateScimWorkspacesRequestRole.Manager => "manager",
                CreateScimWorkspacesRequestRole.Member => "member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateScimWorkspacesRequestRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateScimWorkspacesRequestRole.Admin,
                "manager" => CreateScimWorkspacesRequestRole.Manager,
                "member" => CreateScimWorkspacesRequestRole.Member,
                _ => null,
            };
        }
    }
}