#nullable enable

namespace Portkey
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Prompts Completions<br/>
        /// Execute your saved prompt templates on Portkey
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.CreatePromptCompletionResponse> CreatePromptCompletionAsync(
            string promptId,

            global::Portkey.CreatePromptCompletionRequest2 request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Prompts Completions<br/>
        /// Execute your saved prompt templates on Portkey
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="variables">
        /// Variables to substitute in the prompt template
        /// </param>
        /// <param name="stream">
        /// Default: False. Set to True if you want to stream the response<br/>
        /// Default Value: false
        /// </param>
        /// <param name="hyperparameters">
        /// **Note**: All hyperparameters are optional. Pass them at the root level, and not nested under `hyperparameters`. Their grouping here is for educational purposes only.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.CreatePromptCompletionResponse> CreatePromptCompletionAsync(
            string promptId,
            object? variables = default,
            bool? stream = default,
            global::Portkey.OneOf<global::Portkey.CreateChatCompletionRequest, global::Portkey.CreateCompletionRequest>? hyperparameters = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}