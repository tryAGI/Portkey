#nullable enable

namespace Portkey
{
    public partial interface ISecretReferencesClient
    {
        /// <summary>
        /// List All Secret References
        /// </summary>
        /// <param name="managerType"></param>
        /// <param name="tags"></param>
        /// <param name="search"></param>
        /// <param name="currentPage">
        /// Default Value: 0
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.ListSecretReferencesResponse> ListSecretReferencesAsync(
            global::Portkey.ListSecretReferencesManagerType? managerType = default,
            string? tags = default,
            string? search = default,
            int? currentPage = default,
            int? pageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}