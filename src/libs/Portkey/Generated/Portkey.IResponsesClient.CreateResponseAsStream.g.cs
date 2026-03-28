#nullable enable

namespace Portkey
{
    public partial interface IResponsesClient
    {
        /// <summary>
        /// Creates a model response
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Portkey.ResponseStreamEvent> CreateResponseAsStreamAsync(

            global::Portkey.CreateResponse request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a model response
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Portkey.ResponseStreamEvent> CreateResponseAsStreamAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}