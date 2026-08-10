#nullable enable

namespace Portkey
{
    public partial interface IDeploymentsClient
    {
        /// <summary>
        /// Update a Gateway Deployment
        /// </summary>
        /// <param name="deploymentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateDeploymentAsync(
            global::System.Guid deploymentId,

            global::Portkey.UpdateDeploymentRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a Gateway Deployment
        /// </summary>
        /// <param name="deploymentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<string>> UpdateDeploymentAsResponseAsync(
            global::System.Guid deploymentId,

            global::Portkey.UpdateDeploymentRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a Gateway Deployment
        /// </summary>
        /// <param name="deploymentId"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="status"></param>
        /// <param name="deploymentConfig"></param>
        /// <param name="isDefault"></param>
        /// <param name="rotateAuth">
        /// Issues a new `client_auth` token
        /// </param>
        /// <param name="overrideExisting"></param>
        /// <param name="authSettings"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateDeploymentAsync(
            global::System.Guid deploymentId,
            string? name = default,
            global::Portkey.UpdateDeploymentRequestType? type = default,
            global::Portkey.UpdateDeploymentRequestStatus? status = default,
            object? deploymentConfig = default,
            bool? isDefault = default,
            bool? rotateAuth = default,
            bool? overrideExisting = default,
            global::Portkey.AllOf<global::Portkey.DeploymentAuthSettingsInput, global::Portkey.UpdateDeploymentRequestAuthSettings>? authSettings = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}