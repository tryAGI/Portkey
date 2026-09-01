#nullable enable

namespace Portkey
{
    public partial interface IDeploymentsClient
    {
        /// <summary>
        /// List All Gateway Deployments<br/>
        /// List deployments with optional filters. Tags can be filtered using either<br/>
        /// a JSON string or bracket-notation query parameters.
        /// </summary>
        /// <param name="organisationId"></param>
        /// <param name="status"></param>
        /// <param name="type"></param>
        /// <param name="workspaceSlug"></param>
        /// <param name="search"></param>
        /// <param name="tags"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.ListDeploymentsResponse> ListDeploymentsAsync(
            global::System.Guid? organisationId = default,
            global::Portkey.ListDeploymentsStatus? status = default,
            global::Portkey.ListDeploymentsType? type = default,
            global::System.Collections.Generic.IList<string>? workspaceSlug = default,
            string? search = default,
            global::Portkey.OneOf<string, global::System.Collections.Generic.Dictionary<string, string>>? tags = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List All Gateway Deployments<br/>
        /// List deployments with optional filters. Tags can be filtered using either<br/>
        /// a JSON string or bracket-notation query parameters.
        /// </summary>
        /// <param name="organisationId"></param>
        /// <param name="status"></param>
        /// <param name="type"></param>
        /// <param name="workspaceSlug"></param>
        /// <param name="search"></param>
        /// <param name="tags"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.ListDeploymentsResponse>> ListDeploymentsAsResponseAsync(
            global::System.Guid? organisationId = default,
            global::Portkey.ListDeploymentsStatus? status = default,
            global::Portkey.ListDeploymentsType? type = default,
            global::System.Collections.Generic.IList<string>? workspaceSlug = default,
            string? search = default,
            global::Portkey.OneOf<string, global::System.Collections.Generic.Dictionary<string, string>>? tags = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}