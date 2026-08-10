#nullable enable

namespace Portkey
{
    public partial interface IDeploymentsClient
    {
        /// <summary>
        /// Register a Gateway Deployment<br/>
        /// Registers a self-hosted Gateway with the control plane and issues its `client_auth` token.<br/>
        /// The token is returned in full only here and when rotated via the update endpoint; all reads mask it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.DeploymentCreateResponse> CreateDeploymentAsync(

            global::Portkey.CreateDeploymentRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register a Gateway Deployment<br/>
        /// Registers a self-hosted Gateway with the control plane and issues its `client_auth` token.<br/>
        /// The token is returned in full only here and when rotated via the update endpoint; all reads mask it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.DeploymentCreateResponse>> CreateDeploymentAsResponseAsync(

            global::Portkey.CreateDeploymentRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register a Gateway Deployment<br/>
        /// Registers a self-hosted Gateway with the control plane and issues its `client_auth` token.<br/>
        /// The token is returned in full only here and when rotated via the update endpoint; all reads mask it.
        /// </summary>
        /// <param name="organisationId">
        /// Required if not using API key auth
        /// </param>
        /// <param name="name"></param>
        /// <param name="slug">
        /// Auto-generated from name as `dp-&lt;slug&gt;` if omitted
        /// </param>
        /// <param name="type">
        /// Default Value: production
        /// </param>
        /// <param name="deploymentConfig">
        /// Freeform deployment configuration
        /// </param>
        /// <param name="isDefault">
        /// The first active deployment in an organisation is always made default.
        /// </param>
        /// <param name="authSettings"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.DeploymentCreateResponse> CreateDeploymentAsync(
            string name,
            global::System.Guid? organisationId = default,
            string? slug = default,
            global::Portkey.CreateDeploymentRequestType? type = default,
            object? deploymentConfig = default,
            bool? isDefault = default,
            global::Portkey.DeploymentAuthSettingsInput? authSettings = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}