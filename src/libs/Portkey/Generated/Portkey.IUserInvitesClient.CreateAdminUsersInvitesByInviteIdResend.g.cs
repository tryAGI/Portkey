#nullable enable

namespace Portkey
{
    public partial interface IUserInvitesClient
    {
        /// <summary>
        /// Resend Invite<br/>
        /// Resend an invite to user for your organization
        /// </summary>
        /// <param name="inviteId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.CreateAdminUsersInvitesResendResponse> CreateAdminUsersInvitesByInviteIdResendAsync(
            string inviteId,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resend Invite<br/>
        /// Resend an invite to user for your organization
        /// </summary>
        /// <param name="inviteId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.CreateAdminUsersInvitesResendResponse>> CreateAdminUsersInvitesByInviteIdResendAsResponseAsync(
            string inviteId,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}