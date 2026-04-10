#nullable enable

namespace Portkey
{
    public partial interface IUserInvitesClient
    {
        /// <summary>
        /// Get All Invites
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="currentPage"></param>
        /// <param name="role"></param>
        /// <param name="email"></param>
        /// <param name="status"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.InviteList> GetAdminUsersInvitesAsync(
            int? pageSize = default,
            int? currentPage = default,
            global::Portkey.GetAdminUsersInvitesRole? role = default,
            string? email = default,
            global::Portkey.GetAdminUsersInvitesStatus? status = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get All Invites
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="currentPage"></param>
        /// <param name="role"></param>
        /// <param name="email"></param>
        /// <param name="status"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.InviteList>> GetAdminUsersInvitesAsResponseAsync(
            int? pageSize = default,
            int? currentPage = default,
            global::Portkey.GetAdminUsersInvitesRole? role = default,
            string? email = default,
            global::Portkey.GetAdminUsersInvitesStatus? status = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}