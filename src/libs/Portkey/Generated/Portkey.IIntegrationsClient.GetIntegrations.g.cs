#nullable enable

namespace Portkey
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// List All Integrations
        /// </summary>
        /// <param name="currentPage"></param>
        /// <param name="pageSize"></param>
        /// <param name="workspaceId"></param>
        /// <param name="type">
        /// Default Value: all
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.GetIntegrationsResponse> GetIntegrationsAsync(
            int? currentPage = default,
            int? pageSize = default,
            string? workspaceId = default,
            global::Portkey.GetIntegrationsType? type = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}