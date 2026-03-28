#nullable enable

namespace Portkey
{
    public partial interface IWorkspacesMembersClient
    {
        /// <summary>
        /// Add workspace member
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateAdminWorkspacesByWorkspaceIdUsersAsync(
            string workspaceId,

            global::Portkey.CreateAdminWorkspacesUsersRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add workspace member
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="users"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateAdminWorkspacesByWorkspaceIdUsersAsync(
            string workspaceId,
            global::System.Collections.Generic.IList<global::Portkey.CreateAdminWorkspacesUsersRequestUser>? users = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}