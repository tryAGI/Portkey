#nullable enable

namespace Portkey
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Returns batch output as stream.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GetBatchOutputAsync(
            string batchId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}