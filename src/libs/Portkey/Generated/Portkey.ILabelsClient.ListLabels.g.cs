#nullable enable

namespace Portkey
{
    public partial interface ILabelsClient
    {
        /// <summary>
        /// List labels<br/>
        /// Returns a list of labels based on filters
        /// </summary>
        /// <param name="organisationId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="search"></param>
        /// <param name="currentPage"></param>
        /// <param name="pageSize"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.ListLabelsResponse> ListLabelsAsync(
            global::System.Guid? organisationId = default,
            string? workspaceId = default,
            string? search = default,
            int? currentPage = default,
            int? pageSize = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}