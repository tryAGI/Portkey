
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetScimWorkspacesRole
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
    public static class GetScimWorkspacesRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetScimWorkspacesRole value)
        {
            return value switch
            {
                GetScimWorkspacesRole.Admin => "admin",
                GetScimWorkspacesRole.Manager => "manager",
                GetScimWorkspacesRole.Member => "member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetScimWorkspacesRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetScimWorkspacesRole.Admin,
                "manager" => GetScimWorkspacesRole.Manager,
                "member" => GetScimWorkspacesRole.Member,
                _ => null,
            };
        }
    }
}