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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.CreateAdminUsersInvitesResendResponse> CreateAdminUsersInvitesByInviteIdResendAsync(
            string inviteId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}