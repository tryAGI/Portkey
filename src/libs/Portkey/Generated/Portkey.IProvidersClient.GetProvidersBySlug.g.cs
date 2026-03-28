#nullable enable

namespace Portkey
{
    public partial interface IProvidersClient
    {
        /// <summary>
        /// Get a Provider
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="slug"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.Providers> GetProvidersBySlugAsync(
            string slug,
            string? workspaceId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}