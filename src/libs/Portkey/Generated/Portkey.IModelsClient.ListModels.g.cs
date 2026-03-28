#nullable enable

namespace Portkey
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// List Available Models<br/>
        /// Lists the currently available models that can be used through Portkey, and provides basic information about each one.
        /// </summary>
        /// <param name="aiService"></param>
        /// <param name="provider"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="sort">
        /// Default Value: name
        /// </param>
        /// <param name="order">
        /// Default Value: asc
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.ListModelsResponse> ListModelsAsync(
            string? aiService = default,
            string? provider = default,
            int? limit = default,
            int? offset = default,
            global::Portkey.ListModelsSort? sort = default,
            global::Portkey.ListModelsOrder? order = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}