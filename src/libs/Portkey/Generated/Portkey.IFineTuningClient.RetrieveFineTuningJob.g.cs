#nullable enable

namespace Portkey
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Get info about a fine-tuning job.<br/>
        /// [Learn more about fine-tuning](https://platform.openai.com/docs/guides/fine-tuning)
        /// </summary>
        /// <param name="fineTuningJobId">
        /// Example: ft-AF1WoRqd3aJAHsqc9NY7iL8F
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.FineTuningJob> RetrieveFineTuningJobAsync(
            string fineTuningJobId,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get info about a fine-tuning job.<br/>
        /// [Learn more about fine-tuning](https://platform.openai.com/docs/guides/fine-tuning)
        /// </summary>
        /// <param name="fineTuningJobId">
        /// Example: ft-AF1WoRqd3aJAHsqc9NY7iL8F
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.FineTuningJob>> RetrieveFineTuningJobAsResponseAsync(
            string fineTuningJobId,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}