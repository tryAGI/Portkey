#nullable enable

namespace Portkey
{
    public partial interface IResponsesClient
    {
        /// <summary>
        /// Deletes a model response with the given ID.
        /// </summary>
        /// <param name="responseId">
        /// Example: resp_677efb5139a88190b512bc3fef8e535d
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteResponseAsync(
            string responseId,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}