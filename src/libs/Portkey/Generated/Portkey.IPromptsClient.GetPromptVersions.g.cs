#nullable enable

namespace Portkey
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Get all versions of a prompt
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Portkey.PromptVersionSummary>> GetPromptVersionsAsync(
            string promptId,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}