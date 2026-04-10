#nullable enable

namespace Portkey
{
    public partial interface IProvidersClient
    {
        /// <summary>
        /// Delete a Provider
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="slug"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteProvidersBySlugAsync(
            string slug,
            string? workspaceId = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}