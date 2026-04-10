#nullable enable

namespace Portkey
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Get a specific version of a prompt
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="versionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.Prompt2> GetPromptByVersionAsync(
            string promptId,
            global::System.Guid versionId,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}