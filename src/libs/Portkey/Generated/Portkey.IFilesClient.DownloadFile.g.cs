#nullable enable

namespace Portkey
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Returns the contents of the specified file.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DownloadFileAsync(
            string fileId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}