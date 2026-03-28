#nullable enable

namespace Portkey
{
    public partial interface IVirtualKeysClient
    {
        /// <summary>
        /// List All Virtual Keys
        /// </summary>
        /// <param name="currentPage"></param>
        /// <param name="pageSize"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.GetVirtualKeysResponse> GetVirtualKeysAsync(
            int currentPage,
            int pageSize,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}