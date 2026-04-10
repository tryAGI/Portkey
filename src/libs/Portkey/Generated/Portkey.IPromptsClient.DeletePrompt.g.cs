#nullable enable

namespace Portkey
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Delete a prompt
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeletePromptAsync(
            string promptId,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}