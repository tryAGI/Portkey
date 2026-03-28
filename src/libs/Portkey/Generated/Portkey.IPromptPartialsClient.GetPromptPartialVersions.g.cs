#nullable enable

namespace Portkey
{
    public partial interface IPromptPartialsClient
    {
        /// <summary>
        /// Get all versions of a prompt partial
        /// </summary>
        /// <param name="promptPartialId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Portkey.PromptPartialVersion>> GetPromptPartialVersionsAsync(
            string promptPartialId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}