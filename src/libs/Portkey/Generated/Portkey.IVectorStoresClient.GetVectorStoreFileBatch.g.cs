#nullable enable

namespace Portkey
{
    public partial interface IVectorStoresClient
    {
        /// <summary>
        /// Retrieves a vector store file batch.
        /// </summary>
        /// <param name="vectorStoreId">
        /// Example: vs_abc123
        /// </param>
        /// <param name="batchId">
        /// Example: vsfb_abc123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.VectorStoreFileBatchObject> GetVectorStoreFileBatchAsync(
            string vectorStoreId,
            string batchId,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}