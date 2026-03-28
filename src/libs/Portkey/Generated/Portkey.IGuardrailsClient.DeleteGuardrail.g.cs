#nullable enable

namespace Portkey
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// Delete a guardrail<br/>
        /// Deletes an existing guardrail
        /// </summary>
        /// <param name="guardrailId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteGuardrailAsync(
            string guardrailId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}