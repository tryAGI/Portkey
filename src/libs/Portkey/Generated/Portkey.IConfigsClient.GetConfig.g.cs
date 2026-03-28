#nullable enable

namespace Portkey
{
    public partial interface IConfigsClient
    {
        /// <summary>
        /// Get a config
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.GetConfigResponse> GetConfigAsync(
            string slug,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}