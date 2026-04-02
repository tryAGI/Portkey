#nullable enable

namespace Portkey
{
    public partial interface IUserInvitesClient
    {
        /// <summary>
        /// Get Invite
        /// </summary>
        /// <param name="inviteId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.Invite> GetAdminUsersInvitesByInviteIdAsync(
            string inviteId,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Invite
        /// </summary>
        /// <param name="inviteId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.Invite>> GetAdminUsersInvitesByInviteIdAsResponseAsync(
            string inviteId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}