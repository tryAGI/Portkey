#nullable enable

namespace Portkey
{
    public partial interface IAssistantsClient
    {
        /// <summary>
        /// Delete an assistant.
        /// </summary>
        /// <param name="assistantId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.DeleteAssistantResponse> DeleteAssistantAsync(
            string assistantId,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}