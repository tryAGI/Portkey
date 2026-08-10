#nullable enable

namespace Portkey
{
    public partial interface IDeploymentsClient
    {
        /// <summary>
        /// Get a Gateway Deployment<br/>
        /// Accepts a deployment UUID, or the literal `self` when the request is authenticated with the<br/>
        /// Gateway's own `client_auth` token in the `authorization` header.
        /// </summary>
        /// <param name="deploymentId"></param>
        /// <param name="organisationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.DeploymentDetailResponse> GetDeploymentAsync(
            string deploymentId,
            global::System.Guid? organisationId = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a Gateway Deployment<br/>
        /// Accepts a deployment UUID, or the literal `self` when the request is authenticated with the<br/>
        /// Gateway's own `client_auth` token in the `authorization` header.
        /// </summary>
        /// <param name="deploymentId"></param>
        /// <param name="organisationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.DeploymentDetailResponse>> GetDeploymentAsResponseAsync(
            string deploymentId,
            global::System.Guid? organisationId = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}