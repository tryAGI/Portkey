#nullable enable

namespace Portkey
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Creates and executes a batch from an uploaded file of requests
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.Batch> CreateBatchAsync(

            global::Portkey.AnyOf<global::Portkey.OpenAIBatchJob, global::Portkey.BedrockBatchJob, global::Portkey.VertexBatchJob, global::Portkey.PortkeyBatchJob> request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates and executes a batch from an uploaded file of requests
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.Batch> CreateBatchAsync(
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}