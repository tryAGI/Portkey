#nullable enable

namespace Portkey
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// List prompts
        /// </summary>
        /// <param name="collectionId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="currentPage"></param>
        /// <param name="pageSize"></param>
        /// <param name="search"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.ListPromptsResponse> ListPromptsAsync(
            string? collectionId = default,
            string? workspaceId = default,
            int? currentPage = default,
            int? pageSize = default,
            string? search = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List prompts
        /// </summary>
        /// <param name="collectionId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="currentPage"></param>
        /// <param name="pageSize"></param>
        /// <param name="search"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.ListPromptsResponse>> ListPromptsAsResponseAsync(
            string? collectionId = default,
            string? workspaceId = default,
            int? currentPage = default,
            int? pageSize = default,
            string? search = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}