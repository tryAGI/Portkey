#nullable enable

namespace Portkey
{
    public partial interface IResponsesClient
    {
        /// <summary>
        /// Returns a list of input items for a given response.
        /// </summary>
        /// <param name="responseId"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.ResponseItemList> ListInputItemsAsync(
            string responseId,
            int? limit = default,
            global::Portkey.ListInputItemsOrder? order = default,
            string? after = default,
            string? before = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}