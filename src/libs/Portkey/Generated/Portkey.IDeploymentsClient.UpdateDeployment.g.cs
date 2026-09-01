#nullable enable

namespace Portkey
{
    public partial interface IDeploymentsClient
    {
        /// <summary>
        /// Update a Gateway Deployment<br/>
        /// Update a deployment. Tags can be set, replaced, or cleared.<br/>
        /// - Send a tags object to set/replace tags.<br/>
        /// - Send `"tags": null` to remove all tags.<br/>
        /// - Omit the tags field to leave tags unchanged.
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
        /// Update a Gateway Deployment<br/>
        /// Update a deployment. Tags can be set, replaced, or cleared.<br/>
        /// - Send a tags object to set/replace tags.<br/>
        /// - Send `"tags": null` to remove all tags.<br/>
        /// - Omit the tags field to leave tags unchanged.
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
        /// Update a Gateway Deployment<br/>
        /// Update a deployment. Tags can be set, replaced, or cleared.<br/>
        /// - Send a tags object to set/replace tags.<br/>
        /// - Send `"tags": null` to remove all tags.<br/>
        /// - Omit the tags field to leave tags unchanged.
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
        /// <param name="tags">
        /// Flat key-value string pairs. Keys must be alphanumeric with underscores<br/>
        /// and hyphens (`^[a-zA-Z0-9_-]+$`). Values are arbitrary strings.<br/>
        /// Setting tags to `null` removes all tags from the deployment.<br/>
        /// Example: {"fw-id":"fw-01234","cloud":"aws","region":"us-west-2"}
        /// </param>
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
            global::System.Collections.Generic.Dictionary<string, string>? tags = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}