#nullable enable

namespace Portkey
{
    public partial interface IPromptPartialsClient
    {
        /// <summary>
        /// Get a prompt partial by ID or slug
        /// </summary>
        /// <param name="promptPartialId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.PromptPartial> GetPromptPartialAsync(
            string promptPartialId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}