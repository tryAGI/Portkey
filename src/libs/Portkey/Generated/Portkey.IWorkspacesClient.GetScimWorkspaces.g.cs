#nullable enable

namespace Portkey
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// List SCIM Group to Workspace Mappings<br/>
        /// List all mappings between SCIM groups and workspaces for the organisation.<br/>
        /// Optionally filter by workspace, SCIM group, or role.
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="scimGroupId"></param>
        /// <param name="role"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.GetScimWorkspacesResponse> GetScimWorkspacesAsync(
            string? workspaceId = default,
            string? scimGroupId = default,
            global::Portkey.GetScimWorkspacesRole? role = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List SCIM Group to Workspace Mappings<br/>
        /// List all mappings between SCIM groups and workspaces for the organisation.<br/>
        /// Optionally filter by workspace, SCIM group, or role.
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="scimGroupId"></param>
        /// <param name="role"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.GetScimWorkspacesResponse>> GetScimWorkspacesAsResponseAsync(
            string? workspaceId = default,
            string? scimGroupId = default,
            global::Portkey.GetScimWorkspacesRole? role = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}