#nullable enable

namespace Portkey
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Delete a fine-tuned model. You must have the Owner role in your organization to delete a model.
        /// </summary>
        /// <param name="model">
        /// Example: ft:gpt-3.5-turbo:acemeco:suffix:abc123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.DeleteModelResponse> DeleteModelAsync(
            string model,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}