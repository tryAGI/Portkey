#nullable enable

namespace Portkey
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// Get a specific guardrail<br/>
        /// Retrieves details of a specific guardrail by ID or slug
        /// </summary>
        /// <param name="guardrailId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.GuardrailDetails> GetGuardrailAsync(
            string guardrailId,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}