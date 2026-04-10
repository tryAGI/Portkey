#nullable enable

namespace Portkey
{
    public partial interface IIntegrationsModelsClient
    {
        /// <summary>
        /// List integration models<br/>
        /// Retrieves all model access for a specific integration with their configuration and pricing details.
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.IntegrationModelsResponse> GetIntegrationsBySlugModelsAsync(
            string slug,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}