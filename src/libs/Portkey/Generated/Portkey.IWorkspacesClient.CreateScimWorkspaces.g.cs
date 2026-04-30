#nullable enable

namespace Portkey
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Create SCIM Group to Workspace Mapping<br/>
        /// Create a mapping between a SCIM group and a workspace. <br/>
        /// You can either reference an existing SCIM group by ID, or provide a group name <br/>
        /// to pre-create the SCIM group before the IdP provisions it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.ScimWorkspaceMapping> CreateScimWorkspacesAsync(

            global::Portkey.CreateScimWorkspacesRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create SCIM Group to Workspace Mapping<br/>
        /// Create a mapping between a SCIM group and a workspace. <br/>
        /// You can either reference an existing SCIM group by ID, or provide a group name <br/>
        /// to pre-create the SCIM group before the IdP provisions it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.ScimWorkspaceMapping>> CreateScimWorkspacesAsResponseAsync(

            global::Portkey.CreateScimWorkspacesRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create SCIM Group to Workspace Mapping<br/>
        /// Create a mapping between a SCIM group and a workspace. <br/>
        /// You can either reference an existing SCIM group by ID, or provide a group name <br/>
        /// to pre-create the SCIM group before the IdP provisions it.
        /// </summary>
        /// <param name="workspaceId">
        /// ID or slug (ws_ prefix) of the workspace to map the SCIM group to.
        /// </param>
        /// <param name="role">
        /// Role assigned to group members in the workspace.
        /// </param>
        /// <param name="scimGroupId">
        /// ID of an existing SCIM group. Required if scim_group_name is not provided.
        /// </param>
        /// <param name="scimGroupName">
        /// Display name for the SCIM group. If the group doesn't exist, it will be created. Required if scim_group_id is not provided. Must not match the pattern-based auto-provisioning format (e.g. ws-name-role-admin).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.ScimWorkspaceMapping> CreateScimWorkspacesAsync(
            string workspaceId,
            global::Portkey.CreateScimWorkspacesRequestRole role,
            string? scimGroupId = default,
            string? scimGroupName = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}