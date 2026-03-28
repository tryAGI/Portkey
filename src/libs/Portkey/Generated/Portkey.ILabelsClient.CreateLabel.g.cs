#nullable enable

namespace Portkey
{
    public partial interface ILabelsClient
    {
        /// <summary>
        /// Create a new label<br/>
        /// Creates a new label in the system
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.CreateLabelResponse> CreateLabelAsync(

            global::Portkey.CreateLabelRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new label<br/>
        /// Creates a new label in the system
        /// </summary>
        /// <param name="organisationId">
        /// ID of the organisation
        /// </param>
        /// <param name="workspaceId">
        /// ID or slug of the workspace
        /// </param>
        /// <param name="name">
        /// Name of the label
        /// </param>
        /// <param name="description">
        /// Description of the label
        /// </param>
        /// <param name="colorCode">
        /// Color code for the label
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.CreateLabelResponse> CreateLabelAsync(
            string name,
            global::System.Guid? organisationId = default,
            string? workspaceId = default,
            string? description = default,
            string? colorCode = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}