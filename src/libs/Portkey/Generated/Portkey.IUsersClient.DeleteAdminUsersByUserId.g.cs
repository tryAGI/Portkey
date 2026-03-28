#nullable enable

namespace Portkey
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Remove a user
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteAdminUsersByUserIdAsync(
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}