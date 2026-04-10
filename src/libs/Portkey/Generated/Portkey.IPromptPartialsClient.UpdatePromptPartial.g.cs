#nullable enable

namespace Portkey
{
    public partial interface IPromptPartialsClient
    {
        /// <summary>
        /// Update a prompt partial
        /// </summary>
        /// <param name="promptPartialId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.UpdatePromptPartialResponse> UpdatePromptPartialAsync(
            string promptPartialId,

            global::Portkey.UpdatePromptPartialRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a prompt partial
        /// </summary>
        /// <param name="promptPartialId"></param>
        /// <param name="name"></param>
        /// <param name="string"></param>
        /// <param name="description"></param>
        /// <param name="status"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.UpdatePromptPartialResponse> UpdatePromptPartialAsync(
            string promptPartialId,
            string? name = default,
            string? @string = default,
            string? description = default,
            string? status = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}