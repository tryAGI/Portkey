#nullable enable

namespace Portkey
{
    public partial interface IWorkspacesMembersClient
    {
        /// <summary>
        /// Get workspace members
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="currentPage">
        /// Default Value: 50
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 0
        /// </param>
        /// <param name="role"></param>
        /// <param name="email"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.WorkspaceMemberList> GetAdminWorkspacesByWorkspaceIdUsersAsync(
            string workspaceId,
            double? currentPage = default,
            double? pageSize = default,
            global::Portkey.GetAdminWorkspacesUsersRole? role = default,
            string? email = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}