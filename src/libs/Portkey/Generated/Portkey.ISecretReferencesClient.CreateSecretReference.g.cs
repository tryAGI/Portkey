#nullable enable

namespace Portkey
{
    public partial interface ISecretReferencesClient
    {
        /// <summary>
        /// Create a Secret Reference
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.CreateSecretReferenceResponse> CreateSecretReferenceAsync(

            global::Portkey.CreateSecretReferenceRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Secret Reference
        /// </summary>
        /// <param name="organisationId">
        /// Required if not using API key auth
        /// </param>
        /// <param name="name"></param>
        /// <param name="slug">
        /// Auto-generated from name if omitted
        /// </param>
        /// <param name="description"></param>
        /// <param name="managerType"></param>
        /// <param name="authConfig"></param>
        /// <param name="secretPath"></param>
        /// <param name="secretKey"></param>
        /// <param name="allowAllWorkspaces">
        /// Cannot be true when allowed_workspaces is provided<br/>
        /// Default Value: true
        /// </param>
        /// <param name="allowedWorkspaces">
        /// Array of workspace UUIDs or slugs. Mutually exclusive with allow_all_workspaces=true.
        /// </param>
        /// <param name="tags"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.CreateSecretReferenceResponse> CreateSecretReferenceAsync(
            string name,
            global::Portkey.CreateSecretReferenceRequestManagerType managerType,
            global::Portkey.AuthConfig authConfig,
            string secretPath,
            global::System.Guid? organisationId = default,
            string? slug = default,
            string? description = default,
            string? secretKey = default,
            bool? allowAllWorkspaces = default,
            global::System.Collections.Generic.IList<string>? allowedWorkspaces = default,
            global::System.Collections.Generic.Dictionary<string, string>? tags = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}