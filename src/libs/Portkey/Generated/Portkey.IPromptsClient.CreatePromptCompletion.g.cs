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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.CreatePromptCompletionResponse> CreatePromptCompletionAsync(
            string promptId,

            global::Portkey.CreatePromptCompletionRequest2 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Prompts Completions<br/>
        /// Execute your saved prompt templates on Portkey
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.CreatePromptCompletionResponse> CreatePromptCompletionAsync(
            string promptId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}