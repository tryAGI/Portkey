#nullable enable

namespace Portkey
{
    public partial interface IFinetuneClient
    {
        /// <summary>
        /// Create a Finetune Job<br/>
        /// Finetune a provider model
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.FineTuningJob> CreateFineTuningJobAsync(

            global::Portkey.AnyOf<global::Portkey.OpenAIFinetuneJob, global::Portkey.BedrockFinetuneJob, global::Portkey.PortkeyFinetuneJob> request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Finetune Job<br/>
        /// Finetune a provider model
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.FineTuningJob> CreateFineTuningJobAsync(
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}