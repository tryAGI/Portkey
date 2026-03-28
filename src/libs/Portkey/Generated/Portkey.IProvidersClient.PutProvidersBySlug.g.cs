#nullable enable

namespace Portkey
{
    public partial interface IProvidersClient
    {
        /// <summary>
        /// Update a Provider
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="slug"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.PutProvidersResponse> PutProvidersBySlugAsync(
            string slug,

            global::Portkey.PutProvidersRequest request,
            string? workspaceId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a Provider
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="slug"></param>
        /// <param name="name"></param>
        /// <param name="note"></param>
        /// <param name="usageLimits">
        /// Example: {"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}
        /// </param>
        /// <param name="rateLimits"></param>
        /// <param name="expiresAt"></param>
        /// <param name="resetUsage"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.PutProvidersResponse> PutProvidersBySlugAsync(
            string slug,
            string? workspaceId = default,
            string? name = default,
            string? note = default,
            global::Portkey.UsageLimits? usageLimits = default,
            global::Portkey.RateLimits? rateLimits = default,
            global::System.DateTime? expiresAt = default,
            bool? resetUsage = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}