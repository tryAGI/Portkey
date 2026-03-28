#nullable enable

namespace Portkey
{
    public partial interface IConfigsClient
    {
        /// <summary>
        /// Update a config
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.UpdateConfigResponse> UpdateConfigAsync(
            string slug,

            global::Portkey.UpdateConfigRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a config
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="name"></param>
        /// <param name="config"></param>
        /// <param name="status"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.UpdateConfigResponse> UpdateConfigAsync(
            string slug,
            string? name = default,
            global::Portkey.UpdateConfigRequestConfig? config = default,
            string? status = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}