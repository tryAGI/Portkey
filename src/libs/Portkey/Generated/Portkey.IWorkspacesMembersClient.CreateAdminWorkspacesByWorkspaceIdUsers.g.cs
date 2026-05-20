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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateAdminWorkspacesByWorkspaceIdUsersAsync(
            string workspaceId,

            global::Portkey.CreateAdminWorkspacesUsersRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add workspace member
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<string>> CreateAdminWorkspacesByWorkspaceIdUsersAsResponseAsync(
            string workspaceId,

            global::Portkey.CreateAdminWorkspacesUsersRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add workspace member
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="users"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateAdminWorkspacesByWorkspaceIdUsersAsync(
            string workspaceId,
            global::System.Collections.Generic.IList<global::Portkey.CreateAdminWorkspacesUsersRequestUser>? users = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}