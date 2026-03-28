#nullable enable

namespace Portkey
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// List Files
        /// </summary>
        /// <param name="purpose"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.ListFilesResponse> ListFilesAsync(
            string? purpose = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}