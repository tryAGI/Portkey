#nullable enable

namespace Portkey
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Delete a workspace
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAdminWorkspacesByWorkspaceIdAsync(
            string workspaceId,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}