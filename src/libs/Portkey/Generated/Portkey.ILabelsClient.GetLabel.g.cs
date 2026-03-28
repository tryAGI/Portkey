#nullable enable

namespace Portkey
{
    public partial interface ILabelsClient
    {
        /// <summary>
        /// Get a label by ID<br/>
        /// Returns a specific label by its ID
        /// </summary>
        /// <param name="labelId"></param>
        /// <param name="organisationId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.Label> GetLabelAsync(
            global::System.Guid labelId,
            global::System.Guid? organisationId = default,
            string? workspaceId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}