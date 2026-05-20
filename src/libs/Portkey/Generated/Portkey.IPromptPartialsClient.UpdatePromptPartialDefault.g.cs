#nullable enable

namespace Portkey
{
    public partial interface IPromptPartialsClient
    {
        /// <summary>
        /// Set a version as the default for a prompt partial
        /// </summary>
        /// <param name="promptPartialId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdatePromptPartialDefaultAsync(
            string promptPartialId,

            global::Portkey.UpdatePromptPartialDefaultRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set a version as the default for a prompt partial
        /// </summary>
        /// <param name="promptPartialId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<string>> UpdatePromptPartialDefaultAsResponseAsync(
            string promptPartialId,

            global::Portkey.UpdatePromptPartialDefaultRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set a version as the default for a prompt partial
        /// </summary>
        /// <param name="promptPartialId"></param>
        /// <param name="version">
        /// Version Number to set as default
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdatePromptPartialDefaultAsync(
            string promptPartialId,
            double version,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}