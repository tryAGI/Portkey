#nullable enable

namespace Portkey
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get user
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.User> GetAdminUsersByUserIdAsync(
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}