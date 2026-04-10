#nullable enable

namespace Portkey
{
    public partial interface IUserInvitesClient
    {
        /// <summary>
        /// Invite User<br/>
        /// Send an invite to user for your organization
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.SuccessInvite> InvitesCreateAsync(

            global::Portkey.CreateInvite request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Invite User<br/>
        /// Send an invite to user for your organization
        /// </summary>
        /// <param name="email"></param>
        /// <param name="workspaces"></param>
        /// <param name="role"></param>
        /// <param name="workspaceApiKeyDetails"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.SuccessInvite> InvitesCreateAsync(
            string email,
            global::System.Collections.Generic.IList<global::Portkey.WorkspaceInvite> workspaces,
            global::Portkey.InviteRole role,
            global::Portkey.CreateInviteWorkspaceApiKeyDetails? workspaceApiKeyDetails = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}