#nullable enable

namespace Portkey
{
    public partial interface IProvidersClient
    {
        /// <summary>
        /// List All Providers
        /// </summary>
        /// <param name="currentPage"></param>
        /// <param name="pageSize"></param>
        /// <param name="workspaceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.GetProvidersResponse> GetProvidersAsync(
            int? currentPage = default,
            int? pageSize = default,
            string? workspaceId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}