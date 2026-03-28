#nullable enable

namespace Portkey
{
    public partial interface IIntegrationsWorkspacesClient
    {
        /// <summary>
        /// List integration workspace access<br/>
        /// Retrieves workspace access configuration for an integration, including usage limits and rate limits.
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.IntegrationWorkspacesResponse> GetIntegrationsBySlugWorkspacesAsync(
            string slug,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}