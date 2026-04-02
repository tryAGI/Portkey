#nullable enable

namespace Portkey
{
    public partial interface IWorkspacesMembersClient
    {
        /// <summary>
        /// Get member
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.WorkspaceMember> GetAdminWorkspacesByWorkspaceIdUsersByUserIdAsync(
            string workspaceId,
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get member
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.WorkspaceMember>> GetAdminWorkspacesByWorkspaceIdUsersByUserIdAsResponseAsync(
            string workspaceId,
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}