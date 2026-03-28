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
        global::System.Threading.Tasks.Task<global::Portkey.Response> CreateResponseAsync(

            global::Portkey.CreateResponse request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a model response
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.Response> CreateResponseAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}