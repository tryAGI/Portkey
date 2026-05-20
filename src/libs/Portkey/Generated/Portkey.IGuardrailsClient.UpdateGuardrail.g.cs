#nullable enable

namespace Portkey
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// Update a guardrail<br/>
        /// Updates an existing guardrail's name, checks, or actions
        /// </summary>
        /// <param name="guardrailId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.UpdateGuardrailResponse> UpdateGuardrailAsync(
            string guardrailId,

            global::Portkey.UpdateGuardrailRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a guardrail<br/>
        /// Updates an existing guardrail's name, checks, or actions
        /// </summary>
        /// <param name="guardrailId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.UpdateGuardrailResponse>> UpdateGuardrailAsResponseAsync(
            string guardrailId,

            global::Portkey.UpdateGuardrailRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a guardrail<br/>
        /// Updates an existing guardrail's name, checks, or actions
        /// </summary>
        /// <param name="guardrailId"></param>
        /// <param name="name">
        /// Updated name of the guardrail
        /// </param>
        /// <param name="checks">
        /// Updated array of guardrail checks
        /// </param>
        /// <param name="actions">
        /// Actions to take when guardrail checks fail or pass
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.UpdateGuardrailResponse> UpdateGuardrailAsync(
            string guardrailId,
            string? name = default,
            global::System.Collections.Generic.IList<global::Portkey.GuardrailCheck>? checks = default,
            global::Portkey.GuardrailActions? actions = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}