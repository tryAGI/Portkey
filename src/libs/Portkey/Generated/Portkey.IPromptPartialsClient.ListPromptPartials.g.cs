#nullable enable

namespace Portkey
{
    public partial interface IPromptPartialsClient
    {
        /// <summary>
        /// List prompt partials
        /// </summary>
        /// <param name="collectionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Portkey.PromptPartialSummary>> ListPromptPartialsAsync(
            string? collectionId = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List prompt partials
        /// </summary>
        /// <param name="collectionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Portkey.PromptPartialSummary>>> ListPromptPartialsAsResponseAsync(
            string? collectionId = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}