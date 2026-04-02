#nullable enable

namespace Portkey
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get users
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="currentPage"></param>
        /// <param name="role"></param>
        /// <param name="email"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.UserList> GetAdminUsersAsync(
            int? pageSize = default,
            int? currentPage = default,
            global::Portkey.GetAdminUsersRole? role = default,
            string? email = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}