#nullable enable

namespace Portkey
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Prompts Render<br/>
        /// Renders a prompt template with its variable values filled in
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.PromptRenderResponse> CreatePromptRenderAsync(
            string promptId,

            global::Portkey.CreatePromptRenderRequest2 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Prompts Render<br/>
        /// Renders a prompt template with its variable values filled in
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.PromptRenderResponse> CreatePromptRenderAsync(
            string promptId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}