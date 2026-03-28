#nullable enable

namespace Portkey
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Get workspace
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.WorkspaceWithUsers> GetAdminWorkspacesByWorkspaceIdAsync(
            string workspaceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}