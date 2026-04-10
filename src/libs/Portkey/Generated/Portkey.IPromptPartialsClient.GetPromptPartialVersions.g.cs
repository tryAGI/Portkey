#nullable enable

namespace Portkey
{
    public partial interface IPromptPartialsClient
    {
        /// <summary>
        /// Get all versions of a prompt partial
        /// </summary>
        /// <param name="promptPartialId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Portkey.PromptPartialVersion>> GetPromptPartialVersionsAsync(
            string promptPartialId,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}