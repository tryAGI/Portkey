#nullable enable

namespace Portkey
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Create Workspace
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.Workspace> CreateAdminWorkspacesAsync(

            global::Portkey.CreateAdminWorkspacesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Workspace
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="defaults"></param>
        /// <param name="users"></param>
        /// <param name="usageLimits"></param>
        /// <param name="rateLimits"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.Workspace> CreateAdminWorkspacesAsync(
            string? name = default,
            string? description = default,
            global::Portkey.CreateAdminWorkspacesRequestDefaults? defaults = default,
            global::System.Collections.Generic.IList<string>? users = default,
            global::System.Collections.Generic.IList<global::Portkey.UsageLimits>? usageLimits = default,
            global::System.Collections.Generic.IList<global::Portkey.RateLimits>? rateLimits = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}