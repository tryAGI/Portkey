#nullable enable

namespace Portkey
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Delete SCIM Group to Workspace Mapping<br/>
        /// Remove a SCIM group to workspace mapping. This archives the mapping but does not delete the SCIM group or workspace.
        /// </summary>
        /// <param name="scimWorkspaceGroupId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.DeleteScimWorkspacesResponse> DeleteScimWorkspacesByScimWorkspaceGroupIdAsync(
            string scimWorkspaceGroupId,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete SCIM Group to Workspace Mapping<br/>
        /// Remove a SCIM group to workspace mapping. This archives the mapping but does not delete the SCIM group or workspace.
        /// </summary>
        /// <param name="scimWorkspaceGroupId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.DeleteScimWorkspacesResponse>> DeleteScimWorkspacesByScimWorkspaceGroupIdAsResponseAsync(
            string scimWorkspaceGroupId,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}