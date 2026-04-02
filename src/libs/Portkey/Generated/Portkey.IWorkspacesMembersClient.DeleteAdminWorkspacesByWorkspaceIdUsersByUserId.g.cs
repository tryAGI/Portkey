#nullable enable

namespace Portkey
{
    public partial interface IWorkspacesMembersClient
    {
        /// <summary>
        /// Remove workspace member
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteAdminWorkspacesByWorkspaceIdUsersByUserIdAsync(
            string workspaceId,
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove workspace member
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<string>> DeleteAdminWorkspacesByWorkspaceIdUsersByUserIdAsResponseAsync(
            string workspaceId,
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}