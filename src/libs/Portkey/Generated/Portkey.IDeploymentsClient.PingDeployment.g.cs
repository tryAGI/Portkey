#nullable enable

namespace Portkey
{
    public partial interface IDeploymentsClient
    {
        /// <summary>
        /// Ping a Gateway Deployment<br/>
        /// Runs a two-way connectivity check against the registered `gateway_base_url`.<br/>
        /// - **Outbound** — the control plane calls `GET {gateway_base_url}/v1/health` and expects `{"status": "success", "version": "x.y.z"}`.<br/>
        /// - **Inbound** — the control plane calls `POST {gateway_base_url}/v1/verify-ping` with a one-time code, then waits up to 10s for the Gateway to call back.
        /// </summary>
        /// <param name="deploymentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.DeploymentPingResponse> PingDeploymentAsync(
            global::System.Guid deploymentId,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Ping a Gateway Deployment<br/>
        /// Runs a two-way connectivity check against the registered `gateway_base_url`.<br/>
        /// - **Outbound** — the control plane calls `GET {gateway_base_url}/v1/health` and expects `{"status": "success", "version": "x.y.z"}`.<br/>
        /// - **Inbound** — the control plane calls `POST {gateway_base_url}/v1/verify-ping` with a one-time code, then waits up to 10s for the Gateway to call back.
        /// </summary>
        /// <param name="deploymentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.DeploymentPingResponse>> PingDeploymentAsResponseAsync(
            global::System.Guid deploymentId,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}